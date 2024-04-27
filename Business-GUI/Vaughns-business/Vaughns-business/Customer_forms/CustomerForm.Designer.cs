namespace Vaughns_business
{
    partial class CustomerForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_add_customer = new System.Windows.Forms.Button();
            this.button_edit_customer = new System.Windows.Forms.Button();
            this.button_delete_customer = new System.Windows.Forms.Button();
            this.panel_edit_customers = new System.Windows.Forms.Panel();
            this.panel_customers = new System.Windows.Forms.Panel();
            this.panel_container = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_edit_customers.SuspendLayout();
            this.panel_customers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(442, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_add_customer
            // 
            this.button_add_customer.BackColor = System.Drawing.Color.IndianRed;
            this.button_add_customer.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_add_customer.FlatAppearance.BorderSize = 0;
            this.button_add_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_customer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_add_customer.Location = new System.Drawing.Point(0, 0);
            this.button_add_customer.Name = "button_add_customer";
            this.button_add_customer.Size = new System.Drawing.Size(75, 29);
            this.button_add_customer.TabIndex = 2;
            this.button_add_customer.Text = "Add";
            this.button_add_customer.UseVisualStyleBackColor = false;
            this.button_add_customer.Click += new System.EventHandler(this.button_add_customer_Click);
            // 
            // button_edit_customer
            // 
            this.button_edit_customer.BackColor = System.Drawing.Color.IndianRed;
            this.button_edit_customer.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_edit_customer.FlatAppearance.BorderSize = 0;
            this.button_edit_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit_customer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_edit_customer.Location = new System.Drawing.Point(75, 0);
            this.button_edit_customer.Name = "button_edit_customer";
            this.button_edit_customer.Size = new System.Drawing.Size(75, 29);
            this.button_edit_customer.TabIndex = 3;
            this.button_edit_customer.Text = "Edit";
            this.button_edit_customer.UseVisualStyleBackColor = false;
            this.button_edit_customer.Click += new System.EventHandler(this.button_edit_customer_Click);
            // 
            // button_delete_customer
            // 
            this.button_delete_customer.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete_customer.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_delete_customer.FlatAppearance.BorderSize = 0;
            this.button_delete_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_customer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_delete_customer.Location = new System.Drawing.Point(150, 0);
            this.button_delete_customer.Name = "button_delete_customer";
            this.button_delete_customer.Size = new System.Drawing.Size(75, 29);
            this.button_delete_customer.TabIndex = 4;
            this.button_delete_customer.Text = "Delete";
            this.button_delete_customer.UseVisualStyleBackColor = false;
            this.button_delete_customer.Click += new System.EventHandler(this.button_delete_customer_Click);
            // 
            // panel_edit_customers
            // 
            this.panel_edit_customers.Controls.Add(this.button_delete_customer);
            this.panel_edit_customers.Controls.Add(this.button_edit_customer);
            this.panel_edit_customers.Controls.Add(this.button_add_customer);
            this.panel_edit_customers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_edit_customers.Location = new System.Drawing.Point(0, 433);
            this.panel_edit_customers.Name = "panel_edit_customers";
            this.panel_edit_customers.Size = new System.Drawing.Size(868, 29);
            this.panel_edit_customers.TabIndex = 5;
            // 
            // panel_customers
            // 
            this.panel_customers.Controls.Add(this.dataGridView1);
            this.panel_customers.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_customers.Location = new System.Drawing.Point(0, 0);
            this.panel_customers.Name = "panel_customers";
            this.panel_customers.Size = new System.Drawing.Size(442, 433);
            this.panel_customers.TabIndex = 6;
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.RosyBrown;
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(442, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(426, 433);
            this.panel_container.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "CustomerID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 43;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "FullName";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "Phone";
            this.Column3.HeaderText = "Phone";
            this.Column3.Name = "Column3";
            this.Column3.Width = 63;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Email";
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(868, 462);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_customers);
            this.Controls.Add(this.panel_edit_customers);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_edit_customers.ResumeLayout(false);
            this.panel_customers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add_customer;
        private System.Windows.Forms.Button button_edit_customer;
        private System.Windows.Forms.Button button_delete_customer;
        private System.Windows.Forms.Panel panel_edit_customers;
        private System.Windows.Forms.Panel panel_customers;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}