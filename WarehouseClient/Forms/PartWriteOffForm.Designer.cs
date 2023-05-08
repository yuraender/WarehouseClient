namespace WarehouseClient.Forms {
    partial class PartWriteOffForm {
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
            this.writeOffButton = new System.Windows.Forms.Button();
            this.partBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.reasonBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // writeOffButton
            // 
            this.writeOffButton.Location = new System.Drawing.Point(50, 290);
            this.writeOffButton.Name = "writeOffButton";
            this.writeOffButton.Size = new System.Drawing.Size(156, 51);
            this.writeOffButton.TabIndex = 10;
            this.writeOffButton.Text = "Списать";
            this.writeOffButton.UseVisualStyleBackColor = true;
            this.writeOffButton.Click += new System.EventHandler(this.writeOffButton_Click);
            // 
            // partBox
            // 
            this.partBox.Enabled = false;
            this.partBox.Location = new System.Drawing.Point(33, 50);
            this.partBox.Name = "partBox";
            this.partBox.Size = new System.Drawing.Size(191, 20);
            this.partBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Деталь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Запрашивающее подразделение";
            // 
            // unitBox
            // 
            this.unitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitBox.Enabled = false;
            this.unitBox.FormattingEnabled = true;
            this.unitBox.Location = new System.Drawing.Point(33, 89);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(191, 21);
            this.unitBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(33, 129);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(191, 20);
            this.amountBox.TabIndex = 5;
            // 
            // reasonBox
            // 
            this.reasonBox.Location = new System.Drawing.Point(33, 168);
            this.reasonBox.Multiline = true;
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(191, 50);
            this.reasonBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Место установки";
            // 
            // PartWriteOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 361);
            this.Controls.Add(this.reasonBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partBox);
            this.Controls.Add(this.writeOffButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartWriteOffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Списание детали";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PartWriteOffForm_FormClosed);
            this.Load += new System.EventHandler(this.PartWriteOffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button writeOffButton;
        private System.Windows.Forms.TextBox partBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox unitBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox reasonBox;
        private System.Windows.Forms.Label label5;
    }
}