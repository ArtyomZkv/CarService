
namespace CarServiceDB
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txbx_searchedRegistrationDate = new System.Windows.Forms.TextBox();
            this.txbx_searchedPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbx_searchedClientName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарегистрироватьВызовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСКлиентамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовогоКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовуюУслугуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСПерсоналомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьСписокПерсоналаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_clientsList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.txbx_phoneNumber = new System.Windows.Forms.TextBox();
            this.txbx_registrationDate = new System.Windows.Forms.TextBox();
            this.txbx_clientName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_services = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientsList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_services)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_next);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txbx_searchedRegistrationDate);
            this.groupBox1.Controls.Add(this.txbx_searchedPhoneNumber);
            this.groupBox1.Controls.Add(this.txbx_searchedClientName);
            this.groupBox1.Font = new System.Drawing.Font("Old English Text MT", 13.8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1144, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(861, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(19, 36);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Дата регистрации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Номер телефона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Имя клиента";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(1018, 59);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(117, 35);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "След.";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(887, 58);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(125, 35);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Искать";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txbx_searchedRegistrationDate
            // 
            this.txbx_searchedRegistrationDate.Location = new System.Drawing.Point(593, 58);
            this.txbx_searchedRegistrationDate.Name = "txbx_searchedRegistrationDate";
            this.txbx_searchedRegistrationDate.Size = new System.Drawing.Size(287, 36);
            this.txbx_searchedRegistrationDate.TabIndex = 0;
            // 
            // txbx_searchedPhoneNumber
            // 
            this.txbx_searchedPhoneNumber.Location = new System.Drawing.Point(300, 58);
            this.txbx_searchedPhoneNumber.Name = "txbx_searchedPhoneNumber";
            this.txbx_searchedPhoneNumber.Size = new System.Drawing.Size(287, 36);
            this.txbx_searchedPhoneNumber.TabIndex = 0;
            // 
            // txbx_searchedClientName
            // 
            this.txbx_searchedClientName.Location = new System.Drawing.Point(7, 58);
            this.txbx_searchedClientName.Name = "txbx_searchedClientName";
            this.txbx_searchedClientName.Size = new System.Drawing.Size(287, 36);
            this.txbx_searchedClientName.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.зарегистрироватьВызовToolStripMenuItem,
            this.работаСКлиентамиToolStripMenuItem,
            this.работаСПерсоналомToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // зарегистрироватьВызовToolStripMenuItem
            // 
            this.зарегистрироватьВызовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияToolStripMenuItem});
            this.зарегистрироватьВызовToolStripMenuItem.Name = "зарегистрироватьВызовToolStripMenuItem";
            this.зарегистрироватьВызовToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.зарегистрироватьВызовToolStripMenuItem.Text = "Зарегистрировать вызов";
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.РегистрацияToolStripMenuItem_Click);
            // 
            // работаСКлиентамиToolStripMenuItem
            // 
            this.работаСКлиентамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНовогоКлиентаToolStripMenuItem,
            this.добавитьНовуюУслугуToolStripMenuItem});
            this.работаСКлиентамиToolStripMenuItem.Name = "работаСКлиентамиToolStripMenuItem";
            this.работаСКлиентамиToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.работаСКлиентамиToolStripMenuItem.Text = "Работа с клиентами";
            // 
            // добавитьНовогоКлиентаToolStripMenuItem
            // 
            this.добавитьНовогоКлиентаToolStripMenuItem.Name = "добавитьНовогоКлиентаToolStripMenuItem";
            this.добавитьНовогоКлиентаToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.добавитьНовогоКлиентаToolStripMenuItem.Text = "Добавить нового клиента";
            this.добавитьНовогоКлиентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовогоКлиентаToolStripMenuItem_Click);
            // 
            // добавитьНовуюУслугуToolStripMenuItem
            // 
            this.добавитьНовуюУслугуToolStripMenuItem.Name = "добавитьНовуюУслугуToolStripMenuItem";
            this.добавитьНовуюУслугуToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.добавитьНовуюУслугуToolStripMenuItem.Text = "Добавить новую услугу";
            this.добавитьНовуюУслугуToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовуюУслугуToolStripMenuItem_Click);
            // 
            // работаСПерсоналомToolStripMenuItem
            // 
            this.работаСПерсоналомToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьСписокПерсоналаToolStripMenuItem});
            this.работаСПерсоналомToolStripMenuItem.Name = "работаСПерсоналомToolStripMenuItem";
            this.работаСПерсоналомToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.работаСПерсоналомToolStripMenuItem.Text = "Работа с персоналом";
            // 
            // открытьСписокПерсоналаToolStripMenuItem
            // 
            this.открытьСписокПерсоналаToolStripMenuItem.Name = "открытьСписокПерсоналаToolStripMenuItem";
            this.открытьСписокПерсоналаToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.открытьСписокПерсоналаToolStripMenuItem.Text = "Добавить нового сотрудника";
            this.открытьСписокПерсоналаToolStripMenuItem.Click += new System.EventHandler(this.открытьСписокПерсоналаToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_clientsList);
            this.groupBox2.Font = new System.Drawing.Font("Old English Text MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 245);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список клиентов";
            // 
            // dgv_clientsList
            // 
            this.dgv_clientsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientsList.Location = new System.Drawing.Point(6, 35);
            this.dgv_clientsList.Name = "dgv_clientsList";
            this.dgv_clientsList.ReadOnly = true;
            this.dgv_clientsList.RowHeadersWidth = 51;
            this.dgv_clientsList.RowTemplate.Height = 24;
            this.dgv_clientsList.Size = new System.Drawing.Size(490, 199);
            this.dgv_clientsList.TabIndex = 0;
            this.dgv_clientsList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_clientsList_CellEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txbx_email);
            this.groupBox3.Controls.Add(this.txbx_phoneNumber);
            this.groupBox3.Controls.Add(this.txbx_registrationDate);
            this.groupBox3.Controls.Add(this.txbx_clientName);
            this.groupBox3.Font = new System.Drawing.Font("Old English Text MT", 13.8F);
            this.groupBox3.Location = new System.Drawing.Point(521, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 245);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные клиентов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Эл. почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата регистрации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО КЛИЕНТА";
            // 
            // txbx_email
            // 
            this.txbx_email.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_email.Location = new System.Drawing.Point(235, 198);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.ReadOnly = true;
            this.txbx_email.Size = new System.Drawing.Size(394, 35);
            this.txbx_email.TabIndex = 0;
            // 
            // txbx_phoneNumber
            // 
            this.txbx_phoneNumber.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_phoneNumber.Location = new System.Drawing.Point(235, 141);
            this.txbx_phoneNumber.Name = "txbx_phoneNumber";
            this.txbx_phoneNumber.ReadOnly = true;
            this.txbx_phoneNumber.Size = new System.Drawing.Size(394, 35);
            this.txbx_phoneNumber.TabIndex = 0;
            // 
            // txbx_registrationDate
            // 
            this.txbx_registrationDate.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_registrationDate.Location = new System.Drawing.Point(235, 88);
            this.txbx_registrationDate.Name = "txbx_registrationDate";
            this.txbx_registrationDate.ReadOnly = true;
            this.txbx_registrationDate.Size = new System.Drawing.Size(394, 35);
            this.txbx_registrationDate.TabIndex = 0;
            // 
            // txbx_clientName
            // 
            this.txbx_clientName.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_clientName.Location = new System.Drawing.Point(235, 36);
            this.txbx_clientName.Name = "txbx_clientName";
            this.txbx_clientName.ReadOnly = true;
            this.txbx_clientName.Size = new System.Drawing.Size(394, 35);
            this.txbx_clientName.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_services);
            this.groupBox4.Font = new System.Drawing.Font("Old English Text MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 389);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1144, 292);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выполненные услуги";
            // 
            // dgv_services
            // 
            this.dgv_services.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_services.Location = new System.Drawing.Point(13, 35);
            this.dgv_services.Name = "dgv_services";
            this.dgv_services.ReadOnly = true;
            this.dgv_services.RowHeadersWidth = 51;
            this.dgv_services.RowTemplate.Height = 24;
            this.dgv_services.Size = new System.Drawing.Size(1125, 251);
            this.dgv_services.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 689);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientsList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_services)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_clientsList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_email;
        private System.Windows.Forms.TextBox txbx_phoneNumber;
        private System.Windows.Forms.TextBox txbx_registrationDate;
        private System.Windows.Forms.TextBox txbx_clientName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_services;
        private System.Windows.Forms.ToolStripMenuItem зарегистрироватьВызовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСКлиентамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовогоКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовуюУслугуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСПерсоналомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьСписокПерсоналаToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txbx_searchedRegistrationDate;
        private System.Windows.Forms.TextBox txbx_searchedPhoneNumber;
        private System.Windows.Forms.TextBox txbx_searchedClientName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

