namespace WarehouseClient.Forms.Admin {
    partial class LogForm {
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
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.logBox = new System.Windows.Forms.ListBox();
            this.packetBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(187, 12);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDatePicker.TabIndex = 0;
            this.fromDatePicker.ValueChanged += new System.EventHandler(this.fromDatePicker_ValueChanged);
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(393, 12);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 20);
            this.toDatePicker.TabIndex = 1;
            this.toDatePicker.ValueChanged += new System.EventHandler(this.toDatePicker_ValueChanged);
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(12, 38);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(760, 407);
            this.logBox.TabIndex = 2;
            // 
            // packetBox
            // 
            this.packetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.packetBox.FormattingEnabled = true;
            this.packetBox.Location = new System.Drawing.Point(599, 11);
            this.packetBox.Name = "packetBox";
            this.packetBox.Size = new System.Drawing.Size(173, 21);
            this.packetBox.TabIndex = 3;
            this.packetBox.SelectedIndexChanged += new System.EventHandler(this.packetBox_SelectedIndexChanged);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 457);
            this.Controls.Add(this.packetBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.fromDatePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Логи";
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.ComboBox packetBox;
    }
}