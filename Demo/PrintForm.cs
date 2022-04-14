using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DGVPrinterHelper;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Demo
{
    public partial class PrintForm : Form
    {
        private int curPageNumber;
        private Point point = new Point();
        public PrintForm()
        {
            InitializeComponent();

            curPageNumber = 1;
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
           
        }

        private void 더보기ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
        Bitmap bitmap;
        private void pDFToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "인사발령대장";
            printer.SubTitle = "출력 : " + label3.Text;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "대표이사 : OOO";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
  
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Height = 45000;
            panel2.Height = 45000;
            dataGridView1.Height = 55000;
        }
    }
}
