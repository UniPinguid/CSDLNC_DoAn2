
namespace ConCungReplication
{
    partial class Storage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listProduct = new System.Windows.Forms.DataGridView();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
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
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 74);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1094, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Traces";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1267, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Import/Export";
            this.label3.Click += new System.EventHandler(this.clickIE);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(900, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Storage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(684, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products";
            this.label1.Click += new System.EventHandler(this.clickProducts);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1505, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.clickLogout);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.label7.Location = new System.Drawing.Point(1049, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "TIP: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1087, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(453, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Double click into a row will lead you to its product edit page";
            // 
            // listProduct
            // 
            this.listProduct.BackgroundColor = System.Drawing.Color.White;
            this.listProduct.ColumnHeadersHeight = 29;
            this.listProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listProduct.Location = new System.Drawing.Point(26, 198);
            this.listProduct.Name = "listProduct";
            this.listProduct.RowHeadersWidth = 51;
            this.listProduct.RowTemplate.Height = 29;
            this.listProduct.Size = new System.Drawing.Size(1528, 633);
            this.listProduct.TabIndex = 8;
            // 
            // searchIcon
            // 
            this.searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("searchIcon.Image")));
            this.searchIcon.Location = new System.Drawing.Point(932, 146);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(36, 36);
            this.searchIcon.TabIndex = 53;
            this.searchIcon.TabStop = false;
            // 
            // search
            // 
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(113, 147);
            this.search.Name = "search";
            this.search.PlaceholderText = "Dairy product...";
            this.search.Size = new System.Drawing.Size(803, 23);
            this.search.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(23, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 27);
            this.label9.TabIndex = 51;
            this.label9.Text = "Search:";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(26, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(900, 2);
            this.label10.TabIndex = 50;
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.searchIcon);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Storage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView listProduct;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}