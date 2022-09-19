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
    public partial class 交通工具資料表 : Form
    {
        public 交通工具資料表()
        {
            InitializeComponent();
            var j = from p in T12.Itinerary_Plan行程計畫
                    select p;
            foreach (var item in j)
            {
                comboBoxPjName.Items.Add(item.Itinerary_Name);
            }
            var q = from p in T12.Transportation_Lists
                    select p;
            foreach (var item in q)
            {
                comboBoxClass.Items.Add(item.Transportation);
            }
        }
        TravelerEntities3 T12 = new TravelerEntities3();
        Transportation 交通空具資料表 = new Transportation();
        int index = -1;
        int id = -1;
        DialogResult qresult;
        private void 顯示資料表()
        {
            this.dataGridViewTransportation.DataSource = null;
            var q = from p in T12.Transportations.AsEnumerable()
                    join t in T12.Transportation_Lists on p.TransportationList_ID equals t.TransportationList_ID
                    join d in T12.行程明細 on p.行程明細ID equals d.行程明細ID
                    join j in T12.Itinerary_Plan行程計畫 on d.Itinerary_ID equals j.Itinerary_ID
                    select new
                    {
                        p.TransportationID,
                        p.行程明細ID,
                        j.Itinerary_Name,
                        t.Transportation,
                        p.Company_Name,
                        p.交通工具班次,
                        p.Departure,
                        p.Destination,
                        p.Departure_Time,
                        p.Time_of_Arrival,
                        p.Price,
                    };
            this.dataGridViewTransportation.DataSource = q.ToList();
            隱藏資料表();
        }
        private void 隱藏資料表()
        {
            this.dataGridViewTransportation.Columns[0].Visible = false;
        }
        void 更新資料表List()
        {
            this.dataGridViewTransportationList.DataSource = null;
            this.dataGridViewTransportationList.DataSource = this.T12.Transportation_Lists.ToList();
            this.dataGridViewTransportationList.Columns[2].Visible = false;
        }
        private void dataGridViewTransportation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            id = Convert.ToInt32(dataGridViewTransportation.Rows[index].Cells[0].Value);
            var q = from p in T12.Transportations.AsEnumerable()
                    join t in T12.Transportation_Lists on p.TransportationList_ID equals t.TransportationList_ID
                    join d in T12.行程明細 on p.行程明細ID equals d.行程明細ID
                    join j in T12.Itinerary_Plan行程計畫 on d.Itinerary_ID equals j.Itinerary_ID
                    where p.TransportationID == id
                    select new
                    {
                        p.TransportationID,
                        p.行程明細ID,
                        j.Itinerary_Name,
                        t.Transportation,
                        p.Company_Name,
                        p.交通工具班次,
                        p.Departure,
                        p.Destination,
                        p.Departure_Time,
                        p.Time_of_Arrival,
                        p.Price,
                    };
            foreach (var item in q)
            {
                comboBoxPjName.Text = item.Itinerary_Name;
                txbDetail.Text = item.行程明細ID.ToString();
                comboBoxClass.Text = item.Transportation;
                comboBoxCompanyName.Text = item.Company_Name;
                txbNumber.Text = item.交通工具班次; 
                comboBoxDeparture.Text = item.Departure;
                comboBoxDestination.Text = item.Destination;
                dateTimePickerDeparture.Value = item.Departure_Time;
                dateTimePickerArrvial.Value = item.Time_of_Arrival;
                txbPrice.Text = item.Price.ToString();
            }
            隱藏資料表();
        }
        private void 交通工具資料表_Load(object sender, EventArgs e)
        {
            var q = from p in T12.Transportations.AsEnumerable()
                    join t in T12.Transportation_Lists on p.TransportationList_ID equals t.TransportationList_ID
                    join d in T12.行程明細 on p.行程明細ID equals d.行程明細ID
                    join j in T12.Itinerary_Plan行程計畫 on d.Itinerary_ID equals j.Itinerary_ID
                    select new
                    {
                        p.TransportationID,
                        p.行程明細ID,
                        j.Itinerary_Name,
                        t.Transportation,
                        p.Company_Name,
                        p.交通工具班次,
                        p.Departure,
                        p.Destination,
                        p.Departure_Time,
                        p.Time_of_Arrival,
                        p.Price,
                    };
            
            this.dataGridViewTransportation.DataSource = q.ToList();
            隱藏資料表();

            var q1 = from n in T12.行程明細
                    join j in T12.Itinerary_Plan行程計畫 on n.Itinerary_ID equals j.Itinerary_ID
                    join h in T12.Hotel_Lists on n.Hotel_ID equals h.Hotel_ID
                    select new
                    {
                        n.行程明細ID,
                        j.Itinerary_Name,
                        n.DAY,
                        n.Date,
                        h.Hotel_Name,
                    };
            this.dataGridViewDetail.DataSource = q1.ToList();

            var q2 = from p in T12.Transportation_Lists
                     select p;
            this.dataGridViewTransportationList.DataSource = q2.ToList();
            this.dataGridViewTransportationList.Columns[2].Visible = false;
        }
        private void btn新增_Click(object sender, EventArgs e)
        {
            if (txbClass.Text == "")
            {
                MessageBox.Show("欄位空白");
                return;
            }
            else if (txbDetail.Text == "")
            {
                MessageBox.Show("欄位空白");
                return;
            }
            else if (txbPrice.Text == "")
            {
                MessageBox.Show("欄位空白");
                return;
            }
            Transportation 交通工具資料表 = new Transportation()
            {
                行程明細ID = Convert.ToInt32(txbDetail.Text),
                TransportationList_ID = Convert.ToInt32(txbClass.Text),
                Company_Name = comboBoxCompanyName.Text,
                交通工具班次 = txbNumber.Text,
                Departure = comboBoxDeparture.Text,
                Destination = comboBoxDestination.Text,
                Departure_Time = dateTimePickerDeparture.Value,
                Time_of_Arrival = dateTimePickerArrvial.Value,
                Price = Convert.ToDecimal(txbPrice.Text),
            };

            var properties = 交通工具資料表.GetType().GetProperties();
            var values = properties.Select(s => s.GetValue(交通工具資料表)).ToList();

            foreach (var p in values)
            {
                if (p == null)
                    continue;                
                if (p.ToString() == "")
                {
                    MessageBox.Show("欄位空白");
                    return;
                }
            }

            this.T12.Transportations.Add(交通工具資料表);
            this.T12.SaveChanges();
            顯示資料表();
            MessageBox.Show("新增成功");
        }
        
        private void btn刪除_Click(object sender, EventArgs e)
        {
            if (index < 0) { return; }
            id = Convert.ToInt32(dataGridViewTransportation.Rows[index].Cells[0].Value);
            var q = (from p in T12.Transportations
                     where p.TransportationID == id
                     select p).FirstOrDefault();
            qresult = MessageBox.Show("是否確定刪除", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qresult == DialogResult.Yes)
            {
                this.T12.Transportations.Remove(q);
                this.T12.SaveChanges();
                MessageBox.Show("刪除成功");
                顯示資料表();
            }
            else
                return;
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if (index < 0) { return; }
            id = Convert.ToInt32(dataGridViewTransportation.Rows[index].Cells[0].Value);
            var q2 = from p in T12.Transportations
                     where p.TransportationID == id
                     select p;
            foreach (var q in q2)
            {
                q.行程明細ID = Convert.ToInt32(txbDetail.Text);
                q.TransportationList_ID = Convert.ToInt32(txbClass.Text);
                q.Company_Name = comboBoxCompanyName.Text;
                q.交通工具班次 = txbNumber.Text;
                q.Departure = comboBoxDeparture.Text;
                q.Destination = comboBoxDestination.Text;
                q.Departure_Time = dateTimePickerDeparture.Value;
                q.Time_of_Arrival = dateTimePickerArrvial.Value;
                q.Price = Convert.ToDecimal(txbPrice.Text);
            }
            
            qresult = MessageBox.Show("是否確定修改?", "修改確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qresult == DialogResult.Yes)
            {
                this.T12.SaveChanges();
                MessageBox.Show("修改成功");
                顯示資料表();
            }
            else
            {
                return;
            }
        }

        private void btn查尋_Click(object sender, EventArgs e)
        {
            var q = from p in T12.Transportations.AsEnumerable()
                    join t in T12.Transportation_Lists on p.TransportationList_ID equals t.TransportationList_ID
                    join d in T12.行程明細 on p.行程明細ID equals d.行程明細ID
                    join j in T12.Itinerary_Plan行程計畫 on d.Itinerary_ID equals j.Itinerary_ID
                    where j.Itinerary_Name.Contains(txbSearch.Text) || t.Transportation.Contains(txbSearch.Text)
                    || p.交通工具班次.Contains(txbSearch.Text) || p.Company_Name.Contains(txbSearch.Text)
                    || p.Departure.Contains(txbSearch.Text) || p.Destination.Contains(txbSearch.Text)
                    || p.Departure_Time.Year.ToString().Equals(txbSearch.Text)
                    || p.Time_of_Arrival.Year.ToString().Equals(txbSearch.Text)
                    || p.Price.ToString().Contains(txbSearch.Text)
                    select new
                    {
                        p.TransportationID,
                        p.行程明細ID,
                        j.Itinerary_Name,
                        t.Transportation,
                        p.Company_Name,
                        p.交通工具班次,
                        p.Departure,
                        p.Destination,
                        p.Departure_Time,
                        p.Time_of_Arrival,
                        p.Price,
                    };
            this.dataGridViewTransportation.DataSource = q.ToList();
            隱藏資料表();
        }

        private void btn清除查詢_Click(object sender, EventArgs e)
        {
            txbSearch.Text = "";
            var q = from p in T12.Transportations.AsEnumerable()
                    join t in T12.Transportation_Lists on p.TransportationList_ID equals t.TransportationList_ID
                    join d in T12.行程明細 on p.行程明細ID equals d.行程明細ID
                    join j in T12.Itinerary_Plan行程計畫 on d.Itinerary_ID equals j.Itinerary_ID
                    select new
                    {
                        p.TransportationID,
                        p.行程明細ID,
                        j.Itinerary_Name,
                        t.Transportation,
                        p.Company_Name,
                        p.交通工具班次,
                        p.Departure,
                        p.Destination,
                        p.Departure_Time,
                        p.Time_of_Arrival,
                        p.Price,
                    };
            this.dataGridViewTransportation.DataSource = q.ToList();
        }

        DateTime 預設時間 = new DateTime(2022, 09, 01);
        private void btn清除內容_Click(object sender, EventArgs e)
        {
            comboBoxPjName.Text = "";
            txbDetail.Text = "";
            comboBoxClass.Text = "";
            txbClass.Text = "";
            comboBoxCompanyName.Text = "";
            txbNumber.Text = "";
            comboBoxArea1.Text = "";
            comboBoxDeparture.Text = "";
            comboBoxArea2.Text = "";
            comboBoxDestination.Text = "";
            dateTimePickerDeparture.Value= 預設時間;
            dateTimePickerArrvial.Value = 預設時間;
            txbPrice.Text = "";
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string 交通工具名稱 = comboBoxClass.Text;
            var q = from p in T12.Transportation_Lists
                    where p.Transportation == 交通工具名稱
                    select p;
            foreach (var item in q)
            {
                txbClass.Text = item.TransportationList_ID.ToString();
            }
        
        comboBoxCompanyName.Text = "";
            if (comboBoxClass.Text == "飛機")
            {
                
                comboBoxCompanyName.Items.Clear();
                comboBoxCompanyName.Items.Add("中華航空");
                comboBoxCompanyName.Items.Add("長榮航空");
            }
            else if (comboBoxClass.Text == "渡輪")
            {
                
                comboBoxCompanyName.Items.Clear();
                comboBoxCompanyName.Items.Add("公主郵輪");
                comboBoxCompanyName.Items.Add("麗星郵輪");
            }
            else if (comboBoxClass.Text == "火車")
            {
                
                comboBoxCompanyName.Items.Clear();
                comboBoxCompanyName.Items.Add("台灣鐵路");
                comboBoxCompanyName.Items.Add("台灣高鐵");

            }
            else if (comboBoxClass.Text == "客運")
            {
                
                comboBoxCompanyName.Items.Clear();
                comboBoxCompanyName.Items.Add("統聯客運");
                comboBoxCompanyName.Items.Add("國光客運");
            }
            else if (comboBoxClass.Text ==交通工具名稱)
            {
                return;
            }
            else
            {
                txbClass.Text = "";
            }
        }
       
        private void comboBoxArea1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDeparture.Text = "";
            if (comboBoxArea1.Text == "台灣")
            {
                comboBoxDeparture.Items.Clear();
                comboBoxDeparture.Items.Add("台北");
                comboBoxDeparture.Items.Add("台中");
                comboBoxDeparture.Items.Add("高雄");
                comboBoxDeparture.Items.Add("花蓮");
                comboBoxDestination.Items.Add("屏東");
            }
            else if (comboBoxArea1.Text == "亞洲")
            {
                comboBoxDeparture.Items.Clear();
                comboBoxDeparture.Items.Add("首爾");
                comboBoxDeparture.Items.Add("釜山");
                comboBoxDeparture.Items.Add("濟州島");
                comboBoxDeparture.Items.Add("東京");
                comboBoxDeparture.Items.Add("京都");
                comboBoxDeparture.Items.Add("九州");
                comboBoxDeparture.Items.Add("四國");
                comboBoxDeparture.Items.Add("沖繩");
                comboBoxDeparture.Items.Add("北京");
                comboBoxDeparture.Items.Add("上海");
                comboBoxDeparture.Items.Add("成都");
                comboBoxDeparture.Items.Add("廣州");
                comboBoxDeparture.Items.Add("海南");
            }
            else if (comboBoxArea1.Text == "歐洲")
            {
                comboBoxDeparture.Items.Clear();
                comboBoxDeparture.Items.Add("倫敦");
                comboBoxDeparture.Items.Add("劍橋");
                comboBoxDeparture.Items.Add("柏林");
                comboBoxDeparture.Items.Add("慕尼黑");
                comboBoxDeparture.Items.Add("巴黎");
            }
            else if (comboBoxArea1.Text == "非洲")
            {
                comboBoxDeparture.Items.Clear();
                comboBoxDeparture.Items.Add("開羅");
            }
            else if (comboBoxArea1.Text == "北美洲")
            {
                comboBoxDeparture.Items.Clear();
                comboBoxDeparture.Items.Add("紐約");
                comboBoxDeparture.Items.Add("舊金山");
                comboBoxDeparture.Items.Add("洛杉磯");
                comboBoxDeparture.Items.Add("多倫多");
                comboBoxDeparture.Items.Add("溫哥華");
            }
            else if (comboBoxArea1.Text == "中南美洲")
            {
                comboBoxDeparture.Items.Clear();
                comboBoxDeparture.Items.Add("布宜諾斯艾利斯");
                comboBoxDeparture.Items.Add("里約熱內盧");
            }
            else if (comboBoxArea1.Text == "大洋洲")
            {
                comboBoxDeparture.Items.Clear();
                comboBoxDeparture.Items.Add("墨爾本");
                comboBoxDeparture.Items.Add("達爾文");
                comboBoxDeparture.Items.Add("威靈頓");
                comboBoxDeparture.Items.Add("奧克蘭");
            }
            else
            {
                comboBoxDeparture.Items.Clear();
                comboBoxDeparture.Text = "";
            }
        }

        private void comboBoxArea2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDestination.Text = "";
            if (comboBoxArea2.SelectedItem == "台灣")
            {
                comboBoxDestination.Items.Clear();
                comboBoxDestination.Items.Add("台北");
                comboBoxDestination.Items.Add("台中");
                comboBoxDestination.Items.Add("高雄");
                comboBoxDestination.Items.Add("花蓮");
                comboBoxDestination.Items.Add("屏東");
            }
            else if (comboBoxArea2.SelectedItem == "亞洲")
            {
                comboBoxDestination.Items.Clear();
                comboBoxDestination.Items.Add("首爾");
                comboBoxDestination.Items.Add("釜山");
                comboBoxDestination.Items.Add("濟州島");
                comboBoxDestination.Items.Add("東京");
                comboBoxDestination.Items.Add("京都");
                comboBoxDestination.Items.Add("九州");
                comboBoxDestination.Items.Add("四國");
                comboBoxDestination.Items.Add("沖繩");
                comboBoxDestination.Items.Add("北京");
                comboBoxDestination.Items.Add("上海");
                comboBoxDestination.Items.Add("成都");
                comboBoxDestination.Items.Add("廣州");
                comboBoxDestination.Items.Add("海南");
            }
            else if (comboBoxArea2.SelectedItem == "歐洲")
            {
                comboBoxDestination.Items.Clear();
                comboBoxDestination.Items.Add("倫敦");
                comboBoxDestination.Items.Add("劍橋");
                comboBoxDestination.Items.Add("柏林");
                comboBoxDestination.Items.Add("慕尼黑");
                comboBoxDestination.Items.Add("巴黎");
            }
            else if (comboBoxArea2.SelectedItem == "非洲")
            {
                comboBoxDestination.Items.Clear();
                comboBoxDestination.Items.Add("開羅");
            }
            else if (comboBoxArea2.SelectedItem == "北美洲")
            {
                comboBoxDestination.Items.Clear();
                comboBoxDestination.Items.Add("紐約");
                comboBoxDestination.Items.Add("舊金山");
                comboBoxDestination.Items.Add("洛杉磯");
                comboBoxDestination.Items.Add("多倫多");
                comboBoxDestination.Items.Add("溫哥華");
            }
            else if (comboBoxArea2.SelectedItem == "中南美洲")
            {
                comboBoxDestination.Items.Clear();
                comboBoxDestination.Items.Add("布宜諾斯艾利斯");
                comboBoxDestination.Items.Add("里約熱內盧");
            }
            else if (comboBoxArea2.SelectedItem == "大洋洲")
            {
                comboBoxDestination.Items.Clear();
                comboBoxDestination.Items.Add("墨爾本");
                comboBoxDestination.Items.Add("達爾文");
                comboBoxDestination.Items.Add("威靈頓");
                comboBoxDestination.Items.Add("奧克蘭");
            }
            else
            {
                comboBoxDestination.Items.Clear();
                comboBoxDestination.Text = "";
            }
        }
        string temp;
        private void btnL新增_Click(object sender, EventArgs e)
        {
            if (TxbName.Text == "")
            {
                MessageBox.Show("欄位空白");
                return;
            }

            Transportation_List 交通方式資料總表 = new Transportation_List()
            {
                Transportation = TxbName.Text,
            };
            this.T12.Transportation_Lists.Add(交通方式資料總表);
            temp = TxbName.Text;
            comboBoxClass.Items.Add(temp);
            this.T12.SaveChanges();
            更新資料表List();
            MessageBox.Show("新增成功");
            
        }
        
        private void btnL修改_Click(object sender, EventArgs e)
        {
            if (index < 0) { return; }            
            id = Convert.ToInt32(dataGridViewTransportationList.Rows[index].Cells[0].Value);
            
            var q = (from p in T12.Transportation_Lists
                     where p.TransportationList_ID == id
                     select p).FirstOrDefault();
            temp = q.Transportation;
            q.Transportation = TxbName.Text;
            qresult = MessageBox.Show("是否確定修改?", "修改確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qresult == DialogResult.Yes)
            {
                comboBoxClass.Items.Remove(temp);
                comboBoxClass.Items.Add(TxbName.Text);
                this.T12.SaveChanges();
                MessageBox.Show("修改成功");
                更新資料表List();
            }
            else
                return;
        }
        private void btnL刪除_Click(object sender, EventArgs e)
        {
            if (index < 0) { return; }
            id = Convert.ToInt32(dataGridViewTransportationList.Rows[index].Cells[0].Value);
            var q = (from p in T12.Transportation_Lists
                     where p.TransportationList_ID == id
                     select p).FirstOrDefault();
            this.T12.Transportation_Lists.Remove(q);
            comboBoxClass.Items.Remove(TxbName.Text);
            qresult = MessageBox.Show("是否確定刪除?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qresult == DialogResult.Yes)
            {
                this.T12.SaveChanges();
                更新資料表List();
                MessageBox.Show("刪除成功");
            }
            else
                return;
        }

        private void btnL清除_Click(object sender, EventArgs e)
        {
            TxbName.Text = "";
        }

        private void dataGridViewTransportationList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            id = Convert.ToInt32(dataGridViewTransportationList.Rows[index].Cells[0].Value);
            var q = from n in T12.Transportation_Lists
                    where n.TransportationList_ID == id
                    select n;
            foreach (var item in q)
            {
                TxbName.Text = item.Transportation;
            }
        }
        int a = 12;
        private void comboBoxPjName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = from n in T12.行程明細
                    join j in T12.Itinerary_Plan行程計畫 on n.Itinerary_ID equals j.Itinerary_ID
                    join h in T12.Hotel_Lists on n.Hotel_ID equals h.Hotel_ID
                    where j.Itinerary_Name == comboBoxPjName.Text
                    select new
                    {
                        n.行程明細ID,
                        j.Itinerary_Name,
                        n.DAY,
                        n.Date,
                        h.Hotel_Name,
                    };
            this.dataGridViewDetail.DataSource = q.ToList();
        }
        private void dataGridViewDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            id = Convert.ToInt32(dataGridViewDetail.Rows[index].Cells[0].Value);
            var q = from n in T12.行程明細
                    join j in T12.Itinerary_Plan行程計畫 on n.Itinerary_ID equals j.Itinerary_ID
                    join h in T12.Hotel_Lists on n.Hotel_ID equals h.Hotel_ID
                    where n.行程明細ID == id
                    select new
                    {
                        n.行程明細ID,
                        j.Itinerary_Name,
                        n.DAY,
                        n.Date,
                        h.Hotel_Name,
                    };
            foreach (var item in q)
            {
                txbDetail.Text = item.行程明細ID.ToString();
            }
             
        }
    }
}
