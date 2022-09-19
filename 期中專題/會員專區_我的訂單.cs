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
    public partial class 會員專區_我的訂單 : Form
    {
        public 會員專區_我的訂單()
        {
            InitializeComponent();
        }
        TravelerEntities3 tr = new TravelerEntities3();
        private void 會員專區_我的訂單_Load(object sender, EventArgs e)
        {
            var q = from a in tr.Order訂單
                    where a.Member_ID == COMM.ID && a.訂單狀態編號ID != 1
                    group a by a.Itinerary_Plan行程計畫 into t
                    select new
                    {
                        價格 = t.Key.Single_Journey_Price,
                        行程計畫名稱 = t.Key.Itinerary_Name,
                        出團時間 = t.Key.Inbound_Date,
                        回程時間 = t.Key.Departure_Date
                    };
            var dd = from d in tr.Order訂單
                     where d.Member_ID == COMM.ID && d.訂單狀態編號ID != 1
                     join d1 in tr.OrderDetails隨行人員 on d.OrderID equals d1.OrderID
                     select d1;
               //join tra2 in tr.Transportations on tra.行程明細ID equals tra2.行程明細ID
               //          join tra3 in tr.Transportation_Lists on tra2.TransportationList_ID equals tra3.TransportationList_ID
               //          select new
            if (!q.Any())
            {
                return;
            }

            foreach (var a in q)
            {
                UserControl會員專區 item = new UserControl會員專區();
                item.商品名稱 = a.行程計畫名稱;
                item.價格 = a.價格.ToString().Replace(".0000", "");
                item.出發日期 = a.出團時間.ToString("yyyy/MM/dd");
                item.回程日期 = a.回程時間.ToString("yyyy/MM/dd");
                item.訂單狀態 = "訂單成立";
                foreach (var da in dd)
                {
                    item.購買日期 = da.購買日期.ToString("yyyy/MM/dd");
                }

                flowLayoutPanel1.Controls.Add(item);

            }
        }
    }
}
