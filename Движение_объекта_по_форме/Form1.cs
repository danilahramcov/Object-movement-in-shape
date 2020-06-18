using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Движение_объекта_по_форме
{
    public partial class Form1 : Form
    {
        public bool LeftMove, UpMove, LeftMove2, UpMove2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (LeftMove == true)
                pictureBox1.Left += 10;
            if (LeftMove2 == true)
                pictureBox2.Left += 10;

            if (LeftMove == false)
                pictureBox1.Left -= 10;
            if (LeftMove2 == false)
                pictureBox2.Left -= 10;

            if (UpMove == true)
                pictureBox1.Top += 10;
            if (UpMove2 == true)
                pictureBox2.Top += 10;

            if (UpMove == false)
                pictureBox1.Top -= 10;
            if (UpMove2 == false)
                pictureBox2.Top -= 10;

            if (pictureBox1.Left <= ClientRectangle.Left)
                LeftMove = true;
            if (pictureBox2.Left <= ClientRectangle.Left)
                LeftMove2 = true;

            if (pictureBox1.Right >= ClientRectangle.Right)
                LeftMove = false;
            if (pictureBox2.Right >= ClientRectangle.Right)
                LeftMove2 = false;

            if (pictureBox1.Top <= ClientRectangle.Top)
                UpMove = true;
            if (pictureBox2.Top <= ClientRectangle.Top)
                UpMove2 = true;

            if (pictureBox1.Bottom >= ClientRectangle.Bottom)
                UpMove = false;
            if (pictureBox2.Bottom >= ClientRectangle.Bottom)
                UpMove2 = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p1 = this.Height;
            int p2 = this.Width;
            int s1 = pictureBox1.Size.Width;
            int s2 = pictureBox1.Size.Height;
            int v1 = pictureBox2.Size.Width;
            int v2 = pictureBox2.Size.Height;
            Random rng = new Random();
            pictureBox1.Location = new Point(rng.Next(p1 - s1), rng.Next(p2 - s2));
            pictureBox2.Location = new Point(rng.Next(p1 - v1), rng.Next(p2 - v2));
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button1.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
