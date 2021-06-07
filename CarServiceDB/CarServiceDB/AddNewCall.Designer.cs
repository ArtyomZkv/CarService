
namespace CarServiceDB
{
    partial class AddNewCall
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
            this.lstbx_services = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_chouseService = new System.Windows.Forms.Button();
            this.btn_addNewService = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addNewClient = new System.Windows.Forms.Button();
            this.btn_choseClient = new System.Windows.Forms.Button();
            this.lstbx_clients = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_addData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbx_services
            // 
            this.lstbx_services.DisplayMember = "Наименование услуги";
            this.lstbx_services.FormattingEnabled = true;
            this.lstbx_services.ItemHeight = 30;
            this.lstbx_services.Location = new System.Drawing.Point(6, 37);
            this.lstbx_services.Name = "lstbx_services";
            this.lstbx_services.Size = new System.Drawing.Size(767, 154);
            this.lstbx_services.TabIndex = 0;
            this.lstbx_services.ValueMember = "ID услуги";
            this.lstbx_services.SelectedIndexChanged += new System.EventHandler(this.lstbx_services_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_chouseService);
            this.groupBox1.Controls.Add(this.btn_addNewService);
            this.groupBox1.Controls.Add(this.lstbx_services);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 269);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Окно добавления услуги";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(779, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 38);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(779, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 38);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(779, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 38);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "или";
            // 
            // btn_chouseService
            // 
            this.btn_chouseService.Location = new System.Drawing.Point(6, 214);
            this.btn_chouseService.Name = "btn_chouseService";
            this.btn_chouseService.Size = new System.Drawing.Size(335, 43);
            this.btn_chouseService.TabIndex = 3;
            this.btn_chouseService.Text = "Выбрать услугу из списка";
            this.btn_chouseService.UseVisualStyleBackColor = true;
            this.btn_chouseService.Click += new System.EventHandler(this.btn_chouseService_Click);
            // 
            // btn_addNewService
            // 
            this.btn_addNewService.Location = new System.Drawing.Point(664, 214);
            this.btn_addNewService.Name = "btn_addNewService";
            this.btn_addNewService.Size = new System.Drawing.Size(335, 43);
            this.btn_addNewService.TabIndex = 3;
            this.btn_addNewService.Text = "Создать новую услугу";
            this.btn_addNewService.UseVisualStyleBackColor = true;
            this.btn_addNewService.Click += new System.EventHandler(this.btn_addNewService_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_addNewClient);
            this.groupBox2.Controls.Add(this.btn_choseClient);
            this.groupBox2.Controls.Add(this.lstbx_clients);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1028, 269);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Окно добавления клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "или";
            // 
            // btn_addNewClient
            // 
            this.btn_addNewClient.Location = new System.Drawing.Point(608, 214);
            this.btn_addNewClient.Name = "btn_addNewClient";
            this.btn_addNewClient.Size = new System.Drawing.Size(403, 43);
            this.btn_addNewClient.TabIndex = 3;
            this.btn_addNewClient.Text = "Создать нового клиента";
            this.btn_addNewClient.UseVisualStyleBackColor = true;
            this.btn_addNewClient.Click += new System.EventHandler(this.btn_addNewClient_Click);
            // 
            // btn_choseClient
            // 
            this.btn_choseClient.Location = new System.Drawing.Point(0, 211);
            this.btn_choseClient.Name = "btn_choseClient";
            this.btn_choseClient.Size = new System.Drawing.Size(380, 43);
            this.btn_choseClient.TabIndex = 3;
            this.btn_choseClient.Text = "Выбрать клиента из списка";
            this.btn_choseClient.UseVisualStyleBackColor = true;
            this.btn_choseClient.Click += new System.EventHandler(this.btn_choseClient_Click);
            // 
            // lstbx_clients
            // 
            this.lstbx_clients.DisplayMember = "ФИО клиента";
            this.lstbx_clients.FormattingEnabled = true;
            this.lstbx_clients.ItemHeight = 30;
            this.lstbx_clients.Location = new System.Drawing.Point(6, 37);
            this.lstbx_clients.Name = "lstbx_clients";
            this.lstbx_clients.Size = new System.Drawing.Size(1005, 154);
            this.lstbx_clients.TabIndex = 0;
            this.lstbx_clients.ValueMember = "ID клиента";
            this.lstbx_clients.SelectedIndexChanged += new System.EventHandler(this.lstbx_clients_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_addData);
            this.groupBox3.Location = new System.Drawing.Point(13, 563);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1027, 66);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btn_addData
            // 
            this.btn_addData.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.btn_addData.Location = new System.Drawing.Point(315, 19);
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(361, 39);
            this.btn_addData.TabIndex = 0;
            this.btn_addData.Text = "Добавить новую запись";
            this.btn_addData.UseVisualStyleBackColor = true;
            this.btn_addData.Click += new System.EventHandler(this.btn_addData_Click);
            // 
            // AddNewCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 633);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNewCall";
            this.Text = "AddNewCall";
            this.Load += new System.EventHandler(this.AddNewCall_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbx_services;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_chouseService;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_addNewClient;
        private System.Windows.Forms.Button btn_choseClient;
        private System.Windows.Forms.ListBox lstbx_clients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_addData;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_addNewService;
    }
}