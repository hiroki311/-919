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
    public partial class 會員專區 : Form
    {
        public 會員專區()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        TravelerEntities3 tr = new TravelerEntities3();
        ImageToBinary im = new ImageToBinary();

        private void 會員專區_Load(object sender, EventArgs e)
        {
            idBox1.Text = COMM.ID.ToString();
            emailBox4.Text = COMM.EMAIL;
            txtnameBox1.Text = COMM.姓名;
            txtpas.Text = COMM.密碼;
            phoneBox7.Text = COMM.電話;
            addressBox1.Text = COMM.地址;
            var q = from a in tr.Member_Info_Lists
                    where a.Member_ID == COMM.ID
                    select a;
            foreach (var item in q)
            {
                pictureBox1.Image = im.ConvertToImage(item.image);
            }
        }

        private void button1上傳照片_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
            };
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult qresult;

            qresult = MessageBox.Show("是否確定修改?", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qresult == DialogResult.Yes)
            {
                COMM.姓名 = txtnameBox1.Text;
                COMM.密碼 = txtpas.Text;
                COMM.電話 = phoneBox7.Text;
                COMM.地址 = addressBox1.Text;
                var q = from a in tr.Member_Info_Lists
                        where a.Member_ID == COMM.ID
                        select a;
                foreach (var item in q)
                {
                    item.image = im.ConvertToByte(pictureBox1.Image);
                }
                tr.SaveChanges();
                MessageBox.Show("修改成功");
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            var q = from a in tr.Order訂單
                    where a.Member_ID == COMM.ID && a.訂單狀態編號ID != 1
                    group a by a.Itinerary_Plan行程計畫 into t
                    select new
                    {
                        價格 = t.Key.Single_Journey_Price,
                        行程計畫名稱 = t.Key.Itinerary_Name,
                        出團時間 = t.Key.Inbound_Date,
                        回程時間 = t.Key.Departure_Date
                    };

            if (!q.Any())
            {
                return;
            }

            foreach (var a in q)
            {
                UserControl會員專區 item = new UserControl會員專區();
                item.商品名稱 = a.行程計畫名稱;
                item.價格 = a.價格.ToString().Replace(".0000", "");
                item.出發日期 = a.出團時間.ToString("yyyy/MM/dd");
                item.回程日期 = a.回程時間.ToString("yyyy/MM/dd");
                item.訂單狀態 = "訂單成立";


                flowLayoutPanel1.Controls.Add(item);

            }

        }

    }

}

