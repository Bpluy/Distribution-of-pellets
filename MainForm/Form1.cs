using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MainForm.Model;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Bullet[] bullets = new Bullet[(int)numDrob.Value];
            StreamWriter filePath = new StreamWriter("output.txt");
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new Bullet();
                bullets[i].GenXYZ((double)numMX.Value, (double)numMY.Value, (double)numDX.Value, (double)numDY.Value, (double)numSZ.Value);
                filePath.WriteLine("[" + (i+1) + "] " + bullets[i].X.ToString() + " " + bullets[i].Y.ToString() + " " + bullets[i].Z.ToString());
            }
            filePath.Close();
            DrawGraphics(bullets);
        }
        public void DrawGraphics(Bullet[] bullets)
        {
            Bitmap bXY = new Bitmap("target.bmp");
            Bitmap bXZ = new Bitmap("whitefon.bmp");
            Bitmap bYZ = new Bitmap("whitefon.bmp");
            Graphics gXY = pbXY.CreateGraphics();
            Graphics gXZ = pbXZ.CreateGraphics();
            Graphics gYZ = pbYZ.CreateGraphics();
            for(int i=0;i<bullets.Length;i++)
            {
                bXY.SetPixel(150 + bullets[i].X, 150 + bullets[i].Y, Color.Red);
                bXZ.SetPixel(bullets[i].Z, 150 + bullets[i].X, Color.Red);
                bYZ.SetPixel(bullets[i].Z, 150 + bullets[i].Y, Color.Red);
            }
            gXY.DrawImage(bXY, new Point(0, 0));
            gXZ.DrawImage(bXZ, new Point(0, 0));
            gYZ.DrawImage(bYZ, new Point(0, 0));
        }
    }
}
