using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ConCungReplication
{
    partial class HomepageEmployer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageEmployer));
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cover = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.KPI = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.citizenID = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cover.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 74);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1094, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Traces";
            this.label4.Click += new System.EventHandler(this.clickTraces);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.label2.Location = new System.Drawing.Point(900, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Storage";
            this.label2.Click += new System.EventHandler(this.clickStorage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(52)))), ((int)(((byte)(117)))));
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
            this.cover.Controls.Add(this.panel3);
            this.cover.Controls.Add(this.label6);
            this.cover.Controls.Add(this.groupBox3);
            this.cover.Controls.Add(this.groupBox2);
            this.cover.Controls.Add(this.groupBox1);
            this.cover.Controls.Add(this.label5);
            this.cover.Location = new System.Drawing.Point(0, 110);
            this.cover.Name = "cover";
            this.cover.Size = new System.Drawing.Size(1584, 820);
            this.cover.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.KPI);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.citizenID);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.gender);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 746);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(33, 671);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(235, 48);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.clickLogout);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(33, 608);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(235, 48);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label28.ForeColor = System.Drawing.Color.DimGray;
            this.label28.Location = new System.Drawing.Point(141, 456);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(128, 27);
            this.label28.TabIndex = 102;
            this.label28.Text = "4,000,000đ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.label29.Location = new System.Drawing.Point(157, 431);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(99, 21);
            this.label29.TabIndex = 101;
            this.label29.Text = "MY SALARY";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(43, 377);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 21);
            this.label21.TabIndex = 127;
            this.label21.Text = "Department";
            // 
            // KPI
            // 
            this.KPI.AutoSize = true;
            this.KPI.BackColor = System.Drawing.Color.Transparent;
            this.KPI.Font = new System.Drawing.Font("Montserrat SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KPI.ForeColor = System.Drawing.Color.DimGray;
            this.KPI.Location = new System.Drawing.Point(38, 451);
            this.KPI.Name = "KPI";
            this.KPI.Size = new System.Drawing.Size(74, 37);
            this.KPI.TabIndex = 100;
            this.KPI.Text = "20.2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.Color.DimGray;
            this.label23.Location = new System.Drawing.Point(43, 351);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 21);
            this.label23.TabIndex = 125;
            this.label23.Text = "Birthday";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.label19.Location = new System.Drawing.Point(43, 431);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 21);
            this.label19.TabIndex = 99;
            this.label19.Text = "MY KPI";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(176, 377);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 21);
            this.label20.TabIndex = 128;
            this.label20.Text = "Employee";
            // 
            // citizenID
            // 
            this.citizenID.AutoSize = true;
            this.citizenID.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.citizenID.ForeColor = System.Drawing.Color.DimGray;
            this.citizenID.Location = new System.Drawing.Point(176, 325);
            this.citizenID.Name = "citizenID";
            this.citizenID.Size = new System.Drawing.Size(74, 21);
            this.citizenID.TabIndex = 122;
            this.citizenID.Text = "58127381";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.Color.DimGray;
            this.label22.Location = new System.Drawing.Point(176, 351);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 21);
            this.label22.TabIndex = 126;
            this.label22.Text = "11/11/2011";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(55, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 182);
            this.pictureBox2.TabIndex = 120;
            this.pictureBox2.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.Color.DimGray;
            this.label25.Location = new System.Drawing.Point(43, 325);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 21);
            this.label25.TabIndex = 121;
            this.label25.Text = "Citizen ID";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Roboto Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(202)))));
            this.label27.Location = new System.Drawing.Point(103, 40);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 15);
            this.label27.TabIndex = 118;
            this.label27.Text = "MNV: E0012345";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Montserrat SemiBold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.ForeColor = System.Drawing.Color.DimGray;
            this.label26.Location = new System.Drawing.Point(73, 248);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(153, 39);
            this.label26.TabIndex = 119;
            this.label26.Text = "MYNAME";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label24.Location = new System.Drawing.Point(92, 290);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 18);
            this.label24.TabIndex = 123;
            this.label24.Text = "GENDER";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.ForeColor = System.Drawing.Color.DimGray;
            this.gender.Location = new System.Drawing.Point(159, 289);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(42, 20);
            this.gender.TabIndex = 124;
            this.gender.Text = "Male";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.label6.Location = new System.Drawing.Point(349, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "News";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(1139, 541);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 181);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "System";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(1139, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 181);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(1139, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 251);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipping Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(132)))));
            this.label5.Location = new System.Drawing.Point(1139, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Notifications";
            // 
            // HomepageEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.cover);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomepageEmployer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concung";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cover.ResumeLayout(false);
            this.cover.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private PictureBox logo;
        private Panel panel1;
        private Panel panel2;
        private Panel cover;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label5;
        private Panel panel3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label28;
        private Label label29;
        private Label label21;
        private Label KPI;
        private Label label23;
        private Label label19;
        private Label label20;
        private Label citizenID;
        private Label label22;
        private PictureBox pictureBox2;
        private Label label25;
        private Label label27;
        private Label label26;
        private Label label24;
        private Label gender;
    }
}

