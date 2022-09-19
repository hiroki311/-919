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
    public partial class UserControl會員專區 : UserControl
    {
        public UserControl會員專區()
        {
            InitializeComponent();
        }
        ImageToBinary im = new ImageToBinary();
        TravelerEntities3 tr = new TravelerEntities3();
        public byte[] 旅遊圖片
        {
            set
            {
                this.pB商品照片.Image = im.ConvertToImage(value);
            }
        }
        public string 商品名稱
        {
            set
            {
                this.label1商品名稱.Text = value;
            }
        }
        public string 價格
        {
            set
            {
                this.label3單價.Text = value;
            }
        }
        public string 出發日期
        {
            set
            {
                this.lbl出發時間.Text = value;
            }
        }
        public string 回程日期
        {
            set
            {
                this.lbl回程時間.Text = value;
            }
        }
        public string 訂單狀態
        {
            set
            {
                this.lbl訂單狀態.Text = value;
            }
        }
        public string 購買日期
        {
            set
            {
                this.label2購買日期.Text = value;
            }
        }
    }
}
