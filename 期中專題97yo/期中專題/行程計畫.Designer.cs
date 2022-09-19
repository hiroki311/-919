
namespace 期中專題
{
    partial class 行程計畫
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
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt文章介紹 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ptb上傳照片 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb主題 = new System.Windows.Forms.ComboBox();
            this.cbb類型 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt行程名稱 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt行程描述 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt人數 = new System.Windows.Forms.TextBox();
            this.dT回程日 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dT出發日 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt價格 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt天數 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn新增 = new System.Windows.Forms.Button();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb上傳照片)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(21, 362);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(1028, 282);
            this.dGV1.TabIndex = 14;
            this.dGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt文章介紹);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.ptb上傳照片);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cbb主題);
            this.panel2.Controls.Add(this.cbb類型);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt行程名稱);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt行程描述);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt人數);
            this.panel2.Controls.Add(this.dT回程日);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dT出發日);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt價格);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt天數);
            this.panel2.Location = new System.Drawing.Point(21, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 271);
            this.panel2.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(181, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 21);
            this.label11.TabIndex = 34;
            this.label11.Text = "國家:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(54, 20);
            this.comboBox1.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(453, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 21);
            this.label10.TabIndex = 32;
            this.label10.Text = "介紹文章:";
            // 
            // txt文章介紹
            // 
            this.txt文章介紹.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt文章介紹.Location = new System.Drawing.Point(457, 47);
            this.txt文章介紹.Multiline = true;
            this.txt文章介紹.Name = "txt文章介紹";
            this.txt文章介紹.Size = new System.Drawing.Size(337, 221);
            this.txt文章介紹.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 34);
            this.button1.TabIndex = 30;
            this.button1.Text = "上傳圖片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn上傳照片_Click);
            // 
            // ptb上傳照片
            // 
            this.ptb上傳照片.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb上傳照片.Location = new System.Drawing.Point(801, 47);
            this.ptb上傳照片.Name = "ptb上傳照片";
            this.ptb上傳照片.Size = new System.Drawing.Size(224, 181);
            this.ptb上傳照片.TabIndex = 29;
            this.ptb上傳照片.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(299, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "主題:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(299, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "類型:";
            // 
            // cbb主題
            // 
            this.cbb主題.FormattingEnabled = true;
            this.cbb主題.Location = new System.Drawing.Point(362, 110);
            this.cbb主題.Name = "cbb主題";
            this.cbb主題.Size = new System.Drawing.Size(83, 20);
            this.cbb主題.TabIndex = 24;
            this.cbb主題.SelectedIndexChanged += new System.EventHandler(this.cbb主題_SelectedIndexChanged);
            // 
            // cbb類型
            // 
            this.cbb類型.FormattingEnabled = true;
            this.cbb類型.Location = new System.Drawing.Point(362, 82);
            this.cbb類型.Name = "cbb類型";
            this.cbb類型.Size = new System.Drawing.Size(83, 20);
            this.cbb類型.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "行程名稱:";
            // 
            // txt行程名稱
            // 
            this.txt行程名稱.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt行程名稱.Location = new System.Drawing.Point(110, 20);
            this.txt行程名稱.Multiline = true;
            this.txt行程名稱.Name = "txt行程名稱";
            this.txt行程名稱.Size = new System.Drawing.Size(337, 52);
            this.txt行程名稱.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(3, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "行程描述:";
            // 
            // txt行程描述
            // 
            this.txt行程描述.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt行程描述.Location = new System.Drawing.Point(108, 175);
            this.txt行程描述.Multiline = true;
            this.txt行程描述.Name = "txt行程描述";
            this.txt行程描述.Size = new System.Drawing.Size(337, 93);
            this.txt行程描述.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(181, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "人數:";
            // 
            // txt人數
            // 
            this.txt人數.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt人數.Location = new System.Drawing.Point(239, 80);
            this.txt人數.Multiline = true;
            this.txt人數.Name = "txt人數";
            this.txt人數.Size = new System.Drawing.Size(54, 24);
            this.txt人數.TabIndex = 16;
            // 
            // dT回程日
            // 
            this.dT回程日.Location = new System.Drawing.Point(342, 145);
            this.dT回程日.Name = "dT回程日";
            this.dT回程日.Size = new System.Drawing.Size(103, 22);
            this.dT回程日.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(237, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "回程日期:";
            // 
            // dT出發日
            // 
            this.dT出發日.Location = new System.Drawing.Point(110, 145);
            this.dT出發日.Name = "dT出發日";
            this.dT出發日.Size = new System.Drawing.Size(103, 22);
            this.dT出發日.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(5, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "出發日期:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(47, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "價格:";
            // 
            // txt價格
            // 
            this.txt價格.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt價格.Location = new System.Drawing.Point(110, 113);
            this.txt價格.Multiline = true;
            this.txt價格.Name = "txt價格";
            this.txt價格.Size = new System.Drawing.Size(65, 24);
            this.txt價格.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(47, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "天數:";
            // 
            // txt天數
            // 
            this.txt天數.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt天數.Location = new System.Drawing.Point(110, 81);
            this.txt天數.Multiline = true;
            this.txt天數.Name = "txt天數";
            this.txt天數.Size = new System.Drawing.Size(65, 24);
            this.txt天數.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn新增);
            this.panel1.Controls.Add(this.btn刪除);
            this.panel1.Controls.Add(this.btn修改);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(21, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 61);
            this.panel1.TabIndex = 12;
            // 
            // btn新增
            // 
            this.btn新增.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增.Location = new System.Drawing.Point(136, 3);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(135, 55);
            this.btn新增.TabIndex = 0;
            this.btn新增.Text = "新增";
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // btn刪除
            // 
            this.btn刪除.Enabled = false;
            this.btn刪除.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(544, 3);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(135, 56);
            this.btn刪除.TabIndex = 1;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = true;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // btn修改
            // 
            this.btn修改.Enabled = false;
            this.btn修改.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改.Location = new System.Drawing.Point(340, 3);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(135, 56);
            this.btn修改.TabIndex = 2;
            this.btn修改.Text = "修改";
            this.btn修改.UseVisualStyleBackColor = true;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(748, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "查詢";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn查詢_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dGV1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1070, 665);
            this.panel3.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // 行程計畫
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 665);
            this.Controls.Add(this.panel3);
            this.Name = "行程計畫";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb上傳照片)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt文章介紹;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ptb上傳照片;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb主題;
        private System.Windows.Forms.ComboBox cbb類型;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt行程名稱;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt行程描述;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt人數;
        private System.Windows.Forms.DateTimePicker dT回程日;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dT出發日;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt價格;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt天數;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Button btn刪除;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}