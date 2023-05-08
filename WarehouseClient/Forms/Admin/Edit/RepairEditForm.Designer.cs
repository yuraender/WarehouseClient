namespace WarehouseClient.Forms.Admin.Edit {
    partial class RepairEditForm {
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.organizationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createUpdateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dispatchDatePicker = new System.Windows.Forms.DateTimePicker();
            this.returnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.partBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата возврата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата отправки";
            // 
            // organizationBox
            // 
            this.organizationBox.Location = new System.Drawing.Point(33, 50);
            this.organizationBox.MaxLength = 50;
            this.organizationBox.Name = "organizationBox";
            this.organizationBox.Size = new System.Drawing.Size(191, 20);
            this.organizationBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Организация";
            // 
            // createUpdateButton
            // 
            this.createUpdateButton.Location = new System.Drawing.Point(50, 240);
            this.createUpdateButton.Name = "createUpdateButton";
            this.createUpdateButton.Size = new System.Drawing.Size(156, 51);
            this.createUpdateButton.TabIndex = 8;
            this.createUpdateButton.Text = "CreateUpdate";
            this.createUpdateButton.UseVisualStyleBackColor = true;
            this.createUpdateButton.Click += new System.EventHandler(this.createUpdateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Деталь";
            // 
            // dispatchDatePicker
            // 
            this.dispatchDatePicker.Checked = false;
            this.dispatchDatePicker.Location = new System.Drawing.Point(33, 89);
            this.dispatchDatePicker.Name = "dispatchDatePicker";
            this.dispatchDatePicker.Size = new System.Drawing.Size(191, 20);
            this.dispatchDatePicker.TabIndex = 3;
            // 
            // returnDatePicker
            // 
            this.returnDatePicker.Checked = false;
            this.returnDatePicker.Location = new System.Drawing.Point(33, 128);
            this.returnDatePicker.Name = "returnDatePicker";
            this.returnDatePicker.ShowCheckBox = true;
            this.returnDatePicker.Size = new System.Drawing.Size(191, 20);
            this.returnDatePicker.TabIndex = 5;
            // 
            // partBox
            // 
            this.partBox.Enabled = false;
            this.partBox.Location = new System.Drawing.Point(33, 167);
            this.partBox.Name = "partBox";
            this.partBox.Size = new System.Drawing.Size(191, 20);
            this.partBox.TabIndex = 7;
            // 
            // RepairEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 311);
            this.Controls.Add(this.partBox);
            this.Controls.Add(this.returnDatePicker);
            this.Controls.Add(this.dispatchDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.organizationBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createUpdateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RepairEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RepairEditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RepairEditForm_FormClosed);
            this.Load += new System.EventHandler(this.PartEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox organizationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createUpdateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dispatchDatePicker;
        private System.Windows.Forms.DateTimePicker returnDatePicker;
        private System.Windows.Forms.TextBox partBox;
    }
}