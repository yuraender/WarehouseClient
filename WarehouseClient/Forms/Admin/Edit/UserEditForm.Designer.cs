namespace WarehouseClient.Forms.Admin.Edit {
    partial class UserEditForm {
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
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createUpdateButton = new System.Windows.Forms.Button();
            this.adminBox = new System.Windows.Forms.CheckBox();
            this.unitBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unitAdminBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(33, 128);
            this.passwordBox.MaxLength = 20;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(191, 20);
            this.passwordBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(33, 89);
            this.loginBox.MaxLength = 16;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(191, 20);
            this.loginBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(33, 50);
            this.nameBox.MaxLength = 100;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(191, 20);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // createUpdateButton
            // 
            this.createUpdateButton.Location = new System.Drawing.Point(50, 290);
            this.createUpdateButton.Name = "createUpdateButton";
            this.createUpdateButton.Size = new System.Drawing.Size(156, 51);
            this.createUpdateButton.TabIndex = 10;
            this.createUpdateButton.Text = "CreateUpdate";
            this.createUpdateButton.UseVisualStyleBackColor = true;
            this.createUpdateButton.Click += new System.EventHandler(this.createUpdateButton_Click);
            // 
            // adminBox
            // 
            this.adminBox.Location = new System.Drawing.Point(33, 194);
            this.adminBox.Name = "adminBox";
            this.adminBox.Size = new System.Drawing.Size(191, 24);
            this.adminBox.TabIndex = 8;
            this.adminBox.Text = "Администратор";
            this.adminBox.UseVisualStyleBackColor = true;
            // 
            // unitBox
            // 
            this.unitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitBox.FormattingEnabled = true;
            this.unitBox.Location = new System.Drawing.Point(33, 167);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(191, 21);
            this.unitBox.TabIndex = 7;
            this.unitBox.SelectedIndexChanged += new System.EventHandler(this.unitBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Подразделение";
            // 
            // unitAdminBox
            // 
            this.unitAdminBox.Location = new System.Drawing.Point(33, 224);
            this.unitAdminBox.Name = "unitAdminBox";
            this.unitAdminBox.Size = new System.Drawing.Size(191, 24);
            this.unitAdminBox.TabIndex = 9;
            this.unitAdminBox.Text = "Администратор подразделения";
            this.unitAdminBox.UseVisualStyleBackColor = true;
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 361);
            this.Controls.Add(this.unitAdminBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.adminBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createUpdateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserEditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserEditForm_FormClosed);
            this.Load += new System.EventHandler(this.PartEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createUpdateButton;
        private System.Windows.Forms.CheckBox adminBox;
        private System.Windows.Forms.ComboBox unitBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox unitAdminBox;
    }
}