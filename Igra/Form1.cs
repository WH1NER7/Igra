using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igra
{
    public partial class Form1 : Form
    {
        PictureBox[] cloud;
        int backgroundspeed;
        Random rnd;
        int playerSpeed;

        PictureBox[] swords;
        int swordSpeed;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundspeed = 6;
            cloud = new PictureBox[20];
            rnd = new Random();
            playerSpeed = 50;

            swords = new PictureBox[1];
            swordSpeed = 200;

            for (int i = 0; i < swords.Length; i++)
            {
                swords[i] = new PictureBox();
                swords[i].BorderStyle = BorderStyle.None;
                swords[i].Size = new Size(50, 10);
                swords[i].BackColor = Color.White;

                this.Controls.Add(swords[i]);
            }


            for (int i = 0; i < cloud.Length; i++)
            {
                cloud[i] = new PictureBox();
                cloud[i].BorderStyle = BorderStyle.None;
                cloud[i].Location = new Point(rnd.Next(-1000, 1280), rnd.Next(50, 225));
                if (i % 2 == 1)
                {
                    cloud[i].Size = new Size(rnd.Next(100, 225), rnd.Next(30, 70));
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 200, 200);
                }
                else
                {
                    cloud[i].Size = new Size(180, 30);
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 205, 255);
                }
                this.Controls.Add(cloud[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < cloud.Length; i++)
            {
                cloud[i].Left += backgroundspeed;

                if (cloud[i].Left >= 1280)
                {
                    cloud[i].Left = cloud[i].Height;
                }

            }
            for (int i = cloud.Length; i < cloud.Length; i++)
            {
                cloud[i].Left += backgroundspeed - 10;

                if (cloud[i].Left >= 1280)
                {
                    cloud[i].Left = cloud[i].Left;

                }
            }
        }


        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.Left > 10)
            {
                mainPlayer.Left -= playerSpeed;
            }
        }

        private void RightMove_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.Left < 1150)
            {
                mainPlayer.Left += playerSpeed;
            }
        }

        private void moveUp_Tick(object sender, EventArgs e)
        {
            mainPlayer.Top -= playerSpeed;
        }

        private void moveDown_Tick(object sender, EventArgs e)
        {
            mainPlayer.Top += playerSpeed;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            mainPlayer.Image = Properties.Resources.run;

            if (e.KeyCode == Keys.Left)
            {
                LeftMoveTimer.Start();

            }
            if (e.KeyCode == Keys.Right)
            {
                RightMove.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown.Start();
            }
            if (e.KeyCode == Keys.Space)
            {
                for (int i = 0; i < swords.Length; i++)
                {
                    if (swords[i].Left > 1280)
                    {
                        swords[i].Location = new Point(mainPlayer.Location.X+100 +i*50,mainPlayer.Location.Y+100);

                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            mainPlayer.Image = Properties.Resources.sV7Mefu;
           
                LeftMoveTimer.Stop();
                RightMove.Stop();
                moveUp.Stop();
                moveDown.Stop();
        }

        private void MoveSwordTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < swords.Length; i++)
            {
                swords[i].Left += swordSpeed;
            }
        }
    }
}
