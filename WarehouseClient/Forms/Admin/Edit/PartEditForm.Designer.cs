namespace WarehouseClient.Forms.Admin.Edit {
    partial class PartEditForm {
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
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createUpdateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.repairBox = new System.Windows.Forms.ListBox();
            this.repairCreateButton = new System.Windows.Forms.Button();
            this.repairDeleteButton = new System.Windows.Forms.Button();
            this.repairUpdateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.measureBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(33, 128);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(113, 20);
            this.amountBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(33, 89);
            this.typeBox.MaxLength = 50;
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(191, 20);
            this.typeBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(33, 50);
            this.nameBox.MaxLength = 50;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(191, 20);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // createUpdateButton
            // 
            this.createUpdateButton.Location = new System.Drawing.Point(50, 290);
            this.createUpdateButton.Name = "createUpdateButton";
            this.createUpdateButton.Size = new System.Drawing.Size(156, 51);
            this.createUpdateButton.TabIndex = 16;
            this.createUpdateButton.Text = "CreateUpdate";
            this.createUpdateButton.UseVisualStyleBackColor = true;
            this.createUpdateButton.Click += new System.EventHandler(this.createUpdateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Группа оборудования";
            // 
            // groupBox
            // 
            this.groupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(33, 206);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(191, 21);
            this.groupBox.TabIndex = 11;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(33, 167);
            this.descriptionBox.MaxLength = 1000;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(191, 20);
            this.descriptionBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Описание";
            // 
            // repairBox
            // 
            this.repairBox.FormattingEnabled = true;
            this.repairBox.Location = new System.Drawing.Point(254, 50);
            this.repairBox.Name = "repairBox";
            this.repairBox.Size = new System.Drawing.Size(270, 238);
            this.repairBox.TabIndex = 12;
            // 
            // repairCreateButton
            // 
            this.repairCreateButton.Location = new System.Drawing.Point(254, 294);
            this.repairCreateButton.Name = "repairCreateButton";
            this.repairCreateButton.Size = new System.Drawing.Size(75, 23);
            this.repairCreateButton.TabIndex = 13;
            this.repairCreateButton.Text = "Добавить";
            this.repairCreateButton.UseVisualStyleBackColor = true;
            this.repairCreateButton.Click += new System.EventHandler(this.repairCreateButton_Click);
            // 
            // repairDeleteButton
            // 
            this.repairDeleteButton.Location = new System.Drawing.Point(449, 294);
            this.repairDeleteButton.Name = "repairDeleteButton";
            this.repairDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.repairDeleteButton.TabIndex = 15;
            this.repairDeleteButton.Text = "Удалить";
            this.repairDeleteButton.UseVisualStyleBackColor = true;
            this.repairDeleteButton.Click += new System.EventHandler(this.repairDeleteButton_Click);
            // 
            // repairUpdateButton
            // 
            this.repairUpdateButton.Location = new System.Drawing.Point(352, 294);
            this.repairUpdateButton.Name = "repairUpdateButton";
            this.repairUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.repairUpdateButton.TabIndex = 14;
            this.repairUpdateButton.Text = "Обновить";
            this.repairUpdateButton.UseVisualStyleBackColor = true;
            this.repairUpdateButton.Click += new System.EventHandler(this.repairUpdateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ед. измерения";
            // 
            // measureBox
            // 
            this.measureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.measureBox.FormattingEnabled = true;
            this.measureBox.Items.AddRange(new object[] {
            "шт.",
            "комплект",
            "м",
            "кг"});
            this.measureBox.Location = new System.Drawing.Point(152, 127);
            this.measureBox.Name = "measureBox";
            this.measureBox.Size = new System.Drawing.Size(72, 21);
            this.measureBox.TabIndex = 7;
            // 
            // PartEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.measureBox);
            this.Controls.Add(this.repairUpdateButton);
            this.Controls.Add(this.repairDeleteButton);
            this.Controls.Add(this.repairCreateButton);
            this.Controls.Add(this.repairBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createUpdateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PartEditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PartEditForm_FormClosed);
            this.Load += new System.EventHandler(this.PartEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createUpdateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox repairBox;
        private System.Windows.Forms.Button repairCreateButton;
        private System.Windows.Forms.Button repairDeleteButton;
        private System.Windows.Forms.Button repairUpdateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox measureBox;
    }
}