﻿
namespace 期中專題
{
    partial class 會員專區
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnameBox1 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addressBox1 = new System.Windows.Forms.TextBox();
            this.idBox1 = new System.Windows.Forms.TextBox();
            this.emailBox4 = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.phoneBox7 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1077, 564);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(474, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "會員專區";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1071, 392);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtpas);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtnameBox1);
            this.tabPage1.Controls.Add(this.title);
            this.tabPage1.Controls.Add(this.btnupdate);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.addressBox1);
            this.tabPage1.Controls.Add(this.idBox1);
            this.tabPage1.Controls.Add(this.emailBox4);
            this.tabPage1.Controls.Add(this.phone);
            this.tabPage1.Controls.Add(this.Email);
            this.tabPage1.Controls.Add(this.phoneBox7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1063, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "資料修改";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(554, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "上傳照片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1上傳照片_Click);
            // 
            // txtpas
            // 
            this.txtpas.Location = new System.Drawing.Point(337, 129);
            this.txtpas.Name = "txtpas";
            this.txtpas.Size = new System.Drawing.Size(165, 22);
            this.txtpas.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "MemberID";
            // 
            // txtnameBox1
            // 
            this.txtnameBox1.Location = new System.Drawing.Point(337, 99);
            this.txtnameBox1.Name = "txtnameBox1";
            this.txtnameBox1.Size = new System.Drawing.Size(165, 22);
            this.txtnameBox1.TabIndex = 25;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(275, 99);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(29, 12);
            this.title.TabIndex = 26;
            this.title.Text = "姓名";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(554, 269);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(111, 33);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "修改";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 38;
            this.label5.Text = "地址";
            // 
            // addressBox1
            // 
            this.addressBox1.Location = new System.Drawing.Point(337, 185);
            this.addressBox1.Name = "addressBox1";
            this.addressBox1.Size = new System.Drawing.Size(165, 22);
            this.addressBox1.TabIndex = 37;
            // 
            // idBox1
            // 
            this.idBox1.Enabled = false;
            this.idBox1.Location = new System.Drawing.Point(337, 43);
            this.idBox1.Name = "idBox1";
            this.idBox1.Size = new System.Drawing.Size(165, 22);
            this.idBox1.TabIndex = 35;
            // 
            // emailBox4
            // 
            this.emailBox4.Enabled = false;
            this.emailBox4.Location = new System.Drawing.Point(337, 71);
            this.emailBox4.Name = "emailBox4";
            this.emailBox4.Size = new System.Drawing.Size(165, 22);
            this.emailBox4.TabIndex = 31;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(275, 157);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(29, 12);
            this.phone.TabIndex = 34;
            this.phone.Text = "電話";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(275, 74);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 12);
            this.Email.TabIndex = 32;
            this.Email.Text = "Email";
            // 
            // phoneBox7
            // 
            this.phoneBox7.Location = new System.Drawing.Point(337, 157);
            this.phoneBox7.Name = "phoneBox7";
            this.phoneBox7.Size = new System.Drawing.Size(165, 22);
            this.phoneBox7.TabIndex = 33;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1063, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "我的評論";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1063, 366);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "我的訂單";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1063, 366);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "我的購物車";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // 會員專區
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1077, 564);
            this.Controls.Add(this.splitContainer1);
            this.Name = "會員專區";
            this.Text = "會員專區";
            this.Load += new System.EventHandler(this.會員專區_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnameBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressBox1;
        private System.Windows.Forms.TextBox idBox1;
        private System.Windows.Forms.TextBox emailBox4;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox phoneBox7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}