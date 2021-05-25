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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundspeed = 6;
            cloud = new PictureBox[20];
            rnd = new Random();

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
                    cloud[i].Size = new Size(180,30);
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
    }
}
