using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Web_App_desktop.manage;

namespace Web_App_desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Httpmanage httpmanage = new Httpmanage();
            if(textBox1.Text!=null)
            {
                string number = textBox1.Text;
                List<string> text = httpmanage.getSurvey_point_Number(number);
            }
            else
            {
                MessageBox.Show("输入不为空");
            }
        }
    }
}
