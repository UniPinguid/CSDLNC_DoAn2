using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ConCungReplication
{
    partial class HomepageCustomer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private PictureBox title = new PictureBox();

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageCustomer));
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartQuantity = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBar_overlay = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.aboutUs = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cover = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkGroupProduct = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.searchBar_overlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageLocation = "";
            this.logo.Location = new System.Drawing.Point(48, 25);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(161, 33);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.WaitOnLoad = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.cartQuantity);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.searchBar_overlay);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 74);
            this.panel1.TabIndex = 1;
            // 
            // cartQuantity
            // 
            this.cartQuantity.AutoSize = true;
            this.cartQuantity.BackColor = System.Drawing.Color.White;
            this.cartQuantity.Font = new System.Drawing.Font("Montserrat ExtraBold", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cartQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.cartQuantity.Location = new System.Drawing.Point(1412, 31);
            this.cartQuantity.Name = "cartQuantity";
            this.cartQuantity.Size = new System.Drawing.Size(11, 15);
            this.cartQuantity.TabIndex = 4;
            this.cartQuantity.Text = "1";
            this.cartQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1376, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 43);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.CartClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1509, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // searchBar_overlay
            // 
            this.searchBar_overlay.BackColor = System.Drawing.Color.White;
            this.searchBar_overlay.Controls.Add(this.pictureBox3);
            this.searchBar_overlay.Controls.Add(this.searchBar);
            this.searchBar_overlay.Location = new System.Drawing.Point(240, 18);
            this.searchBar_overlay.Name = "searchBar_overlay";
            this.searchBar_overlay.Size = new System.Drawing.Size(774, 42);
            this.searchBar_overlay.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(735, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 36);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // searchBar
            // 
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.searchBar.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar.Location = new System.Drawing.Point(19, 13);
            this.searchBar.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.searchBar.MaxLength = 256;
            this.searchBar.Name = "searchBar";
            this.searchBar.PlaceholderText = "Search...";
            this.searchBar.Size = new System.Drawing.Size(736, 21);
            this.searchBar.TabIndex = 2;
            // 
            // aboutUs
            // 
            this.aboutUs.AutoSize = true;
            this.aboutUs.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutUs.Location = new System.Drawing.Point(1491, 9);
            this.aboutUs.Name = "aboutUs";
            this.aboutUs.Size = new System.Drawing.Size(79, 21);
            this.aboutUs.TabIndex = 0;
            this.aboutUs.Text = "About Us";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(52)))), ((int)(((byte)(117)))));
            this.panel2.Controls.Add(this.aboutUs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(1920, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 36);
            this.panel2.TabIndex = 2;
            // 
            // cover
            // 
            this.cover.AutoScroll = true;
            this.cover.BackColor = System.Drawing.Color.White;
            this.cover.Controls.Add(this.checkedListBox1);
            this.cover.Controls.Add(this.label4);
            this.cover.Controls.Add(this.label3);
            this.cover.Controls.Add(this.checkGroupProduct);
            this.cover.Controls.Add(this.button1);
            this.cover.Controls.Add(this.label2);
            this.cover.Controls.Add(this.label1);
            this.cover.Controls.Add(this.listProduct);
            this.cover.Location = new System.Drawing.Point(0, 110);
            this.cover.Name = "cover";
            this.cover.Size = new System.Drawing.Size(1584, 820);
            this.cover.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.ColumnWidth = 8;
            this.checkedListBox1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "(All)",
            "Bobby",
            "Comfort",
            "Dove",
            "Ensure",
            "Friso",
            "Huggies",
            "Milo",
            "Nutifood",
            "OMO",
            "Optimum Gold",
            "Pampers",
            "Similac",
            "Whoopee"});
            this.checkedListBox1.Location = new System.Drawing.Point(24, 392);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(198, 322);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.label4.Location = new System.Drawing.Point(76, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "BRAND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(48, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "DEPARTMENT";
            // 
            // checkGroupProduct
            // 
            this.checkGroupProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkGroupProduct.ColumnWidth = 8;
            this.checkGroupProduct.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkGroupProduct.ForeColor = System.Drawing.Color.DimGray;
            this.checkGroupProduct.FormattingEnabled = true;
            this.checkGroupProduct.Items.AddRange(new object[] {
            "(All)",
            "Bath essentials",
            "Bedding",
            "Changing sets",
            "Dairy products",
            "Diapers & wipes",
            "Feeding supplies",
            "Nursery",
            "Soaps",
            "Toys"});
            this.checkGroupProduct.Location = new System.Drawing.Point(24, 93);
            this.checkGroupProduct.Name = "checkGroupProduct";
            this.checkGroupProduct.Size = new System.Drawing.Size(198, 230);
            this.checkGroupProduct.Sorted = true;
            this.checkGroupProduct.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1447, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(668, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "TIP: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(706, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double click into a row will bring you to its main product page";
            // 
            // listProduct
            // 
            this.listProduct.BackgroundColor = System.Drawing.Color.White;
            this.listProduct.ColumnHeadersHeight = 29;
            this.listProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listProduct.Location = new System.Drawing.Point(240, 49);
            this.listProduct.Name = "listProduct";
            this.listProduct.RowHeadersWidth = 51;
            this.listProduct.RowTemplate.Height = 29;
            this.listProduct.Size = new System.Drawing.Size(1301, 669);
            this.listProduct.TabIndex = 0;
            // 
            // HomepageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.cover);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomepageCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concung";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.searchBar_overlay.ResumeLayout(false);
            this.searchBar_overlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.cover.ResumeLayout(false);
            this.cover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listProduct)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private PictureBox logo;
        private Panel panel1;
        private TextBox searchBar;
        private Panel searchBar_overlay;
        private Panel panel2;
        private Label aboutUs;
        private Panel cover;
        private PictureBox pictureBox1;
        private DataGridView listProduct;
        private Label label2;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
        private Label cartQuantity;
        private PictureBox pictureBox3;
        private CheckedListBox checkGroupProduct;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private Label label3;
    }
}

