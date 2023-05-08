namespace WarehouseClient.Forms.Requests {
    partial class RequestEditForm {
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
            this.requesterBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createUpdateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.partGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // requesterBox
            // 
            this.requesterBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.requesterBox.Enabled = false;
            this.requesterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.requesterBox.Location = new System.Drawing.Point(229, 41);
            this.requesterBox.Name = "requesterBox";
            this.requesterBox.Size = new System.Drawing.Size(191, 20);
            this.requesterBox.TabIndex = 1;
            this.requesterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(229, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запрашивающий";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createUpdateButton
            // 
            this.createUpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.createUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.createUpdateButton.Location = new System.Drawing.Point(253, 387);
            this.createUpdateButton.Name = "createUpdateButton";
            this.createUpdateButton.Size = new System.Drawing.Size(156, 51);
            this.createUpdateButton.TabIndex = 7;
            this.createUpdateButton.Text = "CreateUpdate";
            this.createUpdateButton.UseVisualStyleBackColor = true;
            this.createUpdateButton.Click += new System.EventHandler(this.createUpdateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.deleteButton.Location = new System.Drawing.Point(561, 276);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.updateButton.Location = new System.Drawing.Point(561, 247);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.createButton.Location = new System.Drawing.Point(561, 218);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(111, 23);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Добавить";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // completeButton
            // 
            this.completeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.completeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.completeButton.Location = new System.Drawing.Point(561, 126);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(111, 23);
            this.completeButton.TabIndex = 3;
            this.completeButton.Text = "Выполнить";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // partGridView
            // 
            this.partGridView.AllowUserToAddRows = false;
            this.partGridView.AllowUserToDeleteRows = false;
            this.partGridView.AllowUserToOrderColumns = true;
            this.partGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.partGridView.Location = new System.Drawing.Point(45, 67);
            this.partGridView.Name = "partGridView";
            this.partGridView.ReadOnly = true;
            this.partGridView.RowHeadersVisible = false;
            this.partGridView.Size = new System.Drawing.Size(500, 300);
            this.partGridView.TabIndex = 2;
            // 
            // RequestEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.partGridView);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.requesterBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createUpdateButton);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "RequestEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RequestEditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RequestEditForm_FormClosed);
            this.Load += new System.EventHandler(this.RequestEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox requesterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createUpdateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.DataGridView partGridView;
    }
}