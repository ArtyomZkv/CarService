
namespace CarServiceDB
{
    partial class AddNewWorker
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
            this.txbx_workerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_phoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addNewWorker = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbx_workerName
            // 
            this.txbx_workerName.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_workerName.Location = new System.Drawing.Point(260, 24);
            this.txbx_workerName.Multiline = true;
            this.txbx_workerName.Name = "txbx_workerName";
            this.txbx_workerName.Size = new System.Drawing.Size(338, 43);
            this.txbx_workerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО работника";
            // 
            // txbx_phoneNumber
            // 
            this.txbx_phoneNumber.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_phoneNumber.Location = new System.Drawing.Point(260, 73);
            this.txbx_phoneNumber.MaxLength = 16;
            this.txbx_phoneNumber.Multiline = true;
            this.txbx_phoneNumber.Name = "txbx_phoneNumber";
            this.txbx_phoneNumber.Size = new System.Drawing.Size(338, 44);
            this.txbx_phoneNumber.TabIndex = 0;
            this.txbx_phoneNumber.TextChanged += new System.EventHandler(this.txbx_phoneNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер телефона";
            // 
            // btn_addNewWorker
            // 
            this.btn_addNewWorker.Font = new System.Drawing.Font("Leelawadee UI", 13.8F);
            this.btn_addNewWorker.Location = new System.Drawing.Point(260, 167);
            this.btn_addNewWorker.Name = "btn_addNewWorker";
            this.btn_addNewWorker.Size = new System.Drawing.Size(287, 44);
            this.btn_addNewWorker.TabIndex = 2;
            this.btn_addNewWorker.Text = "Добавить работника";
            this.btn_addNewWorker.UseVisualStyleBackColor = true;
            this.btn_addNewWorker.Click += new System.EventHandler(this.btn_addNewWorker_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_addNewWorker);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbx_workerName);
            this.groupBox1.Controls.Add(this.txbx_phoneNumber);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 217);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "Наименование услуги";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(604, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 180);
            this.listBox1.TabIndex = 3;
            this.listBox1.ValueMember = "ID услуги";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 32);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddNewWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 233);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNewWorker";
            this.Text = "AddNewWorker";
            this.Load += new System.EventHandler(this.AddNewWorker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_workerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_phoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addNewWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}