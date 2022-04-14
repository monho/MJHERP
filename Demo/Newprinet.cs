using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Demo
{
    public partial class Newprinet : Form
    {
        private Point point = new Point();
        public Newprinet()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.FromArgb(69,69,235);
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchHnumForm shf = new SearchHnumForm();
            shf.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("gg");
        }
    }
}
