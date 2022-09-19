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
    public partial class UserControl2訂單 : UserControl
    {
        public UserControl2訂單()
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
                this.lbl商品名稱.Text = value;
            }
        }
        public string 單價
        {
            get 
            {
                return lbl單價.Text;
            }
            set
            {
                this.lbl單價.Text = value.Replace(".0000", "");
            }
        }
        public string 數量
        {
            get
            {
                return cbb數量.Text;
            }
            set
            {
                this.cbb數量.Text = value;
            }
        }
        public string 小計
        {
            set
            {
                this.lbl小計.Text = value;
            }
        }
        public string 剩餘人數
        {
            get
            {
                return lbl剩餘人數.Text;
            }
            set
            {
                this.lbl剩餘人數.Text = value;
            }
        }
        public string 刪除
        {
            get
            {
                return btn刪除.Text.Substring(2);
            }
            set
            {
                this.btn刪除.Text += value;
            }
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int 改變前的數量 = 0;
        int 改變後的數量 = 0;
        int 紀錄的價格 = 0;

        private void cbb數量_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string 單價 =lbl單價.Text;
            string 數量 =cbb數量.Text;
            lbl小計.Text = (Convert.ToInt32(數量)*Convert.ToInt32(單價)).ToString();
            改變後的數量 = (int)cbb數量.SelectedItem;
            if (改變後的數量 > 改變前的數量) { 
            紀錄的價格 = (Convert.ToInt32(改變後的數量- 改變前的數量) * Convert.ToInt32(單價));
                COMM.總金額 += 紀錄的價格;
                改變前的數量 = 改變後的數量;
            }
            else if (改變後的數量 < 改變前的數量){
                紀錄的價格 = (Convert.ToInt32(改變前的數量 - 改變後的數量) * Convert.ToInt32(單價));
                COMM.總金額 -= 紀錄的價格;
                改變前的數量 = 改變後的數量;
            }

        }

        private void cbb數量_Click(object sender, EventArgs e)
        {
            int rr = Convert.ToInt32(剩餘人數);
            cbb數量.Items.Clear();
            for (int i = 1; i <= rr; i++)
            {
                cbb數量.Items.Add(i);
            }
        }

        private void button1刪除_Click(object sender, EventArgs e)
        {
            DialogResult qresult;
            qresult = MessageBox.Show("是否確定刪除?", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qresult == DialogResult.Yes)
            {
                int 計畫ID = Convert.ToInt32(刪除);
                var q = (from n in tr.Order訂單
                         where n.Member_ID==COMM.ID && n.Itinerary_ID == 計畫ID && n.訂單狀態編號ID ==1
                         select n).FirstOrDefault();
                this.tr.Order訂單.Remove(q);
                this.tr.SaveChanges();
                
                MessageBox.Show("刪除成功");
                this.Controls.Clear();
                COMM.總金額 = 0;
            }
        }
    }
}
