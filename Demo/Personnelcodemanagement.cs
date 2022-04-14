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
    public partial class Personnelcodemanagement : Form
    {
        public Personnelcodemanagement()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                AddInfo nform = new AddInfo();
                nform.Show();
            }
            else if (e.ColumnIndex == 2)
            {
                AddInfo nform = new AddInfo();
                nform.Show();
            }
        }
    }
}
