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
            var q = from a in tr.Itinerary_Plan行程計畫
                    where a.Itinerary_ID == ID
                    select a;
            //List<Itinerary_Plan行程計畫> list = q.ToList();
            foreach (var i in q)
            {
                label8出發時間.Text = i.Departure_Date.ToString("yyyy/MM/dd");
                label9回程時間.Text = i.Inbound_Date.ToString("yyyy/MM/dd");
                label7價格.Text = i.Single_Journey_Price.ToString().Replace(".0000", "");
                label7標題.Text = i.Itinerary_Name;
                label7總天數.Text = i.Itinerary_Days.ToString();
                label10出團人數.Text = i.Maximum_number_of_people.ToString();
                labelID.Text = "編號"+i.Itinerary_ID.ToString();
                label11簡介.Text = i.Itinerary_Describtion;
                label12介紹.Text = i.介紹文章;
                pictureBox1標題畫面.Image = im.ConvertToImage(i.圖片);
            }
            var x = from c in tr.Itinerary_Plan行程計畫
                    join p in tr.行程明細 on c.Itinerary_ID equals p.Itinerary_ID
                    join p2 in tr.景點報表ID on p.行程明細ID equals p2.行程明細ID
                    join p3 in tr.景點名稱總表 on p2.景點名稱ID equals p3.景點名稱ID
                    select p3;
            dataGridView1.DataSource = x.ToList();
            
            foreach (var m in x)
            {
                pictureBox1標題旁照片.Image = im.ConvertToImage(m.景點圖片1);
                pictureBox1景點圖1.Image = im.ConvertToImage(m.景點圖片2);
                pictureBox1景點圖2.Image = im.ConvertToImage(m.景點圖片3);
            }
         
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
                會員註冊系統 註冊 = new 會員註冊系統();
                MessageBox.Show("請先登入");
                註冊.ShowDialog();
            }
            var q = (from aa in tr.Itinerary_Plan行程計畫
                    where aa.Itinerary_ID == ID
                    select aa).FirstOrDefault();
            Order訂單 OR = new Order訂單()
            {
                Itinerary_ID = q.Itinerary_ID,
                Unified_Business_No_ = null,
                Member_ID = COMM.ID,
                Price =Convert.ToInt32(q.Single_Journey_Price),
                Payment_Methods_ID = 1,
                Credit_Card_Number = null,
                //訂單狀態編號ID=1
            };
            tr.Order訂單.Add(OR);
            tr.SaveChanges();
            MessageBox.Show("新增購物車成功");
        }
    }
}
