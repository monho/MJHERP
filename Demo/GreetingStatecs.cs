using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Demo
{
    public partial class GreetingStatecs : Form
    {
        public GreetingStatecs()
        {



            InitializeComponent();


        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 사원변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        Bitmap bitmap;
        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
         
        }

        private void 더보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 더보기ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void pDFToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void 검색ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PrintForm pfm = new PrintForm();
            pfm.Show();
        }
    }
}
