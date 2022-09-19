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
    public partial class 購物車 : Form
    {
        public 購物車()
        {
            InitializeComponent();
            走起1();
        }
        ImageToBinary im = new ImageToBinary();
        private void 走起1()
        {
            TravelerEntities3 tr = new TravelerEntities3();
            COMM myClass = new COMM();
            

            int 會員ID = COMM.ID;

            var q = from n in tr.Order訂單
                    where n.Member_ID==會員ID
                    group n by n.Itinerary_Plan行程計畫 into t
                    select new {圖片=t.Key.圖片,Name=t.Key.Itinerary_Name,單價= t.Key.Single_Journey_Price,人數= t.Key.Maximum_number_of_people};

                foreach (var i in q)
                {
                UserControl2訂單 U2 = new UserControl2訂單();
                U2.旅遊圖片 =i.圖片;
                    U2.商品名稱 = i.Name;
                    U2.單價 = i.單價.ToString();
                    U2.剩餘人數 = i.人數.ToString();
                    this.flowLayoutPanel1.Controls.Add(U2);
                    Application.DoEvents();
                }
            lb小計.Text = set小計;



        }
        private void 改變金額() {
            lb小計.Text = set小計;
        }
        public string set小計
        {
            get
            {
                return COMM.總金額.ToString();
               
            }
            //set
            //{
            //    lb小計.Text = value;
            //}
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn結帳_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            改變金額();
        }

        private void 購物車_MouseMove(object sender, MouseEventArgs e)
        {
            改變金額();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
