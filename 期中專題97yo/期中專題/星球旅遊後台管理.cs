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
            會員資料修改 a會員修改 = new 會員資料修改();
            //a會員修改.MdiParent = this;
            a會員修改.Show();
        }

        private void button2訂單管理_Click(object sender, EventArgs e)
        {
            行程計畫 a行程計畫 = new 行程計畫();
            a行程計畫.Show();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1景點報表_Click(object sender, EventArgs e)
        {
            景點報表 aa = new 景點報表();
            aa.Show();

        }

        private void button1飯店管理_Click(object sender, EventArgs e)
        {
            飯店列表 A = new 飯店列表();
            A.Show();
        }

        private void button3評論管理_Click(object sender, EventArgs e)
        {

        }
    }
}
