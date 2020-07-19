using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proaim {
    public class Luknja {
        public int Center_x { get; set; }
        public int Center_y { get; set; }
        public int Radius { get; set; }
        public double Area { get; set; }

        public Luknja(int center_x, int center_y, int radius) {
            Center_x = center_x;
            Center_y = center_y;
            Radius = radius;
            Area = (Math.PI * Math.Pow(Radius, 2));
        }
    }
}
