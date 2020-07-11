using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace DownloadsCleanerSettingsApplication
{
    class DirectoryRow
    {
        private static int currentID = 0;

        public bool IsDeleted { get; protected set; } = false;
        public int ID { get; protected set; }
        public int Index { get {
                return _parentPanel.GetRow(_directoryTextBox);
            } }
        public string Path { get {
                return _directoryTextBox.Text;
            } }
        public int AgeLimit { get {

                int timeUnit = 0;
                if (_timeUnitSelector.SelectedIndex == 0)
                {
                    timeUnit = 1;
                } else if (_timeUnitSelector.SelectedIndex == 1)
                {
                    timeUnit = 60;
                } else if (_timeUnitSelector.SelectedIndex == 2)
                {
                    timeUnit = 1440;
                } else if (_timeUnitSelector.SelectedIndex == 3)
                {
                    timeUnit = 10080;
                } else if (_timeUnitSelector.SelectedIndex == 4)
                {
                    timeUnit = 43200;
                }

                return (int)Math.Round(_timeUpDown.Value * timeUnit);
            } }

        private TableLayoutPanel _parentPanel;

        private TextBox _directoryTextBox;
        private Button _directoryLookupButton;
        private NumericUpDown _timeUpDown;
        private ComboBox _timeUnitSelector;
        private Button _removeButton;


        public DirectoryRow()
        {
            //Assign currentID
            ID = currentID;
            currentID++;
        }

        public void Make(TableLayoutPanel table, int index)
        {
            _parentPanel = table;

            _parentPanel.Controls.Add(_directoryTextBox = MakeDirectoryTextBox(), 0, index);
            _parentPanel.Controls.Add(_directoryLookupButton = MakeDirectoryLookUpButton(), 1, index);
            _parentPanel.Controls.Add(_timeUpDown = MakeFrequencyValue(), 2, index);
            _parentPanel.Controls.Add(_timeUnitSelector = MakeTimeSelectionValue(), 3, index);
            _parentPanel.Controls.Add(_removeButton = MakeRemoveButton(), 4, index);
        }

        public void SetRowValues(String path, int minutes)
        {
            _directoryTextBox.Text = path;

            //Set time value
            if (minutes < 60)
            {
                _timeUpDown.Value = Math.Max(1,minutes);
                _timeUnitSelector.SelectedIndex = 0; // minutes
            } else if (minutes < 60 * 48)
            {
                _timeUpDown.Value = Math.Max(1, minutes / 60);
                _timeUnitSelector.SelectedIndex = 1; // hours
            } else if (minutes < 60 * 24 * 14)
            {
                _timeUpDown.Value = Math.Max(1, minutes / (60 * 24));
                _timeUnitSelector.SelectedIndex = 2; // days
            } else if (minutes < 60 * 24 * 59)
            {
                _timeUpDown.Value = Math.Max(1, minutes / (60 * 24 * 7));
                _timeUnitSelector.SelectedIndex = 3; // weeks
            }
            else
            {
                _timeUpDown.Value = Math.Max(1, minutes / (60 * 24 * 30));
                _timeUnitSelector.SelectedIndex = 4; // months
            }
        }

        private Button MakeDirectoryLookUpButton()
        {
            Button button = new Button();
            button.Text = "...";
            button.Click += delegate
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.IsFolderPicker = true;
                CommonFileDialogResult result = dialog.ShowDialog();

                if (result == CommonFileDialogResult.Ok)
                {
                    //Selected a valid folder
                    _directoryTextBox.Text = dialog.FileName;
                }
            };

            return (Button)ProcessControl(button);
        }

        private TextBox MakeDirectoryTextBox()
        {
            TextBox textBox = new TextBox();

            textBox.Text = "c:\\path\\to\\directory";

            return (TextBox)ProcessControl(textBox);
        }

        private NumericUpDown MakeFrequencyValue()
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Value = 7;
            numericUpDown.Minimum = 1;
            numericUpDown.Maximum = 99;
            numericUpDown.MouseWheel += (obj, e) => {
                ((HandledMouseEventArgs)e).Handled = true;
            };

            return (NumericUpDown)ProcessControl(numericUpDown);
        }

        private ComboBox MakeTimeSelectionValue()
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Items.AddRange(new[] { "Minutes", "Hours", "Days", "Weeks", "Months" });
            comboBox.MouseWheel += (obj, e) => {
                ((HandledMouseEventArgs)e).Handled = true;
            };
            comboBox.SelectedIndex = 2;

            return (ComboBox)ProcessControl(comboBox);
        }

        private Button MakeRemoveButton()
        {
            Button button = new Button();
            button.Text = "X";

            button.Click += delegate
            {
                IsDeleted = true;
                int index = Index;
                for (int i = 0; i < _parentPanel.ColumnCount; i++)
                {
                    _parentPanel.GetControlFromPosition(i, index).Dispose();
                }
                Console.WriteLine("Clicked row " + index);

                //Move all additional rows up
                for (int row = index; row < _parentPanel.RowCount - 1; row++)
                {
                    Console.WriteLine("Processing row " + row);
                    for (int col = 0; col < _parentPanel.ColumnCount; col++)
                    {
                        _parentPanel.SetRow(_parentPanel.GetControlFromPosition(col, row + 1), row);
                    }
                }

                _parentPanel.RowCount--;
            };

            return (Button)ProcessControl(button);
        }

        private Control ProcessControl(Control c)
        {
            c.Width = 1000;
            c.Margin = new Padding(1);
            c.TabIndex = 100;
            c.TabStop = false;
            return c;
        }
    }
}
