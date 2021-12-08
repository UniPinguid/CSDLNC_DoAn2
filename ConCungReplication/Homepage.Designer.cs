using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConCungReplication
{
    partial class Homepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private PictureBox title = new PictureBox(); // create a PictureBox
        private Label minimise = new Label(); // this doesn't even have to be a label!
        private Label maximise = new Label(); // this will simulate our this.maximise box
        private Label close = new Label(); // simulates the this.close box

        private bool drag = false; // determine if we should be moving the form
        private Point startPoint = new Point(0, 0); // also for the moving

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutUs = new System.Windows.Forms.Label();
            this.searchBar_overlay = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.searchBar_overlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.aboutUs);
            this.panel1.Controls.Add(this.searchBar_overlay);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 74);
            this.panel1.TabIndex = 1;
            // 
            // aboutUs
            // 
            this.aboutUs.AutoSize = true;
            this.aboutUs.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutUs.Location = new System.Drawing.Point(1439, 25);
            this.aboutUs.Name = "aboutUs";
            this.aboutUs.Size = new System.Drawing.Size(79, 21);
            this.aboutUs.TabIndex = 0;
            this.aboutUs.Text = "About Us";
            // 
            // searchBar_overlay
            // 
            this.searchBar_overlay.BackColor = System.Drawing.Color.White;
            this.searchBar_overlay.Controls.Add(this.searchBar);
            this.searchBar_overlay.Location = new System.Drawing.Point(240, 18);
            this.searchBar_overlay.Name = "searchBar_overlay";
            this.searchBar_overlay.Size = new System.Drawing.Size(774, 42);
            this.searchBar_overlay.TabIndex = 1;
            // 
            // searchBar
            // 
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.searchBar.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar.Location = new System.Drawing.Point(19, 10);
            this.searchBar.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.searchBar.MaxLength = 256;
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(736, 21);
            this.searchBar.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1534, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(52)))), ((int)(((byte)(117)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1593, 36);
            this.panel2.TabIndex = 2;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homepage";
            this.Text = "Concung.com";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.searchBar_overlay.ResumeLayout(false);
            this.searchBar_overlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
        #endregion

        private PictureBox logo;
        private Panel panel1;
        private TextBox searchBar;
        private PictureBox closeButton;
        private Panel searchBar_overlay;
        private Panel panel2;
        private Label aboutUs;
    }
}

