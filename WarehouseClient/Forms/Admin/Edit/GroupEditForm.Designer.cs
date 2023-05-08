namespace WarehouseClient.Forms.Admin.Edit {
    partial class GroupEditForm {
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
            this.label2 = new System.Windows.Forms.Label();
            this.unitBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // createUpdateButton
            // 
            this.createUpdateButton.Location = new System.Drawing.Point(50, 240);
            this.createUpdateButton.Name = "createUpdateButton";
            this.createUpdateButton.Size = new System.Drawing.Size(156, 51);
            this.createUpdateButton.TabIndex = 4;
            this.createUpdateButton.Text = "CreateUpdate";
            this.createUpdateButton.UseVisualStyleBackColor = true;
            this.createUpdateButton.Click += new System.EventHandler(this.createUpdateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Подразделение";
            // 
            // unitBox
            // 
            this.unitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitBox.FormattingEnabled = true;
            this.unitBox.Location = new System.Drawing.Point(33, 89);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(191, 21);
            this.unitBox.TabIndex = 3;
            // 
            // GroupEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 311);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createUpdateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GroupEditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GroupEditForm_FormClosed);
            this.Load += new System.EventHandler(this.RoleEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createUpdateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox unitBox;
    }
}