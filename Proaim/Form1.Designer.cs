namespace Proaim
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loadPicBtn = new System.Windows.Forms.Button();
            this.imgInfoLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dnalogNumBox = new System.Windows.Forms.NumericUpDown();
            this.guidTBox = new System.Windows.Forms.MaskedTextBox();
            this.opombeTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.casIzdelavePicker = new System.Windows.Forms.DateTimePicker();
            this.dnalogTBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayPBox = new Emgu.CV.UI.ImageBox();
            this.cannyThrSlider = new System.Windows.Forms.TrackBar();
            this.circleAccThrSlider = new System.Windows.Forms.TrackBar();
            this.resSlider = new System.Windows.Forms.TrackBar();
            this.minDistSlider = new System.Windows.Forms.TrackBar();
            this.minRadSlider = new System.Windows.Forms.TrackBar();
            this.maxRadSlider = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.luknjeGView = new System.Windows.Forms.DataGridView();
            this.kosSaveBtn = new System.Windows.Forms.Button();
            this.dnalogiIDTBox = new System.Windows.Forms.TextBox();
            this.opisTBox = new System.Windows.Forms.TextBox();
            this.dnOpombeTBox = new System.Windows.Forms.TextBox();
            this.narocnikTBox = new System.Windows.Forms.TextBox();
            this.dnalogiGView = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dodajDnalogBtn = new System.Windows.Forms.Button();
            this.casNarocilaPicker = new System.Windows.Forms.DateTimePicker();
            this.casKoncaPicker = new System.Windows.Forms.DateTimePicker();
            this.stKosovNum = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnalogNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyThrSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleAccThrSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDistSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRadSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRadSlider)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luknjeGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnalogiGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stKosovNum)).BeginInit();
            this.SuspendLayout();
            // 
            // loadPicBtn
            // 
            this.loadPicBtn.Location = new System.Drawing.Point(716, 606);
            this.loadPicBtn.Name = "loadPicBtn";
            this.loadPicBtn.Size = new System.Drawing.Size(75, 23);
            this.loadPicBtn.TabIndex = 1;
            this.loadPicBtn.Text = "Nalozi sliko";
            this.loadPicBtn.UseVisualStyleBackColor = true;
            this.loadPicBtn.Click += new System.EventHandler(this.loadPicBtn_Click);
            // 
            // imgInfoLabel
            // 
            this.imgInfoLabel.AutoSize = true;
            this.imgInfoLabel.Location = new System.Drawing.Point(797, 606);
            this.imgInfoLabel.Name = "imgInfoLabel";
            this.imgInfoLabel.Size = new System.Drawing.Size(56, 39);
            this.imgInfoLabel.TabIndex = 2;
            this.imgInfoLabel.Text = "Image info\r\nImage info\r\nImage info\r\n";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 924);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1766, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dnalogNumBox);
            this.panel1.Controls.Add(this.guidTBox);
            this.panel1.Controls.Add(this.opombeTBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.casIzdelavePicker);
            this.panel1.Controls.Add(this.dnalogTBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.idTBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1388, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 222);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Opombe:";
            // 
            // dnalogNumBox
            // 
            this.dnalogNumBox.Location = new System.Drawing.Point(94, 70);
            this.dnalogNumBox.Name = "dnalogNumBox";
            this.dnalogNumBox.Size = new System.Drawing.Size(144, 20);
            this.dnalogNumBox.TabIndex = 10;
            // 
            // guidTBox
            // 
            this.guidTBox.Location = new System.Drawing.Point(94, 42);
            this.guidTBox.Mask = "<AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA";
            this.guidTBox.Name = "guidTBox";
            this.guidTBox.Size = new System.Drawing.Size(226, 20);
            this.guidTBox.TabIndex = 9;
            // 
            // opombeTBox
            // 
            this.opombeTBox.Location = new System.Drawing.Point(94, 123);
            this.opombeTBox.MaxLength = 50;
            this.opombeTBox.Multiline = true;
            this.opombeTBox.Name = "opombeTBox";
            this.opombeTBox.Size = new System.Drawing.Size(200, 83);
            this.opombeTBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cas izdelave:";
            // 
            // casIzdelavePicker
            // 
            this.casIzdelavePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.casIzdelavePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.casIzdelavePicker.Location = new System.Drawing.Point(94, 96);
            this.casIzdelavePicker.Name = "casIzdelavePicker";
            this.casIzdelavePicker.ShowUpDown = true;
            this.casIzdelavePicker.Size = new System.Drawing.Size(200, 20);
            this.casIzdelavePicker.TabIndex = 6;
            // 
            // dnalogTBox
            // 
            this.dnalogTBox.AutoSize = true;
            this.dnalogTBox.Location = new System.Drawing.Point(16, 72);
            this.dnalogTBox.Name = "dnalogTBox";
            this.dnalogTBox.Size = new System.Drawing.Size(75, 13);
            this.dnalogTBox.TabIndex = 4;
            this.dnalogTBox.Text = "Delovni nalog:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "GUID:";
            // 
            // idTBox
            // 
            this.idTBox.Location = new System.Drawing.Point(94, 16);
            this.idTBox.Name = "idTBox";
            this.idTBox.ReadOnly = true;
            this.idTBox.Size = new System.Drawing.Size(144, 20);
            this.idTBox.TabIndex = 1;
            this.idTBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // displayPBox
            // 
            this.displayPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.displayPBox.Location = new System.Drawing.Point(23, 12);
            this.displayPBox.Name = "displayPBox";
            this.displayPBox.Size = new System.Drawing.Size(1336, 580);
            this.displayPBox.TabIndex = 2;
            this.displayPBox.TabStop = false;
            // 
            // cannyThrSlider
            // 
            this.cannyThrSlider.Location = new System.Drawing.Point(53, 611);
            this.cannyThrSlider.Maximum = 50;
            this.cannyThrSlider.Minimum = 1;
            this.cannyThrSlider.Name = "cannyThrSlider";
            this.cannyThrSlider.Size = new System.Drawing.Size(480, 45);
            this.cannyThrSlider.TabIndex = 5;
            this.cannyThrSlider.Value = 34;
            this.cannyThrSlider.ValueChanged += new System.EventHandler(this.ImgParamValueChanged);
            // 
            // circleAccThrSlider
            // 
            this.circleAccThrSlider.Location = new System.Drawing.Point(50, 667);
            this.circleAccThrSlider.Maximum = 100;
            this.circleAccThrSlider.Minimum = 1;
            this.circleAccThrSlider.Name = "circleAccThrSlider";
            this.circleAccThrSlider.Size = new System.Drawing.Size(480, 45);
            this.circleAccThrSlider.TabIndex = 6;
            this.circleAccThrSlider.Value = 29;
            this.circleAccThrSlider.ValueChanged += new System.EventHandler(this.ImgParamValueChanged);
            // 
            // resSlider
            // 
            this.resSlider.Location = new System.Drawing.Point(50, 718);
            this.resSlider.Maximum = 50;
            this.resSlider.Minimum = 5;
            this.resSlider.Name = "resSlider";
            this.resSlider.Size = new System.Drawing.Size(480, 45);
            this.resSlider.TabIndex = 7;
            this.resSlider.Value = 5;
            this.resSlider.ValueChanged += new System.EventHandler(this.ImgParamValueChanged);
            // 
            // minDistSlider
            // 
            this.minDistSlider.Location = new System.Drawing.Point(50, 769);
            this.minDistSlider.Maximum = 50;
            this.minDistSlider.Minimum = 1;
            this.minDistSlider.Name = "minDistSlider";
            this.minDistSlider.Size = new System.Drawing.Size(480, 45);
            this.minDistSlider.TabIndex = 8;
            this.minDistSlider.Value = 17;
            this.minDistSlider.ValueChanged += new System.EventHandler(this.ImgParamValueChanged);
            // 
            // minRadSlider
            // 
            this.minRadSlider.Location = new System.Drawing.Point(53, 820);
            this.minRadSlider.Maximum = 50;
            this.minRadSlider.Name = "minRadSlider";
            this.minRadSlider.Size = new System.Drawing.Size(480, 45);
            this.minRadSlider.TabIndex = 9;
            this.minRadSlider.Value = 6;
            this.minRadSlider.ValueChanged += new System.EventHandler(this.ImgParamValueChanged);
            // 
            // maxRadSlider
            // 
            this.maxRadSlider.Location = new System.Drawing.Point(53, 871);
            this.maxRadSlider.Maximum = 50;
            this.maxRadSlider.Name = "maxRadSlider";
            this.maxRadSlider.Size = new System.Drawing.Size(480, 45);
            this.maxRadSlider.TabIndex = 10;
            this.maxRadSlider.Value = 26;
            this.maxRadSlider.ValueChanged += new System.EventHandler(this.ImgParamValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 616);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Canny threshold";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 667);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Circle accumulator threshold";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 718);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Resolution";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 769);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Minimum distance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 820);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Minimum radius";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(536, 871);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Maximum radius";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.stKosovNum);
            this.panel2.Controls.Add(this.casKoncaPicker);
            this.panel2.Controls.Add(this.casNarocilaPicker);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.narocnikTBox);
            this.panel2.Controls.Add(this.dnOpombeTBox);
            this.panel2.Controls.Add(this.opisTBox);
            this.panel2.Controls.Add(this.dnalogiIDTBox);
            this.panel2.Location = new System.Drawing.Point(1388, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 209);
            this.panel2.TabIndex = 17;
            // 
            // luknjeGView
            // 
            this.luknjeGView.AllowUserToAddRows = false;
            this.luknjeGView.AllowUserToDeleteRows = false;
            this.luknjeGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luknjeGView.Location = new System.Drawing.Point(716, 653);
            this.luknjeGView.Name = "luknjeGView";
            this.luknjeGView.ReadOnly = true;
            this.luknjeGView.Size = new System.Drawing.Size(448, 249);
            this.luknjeGView.TabIndex = 18;
            // 
            // kosSaveBtn
            // 
            this.kosSaveBtn.Location = new System.Drawing.Point(1388, 240);
            this.kosSaveBtn.Name = "kosSaveBtn";
            this.kosSaveBtn.Size = new System.Drawing.Size(157, 23);
            this.kosSaveBtn.TabIndex = 19;
            this.kosSaveBtn.Text = "Shrani kos in luknje v bazo";
            this.kosSaveBtn.UseVisualStyleBackColor = true;
            this.kosSaveBtn.Click += new System.EventHandler(this.kosSaveBtn_Click);
            // 
            // dnalogiIDTBox
            // 
            this.dnalogiIDTBox.Location = new System.Drawing.Point(94, 16);
            this.dnalogiIDTBox.Name = "dnalogiIDTBox";
            this.dnalogiIDTBox.ReadOnly = true;
            this.dnalogiIDTBox.Size = new System.Drawing.Size(122, 20);
            this.dnalogiIDTBox.TabIndex = 0;
            this.dnalogiIDTBox.Text = "0";
            // 
            // opisTBox
            // 
            this.opisTBox.Location = new System.Drawing.Point(94, 68);
            this.opisTBox.MaxLength = 30;
            this.opisTBox.Name = "opisTBox";
            this.opisTBox.Size = new System.Drawing.Size(252, 20);
            this.opisTBox.TabIndex = 2;
            // 
            // dnOpombeTBox
            // 
            this.dnOpombeTBox.Location = new System.Drawing.Point(94, 94);
            this.dnOpombeTBox.MaxLength = 50;
            this.dnOpombeTBox.Name = "dnOpombeTBox";
            this.dnOpombeTBox.Size = new System.Drawing.Size(252, 20);
            this.dnOpombeTBox.TabIndex = 3;
            // 
            // narocnikTBox
            // 
            this.narocnikTBox.Location = new System.Drawing.Point(94, 172);
            this.narocnikTBox.MaxLength = 50;
            this.narocnikTBox.Name = "narocnikTBox";
            this.narocnikTBox.Size = new System.Drawing.Size(252, 20);
            this.narocnikTBox.TabIndex = 6;
            // 
            // dnalogiGView
            // 
            this.dnalogiGView.AllowUserToAddRows = false;
            this.dnalogiGView.AllowUserToDeleteRows = false;
            this.dnalogiGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dnalogiGView.Location = new System.Drawing.Point(1170, 637);
            this.dnalogiGView.Name = "dnalogiGView";
            this.dnalogiGView.ReadOnly = true;
            this.dnalogiGView.Size = new System.Drawing.Size(569, 265);
            this.dnalogiGView.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(713, 637);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Luknje";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1167, 616);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Delovni nalogi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Stevilo kosov:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Opis:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Opombe:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Cas narocila:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Rok konca:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Narocnik:";
            // 
            // dodajDnalogBtn
            // 
            this.dodajDnalogBtn.Location = new System.Drawing.Point(1388, 538);
            this.dodajDnalogBtn.Name = "dodajDnalogBtn";
            this.dodajDnalogBtn.Size = new System.Drawing.Size(127, 23);
            this.dodajDnalogBtn.TabIndex = 23;
            this.dodajDnalogBtn.Text = "Dodaj delovni nalog";
            this.dodajDnalogBtn.UseVisualStyleBackColor = true;
            this.dodajDnalogBtn.Click += new System.EventHandler(this.dodajDnalogBtn_Click);
            // 
            // casNarocilaPicker
            // 
            this.casNarocilaPicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.casNarocilaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.casNarocilaPicker.Location = new System.Drawing.Point(94, 120);
            this.casNarocilaPicker.Name = "casNarocilaPicker";
            this.casNarocilaPicker.ShowUpDown = true;
            this.casNarocilaPicker.Size = new System.Drawing.Size(200, 20);
            this.casNarocilaPicker.TabIndex = 14;
            // 
            // casKoncaPicker
            // 
            this.casKoncaPicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.casKoncaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.casKoncaPicker.Location = new System.Drawing.Point(94, 146);
            this.casKoncaPicker.Name = "casKoncaPicker";
            this.casKoncaPicker.ShowUpDown = true;
            this.casKoncaPicker.Size = new System.Drawing.Size(200, 20);
            this.casKoncaPicker.TabIndex = 15;
            // 
            // stKosovNum
            // 
            this.stKosovNum.Location = new System.Drawing.Point(94, 43);
            this.stKosovNum.Name = "stKosovNum";
            this.stKosovNum.Size = new System.Drawing.Size(120, 20);
            this.stKosovNum.TabIndex = 16;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1766, 946);
            this.Controls.Add(this.dodajDnalogBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dnalogiGView);
            this.Controls.Add(this.kosSaveBtn);
            this.Controls.Add(this.luknjeGView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxRadSlider);
            this.Controls.Add(this.minRadSlider);
            this.Controls.Add(this.minDistSlider);
            this.Controls.Add(this.resSlider);
            this.Controls.Add(this.circleAccThrSlider);
            this.Controls.Add(this.cannyThrSlider);
            this.Controls.Add(this.displayPBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.imgInfoLabel);
            this.Controls.Add(this.loadPicBtn);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Proaim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnalogNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyThrSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleAccThrSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDistSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRadSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRadSlider)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luknjeGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnalogiGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stKosovNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadPicBtn;
        private System.Windows.Forms.Label imgInfoLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dnalogTBox;
        private System.Windows.Forms.DateTimePicker casIzdelavePicker;
        private System.Windows.Forms.MaskedTextBox guidTBox;
        private System.Windows.Forms.TextBox opombeTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown dnalogNumBox;
        private Emgu.CV.UI.ImageBox displayPBox;
        private System.Windows.Forms.TrackBar cannyThrSlider;
        private System.Windows.Forms.TrackBar circleAccThrSlider;
        private System.Windows.Forms.TrackBar resSlider;
        private System.Windows.Forms.TrackBar minDistSlider;
        private System.Windows.Forms.TrackBar minRadSlider;
        private System.Windows.Forms.TrackBar maxRadSlider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView luknjeGView;
        private System.Windows.Forms.Button kosSaveBtn;
        private System.Windows.Forms.TextBox narocnikTBox;
        private System.Windows.Forms.TextBox dnOpombeTBox;
        private System.Windows.Forms.TextBox opisTBox;
        private System.Windows.Forms.TextBox dnalogiIDTBox;
        private System.Windows.Forms.DataGridView dnalogiGView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker casKoncaPicker;
        private System.Windows.Forms.DateTimePicker casNarocilaPicker;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button dodajDnalogBtn;
        private System.Windows.Forms.NumericUpDown stKosovNum;
    }
}

