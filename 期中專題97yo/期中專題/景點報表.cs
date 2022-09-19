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
    public partial class 景點報表 : Form
    {
        public 景點報表()
        {
            InitializeComponent();
            //axWindowsMediaPlayer1.URL = "https://www.youtube.com/watch?v=EagUsfGggO4";
        }
        ImageToBinary im = new ImageToBinary();
        TravelerEntities3 tr = new TravelerEntities3();
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void 景點報表_Load(object sender, EventArgs e)
        {
            string[] photo = new string[] { "未選擇", "亞洲", "大洋洲", "歐洲", "非洲", "北美洲", "中南美洲" };
                     
            //var q1 = from p1 in tr.國家表ID
            //         where p1.各地地區名稱ID == 1
            //         select p1;
            //foreach (var item in q1)
            //    {
            //        cmb國家.Items.Add(item.國家名稱);
            //    }
           

            cmb選擇地區.Items.AddRange(photo);
            cmb選擇地區.SelectedIndex = 0;
            cmb地區圖片.BorderStyle = BorderStyle.Fixed3D;
            cmb地區圖片.SizeMode = PictureBoxSizeMode.StretchImage;

            var q1 = from p1 in tr.國家名稱
                     select p1;
            this.dataGridView2.DataSource = q1.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb地區圖片.Image = new Bitmap(cmb選擇地區.Text + ".jpg");
            地區.Text = cmb選擇地區.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            城市總表 list = new 城市總表();
            {
                list.城市名稱 = txtcityname.Text;
                list.各地地區名稱ID = Convert.ToInt32(textBox4.Text);
            }
            this.tr.城市總表.Add(list);
            this.tr.SaveChanges();
            MessageBox.Show("新增成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var q = from p in tr.城市總表
                    //where p.城市ID.ToString().Contains(.Text) || p.城市名稱.ToString().Contains(國家ID.Text)
                    select p;
            this.dataGridView1.DataSource = q.ToList();
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            國家名稱 list = new 國家名稱();
            {
                list.國家名稱1 = txt_國家名稱.Text;
            }
            this.tr.國家名稱.Add(list);
            this.tr.SaveChanges();
            MessageBox.Show("新增成功");
            var q = from p in tr.國家名稱
                    select p;
            this.dataGridView2.DataSource = q.ToList();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            景點名稱總表 list = new 景點名稱總表();
            {
                list.景點名稱 = txt景點名稱.Text;
                list.城市ID = Convert.ToInt32(txt城市ID.Text);
                list.景點描述 = txt景點描述.Text;
                 System.IO.MemoryStream ms1 = new System.IO.MemoryStream();
                System.IO.MemoryStream ms2 = new System.IO.MemoryStream();
                System.IO.MemoryStream ms3 = new System.IO.MemoryStream();
             
                this.pictureBox2.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                this.pictureBox3.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg);
                this.pictureBox4.Image.Save(ms3, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] bytes1 = ms1.GetBuffer();
                byte[] bytes2 = ms2.GetBuffer();
                byte[] bytes3 = ms3.GetBuffer();
   
                list.景點圖片1 = bytes1;
                list.景點圖片2 = bytes2;
                list.景點圖片3 = bytes3;
                //this.pictureBox2.Image= Image.FromFile(this.openFileDialog1.FileName);
                //this.pictureBox3.Image= Image.FromFile(this.openFileDialog2.FileName);
                //this.pictureBox4.Image = Image.FromFile(this.openFileDialog3.FileName);
                //list.景點圖片1 = im.ConvertToByte(this.pictureBox2.Image);
                //list.景點圖片2 = im.ConvertToByte(this.pictureBox3.Image);
                //list.景點圖片3 = im.ConvertToByte(this.pictureBox4.Image);
            }
            this.tr.景點名稱總表.Add(list);
            this.tr.SaveChanges();
            MessageBox.Show("新增成功");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.Image = Image.FromFile(this.openFileDialog1.FileName);
            };
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox3.Image = Image.FromFile(this.openFileDialog2.FileName);
            };
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox4.Image = Image.FromFile(this.openFileDialog3.FileName);
            };
        }
       
        private void cmb國家_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void 地區_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmb國家.Items.Count > 0)
            {
                cmb國家.Items.Clear();
            }
            if (地區.SelectedItem.ToString() == "亞洲")
            {
                var q = from p in tr.國家名稱
                        where p.國家總表ID == 1 || p.國家總表ID == 2 || p.國家總表ID == 3
                        select p.國家名稱1;
                foreach (var i in q.ToList())
                {
                    cmb國家.Items.Add(i);
                }
            }
            else if(地區.SelectedItem.ToString() == "大洋洲")
            {
                var q = from p in tr.國家名稱
                        where p.國家總表ID == 1 || p.國家總表ID == 2 || p.國家總表ID == 3
                        select p.國家名稱1;
                foreach (var i in q.ToList())
                {
                    cmb國家.Items.Add(i);
                }
            }
        }

        private void cmb國家_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmb國家_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmb國家_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (cmb國家.Items.Count == 0)
            {
                var q = from p in tr.國家名稱
                        where p.國家總表ID == 1 || p.國家總表ID == 2 || p.國家總表ID == 3
                        select p.國家名稱1;
                foreach (var i in q.ToList())
                {
                    cmb國家.Items.Add(i);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var q1 = from p1 in tr.國家名稱
                     select p1;
            this.dataGridView2.DataSource = q1.ToList();
        }

        private void 地區_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            var Q = from i in tr.國家名稱
                    where i.國家名稱1 == txt_國家名稱.Text
                    select i.國家總表ID;
            var q = from p in tr.國家名稱.AsEnumerable()
                    where p.國家總表ID == Q.First()
                    select p;
            this.dataGridView2.DataSource = q.ToList();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txt_國家名稱.Text = dataGridView2.CurrentCell.OwningRow.Cells["國家名稱1"].Value.ToString();
        }

        //private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        //{
        //axWindowsMediaPlayer1.Ctlcontrols.play();

        //wmp.settings.setMode("loop", True);
        //}

        //private void 起始()
        //{
        //    if (cmb選擇地區.Text == "亞洲")
        //    {
        //        var q = from p in tr.國家表ID
        //                where p.各地地區名稱ID == 1
        //                select p;
        //        foreach (var item in q)
        //        {
        //            cmb國家.Items.Add(item.國家名稱);
        //        }
        //    }
        //}

    }
}
