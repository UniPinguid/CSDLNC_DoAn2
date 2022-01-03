
namespace ConCungReplication
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.inCartData = new System.Windows.Forms.DataGridView();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThuongHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.address = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inCartData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // inCartData
            // 
            this.inCartData.BackgroundColor = System.Drawing.Color.White;
            this.inCartData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inCartData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSP,
            this.ThuongHieu,
            this.Gia,
            this.KhuyenMai});
            this.inCartData.Location = new System.Drawing.Point(28, 215);
            this.inCartData.Name = "inCartData";
            this.inCartData.RowHeadersWidth = 51;
            this.inCartData.RowTemplate.Height = 29;
            this.inCartData.Size = new System.Drawing.Size(1530, 372);
            this.inCartData.TabIndex = 7;
            this.inCartData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inCartData_CellContentDoubleClick);
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 125;
            // 
            // ThuongHieu
            // 
            this.ThuongHieu.DataPropertyName = "ThuongHieu";
            this.ThuongHieu.HeaderText = "Thương Hiệu";
            this.ThuongHieu.MinimumWidth = 6;
            this.ThuongHieu.Name = "ThuongHieu";
            this.ThuongHieu.Width = 125;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.DataPropertyName = "KhuyenMai";
            this.KhuyenMai.HeaderText = "Khuyến Mãi";
            this.KhuyenMai.MinimumWidth = 6;
            this.KhuyenMai.Name = "KhuyenMai";
            this.KhuyenMai.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1185, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 43);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.ForeColor = System.Drawing.Color.DimGray;
            this.address.Location = new System.Drawing.Point(780, 175);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(389, 30);
            this.address.TabIndex = 9;
            this.address.Text = "410 Green Hill Court, Boynton Beach, FL 33435";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerName.ForeColor = System.Drawing.Color.DimGray;
            this.customerName.Location = new System.Drawing.Point(993, 150);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(176, 31);
            this.customerName.TabIndex = 11;
            this.customerName.Text = "John Andrick Doe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(1237, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Subtotal";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtotal.ForeColor = System.Drawing.Color.DimGray;
            this.subtotal.Location = new System.Drawing.Point(1457, 620);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(92, 36);
            this.subtotal.TabIndex = 13;
            this.subtotal.Text = "42,000đ";
            this.subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.discount.ForeColor = System.Drawing.Color.DimGray;
            this.discount.Location = new System.Drawing.Point(1446, 654);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(102, 36);
            this.discount.TabIndex = 15;
            this.discount.Text = "-42,000đ";
            this.discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(1236, 654);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Discount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(53)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(1387, 699);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 70);
            this.label2.TabIndex = 17;
            this.label2.Text = "0.000đ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(1234, 717);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 36);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(1425, 753);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "(VAT included)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(-9, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1585, 131);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1041, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 40);
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(545, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 36);
            this.label7.TabIndex = 45;
            this.label7.Text = "Homepage";
            this.label7.Click += new System.EventHandler(this.clickHomepage);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(742, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 36);
            this.label8.TabIndex = 44;
            this.label8.Text = "Browse";
            this.label8.Click += new System.EventHandler(this.clickBrowse);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(888, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 36);
            this.label9.TabIndex = 43;
            this.label9.Text = "About Us";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1313, 44);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(95, 35);
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(1551, 38);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(32, 32);
            this.panel7.TabIndex = 41;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1470, 37);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageLocation = "";
            this.logo.Location = new System.Drawing.Point(54, 47);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(227, 33);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.WaitOnLoad = true;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(1237, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 65);
            this.panel2.TabIndex = 27;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(58, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "Change Address";
            // 
            // panel14
            // 
            this.panel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel14.BackgroundImage")));
            this.panel14.Controls.Add(this.label11);
            this.panel14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel14.Location = new System.Drawing.Point(1317, 807);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(241, 65);
            this.panel14.TabIndex = 33;
            this.panel14.Click += new System.EventHandler(this.panel14_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(90, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 40);
            this.label11.TabIndex = 33;
            this.label11.Text = "Buy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label12.Location = new System.Drawing.Point(28, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 53);
            this.label12.TabIndex = 34;
            this.label12.Text = "My Cart";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label13.Location = new System.Drawing.Point(45, 603);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 53);
            this.label13.TabIndex = 35;
            this.label13.Text = "Enter Coupon";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(53, 662);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 55);
            this.panel3.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBox1.Location = new System.Drawing.Point(18, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "1234ABCD";
            this.textBox1.Size = new System.Drawing.Size(201, 33);
            this.textBox1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(314, 656);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 65);
            this.panel4.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(177)))), ((int)(((byte)(232)))));
            this.label6.Location = new System.Drawing.Point(65, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 40);
            this.label6.TabIndex = 38;
            this.label6.Text = "Proceed";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.address);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inCartData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inCartData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView inCartData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThuongHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuyenMai;
    }
}