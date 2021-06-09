using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            if (textBox1.Text != null)
            {
                string number = textBox1.Text;
                List<maxloadReadinglist> text = httpmanage.Statistics(number);
                Draw_bitmap(text);
            }
            else
            {
                MessageBox.Show("输入不为空");
            }
        }

        private void Draw_bitmap(List<maxloadReadinglist> textdata)
        {

            int panelHeight = this.panel1.Height;
            int panelWidth = this.panel1.Width;
            //创建新的画布
            Bitmap bitM = new Bitmap(panelWidth, panelHeight);
            Graphics g = Graphics.FromImage(bitM);
            g.Clear(Color.White);
            //设置字体
            Font font = new Font("Arial", 9, FontStyle.Regular);
            Font fontSong = new Font("宋体", 20, FontStyle.Regular);
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, bitM.Width, bitM.Height), Color.Blue, Color.Green, 1.2f, true);
            g.FillRectangle(Brushes.WhiteSmoke, 0, 0, panelWidth, panelHeight);
            Brush brush1 = new SolidBrush(Color.Blue);
            g.DrawString(textBox1.Text, fontSong, brush1, new PointF(180, 30));
            //画图片的边框线
            g.DrawRectangle(new Pen(Color.Blue), 0, 0, panelWidth - 4, panelHeight - 4);
            Pen mypen = new Pen(brush, 1f);
            //绘制纵向线条
            int x = 50;
            for (int i = 0; i < textdata.Count; i++)
            {
                g.DrawLine(mypen, x, 75, x, 850);
                x += 75;
            }
            // 绘制横向线条
            List<double> StrY = getvalue(textdata);
            double min = StrY.Min();
            double max = StrY.Max();
            int y = 74;

            for (int i = 0; i < max; i++)
            {
                g.DrawLine(mypen, 50, y, 2100, y);
                y += 26;
            }
            //绘制X轴           
            x = 15;
            for (int i = 0; i < textdata.Count; i++)
            {
                g.DrawString(textdata[i].SurveyPointNumber, font, Brushes.Red, x, panelHeight - 30);
                x += 75;
            }
            //绘制Y轴数量

            y = 78;
            for (double i = max; i >= min; i=i-1.5)
            {
                g.DrawString(i.ToString(), font, Brushes.Red, 25, y);
                y += 26;
            }
            //填充数据
            for (int i = 0; i < textdata.Count; i++)
            {
                SolidBrush sb = new SolidBrush(Color.FromArgb(150, 0, 0));
                int h = (int)(textdata[i].LoadReading / (max - min) * 850);
                g.FillRectangle(sb, 75+i * 75, y-h, 30, h);
            }
            this.panel1.BackgroundImage = bitM;
        }
        private List<double> getvalue(List<maxloadReadinglist> textdata)
        {
            List<double> StrY = new List<double>();
            for (int i = 0; i < textdata.Count; i++)
            {
                StrY.Add(textdata[i].LoadReading);
            }
            return StrY;
        }
    }
}
