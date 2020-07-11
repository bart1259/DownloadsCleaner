namespace DownloadsCleanerSettingsApplication
{
    partial class CleanerSettingsApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleanerSettingsApplication));
            this.panel1 = new System.Windows.Forms.Panel();
            this.directoryTable = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewDirectoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.delayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.notificationSettingsPanel = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.breakTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.combineTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.decisionTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.defaultActionComboBox = new System.Windows.Forms.ComboBox();
            this.notifyEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.directoryTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumericUpDown)).BeginInit();
            this.notificationSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combineTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decisionTimeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.directoryTable);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 193);
            this.panel1.TabIndex = 0;
            // 
            // directoryTable
            // 
            this.directoryTable.ColumnCount = 5;
            this.directoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.directoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.directoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.directoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.directoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.directoryTable.Controls.Add(this.label5, 4, 0);
            this.directoryTable.Controls.Add(this.label4, 3, 0);
            this.directoryTable.Controls.Add(this.label3, 2, 0);
            this.directoryTable.Controls.Add(this.label1, 0, 0);
            this.directoryTable.Location = new System.Drawing.Point(3, 3);
            this.directoryTable.Margin = new System.Windows.Forms.Padding(1);
            this.directoryTable.Name = "directoryTable";
            this.directoryTable.RowCount = 1;
            this.directoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.directoryTable.Size = new System.Drawing.Size(753, 25);
            this.directoryTable.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(731, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(19, 47);
            this.label5.TabIndex = 5;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(631, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(94, 47);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time Unit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(531, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(94, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(487, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to Directory that will be Searched for Old Files";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addNewDirectoryButton
            // 
            this.addNewDirectoryButton.Location = new System.Drawing.Point(632, 12);
            this.addNewDirectoryButton.Name = "addNewDirectoryButton";
            this.addNewDirectoryButton.Size = new System.Drawing.Size(156, 23);
            this.addNewDirectoryButton.TabIndex = 1;
            this.addNewDirectoryButton.Text = "Add New Directory";
            this.addNewDirectoryButton.UseVisualStyleBackColor = true;
            this.addNewDirectoryButton.Click += new System.EventHandler(this.AddNewDirectoryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(304, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Delay Startup by";
            // 
            // delayNumericUpDown
            // 
            this.delayNumericUpDown.Location = new System.Drawing.Point(418, 244);
            this.delayNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.delayNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.delayNumericUpDown.Name = "delayNumericUpDown";
            this.delayNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.delayNumericUpDown.TabIndex = 3;
            this.delayNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(484, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "minutes";
            // 
            // notificationSettingsPanel
            // 
            this.notificationSettingsPanel.Controls.Add(this.label13);
            this.notificationSettingsPanel.Controls.Add(this.label12);
            this.notificationSettingsPanel.Controls.Add(this.label11);
            this.notificationSettingsPanel.Controls.Add(this.breakTimeNumericUpDown);
            this.notificationSettingsPanel.Controls.Add(this.combineTimeNumericUpDown);
            this.notificationSettingsPanel.Controls.Add(this.label10);
            this.notificationSettingsPanel.Controls.Add(this.label9);
            this.notificationSettingsPanel.Controls.Add(this.decisionTimeNumericUpDown);
            this.notificationSettingsPanel.Controls.Add(this.label8);
            this.notificationSettingsPanel.Controls.Add(this.label7);
            this.notificationSettingsPanel.Controls.Add(this.defaultActionComboBox);
            this.notificationSettingsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationSettingsPanel.ForeColor = System.Drawing.Color.White;
            this.notificationSettingsPanel.Location = new System.Drawing.Point(19, 266);
            this.notificationSettingsPanel.Name = "notificationSettingsPanel";
            this.notificationSettingsPanel.Size = new System.Drawing.Size(769, 137);
            this.notificationSettingsPanel.TabIndex = 5;
            this.notificationSettingsPanel.TabStop = false;
            this.notificationSettingsPanel.Text = "Notification Settings";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(175, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "minutes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(175, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "minutes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(175, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "minutes";
            // 
            // breakTimeNumericUpDown
            // 
            this.breakTimeNumericUpDown.Location = new System.Drawing.Point(109, 82);
            this.breakTimeNumericUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.breakTimeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.breakTimeNumericUpDown.Name = "breakTimeNumericUpDown";
            this.breakTimeNumericUpDown.Size = new System.Drawing.Size(60, 22);
            this.breakTimeNumericUpDown.TabIndex = 12;
            this.breakTimeNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // combineTimeNumericUpDown
            // 
            this.combineTimeNumericUpDown.Location = new System.Drawing.Point(109, 110);
            this.combineTimeNumericUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.combineTimeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.combineTimeNumericUpDown.Name = "combineTimeNumericUpDown";
            this.combineTimeNumericUpDown.Size = new System.Drawing.Size(60, 22);
            this.combineTimeNumericUpDown.TabIndex = 11;
            this.combineTimeNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Combine Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Break Time:";
            // 
            // decisionTimeNumericUpDown
            // 
            this.decisionTimeNumericUpDown.Location = new System.Drawing.Point(109, 25);
            this.decisionTimeNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.decisionTimeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.decisionTimeNumericUpDown.Name = "decisionTimeNumericUpDown";
            this.decisionTimeNumericUpDown.Size = new System.Drawing.Size(60, 22);
            this.decisionTimeNumericUpDown.TabIndex = 7;
            this.decisionTimeNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Decision Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Default action:";
            // 
            // defaultActionComboBox
            // 
            this.defaultActionComboBox.FormattingEnabled = true;
            this.defaultActionComboBox.Items.AddRange(new object[] {
            "Keep",
            "Delete"});
            this.defaultActionComboBox.Location = new System.Drawing.Point(109, 53);
            this.defaultActionComboBox.Name = "defaultActionComboBox";
            this.defaultActionComboBox.Size = new System.Drawing.Size(121, 24);
            this.defaultActionComboBox.TabIndex = 0;
            this.defaultActionComboBox.Text = "Delete";
            // 
            // notifyEnabledCheckBox
            // 
            this.notifyEnabledCheckBox.AutoSize = true;
            this.notifyEnabledCheckBox.Checked = true;
            this.notifyEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notifyEnabledCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyEnabledCheckBox.ForeColor = System.Drawing.Color.White;
            this.notifyEnabledCheckBox.Location = new System.Drawing.Point(21, 240);
            this.notifyEnabledCheckBox.Name = "notifyEnabledCheckBox";
            this.notifyEnabledCheckBox.Size = new System.Drawing.Size(173, 20);
            this.notifyEnabledCheckBox.TabIndex = 6;
            this.notifyEnabledCheckBox.Text = "Notify when deleting files";
            this.notifyEnabledCheckBox.UseVisualStyleBackColor = true;
            this.notifyEnabledCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(21, 409);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(155, 23);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.Location = new System.Drawing.Point(632, 409);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(155, 23);
            this.saveAndCloseButton.TabIndex = 8;
            this.saveAndCloseButton.Text = "Save + Close";
            this.saveAndCloseButton.UseVisualStyleBackColor = true;
            this.saveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(471, 409);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(155, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CleanerSettingsApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.saveAndCloseButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.notifyEnabledCheckBox);
            this.Controls.Add(this.notificationSettingsPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delayNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addNewDirectoryButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CleanerSettingsApplication";
            this.Text = "Download Cleaner";
            this.panel1.ResumeLayout(false);
            this.directoryTable.ResumeLayout(false);
            this.directoryTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumericUpDown)).EndInit();
            this.notificationSettingsPanel.ResumeLayout(false);
            this.notificationSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combineTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decisionTimeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel directoryTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addNewDirectoryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown delayNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox notificationSettingsPanel;
        private System.Windows.Forms.CheckBox notifyEnabledCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox defaultActionComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown decisionTimeNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown combineTimeNumericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown breakTimeNumericUpDown;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button saveAndCloseButton;
        private System.Windows.Forms.Button saveButton;
    }
}

