
namespace 期中專題
{
    partial class 評分報表
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(評分報表));
            this.btn_deleted = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_AllCommon = new System.Windows.Forms.Button();
            this.btn_2Star = new System.Windows.Forms.Button();
            this.btn_4Star = new System.Windows.Forms.Button();
            this.btn_3Star = new System.Windows.Forms.Button();
            this.btn_5Star = new System.Windows.Forms.Button();
            this.btn_1Star = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_fixed = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblOrder_Number = new System.Windows.Forms.Label();
            this.cobStar = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btn_ = new System.Windows.Forms.Button();
            this.btn_AllData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deleted
            // 
            this.btn_deleted.BackColor = System.Drawing.Color.Red;
            this.btn_deleted.Font = new System.Drawing.Font("新細明體", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_deleted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deleted.Location = new System.Drawing.Point(843, 587);
            this.btn_deleted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_deleted.Name = "btn_deleted";
            this.btn_deleted.Size = new System.Drawing.Size(134, 51);
            this.btn_deleted.TabIndex = 1;
            this.btn_deleted.Text = "刪除";
            this.btn_deleted.UseVisualStyleBackColor = false;
            this.btn_deleted.Click += new System.EventHandler(this.btn_deleted_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 453);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(760, 193);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(542, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "異動日期:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(542, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "異動評論內容:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(58, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 48);
            this.label5.TabIndex = 11;
            this.label5.Text = "評論管理";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("新細明體", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(54, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "依評論等級查詢";
            // 
            // btn_AllCommon
            // 
            this.btn_AllCommon.Location = new System.Drawing.Point(59, 160);
            this.btn_AllCommon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AllCommon.Name = "btn_AllCommon";
            this.btn_AllCommon.Size = new System.Drawing.Size(105, 31);
            this.btn_AllCommon.TabIndex = 14;
            this.btn_AllCommon.Text = "全部評論";
            this.btn_AllCommon.UseVisualStyleBackColor = true;
            this.btn_AllCommon.Click += new System.EventHandler(this.btn_AllCommon_Click);
            // 
            // btn_2Star
            // 
            this.btn_2Star.Location = new System.Drawing.Point(180, 211);
            this.btn_2Star.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_2Star.Name = "btn_2Star";
            this.btn_2Star.Size = new System.Drawing.Size(105, 31);
            this.btn_2Star.TabIndex = 15;
            this.btn_2Star.Text = "兩星★★";
            this.btn_2Star.UseVisualStyleBackColor = true;
            this.btn_2Star.Click += new System.EventHandler(this.btn_2Star_Click);
            // 
            // btn_4Star
            // 
            this.btn_4Star.Location = new System.Drawing.Point(303, 160);
            this.btn_4Star.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_4Star.Name = "btn_4Star";
            this.btn_4Star.Size = new System.Drawing.Size(105, 31);
            this.btn_4Star.TabIndex = 16;
            this.btn_4Star.Text = "四星★★★★";
            this.btn_4Star.UseVisualStyleBackColor = true;
            this.btn_4Star.Click += new System.EventHandler(this.btn_4Star_Click);
            // 
            // btn_3Star
            // 
            this.btn_3Star.Location = new System.Drawing.Point(59, 211);
            this.btn_3Star.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_3Star.Name = "btn_3Star";
            this.btn_3Star.Size = new System.Drawing.Size(105, 31);
            this.btn_3Star.TabIndex = 17;
            this.btn_3Star.Text = "三星★★★";
            this.btn_3Star.UseVisualStyleBackColor = true;
            this.btn_3Star.Click += new System.EventHandler(this.btn_3Star_Click);
            // 
            // btn_5Star
            // 
            this.btn_5Star.Location = new System.Drawing.Point(180, 160);
            this.btn_5Star.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_5Star.Name = "btn_5Star";
            this.btn_5Star.Size = new System.Drawing.Size(105, 31);
            this.btn_5Star.TabIndex = 18;
            this.btn_5Star.Text = "五星★★★★★";
            this.btn_5Star.UseVisualStyleBackColor = true;
            this.btn_5Star.Click += new System.EventHandler(this.btn_5Star_Click);
            // 
            // btn_1Star
            // 
            this.btn_1Star.Location = new System.Drawing.Point(303, 211);
            this.btn_1Star.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_1Star.Name = "btn_1Star";
            this.btn_1Star.Size = new System.Drawing.Size(105, 31);
            this.btn_1Star.TabIndex = 19;
            this.btn_1Star.Text = "一星★";
            this.btn_1Star.UseVisualStyleBackColor = true;
            this.btn_1Star.Click += new System.EventHandler(this.btn_1Star_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("新細明體", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_search.Location = new System.Drawing.Point(324, 327);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(116, 31);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "單日查詢";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("新細明體", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(56, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 29;
            this.label7.Text = "依日期查詢";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(545, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "資料異動";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(542, 121);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "異動訂單明細編號:";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("新細明體", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtContent.Location = new System.Drawing.Point(542, 241);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(460, 177);
            this.txtContent.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(845, 213);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "異動星級:";
            // 
            // btn_fixed
            // 
            this.btn_fixed.Font = new System.Drawing.Font("新細明體", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_fixed.Location = new System.Drawing.Point(843, 453);
            this.btn_fixed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_fixed.Name = "btn_fixed";
            this.btn_fixed.Size = new System.Drawing.Size(134, 51);
            this.btn_fixed.TabIndex = 40;
            this.btn_fixed.Text = "修改";
            this.btn_fixed.UseVisualStyleBackColor = true;
            this.btn_fixed.Click += new System.EventHandler(this.btn_fixed_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(629, 165);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // lblOrder_Number
            // 
            this.lblOrder_Number.AutoSize = true;
            this.lblOrder_Number.Font = new System.Drawing.Font("新細明體", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrder_Number.Location = new System.Drawing.Point(681, 120);
            this.lblOrder_Number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrder_Number.Name = "lblOrder_Number";
            this.lblOrder_Number.Size = new System.Drawing.Size(27, 19);
            this.lblOrder_Number.TabIndex = 43;
            this.lblOrder_Number.Text = "00";
            // 
            // cobStar
            // 
            this.cobStar.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cobStar.FormattingEnabled = true;
            this.cobStar.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cobStar.Location = new System.Drawing.Point(923, 211);
            this.cobStar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cobStar.Name = "cobStar";
            this.cobStar.Size = new System.Drawing.Size(68, 24);
            this.cobStar.TabIndex = 44;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(188, 335);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(188, 390);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(120, 22);
            this.dateTimePicker3.TabIndex = 46;
            // 
            // btn_
            // 
            this.btn_.Font = new System.Drawing.Font("新細明體", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_.Location = new System.Drawing.Point(324, 384);
            this.btn_.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(116, 31);
            this.btn_.TabIndex = 47;
            this.btn_.Text = "區間查詢";
            this.btn_.UseVisualStyleBackColor = true;
            this.btn_.Click += new System.EventHandler(this.btnRangeSearch_Click);
            // 
            // btn_AllData
            // 
            this.btn_AllData.Font = new System.Drawing.Font("新細明體", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AllData.Location = new System.Drawing.Point(58, 314);
            this.btn_AllData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AllData.Name = "btn_AllData";
            this.btn_AllData.Size = new System.Drawing.Size(91, 82);
            this.btn_AllData.TabIndex = 48;
            this.btn_AllData.Text = "顯示所有資料";
            this.btn_AllData.UseVisualStyleBackColor = true;
            this.btn_AllData.Click += new System.EventHandler(this.button2_Click);
            // 
            // 評分報表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1049, 606);
            this.Controls.Add(this.btn_AllData);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.cobStar);
            this.Controls.Add(this.lblOrder_Number);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_fixed);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_1Star);
            this.Controls.Add(this.btn_5Star);
            this.Controls.Add(this.btn_3Star);
            this.Controls.Add(this.btn_4Star);
            this.Controls.Add(this.btn_2Star);
            this.Controls.Add(this.btn_AllCommon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_deleted);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "評分報表";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_deleted;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_AllCommon;
        private System.Windows.Forms.Button btn_2Star;
        private System.Windows.Forms.Button btn_4Star;
        private System.Windows.Forms.Button btn_3Star;
        private System.Windows.Forms.Button btn_5Star;
        private System.Windows.Forms.Button btn_1Star;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_fixed;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblOrder_Number;
        private System.Windows.Forms.ComboBox cobStar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.Button btn_AllData;
    }
}