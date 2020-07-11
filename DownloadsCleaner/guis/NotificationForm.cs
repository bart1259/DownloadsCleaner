using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DownloadsCleaner.guis
{
    public partial class NotificationForm : Form
    {
        public delegate void submitCallBack(List<DeletableItem> deletedFiles, List<DeletableItem> whiteListedFiles, bool delayed);

        private submitCallBack _callback;
        private List<DeletableItem> _filesToDelete;
        private Thread _timerThread;
        private bool _done = false;
        private bool _defaultKeep;

        /// <summary>
        /// Creates a new form to notify the user of the files that are about to be deleted
        /// </summary>
        /// <param name="filesToDelete">The files that will potentially be deleted</param>
        /// <param name="timeLimit">The amount of time to cancel the deletion before the are deleted</param>
        /// <param name="callback">The calback for when the decision has been made</param>
        public NotificationForm(List<DeletableItem> filesToDelete, int timeLimit, bool defaultKeep, submitCallBack callback)
        {
            InitializeComponent();

            _callback = callback;
            _defaultKeep = defaultKeep;
            _filesToDelete = filesToDelete;
            _timerThread = new Thread(() =>
            {
                //Ensure window handle is created
                while (IsHandleCreated == false)
                {
                    Thread.Sleep(10);
                }

                for (int i = timeLimit * 60; i >= 0; i--)
                {
                    //Update UI
                    titleLabel.Invoke(new MethodInvoker(() =>
                    {
                        titleLabel.Text = "Deleting " + filesToDelete.Count + " Files in " + i + "s";
                    }));
                    //Sleep for 1 second
                    Thread.Sleep(1000);
                }

                if (_done == false)
                {
                    DeleteSelected();
                }
            });
            _timerThread.Start();

            //Put form in right place
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height);

            //Register close event
            FormClosing += NotificationForm_FormClosing;
            titleLabel.Text = "Deleting " + filesToDelete.Count + " Files in " + (timeLimit * 60) + "s";

            //Set checklist values
            fileCheckList.Items.Clear();
            for (int i = 0; i < filesToDelete.Count; i++)
            {
                fileCheckList.Items.Add(filesToDelete[i], !_defaultKeep);
            }
        }

        private void DeleteFiles(List<DeletableItem> filesToDelete, List<DeletableItem> whiteListedFiles, bool delayed = false)
        {
            if (_done)
            {
                return;
            }
            _done = true;
            _callback(filesToDelete, whiteListedFiles, delayed);

            //Call crossthread safe close
            Invoke(new MethodInvoker(() => Close()));

            //Abort timer thread
            _timerThread.Abort();
        }

        private void NotificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteFiles(_filesToDelete, new List<DeletableItem>());
        }

        private void DeleteNoneButton_Click(object sender, EventArgs e)
        {
            DeleteFiles(new List<DeletableItem>(), _filesToDelete);
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        private void DeleteSelected()
        {
            List<DeletableItem> checkedFiles = new List<DeletableItem>();
            List<DeletableItem> uncheckedFiles = new List<DeletableItem>();
            for (int i = 0; i < fileCheckList.Items.Count; i++)
            {
                DeletableItem item = (DeletableItem)fileCheckList.Items[i];

                if (fileCheckList.GetItemChecked(i))
                {
                    checkedFiles.Add(item);
                }
                else
                {
                    uncheckedFiles.Add(item);
                }
            }
            DeleteFiles(checkedFiles, uncheckedFiles);
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            DeleteFiles(_filesToDelete, new List<DeletableItem>());
        }

        private void LaterButton_Click(object sender, EventArgs e)
        {
            DeleteFiles(new List<DeletableItem>(), new List<DeletableItem>(), true);
        }

        #region NoFocusOnTop

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        private const int WS_EX_TOPMOST = 0x00000008;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_TOPMOST;
                return createParams;
            }
        }

        #endregion
    }
}
