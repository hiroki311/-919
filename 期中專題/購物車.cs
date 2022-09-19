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
        TravelerEntities3 tr = new TravelerEntities3();
        List<UserControl2訂單> 框框 = new List<UserControl2訂單>();
        private void 走起1()
        {
            
            COMM myClass = new COMM();
            

            int 會員ID = COMM.ID;

            var q = from n in tr.Order訂單
                    where n.Member_ID==會員ID && n.訂單狀態編號ID==1
                    group n by n.Itinerary_Plan行程計畫 into t
                    select new
                    {
                        圖片=t.Key.圖片,
                        Name=t.Key.Itinerary_Name,
                        單價= t.Key.Single_Journey_Price,
                        剩餘人數= t.Key.尚可參加人數,
                        計畫ID =t.Key.Itinerary_ID,
                    };

                foreach (var i in q)
                {
                UserControl2訂單 U2 = new UserControl2訂單();
                U2.旅遊圖片 =i.圖片;
                    U2.商品名稱 = i.Name;
                    U2.單價 = i.單價.ToString();
                    U2.剩餘人數 = i.剩餘人數.ToString();
                U2.刪除 = i.計畫ID.ToString();
                    this.flowLayoutPanel1.Controls.Add(U2);
                框框.Add(U2);
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
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn結帳_Click(object sender, EventArgs e)
        {
            if (lb總金額.Text == "0" || lb總金額.Text == "")
            {
                MessageBox.Show("購物車無商品");
                return;
            }

            TravelerEntities3 tr = new TravelerEntities3();
            List<int> 訂單ID串 = new List<int>();
            List<int> 行程ID串 = new List<int>();
            var q = from n in tr.Order訂單
                    where n.Member_ID == COMM.ID
                    select n;
            if (!q.Any())
            {
                return;
            }
            foreach (var G8 in q)
            {
                G8.訂單狀態編號ID = 2;
                訂單ID串.Add(G8.OrderID);
                行程ID串.Add(Convert.ToInt32(G8.Itinerary_ID));
            }

            for (int i = 0; i < 框框.Count; i++)
            {
                OrderDetails隨行人員 ODD = new OrderDetails隨行人員();
                ODD.OrderID = 訂單ID串[i];
                ODD.Member_ID = COMM.ID;
                ODD.購買日期 = DateTime.Now;
                ODD.人數 = (Convert.ToInt32(框框[i].數量));

                tr.OrderDetails隨行人員.Add(ODD);
                int pp = 行程ID串[i];
                var q2 = from n in tr.Itinerary_Plan行程計畫
                         where n.Itinerary_ID == pp

                         select n;
                foreach (var item in q2)
                {
                    item.尚可參加人數 -= (Convert.ToInt32(框框[i].數量));
                }
                tr.SaveChanges();
                MessageBox.Show("結帳成功");
                flowLayoutPanel1.Controls.Clear();
            }
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            改變金額();
            lb總金額.Text = (Convert.ToInt32(set小計) - Convert.ToInt32(lb折抵金額.Text)).ToString();
        }

        private void 購物車_MouseMove(object sender, MouseEventArgs e)
        {
            改變金額();
            lb總金額.Text = (Convert.ToInt32(set小計) - Convert.ToInt32(lb折抵金額.Text)).ToString();
        }

        private void 購物車_Load(object sender, EventArgs e)
        {

        }

        private void 購物車_FormClosing(object sender, FormClosingEventArgs e)
        {
            COMM.總金額 = 0;
        }
    }
}
