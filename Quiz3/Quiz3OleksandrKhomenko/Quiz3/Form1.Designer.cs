namespace Quiz3
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
            this.car_rbtn = new System.Windows.Forms.RadioButton();
            this.owner_rbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.ComboBox();
            this.model = new System.Windows.Forms.ComboBox();
            this.make = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // car_rbtn
            // 
            this.car_rbtn.AutoSize = true;
            this.car_rbtn.Location = new System.Drawing.Point(197, 93);
            this.car_rbtn.Name = "car_rbtn";
            this.car_rbtn.Size = new System.Drawing.Size(41, 17);
            this.car_rbtn.TabIndex = 0;
            this.car_rbtn.Text = "Car";
            this.car_rbtn.UseVisualStyleBackColor = true;
            this.car_rbtn.CheckedChanged += new System.EventHandler(this.car_rbtn_CheckedChanged);
            // 
            // owner_rbtn
            // 
            this.owner_rbtn.AutoSize = true;
            this.owner_rbtn.Location = new System.Drawing.Point(484, 93);
            this.owner_rbtn.Name = "owner_rbtn";
            this.owner_rbtn.Size = new System.Drawing.Size(56, 17);
            this.owner_rbtn.TabIndex = 1;
            this.owner_rbtn.TabStop = true;
            this.owner_rbtn.Text = "Owner";
            this.owner_rbtn.UseVisualStyleBackColor = true;
            this.owner_rbtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.model);
            this.groupBox1.Controls.Add(this.make);
            this.groupBox1.Location = new System.Drawing.Point(98, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Make";
            // 
            // year
            // 
            this.year.FormattingEnabled = true;
            this.year.Location = new System.Drawing.Point(99, 153);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(121, 21);
            this.year.TabIndex = 2;
            this.year.SelectedIndexChanged += new System.EventHandler(this.year_SelectedIndexChanged);
            // 
            // model
            // 
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(99, 96);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(121, 21);
            this.model.TabIndex = 1;
            this.model.SelectedIndexChanged += new System.EventHandler(this.model_SelectedIndexChanged);
            // 
            // make
            // 
            this.make.FormattingEnabled = true;
            this.make.Location = new System.Drawing.Point(99, 40);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(121, 21);
            this.make.TabIndex = 0;
            this.make.SelectedIndexChanged += new System.EventHandler(this.make_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.phone);
            this.groupBox2.Controls.Add(this.lastName);
            this.groupBox2.Controls.Add(this.firstName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(393, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Owner";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(113, 148);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(109, 20);
            this.phone.TabIndex = 8;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(113, 96);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(109, 20);
            this.lastName.TabIndex = 7;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(113, 40);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(109, 20);
            this.firstName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(166, 444);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(94, 23);
            this.reset_btn.TabIndex = 4;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(470, 444);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(100, 23);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 562);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.owner_rbtn);
            this.Controls.Add(this.car_rbtn);
            this.Name = "Form1";
            this.Text = "Carwash System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton car_rbtn;
        private System.Windows.Forms.RadioButton owner_rbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.ComboBox make;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
    }
}

