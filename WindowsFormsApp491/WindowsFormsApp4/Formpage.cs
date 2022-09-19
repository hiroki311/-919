using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Formpage : Form
    {
        public Formpage()
        {
            InitializeComponent();
        }
        TravelerEntities3 資料庫 = new TravelerEntities3();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sing_in(object sender, EventArgs e)
        {
            Member_Info_List 資料表 = new Member_Info_List();
            {
                資料表.Name = nametxt.Text;
                資料表.password = passttxt.Text;
                資料表.Email = emailtxt.Text;
                資料表.Phone_Number = phonetxt.Text;
                資料表.ID_number = idnumtxt.Text;
            };
            this.資料庫.Member_Info_Lists.Add(資料表);
            this.資料庫.SaveChanges();
            MessageBox.Show("註冊成功");


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormHome 主畫面 = new FormHome();
            Member_Info_List 資料表 = new Member_Info_List();
            var q = from p in 資料庫.Member_Info_Lists
                    where p.Email==txtemail.Text && p.password==txtpass.Text
                    select p;
            if (!q.Any())
            {
                MessageBox.Show("密碼錯誤");
               
            }
            else
            {
                                 
              主畫面.ShowDialog();
                
            }
                this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtemail.Text = "qwerty852@gmail.com";
            txtpass.Text = "qwerty258";
        }
    }
}
