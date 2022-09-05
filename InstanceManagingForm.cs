using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstancesManagingApp
{
    public partial class InstanceManagingForm : Form
    {
        private string _processName = String.Empty;
        private bool _bCloseCurrentInstance = false;

        private static volatile bool bTerminateApp = false; //Currently unused variable but can be used to in another terminate-all method
        private static List<Task> runningTasksList = new(); //Can also use a Thread Safe Collection (e.g. Concurrency Stack)

        public InstanceManagingForm()
        {
            InitializeComponent();
        }


        #region HIDE_GUI
        private void hideGUIButton_Click(object sender, EventArgs e)
        {
            HideGui();
        }
        private void MittalGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Only hide the form
            if (!_bCloseCurrentInstance)
            {
                e.Cancel = true; // Cancel the close event
                HideGui();
            }
        }

        private void HideGui()
        {
            var result = MessageBox.Show("Are you sure that you would like to hide the form?", "Hide Application",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
        }
        #endregion

        #region TERMINATE_APP
        //Terminate only the GUI on which the "Terminate" button is pressed
        private void terminateAppButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure that you would like to terminate the current App?", "Terminate Application",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _bCloseCurrentInstance = true;
                this.Close();
            }

        }

        //Not Used: Another way of terminating all running instances of GUI
        private void TerminateApp()
        {
            bTerminateApp = true;

            //Close all running instances of GUI on multiple tasks
            lock (((ICollection)runningTasksList).SyncRoot)
            {
                foreach (var instanceThread in runningTasksList)
                {
                    instanceThread.Wait(500);
                }

            }
            Application.Exit();
        }
        #endregion

        #region CREATE_INSTANCE
        //Create New Instance
        private void createInstanceButton_Click(object sender, EventArgs e)
        {
            Task task = Task.Factory.StartNew(() => Application.Run(new InstanceManagingForm()));

            lock (((ICollection)runningTasksList).SyncRoot)
            {
                runningTasksList.Add(task);
            }
        }
        #endregion

        #region KILL_ALL_INSTANCES
        private void killAllInstancesButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure that you would like to kill all the running instances?", "Kill All!",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(_processName))
                    _processName = Process.GetCurrentProcess().ProcessName.ToString();

                var processes = Process.GetProcessesByName(_processName);
                foreach (var process in processes)
                    process.Kill();
            }
        } 
        #endregion
    }
}
