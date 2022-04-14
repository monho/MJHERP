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
    public partial class Checkgreetingcard : Form
    {
        public Checkgreetingcard()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellBeginEdit_1(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                AddInfo nform = new AddInfo();
                nform.Show();
            }
            if (e.ColumnIndex == 2)
            {
                AddInfo rst = new AddInfo();
                rst.Show();
            }
        }
    }
}
