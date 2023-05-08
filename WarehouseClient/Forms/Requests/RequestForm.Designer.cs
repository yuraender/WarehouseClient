namespace WarehouseClient.Forms.Requests {
    partial class RequestForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.allCheck = new System.Windows.Forms.RadioButton();
            this.uncompletedCheck = new System.Windows.Forms.RadioButton();
            this.completedCheck = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.excelOneButton = new System.Windows.Forms.Button();
            this.excelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.searchBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(575, 437);
            this.dataGridView.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Controls.Add(this.yearBox);
            this.searchBox.Controls.Add(this.label3);
            this.searchBox.Controls.Add(this.allCheck);
            this.searchBox.Controls.Add(this.uncompletedCheck);
            this.searchBox.Controls.Add(this.completedCheck);
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchBox.Location = new System.Drawing.Point(596, 31);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(179, 120);
            this.searchBox.TabIndex = 2;
            this.searchBox.TabStop = false;
            // 
            // yearBox
            // 
            this.yearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(37, 19);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(136, 21);
            this.yearBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Год";
            // 
            // allCheck
            // 
            this.allCheck.AutoSize = true;
            this.allCheck.Checked = true;
            this.allCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.allCheck.Location = new System.Drawing.Point(6, 46);
            this.allCheck.Name = "allCheck";
            this.allCheck.Size = new System.Drawing.Size(44, 17);
            this.allCheck.TabIndex = 2;
            this.allCheck.TabStop = true;
            this.allCheck.Text = "Все";
            this.allCheck.UseVisualStyleBackColor = true;
            this.allCheck.CheckedChanged += new System.EventHandler(this.allCheck_CheckedChanged);
            // 
            // uncompletedCheck
            // 
            this.uncompletedCheck.AutoSize = true;
            this.uncompletedCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.uncompletedCheck.Location = new System.Drawing.Point(6, 92);
            this.uncompletedCheck.Name = "uncompletedCheck";
            this.uncompletedCheck.Size = new System.Drawing.Size(109, 17);
            this.uncompletedCheck.TabIndex = 4;
            this.uncompletedCheck.Text = "Невыполненные";
            this.uncompletedCheck.UseVisualStyleBackColor = true;
            this.uncompletedCheck.CheckedChanged += new System.EventHandler(this.uncompletedCheck_CheckedChanged);
            // 
            // completedCheck
            // 
            this.completedCheck.AutoSize = true;
            this.completedCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.completedCheck.Location = new System.Drawing.Point(6, 69);
            this.completedCheck.Name = "completedCheck";
            this.completedCheck.Size = new System.Drawing.Size(96, 17);
            this.completedCheck.TabIndex = 3;
            this.completedCheck.Text = "Выполненные";
            this.completedCheck.UseVisualStyleBackColor = true;
            this.completedCheck.CheckedChanged += new System.EventHandler(this.completedCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(596, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(596, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Действия";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.excelOneButton);
            this.groupBox1.Controls.Add(this.excelButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(596, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 175);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // excelOneButton
            // 
            this.excelOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.excelOneButton.Image = global::WarehouseClient.Properties.Resources.excel;
            this.excelOneButton.Location = new System.Drawing.Point(6, 50);
            this.excelOneButton.Name = "excelOneButton";
            this.excelOneButton.Size = new System.Drawing.Size(167, 25);
            this.excelOneButton.TabIndex = 1;
            this.excelOneButton.Text = "Сохранить выбранную";
            this.excelOneButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.excelOneButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.excelOneButton.UseVisualStyleBackColor = true;
            this.excelOneButton.Click += new System.EventHandler(this.excelOneButton_Click);
            // 
            // excelButton
            // 
            this.excelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.excelButton.Image = global::WarehouseClient.Properties.Resources.excel;
            this.excelButton.Location = new System.Drawing.Point(6, 19);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(167, 25);
            this.excelButton.TabIndex = 0;
            this.excelButton.Text = "Сохранить";
            this.excelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.excelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.excelButton.UseVisualStyleBackColor = true;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.deleteButton.Location = new System.Drawing.Point(6, 146);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(167, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить заявку";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.updateButton.Location = new System.Drawing.Point(6, 117);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(167, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Изменить заявку";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.createButton.Location = new System.Drawing.Point(6, 88);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(167, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Создать заявку";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataGridView);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "RequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заявки в службу снабжения";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.RadioButton allCheck;
        private System.Windows.Forms.RadioButton uncompletedCheck;
        private System.Windows.Forms.RadioButton completedCheck;
        private System.Windows.Forms.Button excelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.Button excelOneButton;
    }
}