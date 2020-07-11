using DownloadsCleanerConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadsCleanerSettingsApplication
{
    public partial class CleanerSettingsApplication : Form
    {

        private List<DirectoryRow> _directoryRows = new List<DirectoryRow>();

        public CleanerSettingsApplication()
        {
            InitializeComponent();

            CleanerConfig config = CleanerConfig.ParseConfig(CleanerConfig.DEFAULT_CONFIG_PATH);
            if (config == null)
            {
                config = CleanerConfig.DefaultConfig;
            }

            //Load in config
            for (int i = 0; i < config.SearchedDirectories.Count; i++)
            {
                AddTableEntry();
                _directoryRows[i].SetRowValues(config.SearchedDirectories[i].Path, config.SearchedDirectories[i].FileAgeLimit);
            }
            notifyEnabledCheckBox.Checked = config.DeletionStrategy.Equals("Notify", StringComparison.OrdinalIgnoreCase);
            breakTimeNumericUpDown.Value = config.BreakTime;
            combineTimeNumericUpDown.Value = config.CombineTime;
            delayNumericUpDown.Value = config.DelayedStart;
            decisionTimeNumericUpDown.Value = config.PromptValue;
            defaultActionComboBox.SelectedIndex = config.DefaultKeep ? 0 : 1;
            
        }

        public void AddTableEntry()
        {
            const int rowHeight = 25;

            int rowAddingIndex = directoryTable.RowCount;
            directoryTable.RowCount += 1;
            directoryTable.RowStyles.Add(new RowStyle(SizeType.Absolute, rowHeight));      

            DirectoryRow row = new DirectoryRow();
            row.Make(directoryTable, rowAddingIndex);
            _directoryRows.Add(row);

            directoryTable.Height = directoryTable.RowCount * rowHeight;
        }

        private void AddNewDirectoryButton_Click(object sender, EventArgs e)
        {
            AddTableEntry();
            addNewDirectoryButton.Focus();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            notificationSettingsPanel.Enabled = notifyEnabledCheckBox.Checked;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            SaveConfig();
            Close();
        }

        private void SaveConfig()
        {
            CleanerConfig config = new CleanerConfig();

            //Ensure all rows are valid
            for (int i = _directoryRows.Count - 1; i >= 0; i--)
            {
                if (_directoryRows[i].IsDeleted)
                {
                    _directoryRows.RemoveAt(i);
                }
            }

            for (int i = 0; i < _directoryRows.Count; i++)
            {
                string path = _directoryRows[i].Path;
                int ageLimit = _directoryRows[i].AgeLimit;
                if (config.SearchedDirectories.Contains(new SearchedDirectory(path, ageLimit)) == false)
                {
                    config.SearchedDirectories.Add(new SearchedDirectory(path, ageLimit));
                }
            }

            config.BreakTime = (int)breakTimeNumericUpDown.Value;
            config.PromptValue = (int)decisionTimeNumericUpDown.Value;
            config.CombineTime = (int)combineTimeNumericUpDown.Value;
            config.DelayedStart = (int)delayNumericUpDown.Value;
            config.DeletionStrategy = (notifyEnabledCheckBox.Checked ? "Notify" : "None");
            config.DefaultKeep = defaultActionComboBox.SelectedItem.ToString().Equals("Keep", StringComparison.OrdinalIgnoreCase);

            CleanerConfig.SaveConfigToFile(config, CleanerConfig.DEFAULT_CONFIG_PATH);
        }

    }
}
