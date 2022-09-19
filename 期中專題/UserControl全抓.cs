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
    public partial class UserControl全抓 : UserControl
    {
        public UserControl全抓()
        {
            InitializeComponent();
        }
        ImageToBinary im = new ImageToBinary();
        TravelerEntities3 tr = new TravelerEntities3();
        public byte[] 飯店圖片
        {
            set
            {
                this.pictureBox1飯店圖.Image = im.ConvertToImage(value);
            }
        }
        public byte[] 景點圖片
        {
            set
            {
                this.pictureBox1.Image = im.ConvertToImage(value);
            }
        }
        public byte[] 景點圖片2
        {
            set
            {
                this.pictureBox2.Image = im.ConvertToImage(value);
            }
        }
        public string 飯店資訊
        {
            set
            {
                label5飯店資訊.Text = value;
            }
        }
        public string 第幾天
        {
            set
            {
                lbl天數.Text = value;
            }
        }
        public string 交通工具
        {
            set
            {
                label1交通資訊.Text = value;
            }
        }
    }
}
