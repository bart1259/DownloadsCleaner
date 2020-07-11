namespace DownloadsCleaner.guis
{
    partial class NotificationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fileCheckList = new System.Windows.Forms.CheckedListBox();
            this.deleteNoneButton = new System.Windows.Forms.Button();
            this.laterButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.laterButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.deleteAllButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.deleteSelectedButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fileCheckList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteNoneButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 329);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.BackColor = System.Drawing.Color.White;
            this.deleteAllButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAllButton.Location = new System.Drawing.Point(367, 302);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(115, 24);
            this.deleteAllButton.TabIndex = 4;
            this.deleteAllButton.Text = "Delete All";
            this.deleteAllButton.UseVisualStyleBackColor = false;
            this.deleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.BackColor = System.Drawing.Color.White;
            this.deleteSelectedButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedButton.Location = new System.Drawing.Point(249, 302);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(112, 24);
            this.deleteSelectedButton.TabIndex = 3;
            this.deleteSelectedButton.Text = "Delete Selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = false;
            this.deleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.titleLabel, 4);
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(13, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(469, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Deleting 3 Files in 30s";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileCheckList
            // 
            this.fileCheckList.BackColor = System.Drawing.Color.Black;
            this.fileCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileCheckList.CheckOnClick = true;
            this.tableLayoutPanel1.SetColumnSpan(this.fileCheckList, 4);
            this.fileCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileCheckList.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCheckList.ForeColor = System.Drawing.Color.White;
            this.fileCheckList.FormattingEnabled = true;
            this.fileCheckList.HorizontalScrollbar = true;
            this.fileCheckList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fileCheckList.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "IIIII",
            "J",
            "K",
            "L"});
            this.fileCheckList.Location = new System.Drawing.Point(13, 43);
            this.fileCheckList.Name = "fileCheckList";
            this.fileCheckList.Size = new System.Drawing.Size(469, 253);
            this.fileCheckList.Sorted = true;
            this.fileCheckList.TabIndex = 1;
            // 
            // deleteNoneButton
            // 
            this.deleteNoneButton.BackColor = System.Drawing.Color.White;
            this.deleteNoneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteNoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNoneButton.Location = new System.Drawing.Point(131, 302);
            this.deleteNoneButton.Name = "deleteNoneButton";
            this.deleteNoneButton.Size = new System.Drawing.Size(112, 24);
            this.deleteNoneButton.TabIndex = 2;
            this.deleteNoneButton.Text = "Delete None";
            this.deleteNoneButton.UseVisualStyleBackColor = false;
            this.deleteNoneButton.Click += new System.EventHandler(this.DeleteNoneButton_Click);
            // 
            // laterButton
            // 
            this.laterButton.BackColor = System.Drawing.Color.White;
            this.laterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laterButton.Location = new System.Drawing.Point(13, 302);
            this.laterButton.Name = "laterButton";
            this.laterButton.Size = new System.Drawing.Size(112, 24);
            this.laterButton.TabIndex = 5;
            this.laterButton.Text = "Decide Later";
            this.laterButton.UseVisualStyleBackColor = false;
            this.laterButton.Click += new System.EventHandler(this.LaterButton_Click);
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(495, 329);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NotificationForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.CheckedListBox fileCheckList;
        private System.Windows.Forms.Button deleteNoneButton;
        private System.Windows.Forms.Button laterButton;
    }
}