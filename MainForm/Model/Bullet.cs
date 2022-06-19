using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Model
{
    public class Bullet
    {
        public int X;
        public int Y;
        public int Z;
        private static Random r = new Random();

        public Bullet()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public void GenXYZ(double MX,double MY, double DX, double DY, double Sigma)
        {
            
            double x = 0, y = 0, z;
            for(int i=0; i<12; i++)
            {
                x += r.NextDouble();
                y += r.NextDouble();
            }
            x = (x-6) * DX + MX;
            y = (y-6) * DY + MY;
            z = Sigma * Math.Sqrt(2 * Math.Log(1 / (1 - r.NextDouble())));
            X = (int)Math.Round(x*10);            
            Y = (int)Math.Round(y*10);
            Z = (int)Math.Round(z*20);
        }
    }
}
