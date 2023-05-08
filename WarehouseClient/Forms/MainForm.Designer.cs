namespace WarehouseClient.Forms {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.partGridView = new System.Windows.Forms.DataGridView();
            this.repairGridView = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.repairOldCheck = new System.Windows.Forms.CheckBox();
            this.repairNowCheck = new System.Windows.Forms.CheckBox();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.systemMenuItem = new System.Windows.Forms.MenuItem();
            this.requestsMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.passwordMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.settingsMenuItem = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.adminMenuItem = new System.Windows.Forms.MenuItem();
            this.logMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.usersMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.partsMenuItem = new System.Windows.Forms.MenuItem();
            this.groupsMenuItem = new System.Windows.Forms.MenuItem();
            this.unitsMenuItem = new System.Windows.Forms.MenuItem();
            this.helpMenuItem = new System.Windows.Forms.MenuItem();
            this.helpItem = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.unitBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.writeOffButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // partGridView
            // 
            this.partGridView.AllowUserToAddRows = false;
            this.partGridView.AllowUserToDeleteRows = false;
            this.partGridView.AllowUserToOrderColumns = true;
            this.partGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.partGridView.Location = new System.Drawing.Point(12, 39);
            this.partGridView.Name = "partGridView";
            this.partGridView.ReadOnly = true;
            this.partGridView.RowHeadersVisible = false;
            this.partGridView.Size = new System.Drawing.Size(520, 510);
            this.partGridView.TabIndex = 2;
            this.partGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partGridView_CellClick);
            // 
            // repairGridView
            // 
            this.repairGridView.AllowUserToAddRows = false;
            this.repairGridView.AllowUserToDeleteRows = false;
            this.repairGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repairGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.repairGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repairGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.repairGridView.Location = new System.Drawing.Point(538, 178);
            this.repairGridView.Name = "repairGridView";
            this.repairGridView.ReadOnly = true;
            this.repairGridView.RowHeadersVisible = false;
            this.repairGridView.Size = new System.Drawing.Size(404, 371);
            this.repairGridView.TabIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(520, 21);
            this.groupBox.TabIndex = 0;
            this.groupBox.SelectedIndexChanged += new System.EventHandler(this.groupBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.repairOldCheck);
            this.groupBox1.Controls.Add(this.repairNowCheck);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(568, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // repairOldCheck
            // 
            this.repairOldCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.repairOldCheck.Location = new System.Drawing.Point(6, 48);
            this.repairOldCheck.Name = "repairOldCheck";
            this.repairOldCheck.Size = new System.Drawing.Size(142, 24);
            this.repairOldCheck.TabIndex = 1;
            this.repairOldCheck.Text = "Бывшее в ремонте";
            this.repairOldCheck.UseVisualStyleBackColor = true;
            // 
            // repairNowCheck
            // 
            this.repairNowCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.repairNowCheck.Location = new System.Drawing.Point(6, 18);
            this.repairNowCheck.Name = "repairNowCheck";
            this.repairNowCheck.Size = new System.Drawing.Size(142, 24);
            this.repairNowCheck.TabIndex = 0;
            this.repairNowCheck.Text = "Сейчас в ремонте";
            this.repairNowCheck.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.systemMenuItem,
            this.adminMenuItem,
            this.helpMenuItem});
            // 
            // systemMenuItem
            // 
            this.systemMenuItem.Index = 0;
            this.systemMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.requestsMenuItem,
            this.menuItem1,
            this.passwordMenuItem,
            this.menuItem2,
            this.settingsMenuItem,
            this.exitMenuItem});
            this.systemMenuItem.Text = "Система";
            // 
            // requestsMenuItem
            // 
            this.requestsMenuItem.Enabled = false;
            this.requestsMenuItem.Index = 0;
            this.requestsMenuItem.Text = "Заявки в службу снабжения";
            this.requestsMenuItem.Click += new System.EventHandler(this.requestsMenuItem_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "-";
            // 
            // passwordMenuItem
            // 
            this.passwordMenuItem.Index = 2;
            this.passwordMenuItem.Text = "Изменить пароль";
            this.passwordMenuItem.Click += new System.EventHandler(this.passwordMenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.Text = "-";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Index = 4;
            this.settingsMenuItem.Text = "Настройки";
            this.settingsMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Index = 5;
            this.exitMenuItem.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // adminMenuItem
            // 
            this.adminMenuItem.Index = 1;
            this.adminMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.logMenuItem,
            this.menuItem3,
            this.usersMenuItem,
            this.menuItem4,
            this.partsMenuItem,
            this.groupsMenuItem,
            this.unitsMenuItem});
            this.adminMenuItem.Text = "Администрирование";
            this.adminMenuItem.Visible = false;
            // 
            // logMenuItem
            // 
            this.logMenuItem.Enabled = false;
            this.logMenuItem.Index = 0;
            this.logMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.logMenuItem.Text = "Просмотреть логи сервера";
            this.logMenuItem.Click += new System.EventHandler(this.logMenuItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // usersMenuItem
            // 
            this.usersMenuItem.Enabled = false;
            this.usersMenuItem.Index = 2;
            this.usersMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
            this.usersMenuItem.Text = "Управление пользователями";
            this.usersMenuItem.Click += new System.EventHandler(this.usersMenuItem_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "-";
            // 
            // partsMenuItem
            // 
            this.partsMenuItem.Enabled = false;
            this.partsMenuItem.Index = 4;
            this.partsMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.partsMenuItem.Text = "Управление деталями";
            this.partsMenuItem.Click += new System.EventHandler(this.partsMenuItem_Click);
            // 
            // groupsMenuItem
            // 
            this.groupsMenuItem.Enabled = false;
            this.groupsMenuItem.Index = 5;
            this.groupsMenuItem.Text = "Управление группами оборудования";
            this.groupsMenuItem.Click += new System.EventHandler(this.groupsMenuItem_Click);
            // 
            // unitsMenuItem
            // 
            this.unitsMenuItem.Enabled = false;
            this.unitsMenuItem.Index = 6;
            this.unitsMenuItem.Text = "Управление подразделениями";
            this.unitsMenuItem.Click += new System.EventHandler(this.unitsMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Index = 2;
            this.helpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.helpItem,
            this.menuItem5,
            this.aboutMenuItem});
            this.helpMenuItem.Text = "Справка";
            // 
            // helpItem
            // 
            this.helpItem.Index = 0;
            this.helpItem.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.helpItem.Text = "Просмотр справки";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "-";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Index = 2;
            this.aboutMenuItem.Text = "О программе Склад";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchButton.Location = new System.Drawing.Point(716, 67);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(21, 21);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "🔎";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(568, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitBox
            // 
            this.unitBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.unitBox.FormattingEnabled = true;
            this.unitBox.Location = new System.Drawing.Point(538, 12);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(404, 21);
            this.unitBox.TabIndex = 1;
            this.unitBox.SelectedIndexChanged += new System.EventHandler(this.unitBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.writeOffButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(745, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 111);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // writeOffButton
            // 
            this.writeOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.writeOffButton.Location = new System.Drawing.Point(6, 19);
            this.writeOffButton.Name = "writeOffButton";
            this.writeOffButton.Size = new System.Drawing.Size(156, 23);
            this.writeOffButton.TabIndex = 0;
            this.writeOffButton.Text = "Списать деталь";
            this.writeOffButton.UseVisualStyleBackColor = true;
            this.writeOffButton.Click += new System.EventHandler(this.writeOffButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(745, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Действия";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Location = new System.Drawing.Point(568, 67);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(142, 21);
            this.searchBox.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.repairGridView);
            this.Controls.Add(this.partGridView);
            this.KeyPreview = true;
            this.Menu = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView partGridView;
        private System.Windows.Forms.DataGridView repairGridView;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem systemMenuItem;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox repairOldCheck;
        private System.Windows.Forms.CheckBox repairNowCheck;
        private System.Windows.Forms.ComboBox unitBox;
        private System.Windows.Forms.MenuItem adminMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuItem usersMenuItem;
        private System.Windows.Forms.MenuItem partsMenuItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem logMenuItem;
        private System.Windows.Forms.Button writeOffButton;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem exitMenuItem;
        private System.Windows.Forms.MenuItem helpMenuItem;
        private System.Windows.Forms.MenuItem helpItem;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem aboutMenuItem;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem groupsMenuItem;
        private System.Windows.Forms.MenuItem unitsMenuItem;
        private System.Windows.Forms.ComboBox searchBox;
        private System.Windows.Forms.MenuItem requestsMenuItem;
        private System.Windows.Forms.MenuItem passwordMenuItem;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuItem settingsMenuItem;
    }
}

