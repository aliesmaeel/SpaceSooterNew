using SpaceSooterNew.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceSooterNew
{
    public partial class Form1 : Form
    {
        PictureBox[] stars;
        int starsSpeed;
        int bounds;
        Random random;
        int PlayerSpeed;
        PictureBox[] bullets; 
        int bulletsSpeed;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            starsSpeed = 4;
            PlayerSpeed = 4;
            random = new Random();
            stars = new PictureBox[20];
            bulletsSpeed = 15;
            bullets = new PictureBox[3];

            PrintStars();
            PrintBullets();
        }
      
        private void PrintBullets()
        {

            for (int i = 0; i < bullets.Length; i++)
            {

                bullets[i] = new PictureBox();
                bullets[i].BackColor = Color.Yellow;
                bullets[i].Size = new Size(3, 5);
                bullets[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(bullets[i]);
            }
        }

        private void PrintStars()
        {
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(random.Next(0, this.Width), random.Next(0, this.Height));
                stars[i].Size = new Size(2, 2);
                stars[i].BackColor = Color.White;
                this.Controls.Add(stars[i]);
            }
        }

        private void Timer_background_Tick(object sender, EventArgs e)
        {
        
            //// timer will move stars down
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].Top += starsSpeed;

                if (stars[i].Top > this.Height)
                {
                    stars[i].Top = 0;
                }
            }
        }

        private void MoveLeft_Tick(object sender, EventArgs e)
        {
            if(Player.Left > 10)
            {
                Player.Left -= PlayerSpeed;
            }
        }

        private void MoveRight_Tick(object sender, EventArgs e)
        {
            if(Player.Right < this.Width - 25)
            {
                Player.Left += PlayerSpeed;
            }
        }

        private void MoveTop_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= PlayerSpeed;
            }
        }

        private void MoveDown_Tick(object sender, EventArgs e)
        {
            if (Player.Top < this.Height -90)
            {
                Player.Top += PlayerSpeed;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            StopAllTimers();
       
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    bulletsMove.Enabled=true;
                    break;
                case Keys.Left:
                    MoveLeft.Start();
                    break;
                case Keys.Right:
                    MoveRight.Start();
                    break;
                case Keys.Up:
                    MoveUp.Start();
                    break;
                case Keys.Down:
                    MoveDown.Start();
                    break;
            }
        }
        private void StopAllTimers()
        {
            MoveDown.Stop();
            MoveLeft.Stop();
            MoveRight.Stop();
            MoveUp.Stop();
        }

        private void bulletsMove_Tick(object sender, EventArgs e)
        {
 
            int lastBullet = bullets.Length - 1;

            for (int i = 0; i < bullets.Length; i++) {

              


                if (bullets[lastBullet].Top > 0) {

                    bullets[i].Visible = true;
                    bullets[i].Top -= bulletsSpeed;
                }
                else
                {
                    if (bullets[lastBullet].Top < 0)
                    {
                        bulletsMove.Enabled = false;
                        bulletsMove.Stop();
                        break;

                    }

                    bullets[i].Visible = false;
                    bullets[i].Location = new Point(Player.Location.X +30, Player.Location.Y - i*30);
                }
                
               


            }
        }

    }
}
