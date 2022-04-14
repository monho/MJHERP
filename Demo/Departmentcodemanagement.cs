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
    public partial class Departmentcodemanagement : Form
    {
        private Point point = new Point();
        public Departmentcodemanagement()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public void Btnregister()
        {
            // MessageBox.Show("난 폼2에서 조회버튼 실행");
            CodeAddForm npr = new CodeAddForm();
            npr.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            AddDepartmentsADd npr2 = new AddDepartmentsADd();

            npr2.Show();
        }
    }
}
