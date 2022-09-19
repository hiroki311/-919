using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public string 價格
        {
            set
            {
                this.labelPrice.Text = value.Replace(".0000", "");
            }
        }
        ImageToBinary im = new ImageToBinary();
        TravelerEntities3 tr = new TravelerEntities3();

        public byte[] 旅遊圖片
        {
            set
            {
                this.picBox1.Image = im.ConvertToImage(value);
            }
        }
      

        public string 方案名稱
        {
            set
            {
                this.labelName.Text = value;
            }
        }

        private void btn詳細資訊_Click(object sender, EventArgs e)
        {
            旅遊詳細資訊 a資訊 = new 旅遊詳細資訊();
           a資訊.setID = labelID.Text;
            a資訊.Show();
        }
       public int 旅遊方案ID
        {
            set 
            {
                this.labelID.Text = value.ToString();
            }
        }
    }
}
