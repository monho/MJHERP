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
    public partial class femilystate : Form
    {

        DateTimePicker dateTimePicker1;
        public femilystate()
        {
            InitializeComponent();
        }


        private void DPTextchange(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dateTimePicker1.Text.ToString();
        }

        private void DPClose(Object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {

                DateTimePicker dateTimePicker1 = new DateTimePicker();
                dataGridView1.Controls.Add(dateTimePicker1); ;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy 년 MM 월 dd일 ";
                Rectangle displaycalendar = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dateTimePicker1.Size = new Size(displaycalendar.Width, displaycalendar.Height);
                dateTimePicker1.Location = new Point(displaycalendar.X, displaycalendar.Y);


            }



        }
    }
}
