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
    public partial class GreetingaddForm : Form
    {
        public GreetingaddForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                SearchHnumForm nform = new SearchHnumForm();
                nform.Show();
            }
            if (e.ColumnIndex == 3)
            {
                REgsteate rst = new REgsteate();
                rst.Show();
            }
            if (e.ColumnIndex == 5)
            {
                Classificationofgreetings nform = new Classificationofgreetings();
                nform.Show();
            }
            if (e.ColumnIndex == 7)
            {
                DepartmentSearch def = new DepartmentSearch();
                def.Show();
            }
            if (e.ColumnIndex == 8)
            {
                DepartmentSearch def = new DepartmentSearch();
                def.Show();
            }
            if (e.ColumnIndex == 9)
            {
                RankSearch rsf = new RankSearch();
                rsf.Show();
            }
            if (e.ColumnIndex == 10)
            {
                RankSearch rsf = new RankSearch();
                rsf.Show();
            }
        }
    }
}
