namespace kTesterAdmin.View.Catalog
{
    partial class FacultyForm2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.info_label = new System.Windows.Forms.Label();
            this.faculties_dataGridView = new System.Windows.Forms.DataGridView();
            this.faculty_panel = new System.Windows.Forms.Panel();
            this.save_button = new System.Windows.Forms.Button();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.close_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addFaculty_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.faculties_dataGridView)).BeginInit();
            this.faculty_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Факультеты";
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_label.Location = new System.Drawing.Point(15, 47);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(0, 16);
            this.info_label.TabIndex = 1;
            // 
            // faculties_dataGridView
            // 
            this.faculties_dataGridView.AllowUserToAddRows = false;
            this.faculties_dataGridView.AllowUserToDeleteRows = false;
            this.faculties_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.faculties_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.faculties_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.faculties_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.faculties_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.faculties_dataGridView.Location = new System.Drawing.Point(15, 100);
            this.faculties_dataGridView.MultiSelect = false;
            this.faculties_dataGridView.Name = "faculties_dataGridView";
            this.faculties_dataGridView.ReadOnly = true;
            this.faculties_dataGridView.RowHeadersVisible = false;
            this.faculties_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.faculties_dataGridView.Size = new System.Drawing.Size(320, 200);
            this.faculties_dataGridView.TabIndex = 4;
            this.faculties_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.faculties_dataGridView_CellClick);
            // 
            // faculty_panel
            // 
            this.faculty_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faculty_panel.BackColor = System.Drawing.SystemColors.Window;
            this.faculty_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.faculty_panel.Controls.Add(this.save_button);
            this.faculty_panel.Controls.Add(this.id_textBox);
            this.faculty_panel.Controls.Add(this.close_button);
            this.faculty_panel.Controls.Add(this.name_textBox);
            this.faculty_panel.Controls.Add(this.label2);
            this.faculty_panel.Location = new System.Drawing.Point(367, 100);
            this.faculty_panel.Name = "faculty_panel";
            this.faculty_panel.Size = new System.Drawing.Size(271, 200);
            this.faculty_panel.TabIndex = 5;
            this.faculty_panel.Visible = false;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(171, 90);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 5;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(14, 90);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(52, 20);
            this.id_textBox.TabIndex = 4;
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.BackgroundImage = global::kTesterAdmin.Properties.Resources.exit;
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Location = new System.Drawing.Point(241, 3);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(25, 25);
            this.close_button.TabIndex = 3;
            this.close_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textBox.Location = new System.Drawing.Point(14, 43);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(233, 26);
            this.name_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Факультет";
            // 
            // addFaculty_button
            // 
            this.addFaculty_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addFaculty_button.BackColor = System.Drawing.Color.Transparent;
            this.addFaculty_button.BackgroundImage = global::kTesterAdmin.Properties.Resources.blue_plus;
            this.addFaculty_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addFaculty_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFaculty_button.FlatAppearance.BorderSize = 0;
            this.addFaculty_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addFaculty_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addFaculty_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFaculty_button.Location = new System.Drawing.Point(561, 325);
            this.addFaculty_button.Name = "addFaculty_button";
            this.addFaculty_button.Size = new System.Drawing.Size(73, 63);
            this.addFaculty_button.TabIndex = 4;
            this.addFaculty_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addFaculty_button.UseVisualStyleBackColor = false;
            this.addFaculty_button.Click += new System.EventHandler(this.addFaculty_button_Click);
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.addFaculty_button);
            this.Controls.Add(this.faculty_panel);
            this.Controls.Add(this.faculties_dataGridView);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.Load += new System.EventHandler(this.FacultyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.faculties_dataGridView)).EndInit();
            this.faculty_panel.ResumeLayout(false);
            this.faculty_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.DataGridView faculties_dataGridView;
        private System.Windows.Forms.Panel faculty_panel;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button addFaculty_button;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Button save_button;
    }
}