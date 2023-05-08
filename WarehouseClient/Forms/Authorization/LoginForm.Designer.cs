namespace WarehouseClient.Forms.Authorization {
    partial class LoginForm {
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
            this.rememberBox = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.ComboBox();
            this.serverLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rememberBox
            // 
            this.rememberBox.AutoSize = true;
            this.rememberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rememberBox.Location = new System.Drawing.Point(62, 236);
            this.rememberBox.Name = "rememberBox";
            this.rememberBox.Size = new System.Drawing.Size(88, 17);
            this.rememberBox.TabIndex = 5;
            this.rememberBox.Text = "Запомнить?";
            this.rememberBox.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.loginButton.Location = new System.Drawing.Point(118, 351);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(150, 50);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.passwordBox.Location = new System.Drawing.Point(62, 210);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(260, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.passwordLabel.Location = new System.Drawing.Point(59, 194);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loginLabel.Location = new System.Drawing.Point(59, 154);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Логин";
            // 
            // loginBox
            // 
            this.loginBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.loginBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loginBox.FormattingEnabled = true;
            this.loginBox.Location = new System.Drawing.Point(62, 170);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(260, 21);
            this.loginBox.TabIndex = 2;
            this.loginBox.SelectedIndexChanged += new System.EventHandler(this.loginBox_SelectedIndexChanged);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.serverLabel.Location = new System.Drawing.Point(310, 9);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(62, 13);
            this.serverLabel.TabIndex = 7;
            this.serverLabel.TabStop = true;
            this.serverLabel.Text = "IP сервера";
            this.serverLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.serverLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(94, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 441);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.rememberBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox rememberBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.ComboBox loginBox;
        private System.Windows.Forms.LinkLabel serverLabel;
        private System.Windows.Forms.Label label1;
    }
}