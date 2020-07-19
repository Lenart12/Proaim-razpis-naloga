using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace Proaim {
    public partial class mainForm : Form {
        private MySqlConnection conn;
        public List<Luknja> luknje;
        Image<Bgr, byte> src;
        public mainForm() {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e) {
            Console.WriteLine("Main form loaded");
            luknje = new List<Luknja>();

            luknjeGView.DataSource = luknje.ToList();

            conn = new MySqlConnection("server=wigaun.eu.org;user=ec38;database=ec38;port=3306;password=ec38");
            try {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Done.");

            imgInfoLabel.Text = "";
            clearKosi();
            clearDelovniNalogiForm();
            loadDelovniNalogi();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e) {
            conn.Clone();
            Console.WriteLine("Closing");
        }

        private void detectCircles() {
            try {
                const float scale_factor = 1f;
                //const float scale_factor = 0.5f;
                Image<Bgr, byte> img = src.Resize(scale_factor  , Inter.Nearest);

                Image<Gray, byte> gray = img.Convert<Gray, byte>();
                gray._GammaCorrect(0.5);
                CvInvoke.MedianBlur(gray, gray, 5);


                CircleF[] HoughCircles = gray.Clone().HoughCircles(
                                        new Gray(cannyThrSlider.Value),
                                        new Gray(circleAccThrSlider.Value),
                                        resSlider.Value / 10 +0.5, //Resolution of the accumulator used to detect centers of the circles
                                        minDistSlider.Value, //min distance 
                                        minRadSlider.Value, //min radius
                                        maxRadSlider.Value //max radius
                                        )[0]; //Get the circles from the first channel

                bool populate = luknje.Count == 0;

                PointF center_d = new PointF(1040f, 905f);
                const float min_d = 480 * scale_factor;
                const float max_d = 700 * scale_factor;

                img.Draw(new CircleF(center_d, min_d), new Bgr(Color.Blue), 2);
                img.Draw(new CircleF(center_d, max_d), new Bgr(Color.Blue), 2);

                luknjeGView.DataSource = null;
                luknje.Clear();
                luknjeGView.DataSource = luknje.ToList();

                foreach (CircleF circle in HoughCircles) {
                    double dist = Math.Sqrt( Math.Pow((double)circle.Center.X - (double)center_d.X, 2.0d) + Math.Pow((double)circle.Center.Y - (double)center_d.Y, 2.0) );
                    if(dist < max_d && dist > min_d) {
                        img.Draw(circle, new Bgr(Color.Red), 2);
                        luknje.Add(new Luknja((int)circle.Center.X, (int)circle.Center.Y, (int)circle.Radius));
                    }
                }

                displayPBox.Image = img;
                luknjeGView.DataSource = luknje;
                luknjeGView.Refresh();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private int nextAutoIncrement(string table) {
            try {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Auto_increment FROM information_schema.tables WHERE table_name=@tabela";
                cmd.Parameters.AddWithValue("tabela", table);
                using (MySqlDataReader reader = cmd.ExecuteReader()) {
                    reader.Read();
                    return int.Parse(reader.GetString(0));
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        private void clearKosi() {
            try {
                guidTBox.Text = opombeTBox.Text = "";
                dnalogNumBox.Value = 0;
                idTBox.Text = nextAutoIncrement("kosi").ToString();
                casIzdelavePicker.Value = DateTime.Now;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearDelovniNalogiForm() {
            dnalogiIDTBox.Text = nextAutoIncrement("delovni_nalogi").ToString();
            stKosovNum.Value = 0;
            opisTBox.Text = dnOpombeTBox.Text = narocnikTBox.Text = "";
            casNarocilaPicker.Value = casKoncaPicker.Value = DateTime.Now;
        }

        private void loadDelovniNalogi() {
            try {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand("SELECT * FROM delovni_nalogi ORDER BY cas_narocila DESC", conn);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource {
                    DataSource = table
                };

                dnalogiGView.DataSource = bSource;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearImage() {
            displayPBox.Image = null;
            luknjeGView.DataSource = null;
            imgInfoLabel.Text = null;
        }

        private void loadPicBtn_Click(object sender, EventArgs e) {
            try {
                var fileContent = string.Empty;
                var filePath = string.Empty;

                using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                    openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK) {
                        filePath = openFileDialog.FileName;
                        string possible_guid = Path.GetFileNameWithoutExtension(filePath);
                        clearKosi();

                        if(Regex.IsMatch(possible_guid, "(^([0-9A-Fa-f]{8}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{12})$)")) {
                            guidTBox.Text = possible_guid;
                        }

                        Image img_s = Image.FromFile(filePath);
                        Bitmap bmp = new Bitmap(img_s);
                        src = bmp.ToImage<Bgr, byte>();

                        imgInfoLabel.Text = "Nalozena slika: " + Path.GetFileName(filePath) + "\n" +
                                            "Dimenzije (" + src.Width + " x " + src.Height + ") px" + '\n' +
                                            "Velikost " + src.Bytes.Count() / 1000 + "KB";
                        detectCircles();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ImgParamValueChanged(object sender, EventArgs e) {
            detectCircles();
        }

        private void kosSaveBtn_Click(object sender, EventArgs e) {
            try {
                MySqlCommand cmd = conn.CreateCommand();
                int id = nextAutoIncrement("kosi");
                idTBox.Text = id.ToString();
                cmd.CommandText = "INSERT INTO `kosi` (`id`, `guid`, `delovni_nalog`, `cas_vnosa`, `opombe`) " +
                    "VALUES (@id, @guid, @dnalog, @casVnosa, @opombe)";
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("guid", guidTBox.Text);
                cmd.Parameters.AddWithValue("dnalog", dnalogNumBox.Value);
                cmd.Parameters.AddWithValue("casVnosa", casIzdelavePicker.Value);
                cmd.Parameters.AddWithValue("opombe", opombeTBox.Text);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO `luknje` (`id`, `kos_id`, `radij`, `center_x`, `center_y`, `ploscina`) " +
                    "VALUES (NULL, @kos_id, @radij, @center_x, @center_y, @ploscina)";
                foreach (Luknja l in luknje) {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("kos_id", id);
                    cmd.Parameters.AddWithValue("radij", l.Radius);
                    cmd.Parameters.AddWithValue("center_x", l.Center_x);
                    cmd.Parameters.AddWithValue("center_y", l.Center_y);
                    cmd.Parameters.AddWithValue("ploscina", l.Area);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Shranjenih " + (1 + luknje.Count) + " zapisov z ID " + id);

                clearKosi();
                clearImage();                
            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dodajDnalogBtn_Click(object sender, EventArgs e) {
            try {
                MySqlCommand cmd = conn.CreateCommand();
                int id = nextAutoIncrement("delovni_nalogi");
                idTBox.Text = id.ToString();
                cmd.CommandText = "INSERT INTO `delovni_nalogi` (`id`, `st_kosov`, `opis`, `opombe`, `cas_narocila`, `rok_konca`, `narocnik`) " +
                    "VALUES (@id, @st_kosov, @opis, @opombe, @cas_narocila, @rok_konca, @narocnik) ";
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("st_kosov", stKosovNum.Value);
                cmd.Parameters.AddWithValue("opis", opisTBox.Text);
                cmd.Parameters.AddWithValue("opombe", dnOpombeTBox.Text);
                cmd.Parameters.AddWithValue("cas_narocila", casNarocilaPicker.Value);
                cmd.Parameters.AddWithValue("rok_konca", casKoncaPicker.Value);
                cmd.Parameters.AddWithValue("narocnik", narocnikTBox.Text);
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dodan delovni nalog z ID " + id);

                clearDelovniNalogiForm();
                loadDelovniNalogi();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
