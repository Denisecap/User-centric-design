﻿namespace Vaughns_business
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_user_info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.button_customer = new System.Windows.Forms.Button();
            this.button_home_page = new System.Windows.Forms.Button();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_top.Controls.Add(this.label_user_info);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.pictureBox_logo);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(884, 80);
            this.panel_top.TabIndex = 0;
            // 
            // label_user_info
            // 
            this.label_user_info.AutoSize = true;
            this.label_user_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_info.ForeColor = System.Drawing.Color.White;
            this.label_user_info.Location = new System.Drawing.Point(112, 62);
            this.label_user_info.Name = "label_user_info";
            this.label_user_info.Size = new System.Drawing.Size(279, 18);
            this.label_user_info.TabIndex = 2;
            this.label_user_info.Text = "\"User\"(USER ACCESS) Currently Signed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMPANY NAME";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.BackgroundImage")));
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(107, 80);
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_bottom.Controls.Add(this.button_customer);
            this.panel_bottom.Controls.Add(this.button_home_page);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 581);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(884, 80);
            this.panel_bottom.TabIndex = 1;
            // 
            // button_customer
            // 
            this.button_customer.BackColor = System.Drawing.Color.RosyBrown;
            this.button_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_customer.Location = new System.Drawing.Point(331, 20);
            this.button_customer.Name = "button_customer";
            this.button_customer.Size = new System.Drawing.Size(85, 39);
            this.button_customer.TabIndex = 3;
            this.button_customer.Text = "Customer";
            this.button_customer.UseVisualStyleBackColor = false;
            this.button_customer.Click += new System.EventHandler(this.button_customer_Click);
            // 
            // button_home_page
            // 
            this.button_home_page.BackColor = System.Drawing.Color.RosyBrown;
            this.button_home_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home_page.Location = new System.Drawing.Point(28, 20);
            this.button_home_page.Name = "button_home_page";
            this.button_home_page.Size = new System.Drawing.Size(79, 39);
            this.button_home_page.TabIndex = 2;
            this.button_home_page.Text = "Home";
            this.button_home_page.UseVisualStyleBackColor = false;
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.RosyBrown;
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 80);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(884, 501);
            this.panel_container.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Button button_home_page;
        private System.Windows.Forms.Label label_user_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_customer;
        private System.Windows.Forms.Panel panel_container;
    }
}