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
    public partial class 旅遊詳細資訊 : Form
    {
        public 旅遊詳細資訊()
        {
            InitializeComponent();
        }
        TravelerEntities3 tr = new TravelerEntities3();
        ImageToBinary im = new ImageToBinary();
        int ID = 0;
        private void 旅遊詳細資訊_Load(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(labelID.Text);
            COMM.行程計畫編號 = ID;
            int 天數 = 0;
            var q = from a in tr.Itinerary_Plan行程計畫
                    where a.Itinerary_ID == ID
                    //join a2 in tr.action報表 on a.Itinerary_ID equals a2.Itinerary_ID
                    //join a3 in tr.評分表 on a2.評分表ID equals a3.評分表ID
                    select a;
        //            {
        //                Departure_Date = a.Departure_Date,
        //                Itinerary_Days = a.Itinerary_Days,
        //                Inbound_Date = a.Inbound_Date,
        //                Single_Journey_Price = a.Single_Journey_Price,
        //                Itinerary_Name = a.Itinerary_Name,
        //                Maximum_number_of_people = a.Maximum_number_of_people,
        //                Itinerary_ID = "編號" + a.Itinerary_ID,
        //                Itinerary_Describtion = a.Itinerary_Describtion,                        
        //               介紹文章 = a.介紹文章,
        //                ConvertToImage = a.圖片,
        //                評論=a3.評論
        //};
            foreach (var i in q)
            {
                天數 = i.Itinerary_Days;
                label8出發時間.Text = i.Departure_Date.ToString("yyyy/MM/dd");
                label9回程時間.Text = i.Inbound_Date.ToString("yyyy/MM/dd");
                label7價格.Text = i.Single_Journey_Price.ToString().Replace(".0000", "");
                label7標題.Text = i.Itinerary_Name;
                label7總天數.Text = i.Itinerary_Days.ToString();
                label10出團人數.Text = i.Maximum_number_of_people.ToString();
                labelID.Text = "編號"+i.Itinerary_ID.ToString();
                label11簡介.Text = i.Itinerary_Describtion;
                label12介紹.Text = i.介紹文章;
                label5尚可參加人數.Text = i.尚可參加人數.ToString();
                pictureBox1標題畫面.Image = im.ConvertToImage(i.圖片);           
            }

            var q2 = from a in tr.action報表
                     where a.Itinerary_ID == ID
                     join a3 in tr.評分表 on a.評分表ID equals a3.評分表ID              
                     select a3;
            foreach (var ssw in q2)
            {
                label5評論.Text += ssw.評論 + "\n";
            }

            for (int i = 1; i <= 天數; i++)
            {
                var x = from c in tr.Itinerary_Plan行程計畫

                        join p in tr.行程明細 on c.Itinerary_ID equals p.Itinerary_ID
                        join p2 in tr.景點報表ID on p.行程明細ID equals p2.行程明細ID
                        where c.Itinerary_ID == ID && p.DAY == i
                        join p3 in tr.景點名稱總表 on p2.景點名稱ID equals p3.景點名稱ID
                        select p3;

                var ww = from d in tr.行程明細
                     where d.Itinerary_ID == ID && d.DAY ==i
                     join b in tr.Hotel_Lists on d.Hotel_ID equals b.Hotel_ID
                     select b;

                var ss = from tra in tr.行程明細
                         where tra.Itinerary_ID == ID && tra.DAY == i
                         join tra2 in tr.Transportations on tra.行程明細ID equals tra2.行程明細ID
                         join tra3 in tr.Transportation_Lists on tra2.TransportationList_ID equals tra3.TransportationList_ID
                         select new
                         {
                             交通工具 = tra3.Transportation,
                             公司名稱 = tra2.Company_Name,
                             價格 = tra2.Price,
                             出發地點 = tra2.Departure,
                             抵達地點 = tra2.Destination,
                             出發時間 = tra2.Departure_Time,
                             抵達時間=tra2.Time_of_Arrival,
                             隨便 = tra2.行程明細ID
                         };
              
                foreach (var hoimg in ww)
            {
                UserControl全抓 抓 = new UserControl全抓();
                抓.飯店圖片 = hoimg.Hotel_image;
                抓.飯店資訊 = hoimg.Hotel_Name + "\n"
                    + hoimg.Hotel_Address + "\n"
                    + hoimg.Hotel_Phone;
                    抓.第幾天 = $"第{i}天";
                foreach (var m in x)
                {
                    抓.景點圖片 = m.景點圖片1;
                    抓.景點圖片2 = m.景點圖片2;
                }
                    if (!ss.Any())
                        MessageBox.Show("aaa");
                    foreach (var tt in ss)
                    {
                        //MessageBox.Show(tt.TransportationList_ID+"");
                        抓.交通工具 = $"交通工具:{tt.交通工具}({tt.公司名稱})\n預計出發時間:{tt.出發時間}\n預計抵達時間:{tt.抵達時間}\n出發地:{tt.出發地點}   目的地:{tt.抵達地點}";
                    }
                    flowLayoutPanel1.Controls.Add(抓);
            }
                if (label5尚可參加人數.Text == "0")
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
            }
            //var hotel_picture = from a in tr.行程明細
            //                    where a.Itinerary_ID == ID
            //                    group a by a.Hotel_List into g
            //                    select new
            //                    {
            //                        g.Key,
            //                        圖片 = g.Key.Hotel_image
            //                    };
            //foreach (var item in hotel_picture)
            //{
            //    pictureBox1飯店圖.Image = im.ConvertToImage(item.圖片) ;
            //}
        }
        public string setID
        {
            set
            {
                labelID.Text = value;
            }
        }
        private void button購物車_Click(object sender, EventArgs e)
        {         
            //COMM.計畫 = Convert.ToInt32(labelID.Text);
            if (COMM.ID==0)
            {           
                MessageBox.Show("請先登入");
                return;
            }
            var q = (from aa in tr.Itinerary_Plan行程計畫
                    where aa.Itinerary_ID == ID
                    select aa).FirstOrDefault();

            var  hh= from aa in tr.Order訂單
                     where aa.Itinerary_ID == ID &&aa.Member_ID==COMM.ID && aa.訂單狀態編號ID!=2
                     select aa;
            if (!hh.Any())
            {
                Order訂單 OR = new Order訂單()
                {
                    Itinerary_ID = q.Itinerary_ID,
                    Unified_Business_No_ = null,
                    Member_ID = COMM.ID,
                    Price = Convert.ToDecimal(q.Single_Journey_Price),
                    Payment_Methods_ID = 1,
                    Credit_Card_Number = null,
                    訂單狀態編號ID = 1,
                   
            };
            tr.Order訂單.Add(OR);
            tr.SaveChanges();
            MessageBox.Show("新增購物車成功");
            }
            else
            {
                DialogResult qresult;
                qresult = MessageBox.Show("已存在購物車", "去購物車拉", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button2我要評論_Click(object sender, EventArgs e)
        {
            評價頁面 頁面 = new 評價頁面();
            頁面.Show();
        }
    }
}
