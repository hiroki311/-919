using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class 星球旅遊後台管理 : Form
    {
        public 星球旅遊後台管理()
        {
            InitializeComponent();
        }

        private void button1會員管理_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            會員資料修改 a行程計畫 = new 會員資料修改();
            a行程計畫.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(a行程計畫);
            a行程計畫.WindowState = FormWindowState.Maximized;
            a行程計畫.Show();
        }

        private void button2訂單管理_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            行程計畫 a行程計畫 = new 行程計畫();
            a行程計畫.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(a行程計畫);
            a行程計畫.WindowState = FormWindowState.Maximized;
            a行程計畫.Show();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1景點報表_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            景點報表 aa = new 景點報表();
            aa.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(aa);
            aa.WindowState = FormWindowState.Maximized;
            aa.Show();
        }

        private void button3評論管理_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            評分報表 報表 = new 評分報表();
            報表.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(報表);
            報表.WindowState = FormWindowState.Maximized;
            報表.Show();
        }

        private void button1飯店管理_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            飯店列表 A = new 飯店列表();
            A.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(A);
            A.WindowState = FormWindowState.Maximized;
            A.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            交通工具資料表 報表 = new 交通工具資料表();
            報表.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(報表);
            報表.WindowState = FormWindowState.Maximized;
            報表.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            行程明細資料表 報表 = new 行程明細資料表();
            報表.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(報表);
            報表.WindowState = FormWindowState.Maximized;
            報表.Show();
        }



        //private void button1飯店管理_Click(object sender, EventArgs e)
        //{
        //  
        //}
    }
}
