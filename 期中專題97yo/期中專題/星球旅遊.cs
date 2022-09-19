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
       
     
        TravelerEntities3 tr = new TravelerEntities3();
        private void flowPanel顯示(IQueryable<Itinerary_Plan行程計畫> q)
        {
            List<Itinerary_Plan行程計畫> list = q.ToList();
            dataGridView1.DataSource = list;
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

        private void button1_Click(object sender, EventArgs e)
        {  
     

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
            var q = from a in tr.Itinerary_Plan行程計畫
                    select a;
            //var h = from hh in tr.Member_Info_Lists
            //        where hh.Member_ID == COMM.ID
            //        select hh;
          
            //foreach (var it in h)
            //{
            //    label1會員招呼.Text = "HI!  " + it.Name;
            //}
           
             
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
                    orderby c.Single_Journey_Price
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
                button11.Text = "登出";
                foreach (var it in h)
                {
                    label1會員招呼.Text = "HI!  " + it.Name;
                }
                COMM.是否登入成功 = false;
            }
            else
            {
                button11.Text = "登入";
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
    }
}
