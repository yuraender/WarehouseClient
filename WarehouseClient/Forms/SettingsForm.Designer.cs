namespace WarehouseClient.Forms {
    partial class SettingsForm {
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
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontBox = new System.Windows.Forms.TextBox();
            this.folderBox = new System.Windows.Forms.TextBox();
            this.fontButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fontDialog
            // 
            this.fontDialog.AllowScriptChange = false;
            this.fontDialog.AllowSimulations = false;
            this.fontDialog.AllowVectorFonts = false;
            this.fontDialog.AllowVerticalFonts = false;
            this.fontDialog.FontMustExist = true;
            this.fontDialog.MaxSize = 14;
            this.fontDialog.ShowEffects = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(143, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шрифт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(84, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Папка для сохранения заявок";
            // 
            // fontBox
            // 
            this.fontBox.Enabled = false;
            this.fontBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fontBox.Location = new System.Drawing.Point(40, 41);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(197, 20);
            this.fontBox.TabIndex = 1;
            // 
            // folderBox
            // 
            this.folderBox.Enabled = false;
            this.folderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.folderBox.Location = new System.Drawing.Point(40, 133);
            this.folderBox.Name = "folderBox";
            this.folderBox.Size = new System.Drawing.Size(197, 20);
            this.folderBox.TabIndex = 4;
            // 
            // fontButton
            // 
            this.fontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fontButton.Location = new System.Drawing.Point(239, 39);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(59, 23);
            this.fontButton.TabIndex = 2;
            this.fontButton.Text = "Выбрать";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // folderButton
            // 
            this.folderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.folderButton.Location = new System.Drawing.Point(239, 131);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(59, 23);
            this.folderButton.TabIndex = 5;
            this.folderButton.Text = "Выбрать";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 191);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.folderBox);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fontBox;
        private System.Windows.Forms.TextBox folderBox;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.Button folderButton;
    }
}