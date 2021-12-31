
namespace ConCungReplication
{
    partial class OrderPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPayment));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.customerName = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inCartData = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkMOMO = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkZaloPay = new System.Windows.Forms.CheckBox();
            this.checkVNPay = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkMastercard = new System.Windows.Forms.CheckBox();
            this.checkDelivery = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inCartData)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(52)))), ((int)(((byte)(117)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(1920, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 36);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1926, 74);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1304, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 42);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.clickUser);
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageLocation = "";
            this.logo.Location = new System.Drawing.Point(48, 25);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(161, 33);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.WaitOnLoad = true;
            this.logo.Click += new System.EventHandler(this.clickLogo);
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerName.ForeColor = System.Drawing.Color.DimGray;
            this.customerName.Location = new System.Drawing.Point(714, 142);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(180, 25);
            this.customerName.TabIndex = 15;
            this.customerName.Text = "John Andrick Doe";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.ForeColor = System.Drawing.Color.DimGray;
            this.address.Location = new System.Drawing.Point(917, 143);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(405, 24);
            this.address.TabIndex = 14;
            this.address.Text = "410 Green Hill Court, Boynton Beach, FL 33435";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(685, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 28);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // inCartData
            // 
            this.inCartData.BackgroundColor = System.Drawing.Color.White;
            this.inCartData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inCartData.Location = new System.Drawing.Point(48, 192);
            this.inCartData.Name = "inCartData";
            this.inCartData.RowHeadersWidth = 51;
            this.inCartData.RowTemplate.Height = 29;
            this.inCartData.Size = new System.Drawing.Size(1314, 336);
            this.inCartData.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(1247, 733);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "(VAT included)";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(1073, 777);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(289, 50);
            this.SubmitBtn.TabIndex = 26;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.clickSubmit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(1224, 696);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 41);
            this.label2.TabIndex = 25;
            this.label2.Text = "21.000đ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(1068, 702);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Total";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.discount.ForeColor = System.Drawing.Color.DimGray;
            this.discount.Location = new System.Drawing.Point(1268, 623);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(99, 26);
            this.discount.TabIndex = 23;
            this.discount.Text = "-42,000đ";
            this.discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(1067, 623);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Discount";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtotal.ForeColor = System.Drawing.Color.DimGray;
            this.subtotal.Location = new System.Drawing.Point(1274, 591);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(92, 26);
            this.subtotal.TabIndex = 21;
            this.subtotal.Text = "42,000đ";
            this.subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(1068, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(1282, 654);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "21,000đ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(1067, 655);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 26);
            this.label7.TabIndex = 28;
            this.label7.Text = "Delivery fee";
            // 
            // checkMOMO
            // 
            this.checkMOMO.BackColor = System.Drawing.Color.White;
            this.checkMOMO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkMOMO.BackgroundImage")));
            this.checkMOMO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkMOMO.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkMOMO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checkMOMO.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.checkMOMO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkMOMO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkMOMO.Location = new System.Drawing.Point(48, 587);
            this.checkMOMO.Name = "checkMOMO";
            this.checkMOMO.Size = new System.Drawing.Size(199, 81);
            this.checkMOMO.TabIndex = 30;
            this.checkMOMO.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkMOMO.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.label8.Location = new System.Drawing.Point(48, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "SELECT PAYMENT METHOD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(48, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 27);
            this.label9.TabIndex = 32;
            this.label9.Text = "← Return";
            this.label9.Click += new System.EventHandler(this.clickReturn);
            // 
            // checkZaloPay
            // 
            this.checkZaloPay.BackColor = System.Drawing.Color.White;
            this.checkZaloPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkZaloPay.BackgroundImage")));
            this.checkZaloPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkZaloPay.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkZaloPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checkZaloPay.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.checkZaloPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkZaloPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkZaloPay.Location = new System.Drawing.Point(279, 587);
            this.checkZaloPay.Name = "checkZaloPay";
            this.checkZaloPay.Size = new System.Drawing.Size(199, 81);
            this.checkZaloPay.TabIndex = 33;
            this.checkZaloPay.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkZaloPay.UseVisualStyleBackColor = false;
            // 
            // checkVNPay
            // 
            this.checkVNPay.BackColor = System.Drawing.Color.White;
            this.checkVNPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkVNPay.BackgroundImage")));
            this.checkVNPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkVNPay.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkVNPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checkVNPay.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.checkVNPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkVNPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkVNPay.Location = new System.Drawing.Point(506, 587);
            this.checkVNPay.Name = "checkVNPay";
            this.checkVNPay.Size = new System.Drawing.Size(199, 81);
            this.checkVNPay.TabIndex = 34;
            this.checkVNPay.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkVNPay.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox1.BackgroundImage")));
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(747, 587);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(199, 81);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.label10.Location = new System.Drawing.Point(1070, 544);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 26);
            this.label10.TabIndex = 36;
            this.label10.Text = "COUPON";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(9, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 24);
            this.label11.TabIndex = 37;
            this.label11.Text = "ABCDEFGH";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(1178, 539);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 37);
            this.panel3.TabIndex = 38;
            // 
            // checkMastercard
            // 
            this.checkMastercard.BackColor = System.Drawing.Color.White;
            this.checkMastercard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkMastercard.BackgroundImage")));
            this.checkMastercard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkMastercard.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkMastercard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checkMastercard.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.checkMastercard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkMastercard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkMastercard.Location = new System.Drawing.Point(48, 702);
            this.checkMastercard.Name = "checkMastercard";
            this.checkMastercard.Size = new System.Drawing.Size(199, 81);
            this.checkMastercard.TabIndex = 39;
            this.checkMastercard.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkMastercard.UseVisualStyleBackColor = false;
            // 
            // checkDelivery
            // 
            this.checkDelivery.BackColor = System.Drawing.Color.White;
            this.checkDelivery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkDelivery.BackgroundImage")));
            this.checkDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkDelivery.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkDelivery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checkDelivery.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.checkDelivery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkDelivery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkDelivery.Location = new System.Drawing.Point(278, 701);
            this.checkDelivery.Name = "checkDelivery";
            this.checkDelivery.Size = new System.Drawing.Size(199, 81);
            this.checkDelivery.TabIndex = 40;
            this.checkDelivery.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkDelivery.UseVisualStyleBackColor = false;
            // 
            // OrderPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1394, 844);
            this.Controls.Add(this.checkDelivery);
            this.Controls.Add(this.checkMastercard);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkVNPay);
            this.Controls.Add(this.checkZaloPay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkMOMO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubmitBtn);
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inCartData)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView inCartData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkMOMO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkZaloPay;
        private System.Windows.Forms.CheckBox checkVNPay;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkMastercard;
        private System.Windows.Forms.CheckBox checkDelivery;
    }
}