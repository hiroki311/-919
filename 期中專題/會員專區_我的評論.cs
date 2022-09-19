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
    public partial class 會員專區_我的評論 : Form
    {
        public 會員專區_我的評論()
        {
            InitializeComponent();
        }
        TravelerEntities3 tr = new TravelerEntities3();
        private void button1_Click(object sender, EventArgs e)
        {
            var q = from n in tr.action報表
                    where n.Member_ID == COMM.ID
                    group n by n.評分表 into t
                    select new
                    {
                        評分 = t.Key.評分,
                        評論 = t.Key.評論,
                        評論時間 = t.Key.評論日期
                    };
            dataGridView1.DataSource = q.ToList();
                     //var q = from a in tr.Order訂單
                     //        where a.Member_ID == COMM.ID && a.訂單狀態編號ID != 1
                     //        group a by a.Itinerary_Plan行程計畫 into t
                     //        select new
                     //        {
                     //            價格 = t.Key.Single_Journey_Price,
                     //            行程計畫名稱 = t.Key.Itinerary_Name,
                     //            出團時間 = t.Key.Inbound_Date,
                     //            回程時間 = t.Key.Departure_Date
                     //        };
        }
    }
}
