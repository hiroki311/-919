
namespace 期中專題
{
    partial class 飯店列表
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(飯店列表));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txthoadd = new System.Windows.Forms.TextBox();
            this.txthoname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txthophone = new System.Windows.Forms.TextBox();
            this.txt查詢 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 43);
            this.button3.TabIndex = 31;
            this.button3.Text = "刪除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.刪除_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 43);
            this.button2.TabIndex = 28;
            this.button2.Text = "查詢";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.關鍵字_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "飯店地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "飯店名稱";
            // 
            // txthoadd
            // 
            this.txthoadd.Location = new System.Drawing.Point(184, 111);
            this.txthoadd.Name = "txthoadd";
            this.txthoadd.Size = new System.Drawing.Size(439, 22);
            this.txthoadd.TabIndex = 25;
            // 
            // txthoname
            // 
            this.txthoname.Location = new System.Drawing.Point(273, 72);
            this.txthoname.Name = "txthoname";
            this.txthoname.Size = new System.Drawing.Size(147, 22);
            this.txthoname.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "飯店電話";
            // 
            // txthophone
            // 
            this.txthophone.Location = new System.Drawing.Point(500, 72);
            this.txthophone.Name = "txthophone";
            this.txthophone.Size = new System.Drawing.Size(123, 22);
            this.txthophone.TabIndex = 22;
            // 
            // txt查詢
            // 
            this.txt查詢.ForeColor = System.Drawing.Color.Silver;
            this.txt查詢.Location = new System.Drawing.Point(159, 22);
            this.txt查詢.Name = "txt查詢";
            this.txt查詢.Size = new System.Drawing.Size(137, 22);
            this.txt查詢.TabIndex = 21;
            this.txt查詢.Text = "城市/區域/飯店(關鍵字)";
            this.txt查詢.Click += new System.EventHandler(this.txt查詢_Click);
            this.txt查詢.TextChanged += new System.EventHandler(this.txt查詢_TextChanged);
            this.txt查詢.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt查詢_KeyDown);
            this.txt查詢.MouseLeave += new System.EventHandler(this.txt查詢_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(625, 301);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(801, 378);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(248, 62);
            this.button6.TabIndex = 35;
            this.button6.Text = "上傳";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.上傳圖片_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(801, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 301);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(838, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 43);
            this.button4.TabIndex = 36;
            this.button4.Text = "快速查詢";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 306);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 52);
            this.button5.TabIndex = 37;
            this.button5.Text = "修改";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.修改_Click);
            // 
            // 飯店列表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 507);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthoadd);
            this.Controls.Add(this.txthoname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthophone);
            this.Controls.Add(this.txt查詢);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "飯店列表";
            this.Text = "飯店列表";
            this.Load += new System.EventHandler(this.飯店列表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthoadd;
        private System.Windows.Forms.TextBox txthoname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthophone;
        private System.Windows.Forms.TextBox txt查詢;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}