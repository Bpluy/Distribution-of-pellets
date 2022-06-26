using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainForm.Model;

namespace MainForm.Views
{
    public partial class ShootForm : Form
    {
        Bitmap bitmap;
        bool isEnabled = false;
        Brush brush = new SolidBrush(Color.Gray);
        Bullet[] bullets;
        double I = 10;
        Graphics g, g1;
        Pen pen = new Pen(Color.Black);
        public ShootForm(Bullet[] bulletsGen)
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            bullets = bulletsGen;
            ZSort(bullets);
        }
        private void ZSort(Bullet[] bullets)
        {
            int left = 0, right = bullets.Length - 1;
            Bullet buf;
            while (left<=right)
            {
                for(int i = right; i>left; i--)
                {
                    if (bullets[i - 1].Z > bullets[i].Z)
                    {
                        buf = bullets[i - 1];
                        bullets[i - 1] = bullets[i];
                        bullets[i] = buf;
                    }
                }
                left++;
                for(int i = left; i<right; i++)
                {
                    if (bullets[i].Z > bullets[i + 1].Z)
                    {
                        buf = bullets[i];
                        bullets[i] = bullets[i + 1];
                        bullets[i + 1] = buf;
                    }
                }
                right--;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            switch(isEnabled)
            {
                case false: { timerDraw.Enabled = true; buttonStart.Text = "Остановить"; isEnabled = true; break; }
                case true: { timerDraw.Enabled = false; buttonStart.Text = "Пуск"; isEnabled = false; break; }
            }
        }

        private void timerDraw_Tick(object sender, EventArgs e)
        {
            double x, y, diam;
            bitmap = new Bitmap(Properties.Resources.colortarget);
            g1 = Graphics.FromImage(bitmap);
            for(int i=bullets.Length-1;i>=0;i--)
            {
                diam = I * (double)numDiam.Value;
                x = Math.Round(850 + bullets[i].X - diam / 2);
                y = Math.Round(475 - bullets[i].Y - diam / 2);
                g1.FillEllipse(brush, (float)x, (float)y, (float)diam, (float)diam);
                g1.DrawEllipse(pen, (float)x, (float)y, (float)diam, (float)diam);
            }
            g.DrawImage(bitmap, new Point(0, 0));
            double a = 1.03912230;
            I /= a;
            if (I<1)
            {
                I = 10;
                timerDraw.Enabled = false;
                buttonStart.Text = "Пуск"; Score score = new Score();
                CheckResult(score);
                string msg = "Попаданий: " + (bullets.Length - score.numMiss).ToString() +
                    ", промахов: " + score.numMiss.ToString() +
                    "\nПопаданий в кольцо #1: " + score.numCircle1.ToString() +
                    "\nПопаданий в кольцо #2: " + score.numCircle2.ToString()+
                    "\nПопаданий в кольцо #3: " + score.numCircle3.ToString()+
                    "\nПопаданий в кольцо #4: " + score.numCircle4.ToString()+
                    "\nПопаданий в кольцо #5: " + score.numCircle5.ToString()+
                    "\nКоличество очков: " + score.score.ToString();
                MessageBoxButtons but = MessageBoxButtons.OK;
                string caption = "Результат";
                DialogResult result;
                result = MessageBox.Show(msg, caption, but);
            }
        }
        private void CheckResult(Score score)
        {
            double length;
            int x, y;
            for(int i = 0;i<bullets.Length;i++)
            {
                x = Math.Abs(bullets[i].X);
                y = Math.Abs(bullets[i].Y);
                length = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (length <= 15)
                {
                    score.numCircle1++;
                    score.score += 5;
                }
                else
                {
                    if (length <= 30)
                    {
                        score.numCircle2++;
                        score.score += 4;
                    }
                    else
                    {
                        if (length <= 45)
                        {
                            score.numCircle3++;
                            score.score += 3;
                        }
                        else
                        {
                            if (length <= 60)
                            {
                                score.numCircle4++;
                                score.score += 2;
                            }
                            else
                            {
                                if (length <= 75)
                                {
                                    score.numCircle5++;
                                    score.score++;
                                }
                                else
                                    score.numMiss++;
                            }
                        }
                    }
                }
            }
        }
    }
}
