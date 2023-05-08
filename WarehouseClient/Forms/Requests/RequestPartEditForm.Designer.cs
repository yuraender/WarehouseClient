namespace WarehouseClient.Forms.Requests {
    partial class RequestPartEditForm {
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createUpdateButton = new System.Windows.Forms.Button();
            this.partBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reasonBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.measureBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.specificationsBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(72, 71);
            this.nameBox.MaxLength = 50;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(191, 20);
            this.nameBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Деталь";
            // 
            // createUpdateButton
            // 
            this.createUpdateButton.Location = new System.Drawing.Point(200, 310);
            this.createUpdateButton.Name = "createUpdateButton";
            this.createUpdateButton.Size = new System.Drawing.Size(156, 51);
            this.createUpdateButton.TabIndex = 20;
            this.createUpdateButton.Text = "CreateUpdate";
            this.createUpdateButton.UseVisualStyleBackColor = true;
            this.createUpdateButton.Click += new System.EventHandler(this.createUpdateButton_Click);
            // 
            // partBox
            // 
            this.partBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partBox.FormattingEnabled = true;
            this.partBox.Location = new System.Drawing.Point(72, 31);
            this.partBox.Name = "partBox";
            this.partBox.Size = new System.Drawing.Size(191, 21);
            this.partBox.TabIndex = 1;
            this.partBox.SelectedIndexChanged += new System.EventHandler(this.partBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(72, 110);
            this.typeBox.MaxLength = 50;
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(191, 20);
            this.typeBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(72, 226);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(113, 20);
            this.amountBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Группа оборудования";
            // 
            // groupBox
            // 
            this.groupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(72, 265);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(162, 21);
            this.groupBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Обоснование необходимости";
            // 
            // reasonBox
            // 
            this.reasonBox.Location = new System.Drawing.Point(293, 165);
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(191, 20);
            this.reasonBox.TabIndex = 18;
            // 
            // statusBox
            // 
            this.statusBox.AutoSize = true;
            this.statusBox.Enabled = false;
            this.statusBox.Location = new System.Drawing.Point(293, 191);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(60, 17);
            this.statusBox.TabIndex = 19;
            this.statusBox.Text = "Статус";
            this.statusBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(293, 126);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker.TabIndex = 16;
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
            this.measureBox.Location = new System.Drawing.Point(191, 225);
            this.measureBox.Name = "measureBox";
            this.measureBox.Size = new System.Drawing.Size(72, 21);
            this.measureBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Технические характеристики";
            // 
            // specificationsBox
            // 
            this.specificationsBox.Location = new System.Drawing.Point(72, 149);
            this.specificationsBox.MaxLength = 1000;
            this.specificationsBox.Multiline = true;
            this.specificationsBox.Name = "specificationsBox";
            this.specificationsBox.Size = new System.Drawing.Size(191, 58);
            this.specificationsBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ед. измерения";
            // 
            // groupButton
            // 
            this.groupButton.Location = new System.Drawing.Point(240, 264);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(23, 23);
            this.groupButton.TabIndex = 14;
            this.groupButton.Text = "+";
            this.groupButton.UseVisualStyleBackColor = true;
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // RequestPartEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 381);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.specificationsBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.measureBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reasonBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.partBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createUpdateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequestPartEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RequestEditForm";
            this.Load += new System.EventHandler(this.RequestPartEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createUpdateButton;
        private System.Windows.Forms.ComboBox partBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reasonBox;
        private System.Windows.Forms.CheckBox statusBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox measureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox specificationsBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button groupButton;
    }
}