
namespace CarServiceDB
{
    partial class AddNewService
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
            this.txbx_serviceName = new System.Windows.Forms.TextBox();
            this.txbx_servicePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstbx_services = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbx_serviceName
            // 
            this.txbx_serviceName.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.txbx_serviceName.Location = new System.Drawing.Point(301, 158);
            this.txbx_serviceName.Multiline = true;
            this.txbx_serviceName.Name = "txbx_serviceName";
            this.txbx_serviceName.Size = new System.Drawing.Size(527, 35);
            this.txbx_serviceName.TabIndex = 0;
            // 
            // txbx_servicePrice
            // 
            this.txbx_servicePrice.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.txbx_servicePrice.Location = new System.Drawing.Point(301, 198);
            this.txbx_servicePrice.Multiline = true;
            this.txbx_servicePrice.Name = "txbx_servicePrice";
            this.txbx_servicePrice.Size = new System.Drawing.Size(527, 35);
            this.txbx_servicePrice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.label1.Location = new System.Drawing.Point(6, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.label2.Location = new System.Drawing.Point(6, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стоимость услуги";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstbx_services);
            this.groupBox1.Controls.Add(this.txbx_servicePrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbx_serviceName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 343);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lstbx_services
            // 
            this.lstbx_services.DisplayMember = "ФИО";
            this.lstbx_services.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.lstbx_services.FormattingEnabled = true;
            this.lstbx_services.ItemHeight = 30;
            this.lstbx_services.Location = new System.Drawing.Point(301, 16);
            this.lstbx_services.Name = "lstbx_services";
            this.lstbx_services.Size = new System.Drawing.Size(527, 124);
            this.lstbx_services.TabIndex = 3;
            this.lstbx_services.ValueMember = "ID работника";
            this.lstbx_services.SelectedIndexChanged += new System.EventHandler(this.lstbx_services_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "ФИО мастера";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.button1.Location = new System.Drawing.Point(289, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить услугу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 367);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNewService";
            this.Text = "AddNewService";
            this.Load += new System.EventHandler(this.AddNewService_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_serviceName;
        private System.Windows.Forms.TextBox txbx_servicePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstbx_services;
        private System.Windows.Forms.Label label3;
    }
}