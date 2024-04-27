namespace Vaughns_business
{
    partial class StaffForm
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
            this.panel_edit_staff = new System.Windows.Forms.Panel();
            this.button_delete_staff = new System.Windows.Forms.Button();
            this.button_edit_staff = new System.Windows.Forms.Button();
            this.button_add_staff = new System.Windows.Forms.Button();
            this.panel_staff = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_container = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_edit_staff.SuspendLayout();
            this.panel_staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_edit_staff
            // 
            this.panel_edit_staff.Controls.Add(this.button_delete_staff);
            this.panel_edit_staff.Controls.Add(this.button_edit_staff);
            this.panel_edit_staff.Controls.Add(this.button_add_staff);
            this.panel_edit_staff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_edit_staff.Location = new System.Drawing.Point(0, 433);
            this.panel_edit_staff.Name = "panel_edit_staff";
            this.panel_edit_staff.Size = new System.Drawing.Size(868, 29);
            this.panel_edit_staff.TabIndex = 6;
            // 
            // button_delete_staff
            // 
            this.button_delete_staff.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete_staff.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_delete_staff.FlatAppearance.BorderSize = 0;
            this.button_delete_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_staff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_delete_staff.Location = new System.Drawing.Point(150, 0);
            this.button_delete_staff.Name = "button_delete_staff";
            this.button_delete_staff.Size = new System.Drawing.Size(75, 29);
            this.button_delete_staff.TabIndex = 4;
            this.button_delete_staff.Text = "Delete";
            this.button_delete_staff.UseVisualStyleBackColor = false;
            this.button_delete_staff.Click += new System.EventHandler(this.button_delete_staff_Click);
            // 
            // button_edit_staff
            // 
            this.button_edit_staff.BackColor = System.Drawing.Color.IndianRed;
            this.button_edit_staff.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_edit_staff.FlatAppearance.BorderSize = 0;
            this.button_edit_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit_staff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_edit_staff.Location = new System.Drawing.Point(75, 0);
            this.button_edit_staff.Name = "button_edit_staff";
            this.button_edit_staff.Size = new System.Drawing.Size(75, 29);
            this.button_edit_staff.TabIndex = 3;
            this.button_edit_staff.Text = "Edit";
            this.button_edit_staff.UseVisualStyleBackColor = false;
            this.button_edit_staff.Click += new System.EventHandler(this.button_edit_staff_Click);
            // 
            // button_add_staff
            // 
            this.button_add_staff.BackColor = System.Drawing.Color.IndianRed;
            this.button_add_staff.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_add_staff.FlatAppearance.BorderSize = 0;
            this.button_add_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_staff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_add_staff.Location = new System.Drawing.Point(0, 0);
            this.button_add_staff.Name = "button_add_staff";
            this.button_add_staff.Size = new System.Drawing.Size(75, 29);
            this.button_add_staff.TabIndex = 2;
            this.button_add_staff.Text = "Add";
            this.button_add_staff.UseVisualStyleBackColor = false;
            this.button_add_staff.Click += new System.EventHandler(this.button_add_staff_Click);
            // 
            // panel_staff
            // 
            this.panel_staff.Controls.Add(this.dataGridView1);
            this.panel_staff.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_staff.Location = new System.Drawing.Point(0, 0);
            this.panel_staff.Name = "panel_staff";
            this.panel_staff.Size = new System.Drawing.Size(505, 433);
            this.panel_staff.TabIndex = 8;
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
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(505, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.RosyBrown;
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(505, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(363, 433);
            this.panel_container.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "StaffID";
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
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.DataPropertyName = "Position";
            this.Column5.HeaderText = "Position";
            this.Column5.Name = "Column5";
            this.Column5.Width = 69;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.DataPropertyName = "Salary";
            this.Column6.HeaderText = "Salary";
            this.Column6.Name = "Column6";
            this.Column6.Width = 61;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(868, 462);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_staff);
            this.Controls.Add(this.panel_edit_staff);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.panel_edit_staff.ResumeLayout(false);
            this.panel_staff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_edit_staff;
        private System.Windows.Forms.Button button_delete_staff;
        private System.Windows.Forms.Button button_edit_staff;
        private System.Windows.Forms.Button button_add_staff;
        private System.Windows.Forms.Panel panel_staff;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}