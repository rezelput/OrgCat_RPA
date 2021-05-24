namespace sharpRPA.UI.Forms
{
    partial class frmScriptEngine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScriptEngine));
            this.bgwRunScript = new System.ComponentModel.BackgroundWorker();
            this.lstSteppingCommands = new System.Windows.Forms.ListBox();
            this.tmrNotify = new System.Windows.Forms.Timer(this.components);
            this.lblCloseTimer = new System.Windows.Forms.Label();
            this.lblMainLogo = new System.Windows.Forms.Label();
            this.uiBtnCancel = new sharpRPA.UI.CustomControls.UIPictureButton();
            this.uiBtnPause = new sharpRPA.UI.CustomControls.UIPictureButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnPause)).BeginInit();
            this.SuspendLayout();
            // 
            // bgwRunScript
            // 
            this.bgwRunScript.WorkerReportsProgress = true;
            this.bgwRunScript.WorkerSupportsCancellation = true;
            this.bgwRunScript.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRunScript_DoWork);
            this.bgwRunScript.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwRunScript_ProgressChanged);
            this.bgwRunScript.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwRunScript_RunWorkerCompleted);
            // 
            // lstSteppingCommands
            // 
            this.lstSteppingCommands.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSteppingCommands.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstSteppingCommands.FormattingEnabled = true;
            this.lstSteppingCommands.ItemHeight = 21;
            this.lstSteppingCommands.Location = new System.Drawing.Point(9, 64);
            this.lstSteppingCommands.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSteppingCommands.Name = "lstSteppingCommands";
            this.lstSteppingCommands.Size = new System.Drawing.Size(805, 130);
            this.lstSteppingCommands.TabIndex = 0;
            // 
            // tmrNotify
            // 
            this.tmrNotify.Interval = 5000;
            this.tmrNotify.Tick += new System.EventHandler(this.autoCloseTimer_Tick);
            // 
            // lblCloseTimer
            // 
            this.lblCloseTimer.AutoSize = true;
            this.lblCloseTimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseTimer.ForeColor = System.Drawing.Color.White;
            this.lblCloseTimer.Location = new System.Drawing.Point(16, 217);
            this.lblCloseTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCloseTimer.Name = "lblCloseTimer";
            this.lblCloseTimer.Size = new System.Drawing.Size(0, 23);
            this.lblCloseTimer.TabIndex = 3;
            // 
            // lblMainLogo
            // 
            this.lblMainLogo.AutoSize = true;
            this.lblMainLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblMainLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainLogo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMainLogo.Location = new System.Drawing.Point(13, 9);
            this.lblMainLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainLogo.Name = "lblMainLogo";
            this.lblMainLogo.Size = new System.Drawing.Size(216, 46);
            this.lblMainLogo.TabIndex = 4;
            this.lblMainLogo.Text = "debug info";
            // 
            // uiBtnCancel
            // 
            this.uiBtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnCancel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnCancel.DisplayText = "Cancel";
            this.uiBtnCancel.DisplayTextBrush = System.Drawing.Color.Black;
            this.uiBtnCancel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("uiBtnCancel.Image")));
            this.uiBtnCancel.IsMouseOver = false;
            this.uiBtnCancel.Location = new System.Drawing.Point(748, 2);
            this.uiBtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiBtnCancel.Name = "uiBtnCancel";
            this.uiBtnCancel.Size = new System.Drawing.Size(64, 59);
            this.uiBtnCancel.TabIndex = 14;
            this.uiBtnCancel.TabStop = false;
            this.uiBtnCancel.Click += new System.EventHandler(this.uiBtnCancel_Click);
            // 
            // uiBtnPause
            // 
            this.uiBtnPause.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnPause.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnPause.DisplayText = "Pause";
            this.uiBtnPause.DisplayTextBrush = System.Drawing.Color.Black;
            this.uiBtnPause.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnPause.Image = global::sharpRPA.Properties.Resources.pause;
            this.uiBtnPause.IsMouseOver = false;
            this.uiBtnPause.Location = new System.Drawing.Point(676, 2);
            this.uiBtnPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiBtnPause.Name = "uiBtnPause";
            this.uiBtnPause.Size = new System.Drawing.Size(64, 59);
            this.uiBtnPause.TabIndex = 15;
            this.uiBtnPause.TabStop = false;
            this.uiBtnPause.Click += new System.EventHandler(this.uiBtnPause_Click);
            // 
            // frmScriptEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundChangeIndex = 92;
            this.ClientSize = new System.Drawing.Size(828, 228);
            this.Controls.Add(this.uiBtnPause);
            this.Controls.Add(this.uiBtnCancel);
            this.Controls.Add(this.lblMainLogo);
            this.Controls.Add(this.lblCloseTimer);
            this.Controls.Add(this.lstSteppingCommands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmScriptEngine";
            this.Text = "frmProcessingStatus";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmScriptEngine_FormClosing);
            this.Load += new System.EventHandler(this.frmProcessingStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgwRunScript;
        private System.Windows.Forms.ListBox lstSteppingCommands;
        private System.Windows.Forms.Timer tmrNotify;
        private System.Windows.Forms.Label lblCloseTimer;
        private System.Windows.Forms.Label lblMainLogo;
        private sharpRPA.UI.CustomControls.UIPictureButton uiBtnCancel;
        private sharpRPA.UI.CustomControls.UIPictureButton uiBtnPause;
    }
}