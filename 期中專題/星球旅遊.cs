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
    public partial class 星球旅遊 : Form
    {
        public 星球旅遊()
        {
            InitializeComponent();
          
        }

        ImageToBinary im = new ImageToBinary();
        TravelerEntities3 tr = new TravelerEntities3();
        private void flowPanel顯示(IQueryable<Itinerary_Plan行程計畫> q)
        {
            List<Itinerary_Plan行程計畫> list = q.ToList();
            this.flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                UserControl1 item = new UserControl1();
                item.價格 = list[i].Single_Journey_Price.ToString();
                item.方案名稱 = list[i].Itinerary_Name;
                item.旅遊圖片 = list[i].圖片;
                item.旅遊方案ID = list[i].Itinerary_ID;

                this.flowLayoutPanel1.Controls.Add(item);
                Application.DoEvents();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            行程計畫 AA = new 行程計畫();
            AA.Show();
            
        }

        會員註冊系統 b = new 會員註冊系統();
        private void 星球旅遊_Load(object sender, EventArgs e)
        {
            //b.ShowDialog();
            片片.Ctlcontrols.play();
            var q = from a in tr.Itinerary_Plan行程計畫
                    select a;
   
            flowPanel顯示(q);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            var q = from c in tr.Itinerary_Plan行程計畫
                    where c.旅遊主題ID == 2
                    select c;

            flowPanel顯示(q);
        }

      

        private void button全部_Click(object sender, EventArgs e)
        {
            var q = from a in tr.Itinerary_Plan行程計畫
                    select a;
            flowPanel顯示(q);
        }

        private void button12情侶_Click(object sender, EventArgs e)
        {
            var q = from c in tr.Itinerary_Plan行程計畫
                    where c.旅遊主題ID == 1
                    select c;
            flowPanel顯示(q);
        }

        private void button1馬上出發_Click(object sender, EventArgs e)
        {
            var q = from c in tr.Itinerary_Plan行程計畫
                    orderby c.Itinerary_Describtion 
                    select c;
            flowPanel顯示(q);
        }

        private void button11熱賣中_Click(object sender, EventArgs e)
        {
            var q = from c in tr.Itinerary_Plan行程計畫
                 where c.旅遊主題ID==4
                    select c;
            flowPanel顯示(q);
        }

        private void button會員專區_Click(object sender, EventArgs e)
        {
            會員專區 A會員專區 = new 會員專區();
         
           
            A會員專區.ShowDialog();
          
        }

        private void buttonLOGIN_Click_1(object sender, EventArgs e)
        {
                

            if (COMM.是否登入成功)
            {
               會員註冊系統 註冊 = new 會員註冊系統();
                註冊.ShowDialog();
                var h = from hh in tr.Member_Info_Lists
                        where hh.Member_ID == COMM.ID
                        select hh;
                
                button11大頭貼.Text = "登出";
                
                foreach (var it in h)
                {
                    button11大頭貼.BackgroundImage = im.ConvertToImage(it.image);
                    label1會員招呼.Text = "HI!  " + it.Name;
                }
                COMM.是否登入成功 = false;
            }
            else
            {
                
                button11大頭貼.Text = "登入";
                //button11大頭貼.BackgroundImage = im.ConvertToImage(it.image);
                COMM.ID = 0;
                COMM.是否登入成功 =true;
                label1會員招呼.Text = "";
                MessageBox.Show("登出成功");
            }

            
            //if驗證成功，按鍵名稱改成登出
            //驗證可用member ID確認
            //if member id = true

        
            //if登出click，按鍵名稱改成登入
        }

        private void button3連結後台_Click(object sender, EventArgs e)
        {
            星球旅遊後台管理 管理 = new 星球旅遊後台管理();
            管理.Show();
        }

        private void button2登出_Click(object sender, EventArgs e)
        {
            購物車 車子 = new 購物車();
            車子.Show();
        }

        private void button1台灣_Click(object sender, EventArgs e)
        {
            var q = from a in tr.Itinerary_Plan行程計畫
                    where a.國家總表ID == 1
                    select a;
            flowPanel顯示(q);
        }
        private void button4日本_Click(object sender, EventArgs e)
        {
            var q = from a in tr.Itinerary_Plan行程計畫
                    where a.國家總表ID == 7
                    select a;
            flowPanel顯示(q);
        }

        private void button6韓國_Click(object sender, EventArgs e)
        {
            var q = from a in tr.Itinerary_Plan行程計畫
                    where a.國家總表ID == 8
                    select a;
            flowPanel顯示(q);
        }

        private void button8美加_Click(object sender, EventArgs e)
        {
            var q = from a in tr.Itinerary_Plan行程計畫
                    where a.國家總表ID == 9
                    select a;
            flowPanel顯示(q);
        }

        private void button7歐洲_Click(object sender, EventArgs e)
        {
            var q = from a in tr.Itinerary_Plan行程計畫
                    where a.國家總表ID == 10
                    select a;
            flowPanel顯示(q);
        }

        private void button5港澳_Click(object sender, EventArgs e)
        {
            var q = from a in tr.Itinerary_Plan行程計畫
                    where a.國家總表ID == 11
                    select a;
            flowPanel顯示(q);
        }

        private void button10東南亞_Click(object sender, EventArgs e)
        {
            var q = from a in tr.Itinerary_Plan行程計畫
                    where a.國家總表ID == 12
                    select a;
            flowPanel顯示(q);
        }

        private void button2會員資料修改_Click_1(object sender, EventArgs e)
        {
            if (COMM.ID == 0)
            {

                MessageBox.Show("請先登入");
                return;
            }
            會員專區_資料修改 a = new 會員專區_資料修改();
            this.flowLayoutPanel1.Controls.Clear();
            a.TopLevel = false;
            this.flowLayoutPanel1.Controls.Add(a);
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (COMM.ID == 0)
            {

                MessageBox.Show("請先登入");
                return;
            }
            會員專區_我的評論 a = new 會員專區_我的評論();
            this.flowLayoutPanel1.Controls.Clear();
            a.TopLevel = false;
            this.flowLayoutPanel1.Controls.Add(a);
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void button12會員專區我的訂單_Click(object sender, EventArgs e)
        {
            if (COMM.ID == 0)
            {

                MessageBox.Show("請先登入");
                return;
            }
            會員專區_我的訂單 a = new 會員專區_我的訂單();
            this.flowLayoutPanel1.Controls.Clear();
            a.TopLevel = false;
            this.flowLayoutPanel1.Controls.Add(a);
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button11一個人_Click(object sender, EventArgs e)
        {
            var q = from c in tr.Itinerary_Plan行程計畫
                    where c.旅遊主題ID == 3
                    select c;
            flowPanel顯示(q);
        }
    }
}
