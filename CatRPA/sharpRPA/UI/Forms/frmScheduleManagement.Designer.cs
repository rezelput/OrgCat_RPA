namespace sharpRPA.UI.Forms
{
    partial class frmScheduleManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleManagement));
            this.txtAppPath = new System.Windows.Forms.TextBox();
            this.cboSelectedScript = new System.Windows.Forms.ComboBox();
            this.lblMainLogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvScheduledTasks = new System.Windows.Forms.DataGridView();
            this.colTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskLastRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskLastResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskNextRunTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChangeTaskStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bgwGetSchedulingInfo = new System.ComponentModel.BackgroundWorker();
            this.tmrGetSchedulingInfo = new System.Windows.Forms.Timer(this.components);
            this.uiBtnShowScheduleManager = new sharpRPA.UI.CustomControls.UIPictureButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uiBtnOk = new sharpRPA.UI.CustomControls.UIPictureButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboRecurType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecurCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoDoNotEnd = new System.Windows.Forms.RadioButton();
            this.rdoEndByDate = new System.Windows.Forms.RadioButton();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnShowScheduleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnOk)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAppPath
            // 
            this.txtAppPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppPath.Location = new System.Drawing.Point(5, 314);
            this.txtAppPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAppPath.Name = "txtAppPath";
            this.txtAppPath.Size = new System.Drawing.Size(683, 29);
            this.txtAppPath.TabIndex = 0;
            // 
            // cboSelectedScript
            // 
            this.cboSelectedScript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectedScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectedScript.FormattingEnabled = true;
            this.cboSelectedScript.Location = new System.Drawing.Point(5, 367);
            this.cboSelectedScript.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSelectedScript.Name = "cboSelectedScript";
            this.cboSelectedScript.Size = new System.Drawing.Size(444, 32);
            this.cboSelectedScript.TabIndex = 2;
            // 
            // lblMainLogo
            // 
            this.lblMainLogo.AutoSize = true;
            this.lblMainLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblMainLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainLogo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMainLogo.Location = new System.Drawing.Point(65, 9);
            this.lblMainLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainLogo.Name = "lblMainLogo";
            this.lblMainLogo.Size = new System.Drawing.Size(463, 46);
            this.lblMainLogo.TabIndex = 4;
            this.lblMainLogo.Text = "Менеджер расписаний";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(0, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Запланированные сценарии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(0, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Создать сценарий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(1, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CatRPA путь...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Скрипт";
            // 
            // dgvScheduledTasks
            // 
            this.dgvScheduledTasks.AllowUserToAddRows = false;
            this.dgvScheduledTasks.AllowUserToDeleteRows = false;
            this.dgvScheduledTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScheduledTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvScheduledTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduledTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTaskName,
            this.colTaskLastRun,
            this.colTaskLastResult,
            this.colTaskNextRunTime,
            this.colTaskState,
            this.colChangeTaskStatus});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScheduledTasks.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvScheduledTasks.Location = new System.Drawing.Point(5, 103);
            this.dgvScheduledTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvScheduledTasks.Name = "dgvScheduledTasks";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScheduledTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvScheduledTasks.RowHeadersWidth = 51;
            this.dgvScheduledTasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvScheduledTasks.Size = new System.Drawing.Size(816, 153);
            this.dgvScheduledTasks.TabIndex = 11;
            this.dgvScheduledTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScheduledTasks_CellContentClick);
            // 
            // colTaskName
            // 
            this.colTaskName.HeaderText = "Task Name";
            this.colTaskName.MinimumWidth = 6;
            this.colTaskName.Name = "colTaskName";
            this.colTaskName.ReadOnly = true;
            this.colTaskName.Width = 114;
            // 
            // colTaskLastRun
            // 
            this.colTaskLastRun.HeaderText = "Last Run";
            this.colTaskLastRun.MinimumWidth = 6;
            this.colTaskLastRun.Name = "colTaskLastRun";
            this.colTaskLastRun.ReadOnly = true;
            this.colTaskLastRun.Width = 96;
            // 
            // colTaskLastResult
            // 
            this.colTaskLastResult.HeaderText = "Last Result";
            this.colTaskLastResult.MinimumWidth = 6;
            this.colTaskLastResult.Name = "colTaskLastResult";
            this.colTaskLastResult.ReadOnly = true;
            this.colTaskLastResult.Width = 111;
            // 
            // colTaskNextRunTime
            // 
            this.colTaskNextRunTime.HeaderText = "Next Run";
            this.colTaskNextRunTime.MinimumWidth = 6;
            this.colTaskNextRunTime.Name = "colTaskNextRunTime";
            this.colTaskNextRunTime.ReadOnly = true;
            this.colTaskNextRunTime.Width = 98;
            // 
            // colTaskState
            // 
            this.colTaskState.HeaderText = "Active";
            this.colTaskState.MinimumWidth = 6;
            this.colTaskState.Name = "colTaskState";
            this.colTaskState.ReadOnly = true;
            this.colTaskState.Width = 76;
            // 
            // colChangeTaskStatus
            // 
            this.colChangeTaskStatus.HeaderText = "Update";
            this.colChangeTaskStatus.MinimumWidth = 6;
            this.colChangeTaskStatus.Name = "colChangeTaskStatus";
            this.colChangeTaskStatus.ReadOnly = true;
            this.colChangeTaskStatus.Width = 61;
            // 
            // bgwGetSchedulingInfo
            // 
            this.bgwGetSchedulingInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGetSchedulingInfo_DoWork);
            this.bgwGetSchedulingInfo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGetSchedulingInfo_RunWorkerCompleted);
            // 
            // tmrGetSchedulingInfo
            // 
            this.tmrGetSchedulingInfo.Enabled = true;
            this.tmrGetSchedulingInfo.Interval = 1000;
            this.tmrGetSchedulingInfo.Tick += new System.EventHandler(this.tmrGetSchedulingInfo_Tick);
            // 
            // uiBtnShowScheduleManager
            // 
            this.uiBtnShowScheduleManager.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnShowScheduleManager.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnShowScheduleManager.DisplayText = "Task Scheduler";
            this.uiBtnShowScheduleManager.DisplayTextBrush = System.Drawing.Color.Black;
            this.uiBtnShowScheduleManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.uiBtnShowScheduleManager.Image = ((System.Drawing.Image)(resources.GetObject("uiBtnShowScheduleManager.Image")));
            this.uiBtnShowScheduleManager.IsMouseOver = false;
            this.uiBtnShowScheduleManager.Location = new System.Drawing.Point(699, 37);
            this.uiBtnShowScheduleManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiBtnShowScheduleManager.Name = "uiBtnShowScheduleManager";
            this.uiBtnShowScheduleManager.Size = new System.Drawing.Size(123, 59);
            this.uiBtnShowScheduleManager.TabIndex = 14;
            this.uiBtnShowScheduleManager.TabStop = false;
            this.uiBtnShowScheduleManager.Click += new System.EventHandler(this.uiBtnShowScheduleManager_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::sharpRPA.Properties.Resources.RPALogo;
            this.pictureBox2.Location = new System.Drawing.Point(5, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // uiBtnOk
            // 
            this.uiBtnOk.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnOk.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnOk.DisplayText = "Add";
            this.uiBtnOk.DisplayTextBrush = System.Drawing.Color.White;
            this.uiBtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.uiBtnOk.Image = ((System.Drawing.Image)(resources.GetObject("uiBtnOk.Image")));
            this.uiBtnOk.IsMouseOver = false;
            this.uiBtnOk.Location = new System.Drawing.Point(239, 69);
            this.uiBtnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiBtnOk.Name = "uiBtnOk";
            this.uiBtnOk.Size = new System.Drawing.Size(73, 59);
            this.uiBtnOk.TabIndex = 1;
            this.uiBtnOk.TabStop = false;
            this.uiBtnOk.Click += new System.EventHandler(this.uiBtnOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cboRecurType);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtRecurCount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rdoDoNotEnd);
            this.panel1.Controls.Add(this.rdoEndByDate);
            this.panel1.Controls.Add(this.dtEndTime);
            this.panel1.Controls.Add(this.dtStartTime);
            this.panel1.Controls.Add(this.uiBtnOk);
            this.panel1.Location = new System.Drawing.Point(5, 415);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 148);
            this.panel1.TabIndex = 15;
            // 
            // cboRecurType
            // 
            this.cboRecurType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRecurType.FormattingEnabled = true;
            this.cboRecurType.Items.AddRange(new object[] {
            "Minutes",
            "Hours",
            "Days"});
            this.cboRecurType.Location = new System.Drawing.Point(287, 28);
            this.cboRecurType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboRecurType.Name = "cboRecurType";
            this.cboRecurType.Size = new System.Drawing.Size(209, 26);
            this.cboRecurType.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(235, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Каждый день";
            // 
            // txtRecurCount
            // 
            this.txtRecurCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecurCount.Location = new System.Drawing.Point(239, 28);
            this.txtRecurCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRecurCount.Name = "txtRecurCount";
            this.txtRecurCount.Size = new System.Drawing.Size(41, 24);
            this.txtRecurCount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Начало";
            // 
            // rdoDoNotEnd
            // 
            this.rdoDoNotEnd.AutoSize = true;
            this.rdoDoNotEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDoNotEnd.ForeColor = System.Drawing.Color.White;
            this.rdoDoNotEnd.Location = new System.Drawing.Point(7, 110);
            this.rdoDoNotEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoDoNotEnd.Name = "rdoDoNotEnd";
            this.rdoDoNotEnd.Size = new System.Drawing.Size(166, 24);
            this.rdoDoNotEnd.TabIndex = 3;
            this.rdoDoNotEnd.TabStop = true;
            this.rdoDoNotEnd.Text = "Не заканчивать";
            this.rdoDoNotEnd.UseVisualStyleBackColor = true;
            // 
            // rdoEndByDate
            // 
            this.rdoEndByDate.AutoSize = true;
            this.rdoEndByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEndByDate.ForeColor = System.Drawing.Color.White;
            this.rdoEndByDate.Location = new System.Drawing.Point(7, 57);
            this.rdoEndByDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoEndByDate.Name = "rdoEndByDate";
            this.rdoEndByDate.Size = new System.Drawing.Size(153, 24);
            this.rdoEndByDate.TabIndex = 2;
            this.rdoEndByDate.TabStop = true;
            this.rdoEndByDate.Text = "Конец по дате";
            this.rdoEndByDate.UseVisualStyleBackColor = true;
            // 
            // dtEndTime
            // 
            this.dtEndTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(7, 81);
            this.dtEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(205, 22);
            this.dtEndTime.TabIndex = 1;
            // 
            // dtStartTime
            // 
            this.dtStartTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(7, 28);
            this.dtStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(205, 22);
            this.dtStartTime.TabIndex = 0;
            // 
            // frmScheduleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundChangeIndex = 268;
            this.ClientSize = new System.Drawing.Size(837, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiBtnShowScheduleManager);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvScheduledTasks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMainLogo);
            this.Controls.Add(this.cboSelectedScript);
            this.Controls.Add(this.txtAppPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmScheduleManagement";
            this.Text = "Schedule Management";
            this.Load += new System.EventHandler(this.frmScheduleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnShowScheduleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnOk)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppPath;
        private sharpRPA.UI.CustomControls.UIPictureButton uiBtnOk;
        private System.Windows.Forms.ComboBox cboSelectedScript;
        private System.Windows.Forms.Label lblMainLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvScheduledTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskLastRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskLastResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskNextRunTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskState;
        private System.Windows.Forms.DataGridViewButtonColumn colChangeTaskStatus;
        private System.ComponentModel.BackgroundWorker bgwGetSchedulingInfo;
        private System.Windows.Forms.Timer tmrGetSchedulingInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private sharpRPA.UI.CustomControls.UIPictureButton uiBtnShowScheduleManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.RadioButton rdoEndByDate;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.RadioButton rdoDoNotEnd;
        private System.Windows.Forms.ComboBox cboRecurType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRecurCount;
        private System.Windows.Forms.Label label5;
    }
}