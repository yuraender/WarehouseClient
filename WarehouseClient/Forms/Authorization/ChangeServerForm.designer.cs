namespace WarehouseClient.Forms.Authorization {
    partial class ChangeServerForm {
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
            this.serverBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverBox
            // 
            this.serverBox.Location = new System.Drawing.Point(12, 25);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(160, 20);
            this.serverBox.TabIndex = 0;
            this.serverBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(55, 76);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Сменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // ChangeServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 111);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.serverBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сменить сервер";
            this.Load += new System.EventHandler(this.ChangeServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverBox;
        private System.Windows.Forms.Button changeButton;
    }
}