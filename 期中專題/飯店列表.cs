//using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class 飯店列表 : Form
    {
        public 飯店列表()
        {
            InitializeComponent();
        }
        TravelerEntities3 tr = new TravelerEntities3();
        ImageToBinary im = new ImageToBinary();
        private void button1_Click(object sender, EventArgs e)
        {

            Hotel_List list = new Hotel_List();
            {



                //System.IO.MemoryStream ms1 = new System.IO.MemoryStream();
                var q = from p in tr.Hotel_Lists
                        select p;
                foreach (var item in q)
                {
                        if(txthoadd.Text== item.Hotel_Address&&txthoname.Text==item.Hotel_Name&&txthophone.Text==item.Hotel_Phone)
                            {
                        MessageBox.Show("這是同一間飯店");
                        return;
                            }
    
                        //this.pictureBox2.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //byte[] bytes1 = ms1.GetBuffer();
                        //     list.Hotel_image = bytes1;
                                  
                }  
                      list.Hotel_Name = txthoname.Text;
                        list.Hotel_Address = txthoadd.Text;
                        list.Hotel_Phone = txthophone.Text;
                        list.Hotel_image = im.ConvertToByte(pictureBox2.Image);   

            };
            this.tr.Hotel_Lists.Add(list);
            this.tr.SaveChanges();
            MessageBox.Show("新增成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var q = from p in tr.Hotel_Lists
                        //where p.Hotel_ID.ToString().Contains(txt_ID.Text)
                        //|| p.Hotel_Name.ToString().Contains(txt_ID.Text)
                        //|| p.Hotel_Address.ToString().Contains(txt_ID.Text)
                        //|| p.Hotel_Phone.ToString().Contains(txt_ID.Text)
                    select p;
            this.dataGridView1.DataSource = q.ToList();
        }
        int id = -1;
        int index = -1;
        private void 刪除_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            var q = (from p in tr.Hotel_Lists
                     where p.Hotel_ID == id
                     select p).FirstOrDefault();
            this.tr.Hotel_Lists.Remove(q);
            this.tr.SaveChanges();
            更新資料表();
            MessageBox.Show("刪除成功");

        }
        private void 更新資料表()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.tr.Hotel_Lists.ToList();
        }

        private void 上傳圖片_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.Image = Image.FromFile(this.openFileDialog1.FileName);
            };
           
        }
        public byte[] Hotel_image
        {
            set
            {
                this.pictureBox2.Image = im.ConvertToImage(value);
            }
        }
        private void 關鍵字_Click_1(object sender, EventArgs e)
        {
            var q = from p in tr.Hotel_Lists
                    where p.Hotel_Name.Contains(txt查詢.Text) || p.Hotel_Phone.ToString().Contains(txt查詢.Text) || p.Hotel_Address.Contains(txt查詢.Text)
                    select new
                    {
                        p.Hotel_ID,
                        p.Hotel_Name,
                        p.Hotel_Phone,
                        p.Hotel_Address,
                        p.Hotel_image
                    };
            this.dataGridView1.DataSource = q.ToList();
            if (txt查詢.Text == "")
            {
                txt查詢.Text = "城市 / 區域 / 飯店(關鍵字)";
                txt查詢.ForeColor = Color.Silver;
            }
        }

        private void 飯店列表_Load(object sender, EventArgs e)
        {

        }

        private void txt查詢_Click(object sender, EventArgs e)
        {
            if (txt查詢.Text == "城市 / 區域 / 飯店(關鍵字)")
            {
                txt查詢.ForeColor = Color.Silver;
            }
            txt查詢.Text = "";
            txt查詢.ForeColor = Color.Black;
        }

        private void txt查詢_MouseLeave(object sender, EventArgs e)
        {
           if(txt查詢.Text== "城市 / 區域 / 飯店(關鍵字)")
            {
                txt查詢.ForeColor = Color.Silver;
                txt查詢.Clear();
            }
                
        }

        private void txt查詢_TextChanged(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q = from n in tr.Hotel_Lists
                    select n;
            dataGridView1.DataSource = q.ToList();
        }
        private void datagridview_cell(int s)
        {
            var q = from p in tr.Hotel_Lists
                    where p.Hotel_ID == s
                    select p;
            foreach (var item in q)
            {
                txthoname.Text = item.Hotel_Name;
                txthophone.Text = item.Hotel_Phone;
                txthoadd.Text = item.Hotel_Address;
                pictureBox2.Image = im.ConvertToImage(item.Hotel_image);
            }
        }
        int _position = -1;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             index = e.RowIndex;
            id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            datagridview_cell(id);
            
        }

        private void txt查詢_KeyDown(object sender, KeyEventArgs e)
        {
            txt查詢.Text = "";
            txt查詢.ForeColor = Color.Black;
        }

        private void 刪除_Click_1(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            var q = (from p in tr.Hotel_Lists
                     where p.Hotel_ID == id
                     select p).FirstOrDefault();
            this.tr.Hotel_Lists.Remove(q);
            tr.SaveChanges();
            MessageBox.Show("刪除成功");
            var c = from n in tr.Hotel_Lists
                    select n;
            this.dataGridView1.DataSource = c.ToList();
        }

        private void 修改_Click(object sender, EventArgs e)
        {
           
            var k = from z in tr.Hotel_Lists
                    where z.Hotel_ID == id
                    select z;
            foreach(var a in k)
            {
                a.Hotel_Name = txthoname.Text;
                a.Hotel_Phone = txthophone.Text;
                a.Hotel_Address = txthoadd.Text;
                a.Hotel_image = im.ConvertToByte(pictureBox2.Image);
            }          
            tr.SaveChanges();
            MessageBox.Show("修改成功");
             var c = from n in tr.Hotel_Lists
                    select n;
            dataGridView1.DataSource = c.ToList();

        }
    }
}
