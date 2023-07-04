namespace payroll_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mon_salary_textBox2 = new System.Windows.Forms.TextBox();
            this.contact__textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emp_name_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.houre_rate_textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.allow_textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Update_btn);
            this.groupBox1.Controls.Add(this.Delete_btn);
            this.groupBox1.Controls.Add(this.Add_btn);
            this.groupBox1.Controls.Add(this.allow_textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.houre_rate_textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mon_salary_textBox2);
            this.groupBox1.Controls.Add(this.contact__textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.emp_name_comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(251, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 292);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // mon_salary_textBox2
            // 
            this.mon_salary_textBox2.Location = new System.Drawing.Point(159, 109);
            this.mon_salary_textBox2.Name = "mon_salary_textBox2";
            this.mon_salary_textBox2.Size = new System.Drawing.Size(209, 20);
            this.mon_salary_textBox2.TabIndex = 5;
            // 
            // contact__textBox1
            // 
            this.contact__textBox1.Location = new System.Drawing.Point(159, 70);
            this.contact__textBox1.Name = "contact__textBox1";
            this.contact__textBox1.Size = new System.Drawing.Size(209, 20);
            this.contact__textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monthly Salary";
            // 
            // emp_name_comboBox1
            // 
            this.emp_name_comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emp_name_comboBox1.FormattingEnabled = true;
            this.emp_name_comboBox1.Location = new System.Drawing.Point(159, 22);
            this.emp_name_comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.emp_name_comboBox1.Name = "emp_name_comboBox1";
            this.emp_name_comboBox1.Size = new System.Drawing.Size(209, 24);
            this.emp_name_comboBox1.TabIndex = 4;
            this.emp_name_comboBox1.SelectedIndexChanged += new System.EventHandler(this.emp_name_comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contact Number";
            // 
            // houre_rate_textBox1
            // 
            this.houre_rate_textBox1.Location = new System.Drawing.Point(159, 150);
            this.houre_rate_textBox1.Name = "houre_rate_textBox1";
            this.houre_rate_textBox1.Size = new System.Drawing.Size(209, 20);
            this.houre_rate_textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rates-Hourly";
            // 
            // allow_textBox2
            // 
            this.allow_textBox2.Location = new System.Drawing.Point(159, 187);
            this.allow_textBox2.Name = "allow_textBox2";
            this.allow_textBox2.Size = new System.Drawing.Size(209, 20);
            this.allow_textBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(13, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Allowances";
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Close_btn.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.Close_btn.Location = new System.Drawing.Point(573, 334);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(56, 23);
            this.Close_btn.TabIndex = 16;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Delete_btn.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.Delete_btn.Location = new System.Drawing.Point(221, 253);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(67, 22);
            this.Delete_btn.TabIndex = 15;
            this.Delete_btn.Text = "DELETE";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_btn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add_btn.Location = new System.Drawing.Point(308, 253);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(60, 22);
            this.Add_btn.TabIndex = 14;
            this.Add_btn.Text = "ADD";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Update_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Update_btn.Location = new System.Drawing.Point(17, 249);
            this.Update_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(107, 26);
            this.Update_btn.TabIndex = 16;
            this.Update_btn.Text = "Update Details";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 368);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(656, 407);
            this.MinimumSize = new System.Drawing.Size(656, 407);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mon_salary_textBox2;
        private System.Windows.Forms.TextBox contact__textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox emp_name_comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.TextBox allow_textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox houre_rate_textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Close_btn;
    }
}

