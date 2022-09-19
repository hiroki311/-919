
namespace 期中專題
{
    partial class 行程明細資料表
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbHotelID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.txbPjID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn清除查詢 = new System.Windows.Forms.Button();
            this.txbsearch = new System.Windows.Forms.TextBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.comboBoxPJName = new System.Windows.Forms.ComboBox();
            this.comboBoxHotelName = new System.Windows.Forms.ComboBox();
            this.btn清除內容 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_testSearch = new System.Windows.Forms.Button();
            this.dataGridViewTotal = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnT清除 = new System.Windows.Forms.Button();
            this.btnT查詢 = new System.Windows.Forms.Button();
            this.txbsearchT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn景點新增 = new System.Windows.Forms.Button();
            this.comboBoxAttracion = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbAttractionID = new System.Windows.Forms.TextBox();
            this.txbDetailID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbHotelID
            // 
            this.txbHotelID.Enabled = false;
            this.txbHotelID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbHotelID.Location = new System.Drawing.Point(125, 263);
            this.txbHotelID.Name = "txbHotelID";
            this.txbHotelID.Size = new System.Drawing.Size(176, 29);
            this.txbHotelID.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(27, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 68;
            this.label7.Text = "飯店ID:";
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Location = new System.Drawing.Point(126, 117);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(176, 28);
            this.comboBoxDay.TabIndex = 66;
          
            this.comboBoxDay.Click += new System.EventHandler(this.comboBoxDay_Click);
            // 
            // txbPjID
            // 
            this.txbPjID.Enabled = false;
            this.txbPjID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbPjID.Location = new System.Drawing.Point(126, 68);
            this.txbPjID.Name = "txbPjID";
            this.txbPjID.Size = new System.Drawing.Size(176, 29);
            this.txbPjID.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(27, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "旅遊計畫ID:";
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Location = new System.Drawing.Point(325, 12);
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowTemplate.Height = 24;
            this.dataGridViewDetail.Size = new System.Drawing.Size(575, 282);
            this.dataGridViewDetail.TabIndex = 62;
            this.dataGridViewDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetail_CellClick);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(126, 165);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(176, 29);
            this.dateTimePickerDate.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(27, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "日期:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(27, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "飯店名稱:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(27, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "第幾天:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "旅遊計畫名:";
            // 
            // btn清除查詢
            // 
            this.btn清除查詢.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除查詢.Location = new System.Drawing.Point(762, 378);
            this.btn清除查詢.Name = "btn清除查詢";
            this.btn清除查詢.Size = new System.Drawing.Size(126, 42);
            this.btn清除查詢.TabIndex = 75;
            this.btn清除查詢.Text = "清除查詢";
            this.btn清除查詢.UseVisualStyleBackColor = true;
            this.btn清除查詢.Click += new System.EventHandler(this.btn清除查詢_Click);
            // 
            // txbsearch
            // 
            this.txbsearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbsearch.Location = new System.Drawing.Point(472, 386);
            this.txbsearch.Name = "txbsearch";
            this.txbsearch.Size = new System.Drawing.Size(124, 29);
            this.txbsearch.TabIndex = 74;
            // 
            // btn搜尋
            // 
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(617, 379);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(126, 42);
            this.btn搜尋.TabIndex = 73;
            this.btn搜尋.Text = "查詢";
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // btn修改
            // 
            this.btn修改.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改.Location = new System.Drawing.Point(470, 314);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(126, 42);
            this.btn修改.TabIndex = 72;
            this.btn修改.Text = "修改資料";
            this.btn修改.UseVisualStyleBackColor = true;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // btn刪除
            // 
            this.btn刪除.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(617, 313);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(126, 42);
            this.btn刪除.TabIndex = 71;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = true;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // btn新增
            // 
            this.btn新增.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增.Location = new System.Drawing.Point(325, 315);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(126, 42);
            this.btn新增.TabIndex = 70;
            this.btn新增.Text = "新增";
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // comboBoxPJName
            // 
            this.comboBoxPJName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxPJName.FormattingEnabled = true;
            this.comboBoxPJName.Location = new System.Drawing.Point(126, 20);
            this.comboBoxPJName.Name = "comboBoxPJName";
            this.comboBoxPJName.Size = new System.Drawing.Size(176, 28);
            this.comboBoxPJName.TabIndex = 76;
            this.comboBoxPJName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPJName_SelectedIndexChanged);
            // 
            // comboBoxHotelName
            // 
            this.comboBoxHotelName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxHotelName.FormattingEnabled = true;
            this.comboBoxHotelName.Location = new System.Drawing.Point(126, 217);
            this.comboBoxHotelName.Name = "comboBoxHotelName";
            this.comboBoxHotelName.Size = new System.Drawing.Size(175, 28);
            this.comboBoxHotelName.TabIndex = 77;
            this.comboBoxHotelName.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btn清除內容
            // 
            this.btn清除內容.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除內容.Location = new System.Drawing.Point(762, 313);
            this.btn清除內容.Name = "btn清除內容";
            this.btn清除內容.Size = new System.Drawing.Size(126, 42);
            this.btn清除內容.TabIndex = 78;
            this.btn清除內容.Text = "清除內容";
            this.btn清除內容.UseVisualStyleBackColor = true;
            this.btn清除內容.Click += new System.EventHandler(this.btn清除內容_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(317, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 66);
            this.panel1.TabIndex = 79;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(317, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 48);
            this.panel2.TabIndex = 80;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(8, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 20);
            this.label15.TabIndex = 88;
            this.label15.Text = "行程明細查詢:";
            // 
            // btn_testSearch
            // 
            this.btn_testSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_testSearch.Location = new System.Drawing.Point(75, 552);
            this.btn_testSearch.Name = "btn_testSearch";
            this.btn_testSearch.Size = new System.Drawing.Size(155, 63);
            this.btn_testSearch.TabIndex = 83;
            this.btn_testSearch.Text = "顯示所有明細";
            this.btn_testSearch.UseVisualStyleBackColor = true;
            this.btn_testSearch.Click += new System.EventHandler(this.btn顯示全部資料_Click);
            // 
            // dataGridViewTotal
            // 
            this.dataGridViewTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotal.Location = new System.Drawing.Point(316, 495);
            this.dataGridViewTotal.Name = "dataGridViewTotal";
            this.dataGridViewTotal.RowTemplate.Height = 24;
            this.dataGridViewTotal.Size = new System.Drawing.Size(583, 169);
            this.dataGridViewTotal.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(25, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 35);
            this.label8.TabIndex = 86;
            this.label8.Text = "所有的行程資料";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnT清除);
            this.panel3.Controls.Add(this.btnT查詢);
            this.panel3.Controls.Add(this.txbsearchT);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(316, 667);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 48);
            this.panel3.TabIndex = 89;
            // 
            // btnT清除
            // 
            this.btnT清除.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnT清除.Location = new System.Drawing.Point(445, 3);
            this.btnT清除.Name = "btnT清除";
            this.btnT清除.Size = new System.Drawing.Size(126, 42);
            this.btnT清除.TabIndex = 90;
            this.btnT清除.Text = "清除查詢";
            this.btnT清除.UseVisualStyleBackColor = true;
            this.btnT清除.Click += new System.EventHandler(this.btnT清除_Click);
            // 
            // btnT查詢
            // 
            this.btnT查詢.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnT查詢.Location = new System.Drawing.Point(300, 3);
            this.btnT查詢.Name = "btnT查詢";
            this.btnT查詢.Size = new System.Drawing.Size(126, 42);
            this.btnT查詢.TabIndex = 90;
            this.btnT查詢.Text = "查詢";
            this.btnT查詢.UseVisualStyleBackColor = true;
            this.btnT查詢.Click += new System.EventHandler(this.btnT查詢_Click);
            // 
            // txbsearchT
            // 
            this.txbsearchT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbsearchT.Location = new System.Drawing.Point(150, 11);
            this.txbsearchT.Name = "txbsearchT";
            this.txbsearchT.Size = new System.Drawing.Size(124, 29);
            this.txbsearchT.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(8, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 88;
            this.label9.Text = "行程明細查詢:";
            // 
            // btn景點新增
            // 
            this.btn景點新增.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn景點新增.Location = new System.Drawing.Point(325, 428);
            this.btn景點新增.Name = "btn景點新增";
            this.btn景點新增.Size = new System.Drawing.Size(126, 42);
            this.btn景點新增.TabIndex = 91;
            this.btn景點新增.Text = "新增景點";
            this.btn景點新增.UseVisualStyleBackColor = true;
            this.btn景點新增.Click += new System.EventHandler(this.btn景點新增_Click);
            // 
            // comboBoxAttracion
            // 
            this.comboBoxAttracion.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxAttracion.FormattingEnabled = true;
            this.comboBoxAttracion.Location = new System.Drawing.Point(125, 377);
            this.comboBoxAttracion.Name = "comboBoxAttracion";
            this.comboBoxAttracion.Size = new System.Drawing.Size(175, 28);
            this.comboBoxAttracion.TabIndex = 92;
            this.comboBoxAttracion.SelectedIndexChanged += new System.EventHandler(this.comboBoxAttracion_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(26, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 94;
            this.label11.Text = "景點名稱:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(26, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 95;
            this.label12.Text = "景點名稱ID:";
            // 
            // txbAttractionID
            // 
            this.txbAttractionID.Enabled = false;
            this.txbAttractionID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbAttractionID.Location = new System.Drawing.Point(124, 424);
            this.txbAttractionID.Name = "txbAttractionID";
            this.txbAttractionID.Size = new System.Drawing.Size(176, 29);
            this.txbAttractionID.TabIndex = 96;
            // 
            // txbDetailID
            // 
            this.txbDetailID.Enabled = false;
            this.txbDetailID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbDetailID.Location = new System.Drawing.Point(125, 328);
            this.txbDetailID.Name = "txbDetailID";
            this.txbDetailID.Size = new System.Drawing.Size(176, 29);
            this.txbDetailID.TabIndex = 98;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(27, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 97;
            this.label13.Text = "行程明細ID:";
            // 
            // 行程明細資料表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 711);
            this.Controls.Add(this.txbDetailID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbAttractionID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxAttracion);
            this.Controls.Add(this.btn景點新增);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewTotal);
            this.Controls.Add(this.btn_testSearch);
            this.Controls.Add(this.btn清除內容);
            this.Controls.Add(this.comboBoxHotelName);
            this.Controls.Add(this.comboBoxPJName);
            this.Controls.Add(this.btn清除查詢);
            this.Controls.Add(this.txbsearch);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.btn修改);
            this.Controls.Add(this.btn刪除);
            this.Controls.Add(this.btn新增);
            this.Controls.Add(this.txbHotelID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.txbPjID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewDetail);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "行程明細資料表";
            this.Text = "行程明細資料表";
            this.Load += new System.EventHandler(this.行程明細資料表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbHotelID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.TextBox txbPjID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn清除查詢;
        private System.Windows.Forms.TextBox txbsearch;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Button btn刪除;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.ComboBox comboBoxPJName;
        private System.Windows.Forms.ComboBox comboBoxHotelName;
        private System.Windows.Forms.Button btn清除內容;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_testSearch;
        private System.Windows.Forms.DataGridView dataGridViewTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnT清除;
        private System.Windows.Forms.Button btnT查詢;
        private System.Windows.Forms.TextBox txbsearchT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn景點新增;
        private System.Windows.Forms.ComboBox comboBoxAttracion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbAttractionID;
        private System.Windows.Forms.TextBox txbDetailID;
        private System.Windows.Forms.Label label13;
    }
}