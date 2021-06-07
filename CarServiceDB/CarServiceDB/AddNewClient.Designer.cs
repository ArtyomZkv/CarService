
namespace CarServiceDB
{
    partial class AddNewClient
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
            this.dtp_registrationDate = new System.Windows.Forms.DateTimePicker();
            this.txbx_clientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_phoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txbx_date = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_registrationDate
            // 
            this.dtp_registrationDate.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.dtp_registrationDate.Location = new System.Drawing.Point(774, 61);
            this.dtp_registrationDate.Name = "dtp_registrationDate";
            this.dtp_registrationDate.Size = new System.Drawing.Size(24, 38);
            this.dtp_registrationDate.TabIndex = 2;
            this.dtp_registrationDate.ValueChanged += new System.EventHandler(this.dtp_registrationDate_ValueChanged);
            // 
            // txbx_clientName
            // 
            this.txbx_clientName.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.txbx_clientName.Location = new System.Drawing.Point(265, 24);
            this.txbx_clientName.Name = "txbx_clientName";
            this.txbx_clientName.Size = new System.Drawing.Size(546, 38);
            this.txbx_clientName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО клиента";
            // 
            // txbx_phoneNumber
            // 
            this.txbx_phoneNumber.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.txbx_phoneNumber.Location = new System.Drawing.Point(338, 118);
            this.txbx_phoneNumber.MaxLength = 16;
            this.txbx_phoneNumber.Name = "txbx_phoneNumber";
            this.txbx_phoneNumber.Size = new System.Drawing.Size(460, 38);
            this.txbx_phoneNumber.TabIndex = 0;
            this.txbx_phoneNumber.Click += new System.EventHandler(this.txbx_phoneNumber_Click);
            this.txbx_phoneNumber.TextChanged += new System.EventHandler(this.txbx_phoneNumer_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.label3.Location = new System.Drawing.Point(2, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Номер телефона";
            // 
            // txbx_email
            // 
            this.txbx_email.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.txbx_email.Location = new System.Drawing.Point(317, 188);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.Size = new System.Drawing.Size(494, 38);
            this.txbx_email.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.label4.Location = new System.Drawing.Point(2, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Электронная почта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.label5.Location = new System.Drawing.Point(15, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Дата регистрации";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_registrationDate);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txbx_date);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txbx_phoneNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 300);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(261, 187);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(261, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.button1.Location = new System.Drawing.Point(227, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить услугу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbx_date
            // 
            this.txbx_date.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.txbx_date.Location = new System.Drawing.Point(252, 61);
            this.txbx_date.Name = "txbx_date";
            this.txbx_date.Size = new System.Drawing.Size(546, 38);
            this.txbx_date.TabIndex = 0;
            // 
            // AddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 323);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_email);
            this.Controls.Add(this.txbx_clientName);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNewClient";
            this.Text = "AddNewClient";
            this.Load += new System.EventHandler(this.AddNewClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_registrationDate;
        private System.Windows.Forms.TextBox txbx_clientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_phoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbx_date;
    }
}