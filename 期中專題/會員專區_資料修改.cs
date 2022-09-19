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
    public partial class 會員專區_資料修改 : Form
    {
        public 會員專區_資料修改()
        {
            InitializeComponent();
        }
        TravelerEntities3 tr = new TravelerEntities3();
        ImageToBinary im = new ImageToBinary();



        private void 會員專區_資料修改_Load(object sender, EventArgs e)
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


        private void btnupdate_Click_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
            };
        }
    }
}
