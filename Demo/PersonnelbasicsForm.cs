using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;


namespace Demo
{
    public partial class PersonnelbasicsForm : Form
    {
        public string aResult { get; set; }
        public string aItems { get; set; }
        public string name { get; set; }
        //슬라이딩 메뉴의 최대, 최소 폭 크기
        const int MAX_SLIDING_WIDTH = 200;
        const int MIN_SLIDING_WIDTH = 50;
        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 10;
        //최초 슬라이딩 메뉴 크기
        int _posSliding = 200;
        private bool isCollapsed;
      
        public PersonnelbasicsForm()
        {
            InitializeComponent();
        }
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {


        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
           
            
        }

        private void timerSliding_Tick(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void PersonnelbasicsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
