
namespace 期中專題
{
    partial class 會員資料修改
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtidnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtnameBox1 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.sexBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.addressBox1 = new System.Windows.Forms.TextBox();
            this.birthBox3 = new System.Windows.Forms.TextBox();
            this.birth = new System.Windows.Forms.Label();
            this.idBox1 = new System.Windows.Forms.TextBox();
            this.emailBox4 = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.phoneBox7 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnclick = new System.Windows.Forms.Button();
            this.txtwheremail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtidnumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtpas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtnameBox1);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.sexBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.addressBox1);
            this.groupBox1.Controls.Add(this.birthBox3);
            this.groupBox1.Controls.Add(this.birth);
            this.groupBox1.Controls.Add(this.idBox1);
            this.groupBox1.Controls.Add(this.emailBox4);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.phoneBox7);
            this.groupBox1.Location = new System.Drawing.Point(48, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 334);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "會員資料修改";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(308, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "上傳照片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.pic_Click);
            // 
            // txtidnumber
            // 
            this.txtidnumber.Enabled = false;
            this.txtidnumber.Location = new System.Drawing.Point(91, 92);
            this.txtidnumber.Name = "txtidnumber";
            this.txtidnumber.Size = new System.Drawing.Size(165, 22);
            this.txtidnumber.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "身分證字號";
            // 
            // txtpas
            // 
            this.txtpas.Location = new System.Drawing.Point(91, 122);
            this.txtpas.Name = "txtpas";
            this.txtpas.Size = new System.Drawing.Size(165, 22);
            this.txtpas.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "MemberID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "刪除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtnameBox1
            // 
            this.txtnameBox1.Location = new System.Drawing.Point(91, 150);
            this.txtnameBox1.Name = "txtnameBox1";
            this.txtnameBox1.Size = new System.Drawing.Size(165, 22);
            this.txtnameBox1.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(29, 150);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(29, 12);
            this.title.TabIndex = 2;
            this.title.Text = "姓名";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(308, 262);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(111, 33);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "修改";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // sexBox2
            // 
            this.sexBox2.Enabled = false;
            this.sexBox2.Location = new System.Drawing.Point(91, 178);
            this.sexBox2.Name = "sexBox2";
            this.sexBox2.Size = new System.Drawing.Size(165, 22);
            this.sexBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "地址";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(29, 178);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 4;
            this.name.Text = "性別";
            // 
            // addressBox1
            // 
            this.addressBox1.Location = new System.Drawing.Point(91, 262);
            this.addressBox1.Name = "addressBox1";
            this.addressBox1.Size = new System.Drawing.Size(165, 22);
            this.addressBox1.TabIndex = 13;
            // 
            // birthBox3
            // 
            this.birthBox3.Location = new System.Drawing.Point(91, 234);
            this.birthBox3.Name = "birthBox3";
            this.birthBox3.Size = new System.Drawing.Size(165, 22);
            this.birthBox3.TabIndex = 5;
            // 
            // birth
            // 
            this.birth.AutoSize = true;
            this.birth.Location = new System.Drawing.Point(29, 234);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(29, 12);
            this.birth.TabIndex = 6;
            this.birth.Text = "生日";
            // 
            // idBox1
            // 
            this.idBox1.Enabled = false;
            this.idBox1.Location = new System.Drawing.Point(91, 36);
            this.idBox1.Name = "idBox1";
            this.idBox1.Size = new System.Drawing.Size(165, 22);
            this.idBox1.TabIndex = 11;
            // 
            // emailBox4
            // 
            this.emailBox4.Location = new System.Drawing.Point(91, 64);
            this.emailBox4.Name = "emailBox4";
            this.emailBox4.Size = new System.Drawing.Size(165, 22);
            this.emailBox4.TabIndex = 7;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(29, 206);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(29, 12);
            this.phone.TabIndex = 10;
            this.phone.Text = "電話";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(29, 67);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 12);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email";
            // 
            // phoneBox7
            // 
            this.phoneBox7.Location = new System.Drawing.Point(91, 206);
            this.phoneBox7.Name = "phoneBox7";
            this.phoneBox7.Size = new System.Drawing.Size(165, 22);
            this.phoneBox7.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(998, 272);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(48, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1010, 299);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "全部資料顯示";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.btnclick);
            this.groupBox3.Controls.Add(this.txtwheremail);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(636, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 333);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "會員帳號查詢";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(407, 281);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btnclick
            // 
            this.btnclick.Location = new System.Drawing.Point(314, 17);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(62, 23);
            this.btnclick.TabIndex = 2;
            this.btnclick.Text = "確定";
            this.btnclick.UseVisualStyleBackColor = true;
            this.btnclick.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // txtwheremail
            // 
            this.txtwheremail.Location = new System.Drawing.Point(146, 17);
            this.txtwheremail.Name = "txtwheremail";
            this.txtwheremail.Size = new System.Drawing.Size(149, 22);
            this.txtwheremail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "會員帳號或手機號碼:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // 會員資料修改
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 699);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "會員資料修改";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.會員資料修改_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtnameBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox sexBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox addressBox1;
        private System.Windows.Forms.TextBox birthBox3;
        private System.Windows.Forms.Label birth;
        private System.Windows.Forms.TextBox idBox1;
        private System.Windows.Forms.TextBox emailBox4;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox phoneBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtidnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.TextBox txtwheremail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

