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
    public partial class 行程明細資料表 : Form
    {
        public 行程明細資料表()
        {
            InitializeComponent();
            var j = from p in T12.Itinerary_Plan行程計畫
                    select p;
            foreach (var item in j)
            {
                comboBoxPJName.Items.Add(item.Itinerary_Name);
            }
            var r = from p in T12.Hotel_Lists
                    select p;
            foreach(var item in r)
            {
                comboBoxHotelName.Items.Add(item.Hotel_Name);
            }
            var x = from p in T12.景點名稱總表
                          select p;
            foreach (var item in x)
            {
                comboBoxAttracion.Items.Add(item.景點名稱);
            }
        }
        TravelerEntities3 T12 = new TravelerEntities3();
        行程明細 行程明細 = new 行程明細();
        int index = -1;
        int id = -1;
        DialogResult qresult;

        private void 顯示資料表()
        {
            this.dataGridViewDetail.DataSource = null;
            var q = from p in T12.行程明細.AsEnumerable()
                    join j in T12.Itinerary_Plan行程計畫 on p.Itinerary_ID equals j.Itinerary_ID
                    join h in T12.Hotel_Lists on p.Hotel_ID equals h.Hotel_ID
                    select new
                    {
                       p.行程明細ID,
                       j.Itinerary_Name,
                       p.DAY,
                       p.Date,
                       h.Hotel_Name,
                    };
            this.dataGridViewDetail.DataSource = q.ToList();
        }
        private void 隱藏資料表()
        {
            this.dataGridViewDetail.Columns[0].Visible = false;
        }
        private void dataGridViewDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            id = Convert.ToInt32(dataGridViewDetail.Rows[index].Cells[0].Value);
            var q = from p in T12.行程明細.AsEnumerable()
                    join j in T12.Itinerary_Plan行程計畫 on p.Itinerary_ID equals j.Itinerary_ID
                    join h in T12.Hotel_Lists on p.Hotel_ID equals h.Hotel_ID
                    where p.行程明細ID == id
                    select new
                    {
                        p.行程明細ID,
                        j.Itinerary_Name,
                        p.DAY,
                        p.Date,
                        h.Hotel_Name,
                    };
            foreach (var item in q)
            {
                comboBoxPJName.Text = item.Itinerary_Name;
                comboBoxDay.Text = item.DAY.ToString();
                dateTimePickerDate.Value = item.Date;
                comboBoxHotelName.Text = item.Hotel_Name;
                txbDetailID.Text = item.行程明細ID.ToString();
            }
        }
        private void 行程明細資料表_Load(object sender, EventArgs e)
        {
            顯示資料表();
        }
        private void btn新增_Click(object sender, EventArgs e)
        {
            if (txbPjID.Text == "")
            {
                MessageBox.Show("欄位空白");
                return;
            }
            else if (comboBoxDay.Text == "")
            {
                MessageBox.Show("欄位空白");
                return;
            }
            else if (txbHotelID.Text == "")
            {
                MessageBox.Show("欄位空白");
                return;
            }
            //數字防呆();
            行程明細 行程明細 = new 行程明細()
            {
                Itinerary_ID = Convert.ToInt32(txbPjID.Text),
                DAY = Convert.ToInt32(comboBoxDay.Text),
                Date = dateTimePickerDate.Value,
                Hotel_ID = Convert.ToInt32(txbHotelID.Text),
            };

            var properties = 行程明細.GetType().GetProperties();
            var values = properties.Select(s => s.GetValue(行程明細)).ToList();

            foreach (var p in values)
            {
                if (p == null)
                    continue;
                if (p.ToString() == "")
                {
                    MessageBox.Show("欄位空白");
                    return;
                }
            }

            this.T12.行程明細.Add(行程明細);
            this.T12.SaveChanges();
            顯示資料表();
            MessageBox.Show("新增成功");
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if (index < 0) { return; }
            id = Convert.ToInt32(dataGridViewDetail.Rows[index].Cells[0].Value);
            var q2 = from p in T12.行程明細
                     where p.行程明細ID == id
                     select p;
            foreach (var q in q2)
            {
                q.Itinerary_ID = Convert.ToInt32(txbPjID.Text);
                q.DAY = Convert.ToInt32(comboBoxDay.Text);
                q.Date = dateTimePickerDate.Value;
                q.Hotel_ID = Convert.ToInt32(txbHotelID.Text);
            }
            qresult = MessageBox.Show("是否確定修改?", "修改確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qresult == DialogResult.Yes)
            {
                this.T12.SaveChanges();
                MessageBox.Show("修改成功");
                顯示資料表();
            }
            else
            {
                return;
            }
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            if (index < 0) { return; }
            id = Convert.ToInt32(dataGridViewDetail.Rows[index].Cells[0].Value);
            var q = (from p in T12.行程明細
                     where p.行程明細ID == id
                     select p).FirstOrDefault();
            qresult = MessageBox.Show("是否確定刪除", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qresult == DialogResult.Yes)
            {
                this.T12.行程明細.Remove(q);
                this.T12.SaveChanges();
                MessageBox.Show("刪除成功");
                顯示資料表();
            }
            else
                return;
        }

        private void comboBoxPJName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string 行程計畫名稱 = comboBoxPJName.Text;
            var q = from p in T12.Itinerary_Plan行程計畫
                    where p.Itinerary_Name == 行程計畫名稱
                    select p;
            foreach (var item in q)
            {
                txbPjID.Text = item.Itinerary_ID.ToString();
                dateTimePickerDate.Value = item.Departure_Date;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string 飯店名稱 = comboBoxHotelName.Text;
            var q = from p in T12.Hotel_Lists
                    where p.Hotel_Name == 飯店名稱
                    select p;
            foreach (var item in q)
            {
               txbHotelID.Text = item.Hotel_ID.ToString();
            }
        }
        DateTime 預設時間 = new DateTime(2022, 09, 01);
        private void btn清除內容_Click(object sender, EventArgs e)
        {
            comboBoxPJName.Text = "";
            txbPjID.Text = "";
            comboBoxDay.Text = "";
            dateTimePickerDate.Value = 預設時間;
            comboBoxHotelName.Text = "";
            txbHotelID.Text = "";
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            var q = from p in T12.行程明細.AsEnumerable()
                    join j in T12.Itinerary_Plan行程計畫 on p.Itinerary_ID equals j.Itinerary_ID
                    join h in T12.Hotel_Lists on p.Hotel_ID equals h.Hotel_ID
                    where j.Itinerary_Name.Contains(txbsearch.Text) || h.Hotel_Name.Contains(txbsearch.Text)
                    || p.Date.Year.ToString().Equals(txbsearch.Text)
                    select new
                    {
                        p.行程明細ID,
                        j.Itinerary_Name,
                        p.DAY,
                        p.Date,
                        h.Hotel_Name,
                    };
            this.dataGridViewDetail.DataSource = q.ToList();
        }

        private void btn清除查詢_Click(object sender, EventArgs e)
        {
            txbsearch.Text = "";
            var q = from p in T12.行程明細.AsEnumerable()
                    join j in T12.Itinerary_Plan行程計畫 on p.Itinerary_ID equals j.Itinerary_ID
                    join h in T12.Hotel_Lists on p.Hotel_ID equals h.Hotel_ID
                    select new
                    {
                        p.行程明細ID,
                        j.Itinerary_Name,
                        p.DAY,
                        p.Date,
                        h.Hotel_Name,
                    };
            this.dataGridViewDetail.DataSource = q.ToList();
        }

        private void btn顯示全部資料_Click(object sender, EventArgs e)
        {
            var q = from p in T12.行程明細.AsEnumerable()
                    join j in T12.Itinerary_Plan行程計畫 on p.Itinerary_ID equals j.Itinerary_ID
                    join h in T12.Hotel_Lists on p.Hotel_ID equals h.Hotel_ID
                    join d in T12.景點報表ID on p.行程明細ID equals d.行程明細ID
                    join a in T12.景點名稱總表 on d.景點名稱ID equals a.景點名稱ID
                    join t in T12.Transportations on p.行程明細ID equals t.行程明細ID
                    join tl in T12.Transportation_Lists on t.TransportationList_ID equals tl.TransportationList_ID
                    select new
                    {
                        p.行程明細ID,
                        j.Itinerary_Name,
                        p.DAY,
                        p.Date,
                        a.景點名稱,
                        h.Hotel_Name,
                        tl.Transportation
                    };
            this.dataGridViewTotal.DataSource = q.ToList();
        }

        private void btnT查詢_Click(object sender, EventArgs e)
        {
            var q = from p in T12.行程明細.AsEnumerable()
                    join j in T12.Itinerary_Plan行程計畫 on p.Itinerary_ID equals j.Itinerary_ID
                    join h in T12.Hotel_Lists on p.Hotel_ID equals h.Hotel_ID
                    join d in T12.景點報表ID on p.行程明細ID equals d.行程明細ID
                    join a in T12.景點名稱總表 on d.景點名稱ID equals a.景點名稱ID
                    join t in T12.Transportations on p.行程明細ID equals t.行程明細ID
                    join tl in T12.Transportation_Lists on t.TransportationList_ID equals tl.TransportationList_ID
                    where j.Itinerary_Name.Contains(txbsearchT.Text) || h.Hotel_Name.Contains(txbsearchT.Text)
                    || p.Date.Year.ToString().Equals(txbsearchT.Text) || a.景點名稱.Contains(txbsearchT.Text) 
                    ||tl.Transportation.Equals(txbsearchT.Text)
                    select new
                    {
                        p.行程明細ID,
                        j.Itinerary_Name,
                        p.DAY,
                        p.Date,
                        a.景點名稱,
                        h.Hotel_Name,
                        tl.Transportation
                    };
            this.dataGridViewTotal.DataSource = q.ToList();
        }

        private void btnT清除_Click(object sender, EventArgs e)
        {
            txbsearchT.Text = "";
            var q = from p in T12.行程明細.AsEnumerable()
                    join j in T12.Itinerary_Plan行程計畫 on p.Itinerary_ID equals j.Itinerary_ID
                    join h in T12.Hotel_Lists on p.Hotel_ID equals h.Hotel_ID
                    join d in T12.景點報表ID on p.行程明細ID equals d.行程明細ID
                    join a in T12.景點名稱總表 on d.景點名稱ID equals a.景點名稱ID
                    join t in T12.Transportations on p.行程明細ID equals t.行程明細ID
                    join tl in T12.Transportation_Lists on t.TransportationList_ID equals tl.TransportationList_ID
                    select new
                    {
                        p.行程明細ID,
                        j.Itinerary_Name,
                        p.DAY,
                        p.Date,
                        a.景點名稱,
                        h.Hotel_Name,
                        tl.Transportation
                    };
            this.dataGridViewTotal.DataSource = q.ToList();
        }


        private void comboBoxAttracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string 景點名稱 = comboBoxAttracion.Text;
            var q = from p in T12.景點名稱總表
                    where p.景點名稱 == 景點名稱
                    select p;
            foreach (var item in q)
            {
                txbAttractionID.Text = item.景點名稱ID.ToString();
            }
        }

        private void btn景點新增_Click(object sender, EventArgs e)
        {
            景點報表ID 景點報表ID = new 景點報表ID()
            {
                行程明細ID = Convert.ToInt32(txbDetailID.Text),
                景點名稱ID = Convert.ToInt32(txbAttractionID.Text),
            };
            this.T12.景點報表ID.Add(景點報表ID);
            this.T12.SaveChanges();
            MessageBox.Show("新增成功");
        }

        
  
        private void comboBoxDay_Click(object sender, EventArgs e)
        {
            if (txbPjID.Text == "")
            {
                return;
            }
            comboBoxDay.Items.Clear();
            int a = Convert.ToInt32(txbPjID.Text);
            var q = (from n in T12.Itinerary_Plan行程計畫
                     where n.Itinerary_ID == a
                     select n).FirstOrDefault();
            int 計畫天數 = q.Itinerary_Days;
            for (int i = 1; i <= 計畫天數; i++)
            {
                comboBoxDay.Items.Add(i);
            }
        }
    }
}
