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
    public partial class Certificateissued : Form
    {
        public Certificateissued()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Newprinet npr = new Newprinet();
            npr.Show();
        }
    }
}
