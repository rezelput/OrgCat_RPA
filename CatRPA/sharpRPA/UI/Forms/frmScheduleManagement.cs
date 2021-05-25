using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;
namespace sharpRPA.UI.Forms
{
    public partial class frmScheduleManagement : UIForm
    {
        string rpaScriptsFolder;
        public frmScheduleManagement()
        {
            InitializeComponent();
        }

        #region Form and Control Events

        private void frmScheduleManagement_Load(object sender, EventArgs e)
        {
            
            txtAppPath.Text = System.Reflection.Assembly.GetEntryAssembly().Location;

            rpaScriptsFolder = Core.Common.GetScriptFolderPath();

            var files = System.IO.Directory.GetFiles(rpaScriptsFolder);

            foreach (var fil in files)
            {
                System.IO.FileInfo newFileInfo = new System.IO.FileInfo(fil);
                cboSelectedScript.Items.Add(newFileInfo.Name);
            }

            colTaskName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            RefreshTasks();
        }
        private void uiBtnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtRecurCount.Text))
            {
                MessageBox.Show("Please indicate a recurrence value!");
                return;
            }

            if (String.IsNullOrEmpty(cboRecurType.Text))
            {
                MessageBox.Show("Please select a recurrence frequency!");
                return;
            }

            if (String.IsNullOrEmpty(cboSelectedScript.Text))
            {
                MessageBox.Show("Please select a script!");
                return;
            }

            var selectedFile = rpaScriptsFolder + cboSelectedScript.Text;

            using (TaskService ts = new TaskService())
            {
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Scheduled task from sharpRPA - " + selectedFile;
                var trigger = new TimeTrigger();

                trigger.StartBoundary = dtStartTime.Value;
                if (rdoEndByDate.Checked)
                {
                    trigger.EndBoundary = dtEndTime.Value;
                }

                double recurParsed;

                if (!double.TryParse(txtRecurCount.Text, out recurParsed))
                {
                    MessageBox.Show("Recur value must be a number type (double)!");
                    return;
                }

                switch (cboRecurType.Text)
                {
                    case "Minutes":
                        trigger.Repetition.Interval = TimeSpan.FromMinutes(recurParsed);
                        break;

                    case "Hours":
                        trigger.Repetition.Interval = TimeSpan.FromHours(recurParsed);
                        break;

                    case "Days":
                        trigger.Repetition.Interval = TimeSpan.FromDays(recurParsed);
                        break;

                    default:
                        break;
                }

                td.Triggers.Add(trigger);

                td.Actions.Add(new ExecAction(@"" + txtAppPath.Text + "", "\"" + selectedFile + "\"", null));
                ts.RootFolder.RegisterTaskDefinition(@"sharpRPA-" + cboSelectedScript.Text, td);
            }
        }
        private void uiBtnShowScheduleManager_Click(object sender, EventArgs e)
        {
            using (TaskService ts = new TaskService())
                ts.StartSystemTaskSchedulerManager();
        }
        private void dgvScheduledTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvScheduledTasks.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int row = this.dgvScheduledTasks.CurrentCell.RowIndex;
                using (TaskService ts = new TaskService())
                {
                    string taskName = (string)dgvScheduledTasks.Rows[row].Cells["colTaskName"].Value;
                    var updateTask = ts.FindTask(taskName);
                    updateTask.Enabled = !updateTask.Enabled;
                }

                using (TaskService ts = new TaskService())
                {
                    //disable task
                    var taskToDisable = ts.FindTask("Some_Task_Name");
                    taskToDisable.Enabled = false;
                }
            }
        }

        #endregion Form and Control Events

        #region BackgroundWorker, Timer

        //events for background worker and associated methods
        private void RefreshTasks()
        {
            bgwGetSchedulingInfo.RunWorkerAsync();
        }
        private void tmrGetSchedulingInfo_Tick(object sender, EventArgs e)
        {
            if (!bgwGetSchedulingInfo.IsBusy)
                bgwGetSchedulingInfo.RunWorkerAsync();
        }
        private void bgwGetSchedulingInfo_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Object[]> scheduledTaskList = new List<Object[]>();

            using (TaskService ts = new TaskService())
            {
                foreach (Microsoft.Win32.TaskScheduler.Task task in ts.RootFolder.Tasks)
                {
                    if (task.Name.Contains("sharpRPA"))
                    {
                        string currentState = "enable";
                        if (task.Enabled)
                            currentState = "disable";

                        var scheduleItem = new object[] { task.Name, task.LastRunTime, task.LastTaskResult, task.NextRunTime, task.IsActive, currentState };
                        scheduledTaskList.Add(scheduleItem);
                    }
                }
            }

            e.Result = scheduledTaskList;
        }
        private void bgwGetSchedulingInfo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvScheduledTasks.Rows.Clear();
            List<object[]> datagridRows = (List<object[]>)e.Result;
            datagridRows.ForEach(itm => dgvScheduledTasks.Rows.Add(itm[0], itm[1], itm[2], itm[3], itm[4], itm[5]));
        }

        #endregion BackgroundWorker, Timer
    }
}