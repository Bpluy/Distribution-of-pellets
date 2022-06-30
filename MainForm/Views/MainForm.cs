using MainForm.Model;
using MainForm.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form
    {
        Bullet[,] bullets;
        int currentExperimentNumber = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            bullets = new Bullet[(int)numExperiments.Value, (int)numDrob.Value];
            for (int i = 0; i < numExperiments.Value; i++)
            {
                for (int i1 = 0; i1 < numDrob.Value; i1++)
                {
                    bullets[i, i1] = new Bullet();
                    bullets[i, i1].GenXYZ((double)numKX.Value, (double)numKY.Value, (double)numKZ.Value);
                }
            }
            
            buttonShoot.Enabled = true;
            numCurrentExperiment.Enabled = true;
            numCurrentExperiment.Maximum = numExperiments.Value;
            ShowViews();
        }
        public void DrawGraphics(Bullet[,] bullets, int num)
        {
            Bitmap bXY = new Bitmap(Properties.Resources.target);
            Bitmap bXZ = new Bitmap(Properties.Resources.XZ);
            Bitmap bYZ = new Bitmap(Properties.Resources.YZ);
            Graphics gXY = pbXY.CreateGraphics();
            Graphics gXZ = pbXZ.CreateGraphics();
            Graphics gYZ = pbYZ.CreateGraphics();
            for(int i = 0; i < numDrob.Value; i++)
            {
                if (bullets[num, i].X > -300 && bullets[num, i].X < 150 && bullets[num, i].Y > -300 && bullets[num, i].Y < 150)
                    bXY.SetPixel(150 + bullets[num, i].X, 150 - bullets[num, i].Y, Color.Red);
                if (bullets[num, i].X > -300 && bullets[num, i].X < 150 && bullets[num, i].Z > -100 && bullets[num, i].Z < 200)
                    bXZ.SetPixel(150 + bullets[num, i].X, 299 - bullets[num, i].Z, Color.Red);
                if (bullets[num, i].Y > -300 && bullets[num, i].Y < 150 && bullets[num, i].Z > -100 && bullets[num, i].Z < 200)
                    bYZ.SetPixel(bullets[num, i].Z, 150 - bullets[num, i].Y, Color.Red);
            }
            gXY.DrawImage(bXY, new Point(0, 0));
            gXZ.DrawImage(bXZ, new Point(0, 0));
            gYZ.DrawImage(bYZ, new Point(0, 0));
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            Bullet[] buf = new Bullet[(int)numDrob.Value];
            for (int i = 0; i < buf.Length; i++)
            {
                buf[i] = bullets[currentExperimentNumber, i];
            }
            ShootForm shootForm = new ShootForm(buf, (int)numDrob.Value);            
            shootForm.ShowDialog(this);
        }

        private void ShowViews()
        {
            currentExperimentNumber = (int)numCurrentExperiment.Value - 1;
            DrawGraphics(bullets, currentExperimentNumber);
            Score score = new Score();
            CheckResult(score);
            labelInfo.Text = "Попаданий: " + ((int)numDrob.Value - score.numMiss).ToString() +
                    ", промахов: " + score.numMiss.ToString() +
                    "\nПопаданий в кольцо #1: " + score.numCircle1.ToString() +
                    "\nПопаданий в кольцо #2: " + score.numCircle2.ToString() +
                    "\nПопаданий в кольцо #3: " + score.numCircle3.ToString() +
                    "\nПопаданий в кольцо #4: " + score.numCircle4.ToString() +
                    "\nПопаданий в кольцо #5: " + score.numCircle5.ToString() +
                    "\nКоличество очков: " + score.score.ToString();
        }
        private void CheckResult(Score score)
        {
            double length;
            int x, y;
            for (int i = 0; i < (int)numDrob.Value; i++)
            {
                x = Math.Abs(bullets[currentExperimentNumber, i].X);
                y = Math.Abs(bullets[currentExperimentNumber, i].Y);
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

        private void numCurrentExperiment_ValueChanged(object sender, EventArgs e)
        {
            ShowViews();
        }
    }
}
