using System;

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

        public void GenXYZ(double KX, double KY, double KZ)
        {            
            double x = 0, y = 0, z;
            for(int i=0; i<12; i++)
            {
                x += r.NextDouble();
                y += r.NextDouble();
            }
            x = KX * (x-6);
            y = KY * (y-6);
            z = KZ * Math.Sqrt(2 * Math.Log(1 / (1 - r.NextDouble())));
            X = (int)Math.Round(x);            
            Y = (int)Math.Round(y);
            Z = (int)Math.Round(z);
        }
    }
}
