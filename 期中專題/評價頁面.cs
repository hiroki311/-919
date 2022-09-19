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
    public partial class 評價頁面 : Form
    {
        public 評價頁面()
        {
            InitializeComponent();
            行程編號();
        }

        
        TravelerEntities3 tr4 = new TravelerEntities3();
        int 評分 = 0;
        
       

        private void button4_Click(object sender, EventArgs e)
        {
            if (COMM.ID == 0)
            {
                MessageBox.Show("請先登入");
                return;
            }
            var q = from n in tr4.評分表
                        select n;
                評分表 scoreList = new 評分表();
                {
                    scoreList.評分 = /*(byte?)*/評分.ToString();//資料庫要改
                    scoreList.評論 = txtCommon.Text;
                   scoreList.評論日期 = dateTimePicker1.Value;
                }
                  this.tr4.評分表.Add(scoreList);
                  this.tr4.SaveChanges();

            var sa = (from sx in tr4.評分表.AsEnumerable()
                      select sx).LastOrDefault();
            int 表ID = sa.評分表ID;
            action報表 報表 = new action報表();
            報表.評分表ID = 表ID;
            報表.Member_ID = COMM.ID;
            報表.行為ID = 1;
            報表.Itinerary_ID = COMM.行程計畫編號;
            this.tr4.action報表.Add(報表);
            this.tr4.SaveChanges();
            DialogResult qresult;
            qresult = MessageBox.Show("評論成功!!", "讚", MessageBoxButtons.OK);

            if (qresult == DialogResult.OK)


            this.Close();
        }

        private void btn_5star_Click(object sender, EventArgs e)
        {
            按鍵變顏色();
            btn_5star.BackColor = Color.Gold;
            評分 = 5;
        }

       

        private void btn_3star_Click(object sender, EventArgs e)
        {
            按鍵變顏色();
            btn_3star.BackColor = Color.LemonChiffon;
            評分 = 3;
        }

        private void btn_1star_Click(object sender, EventArgs e)
        {
            按鍵變顏色();
            btn_1star.BackColor = Color.Red;
            評分 = 1;
        }

        private void btn_4star_Click(object sender, EventArgs e)
        {
            按鍵變顏色();
            btn_4star.BackColor = Color.Yellow;
            評分 = 4;
        }

        private void btn_2star_Click(object sender, EventArgs e)
        {
            按鍵變顏色();
            btn_2star.BackColor = Color.PaleVioletRed;
            評分 = 2;
        }
        private void 按鍵變顏色()
        {
            btn_1star.BackColor = Color.WhiteSmoke;
            btn_2star.BackColor = Color.WhiteSmoke;
            btn_3star.BackColor = Color.WhiteSmoke;
            btn_4star.BackColor = Color.WhiteSmoke;
            btn_5star.BackColor = Color.WhiteSmoke;
           
        }
        private void button5_Click(object sender, EventArgs e)
        {
            按鍵變顏色();
            評分 = 0;
            txtCommon.Text = "";
        }
       
        private void txtCommon_TextChanged(object sender, EventArgs e)
        {
            if (txtCommon.Text == "" && 評分==0)
            {
                button4.Enabled = false;
            }
            else if(txtCommon.Text != "" && 評分 != 0)
            {
                button4.Enabled = true;
            }
        }

        private void 行程編號() {
            var q = from a in tr4.Itinerary_Plan行程計畫
                    where a.Itinerary_ID ==COMM.行程計畫編號
                    select a;
            foreach (var item in q)
            {
                label4.Text = item.Itinerary_ID.ToString();
            }
            
        }

    }
}
