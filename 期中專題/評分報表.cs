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
    public partial class 評分報表 : Form
    {
        public 評分報表()
        {
            InitializeComponent();
        }
        //導入資料庫
        TravelerEntities3 travelerEntities4 = new TravelerEntities3();

        int 評分 = 0;
        private void btn_AllCommon_Click(object sender, EventArgs e)
        {
            var q = from n in travelerEntities4.評分表
                    select n;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn_5Star_Click(object sender, EventArgs e)
        {
            var q = from n in travelerEntities4.評分表
                    where n.評分 == 5.ToString()
            select n;

            this.dataGridView1.DataSource = q.ToList();
        }

       

        private void btn_search_Click(object sender, EventArgs e)
        {
         
            var q = from n in travelerEntities4.評分表 
                    where n.評論日期 == dateTimePicker2.Value.Date
                    select n;

            
            this.dataGridView1.DataSource = q.ToList();

            //DataSearch();

        }

        private void DataSearch()
        {
            var q = from n in travelerEntities4.評分表
                    select n;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn_fixed_Click(object sender, EventArgs e)
        {
            
           
            var q = from n in travelerEntities4.評分表.AsEnumerable()
                    where n.評分表ID ==Convert.ToInt32(lblOrder_Number.Text)
                    select n;

            foreach (var x in q) {
                x.評分 = cobStar.Text;
                x.評論 = txtContent.Text;
                x.評論日期 = dateTimePicker1.Value.Date;
               
            }

            this.travelerEntities4.SaveChanges();
            MessageBox.Show("成功修改資料!");
            DataSearch();
        }

        private void btn_deleted_Click(object sender, EventArgs e)
        {
            var q = (from n in travelerEntities4.評分表.AsEnumerable()
                    select n).FirstOrDefault();

            this.travelerEntities4.評分表.Remove(q);
            this.travelerEntities4.SaveChanges();
            MessageBox.Show("刪除資料成功!");
            DataSearch();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;//資料行
            int s = Convert.ToInt32(dataGridView1.Rows[a].Cells[0].Value);
            var q = from n in travelerEntities4.評分表
                    where n.評分表ID == s
                    select n;

            foreach (var item in q)
            {
                cobStar.Text = item.評分;
                txtContent.Text = item.評論;
                lblOrder_Number.Text = item.評分表ID.ToString();
                dateTimePicker1.Value = item.評論日期;
            }
        }

       

        private void btn_4Star_Click(object sender, EventArgs e)
        {
            var q = from n in travelerEntities4.評分表
                    where n.評分 == 4.ToString()
                    select n;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn_3Star_Click(object sender, EventArgs e)
        {
            var q = from n in travelerEntities4.評分表
                    where n.評分 == 3.ToString()
                    select n;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn_2Star_Click(object sender, EventArgs e)
        {
            var q = from n in travelerEntities4.評分表
                    where n.評分 == 2.ToString()
                    select n;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn_1Star_Click(object sender, EventArgs e)
        {
            var q = from n in travelerEntities4.評分表
                    where n.評分 == 1.ToString()
                    select n;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void btnRangeSearch_Click(object sender, EventArgs e)
        {
            var q = from n in travelerEntities4.評分表
                    where 
                    n.評論日期 >= dateTimePicker2.Value.Date 
                    && n.評論日期 <= dateTimePicker3.Value.Date
                    select n;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var q = from n in travelerEntities4.評分表
                    select n;

            this.dataGridView1.DataSource = q.ToList();
        }
    }
}
