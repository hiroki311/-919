using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class 會員資料修改 : Form
    {
        public 會員資料修改()
        {
            InitializeComponent();
        }
        ImageToBinary im = new ImageToBinary();
        TravelerEntities3 tr = new TravelerEntities3();
        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult  qresult;
            
            qresult = MessageBox.Show("是否確定修改?", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qresult==DialogResult.Yes)
            {
                int id = Convert.ToInt32(idBox1.Text);
                var q = (from n in tr.Member_Info_Lists
                         where n.Member_ID == id
                         select n).FirstOrDefault();
                q.Email = emailBox4.Text;
                q.password = txtpas.Text;
                q.Name = txtnameBox1.Text;
                q.Phone_Number = phoneBox7.Text;
                q.Address = addressBox1.Text;

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] bytes = ms.GetBuffer();
                //q.image = im.ConvertToByte(this.pictureBox1.Image);軒哥方法
                q.image = bytes;
                tr.SaveChanges();
                會員資料修改_Load(sender, e);
                MessageBox.Show("修改成功");
            }
        }

        private void 會員資料修改_Load(object sender, EventArgs e)
        {
            var q = from n in tr.Member_Info_Lists
                    select n;
            dataGridView1.DataSource = q.ToList();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = e.RowIndex;
                int s = Convert.ToInt32(dataGridView1.Rows[a].Cells[0].Value);
                datagridview_cell(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"");
            }
        }

        private void datagridview_cell(int s)
        {
            var q = from n in tr.Member_Info_Lists
                    where n.Member_ID == s
                    select n;
            foreach (var item in q)
            {
                idBox1.Text = item.Member_ID.ToString();
                txtidnumber.Text = item.ID_number;
                emailBox4.Text = item.Email;
                txtpas.Text = item.password;
                txtnameBox1.Text = item.Name;
                sexBox2.Text = item.SEX;
                phoneBox7.Text = item.Phone_Number;
                birthBox3.Text = item.D_O_B;
                addressBox1.Text = item.Address;
                pictureBox1.Image = im.ConvertToImage(item.image);
            }
        }

        int _position = -1;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            DialogResult qresult;
            qresult = MessageBox.Show("是否確定刪除?", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qresult == DialogResult.Yes)
            {
                var q = (from n in tr.Member_Info_Lists
                         select n).FirstOrDefault();
                this.tr.Member_Info_Lists.Remove(q);
                this.tr.SaveChanges();
                會員資料修改_Load(sender, e);
                MessageBox.Show("刪除成功");
            }          
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            var q = from n in tr.Member_Info_Lists.AsEnumerable()
                    select n;
            foreach (var a in q)
            {
                bool email = a.Email.Contains(txtwheremail.Text);
                bool phone = a.Phone_Number.Contains(txtwheremail.Text);
                if (email||phone)
                {
                    var q2 = from n2 in tr.Member_Info_Lists.AsEnumerable()
                             where n2.Member_ID == a.Member_ID
                             select n2;

                    dataGridView2.DataSource = q2.ToList();

                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            int s = Convert.ToInt32(dataGridView2.Rows[a].Cells[0].Value);
            datagridview_cell(s);
            

        }

        private void pic_Click(object sender, EventArgs e)
        {

            if (this.openFileDialog1.ShowDialog() ==DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
            };

            
        }

    }
}
