
namespace ConCungReplication
{
    partial class SubmitOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmitOrder));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PurchaseHistoryBtn = new System.Windows.Forms.Button();
            this.HomepageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 247);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(234, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your order has been successfully submitted.\r\nThe shipment will be arrived in a ne" +
    "xt few days.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PurchaseHistoryBtn
            // 
            this.PurchaseHistoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.PurchaseHistoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PurchaseHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseHistoryBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PurchaseHistoryBtn.ForeColor = System.Drawing.Color.White;
            this.PurchaseHistoryBtn.Location = new System.Drawing.Point(155, 450);
            this.PurchaseHistoryBtn.Name = "PurchaseHistoryBtn";
            this.PurchaseHistoryBtn.Size = new System.Drawing.Size(349, 50);
            this.PurchaseHistoryBtn.TabIndex = 19;
            this.PurchaseHistoryBtn.Text = "View Purchase History";
            this.PurchaseHistoryBtn.UseVisualStyleBackColor = false;
            this.PurchaseHistoryBtn.Click += new System.EventHandler(this.clickViewPurchaseHistory);
            // 
            // HomepageBtn
            // 
            this.HomepageBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomepageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomepageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomepageBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomepageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.HomepageBtn.Location = new System.Drawing.Point(544, 450);
            this.HomepageBtn.Name = "HomepageBtn";
            this.HomepageBtn.Size = new System.Drawing.Size(349, 50);
            this.HomepageBtn.TabIndex = 20;
            this.HomepageBtn.Text = "Back to Homepage →";
            this.HomepageBtn.UseVisualStyleBackColor = false;
            this.HomepageBtn.Click += new System.EventHandler(this.clickToHomepage);
            // 
            // SubmitOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 524);
            this.Controls.Add(this.HomepageBtn);
            this.Controls.Add(this.PurchaseHistoryBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubmitOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Submitted";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PurchaseHistoryBtn;
        private System.Windows.Forms.Button HomepageBtn;
    }
}