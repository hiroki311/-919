using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            飯店();
            飯店地點();
        }
        TravelerEntities3 db = new TravelerEntities3();
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private async void hoteltxt_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.president.gov.tw/Page/106");
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string html = await response.Content.ReadAsStringAsync();
                HtmlParser parser = new HtmlParser();
                var document = await parser.ParseDocumentAsync(html);
                var data = document.QuerySelectorAll(".big2 a");               
                foreach (var i in data)
                {
                    listBox1.Items.Add(i.InnerHtml);

                }                   
            }
        }
        private async void 飯店()
        {
            Uri uri = new Uri("https://multiplestore.easytravel.com.tw/list.aspx");
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string html = await response.Content.ReadAsStringAsync();
                HtmlParser parser = new HtmlParser();
                var document = await parser.ParseDocumentAsync(html);
                var data = document.QuerySelectorAll(".title2");
                foreach (var i in data)
                {
                    int length = i.InnerHtml.Length;
                    comboBox1.Items.Add(i.InnerHtml);
                }
            }
        }
        private async void 飯店地點()
        {
            Uri uri = new Uri("https://www.president.gov.tw/Page/106");
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string html = await response.Content.ReadAsStringAsync();
                HtmlParser parser = new HtmlParser();
                var document = await parser.ParseDocumentAsync(html);
                var data = document.QuerySelectorAll(".big2 a");
                foreach (var i in data)
                {
                    var 新城市 = new 城市總表()
                    {
                        城市名稱 = i.InnerHtml
                    };
                    comboBox2.Items.Add(i.InnerHtml);
                    db.城市總表.Add(新城市);
                }
                db.SaveChanges();
                MessageBox.Show("OK");

            }
        }
    }
}
