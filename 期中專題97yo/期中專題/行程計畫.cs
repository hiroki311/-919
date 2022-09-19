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
    public partial class 行程計畫 : Form
    {
        public 行程計畫()
        {
            InitializeComponent();
            起始();
        }
        TravelerEntities3 T12 = new TravelerEntities3();
        Itinerary_Plan行程計畫 G8 = new Itinerary_Plan行程計畫();
        private void 起始()
        {
            var ww = from p in T12.主題類表
                     select p;
            foreach (var item in ww)
            {
                cbb主題.Items.Add(item.旅遊主題ID + "." + item.旅遊主題名稱);
            }
            var w = from p in T12.旅遊類型總表
                    select p;
            foreach (var item in w)
            {
                cbb類型.Items.Add(item.旅遊類型ID + "." + item.旅遊類型);
            }
        }
        private void btn新增_Click(object sender, EventArgs e)
        {
            新增();
            this.T12.Itinerary_Plan行程計畫.Add(G8);
            T12.SaveChanges();
            MessageBox.Show("新增成功");
            查詢();
        }
        private void 新增()
        {
            G8.Itinerary_Days = Convert.ToInt16(txt天數.Text);
            G8.Inbound_Date = dT出發日.Value;
            G8.Departure_Date = dT回程日.Value;
            G8.Maximum_number_of_people = Convert.ToInt16(txt人數.Text);
            G8.Single_Journey_Price = Convert.ToDecimal(txt價格.Text);
            G8.Itinerary_Describtion = txt行程描述.Text;
            G8.Itinerary_Name = txt行程名稱.Text;
            G8.介紹文章 = txt文章介紹.Text;
            G8.旅遊主題ID = Convert.ToInt32(cbb主題.Text.Substring(0, 1));
            G8.旅遊類型ID = Convert.ToInt32(cbb類型.Text.Substring(0, 1));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.ptb上傳照片.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] bytes = ms.GetBuffer();
            G8.圖片 = bytes;
        }
        private void 查詢()
        {
            var q = from p in T12.Itinerary_Plan行程計畫
                    select p;
            dGV1.DataSource = q.ToList();

        }
        private void btn修改_Click(object sender, EventArgs e)
        {
            var q = from p in T12.Itinerary_Plan行程計畫
                    where p.Itinerary_ID == id
                    select p;
            foreach (var G8 in q)
            {
                G8.Itinerary_Days = Convert.ToInt16(txt天數.Text);
                G8.Inbound_Date = dT出發日.Value;
                G8.Departure_Date = dT回程日.Value;
                G8.Maximum_number_of_people = Convert.ToInt16(txt人數.Text);
                G8.Single_Journey_Price = Convert.ToDecimal(txt價格.Text);
                G8.Itinerary_Describtion = txt行程描述.Text;
                G8.Itinerary_Name = txt行程名稱.Text;
                G8.旅遊主題ID = Convert.ToInt32(cbb主題.Text);
                G8.旅遊類型ID = Convert.ToInt32(cbb類型.Text);
            }
            T12.SaveChanges();
            MessageBox.Show("修改成功");
            查詢();
        }


        int index = -1;
        int id = -1;
        private void btn刪除_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dGV1.Rows[index].Cells[0].Value);
            var q = (from p in T12.Itinerary_Plan行程計畫
                     where p.Itinerary_ID == id
                     select p).FirstOrDefault();
            this.T12.Itinerary_Plan行程計畫.Remove(q);
            T12.SaveChanges();
            MessageBox.Show("刪除成功");
            查詢();
        }

        private void btn查詢_Click(object sender, EventArgs e)
        {
                查詢();
        }

        private void dGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn修改.Enabled = true;
            btn刪除.Enabled = true;
            index = e.RowIndex;
            id = Convert.ToInt32(dGV1.Rows[index].Cells[0].Value);
            var q = from p in T12.Itinerary_Plan行程計畫
                    where p.Itinerary_ID == id
                    select p;
            foreach (var p in q)
            {
                txt天數.Text = p.Itinerary_Days.ToString();
                txt人數.Text = p.Maximum_number_of_people.ToString();
                txt價格.Text = p.Single_Journey_Price.ToString();
                txt行程描述.Text = p.Itinerary_Describtion;
                txt行程名稱.Text = p.Itinerary_Name;
                dT出發日.Value = p.Inbound_Date;
                dT回程日.Value = p.Departure_Date;
                cbb主題.Text = p.旅遊主題ID.ToString();
                cbb類型.Text = p.旅遊類型ID.ToString();
            }
        }

        private void btn上傳照片_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.ptb上傳照片.Image = Image.FromFile(this.openFileDialog1.FileName);
            };
        }

        private void cbb主題_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
