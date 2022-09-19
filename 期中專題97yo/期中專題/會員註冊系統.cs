using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class 會員註冊系統 : Form
    {
        public 會員註冊系統()
        {
            InitializeComponent();
        }
        
        TravelerEntities3 tr = new TravelerEntities3();
        private void btnsend_Click(object sender, EventArgs e)
        {
            Member_Info_List mm = new Member_Info_List()
            {
                Name = textname.Text,
                Phone_Number = textphone.Text,
                Email = textmail.Text,
                D_O_B = dateTimePicker1.Value.ToString("yyyy/MM/dd"),
                Address = comboBoxadress.SelectedItem.ToString() + textadress.Text,
                Nationality = textcon.Text,
                bonus_points = 0,
                password = textpas1.Text,
                ID_number = textid.Text,
                SEX = comboBoxsex.SelectedItem.ToString(),
                image = null,                                 
                Passport_Number=null
                };
            var properties = mm.GetType().GetProperties();
            var value = properties.Select(S => S.GetValue(mm)).ToList();
            foreach (var a in value)
            {
                if (a == null)
                    continue;
                if (a.ToString() == "")
                {
                    MessageBox.Show("請輸入完整資料");
                    //return;
                }
            }
            //this.tr.Member_Info_Lists.Add(mm);
            //this.tr.SaveChanges();
            //MessageBox.Show("新增完成");
            foreach (Control a in groupBox1.Controls)
            {
                if (a is TextBox)
                {
                    a.Text = "";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control a in groupBox1.Controls)
            {
                if (a is TextBox)
                {
                    a.Text = "";
                }
            }
        }
        bool IsStrongpassword(string Password)
        {
            return Regex.IsMatch(Password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$");
        }
      
        bool IsIDCorrrct(string ID)
        {
            return Regex.IsMatch(ID, @"^(?=.*[A-Z]{1}[1-2]{1}[0-9]{8}$)");
        }

        private void textid_TextChanged(object sender, EventArgs e)
        {
            Image imagev = Image.FromFile("C:\\image\\v.png");
            Image imagex = Image.FromFile("C:\\image\\x.png");

            if (IsIDCorrrct(textid.Text))
            {
                label13.Image = imagev;
            }
            else
            {
                label13.Image = imagex;
            }
        }
        bool IsEmail(string str_Email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str_Email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private void textmail_Leave(object sender, EventArgs e)
        {
            var q = from cc in tr.Member_Info_Lists
                    select cc;
            foreach (var s in q)
            {
                Image imagev = Image.FromFile("C:\\image\\v.png");
                Image imagex = Image.FromFile("C:\\image\\x.png");

                if (IsEmail(textmail.Text)&&textmail.Text!=s.Email)
                {
                    label14.Image = imagev;
                }
                else if (textmail.Text==s.Email)
                {
                    label14.Text = "重複的Email";
                }
                else
                {
                    label14.Image = imagex;
                }
            }
           
        }

       
        
        private void button3_Click(object sender, EventArgs e)
        {
            ImageToBinary im = new ImageToBinary();
            星球旅遊 會員主畫面 = new 星球旅遊();
            var q = from p in tr.Member_Info_Lists
                    where p.Email == txtemail.Text && p.password == txtpass.Text
                    select p;
           
            foreach (var it in q)
            {
                COMM.ID = it.Member_ID;
                COMM.姓名 = it.Name;
                COMM.EMAIL = it.Email;
                COMM.地址 = it.Address;
                COMM.密碼 = it.password;
                COMM.電話 = it.Phone_Number;
            }
            if (q.Any())
            {
                
                MessageBox.Show("登入成功");
                Close();
            }
            else
            {
                MessageBox.Show("密碼錯誤");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtemail.Text = "123@123.com";
            txtpass.Text = "aA02524278";
        }
        private void textpas1_TextChanged(object sender, EventArgs e)
        {
            Image imagev = Image.FromFile("C:\\image\\v.png");
            Image imagex = Image.FromFile("C:\\image\\x.png");

            if (IsStrongpassword(textpas1.Text))
            {
                label11.Image = imagev;
            }
            else
            {
                label11.Image = imagex;
            }
        }
        private void textpas2_TextChanged(object sender, EventArgs e)
        {
            Image imagev = Image.FromFile("C:\\image\\v.png");
            Image imagex = Image.FromFile("C:\\image\\x.png");

            if (IsStrongpassword(textpas1.Text)&&textpas2.Text==textpas1.Text)
            {
                label18.Image = imagev;
            }
            else if (textpas2.Text!=textpas1.Text)
            {
                label18.Text = "密碼不一致";
            }
            else
            {
                label18.Image = imagex;
            }
        }
    }
    
}
