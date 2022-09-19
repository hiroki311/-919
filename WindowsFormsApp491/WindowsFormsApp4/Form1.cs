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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }
        TravelerEntities1 資料庫 = new TravelerEntities1();
        private void button1_Click(object sender, EventArgs e)
        {
            Member_Info_List 資料表 = new Member_Info_List();
            {
                資料表.Member_ID = Convert.ToInt32(idtxt.Text);
                資料表.Name = nametxt.Text;
                資料表.Title = titletxt.Text;
                資料表.Phone_Number=phonetxt.Text;
                資料表.Email = emailtxt.Text;
                資料表.D_O_B = dobtxt.Text;
                資料表.Address = addtxt.Text;
                資料表.Nationality = "null";
                資料表.Passport_Number = "null";
                資料表.Passport_Expiry_Date = "null";
                資料表.Credit_Card_Number = "null";
                資料表.bonus_points = null;
            };
          
            this.資料庫.Member_Info_Lists.Add(資料表);
            this.資料庫.SaveChanges();
            MessageBox.Show("新增完成");
        }
    }
}
