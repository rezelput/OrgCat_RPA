namespace sharpRPA.UI.Forms
{
    partial class frmCommandBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommandBrowser));
            this.flwCommandCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.flwCommandSelections = new System.Windows.Forms.FlowLayoutPanel();
            this.uiBtnCancel = new sharpRPA.UI.CustomControls.UIPictureButton();
            this.uiBtnAdd = new sharpRPA.UI.CustomControls.UIPictureButton();
            this.flwCommandDescription = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCommandName = new System.Windows.Forms.Label();
            this.lblFunctionalDescription = new System.Windows.Forms.Label();
            this.lblImplementationDescription = new System.Windows.Forms.Label();
            this.tlpMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlControls = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnAdd)).BeginInit();
            this.flwCommandDescription.SuspendLayout();
            this.tlpMainLayout.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwCommandCategories
            // 
            this.flwCommandCategories.AutoScroll = true;
            this.flwCommandCategories.BackColor = System.Drawing.Color.SteelBlue;
            this.flwCommandCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwCommandCategories.Location = new System.Drawing.Point(0, 25);
            this.flwCommandCategories.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.flwCommandCategories.Name = "flwCommandCategories";
            this.flwCommandCategories.Size = new System.Drawing.Size(444, 492);
            this.flwCommandCategories.TabIndex = 1;
            // 
            // flwCommandSelections
            // 
            this.flwCommandSelections.AutoScroll = true;
            this.flwCommandSelections.BackColor = System.Drawing.Color.SteelBlue;
            this.flwCommandSelections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwCommandSelections.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwCommandSelections.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flwCommandSelections.Location = new System.Drawing.Point(444, 25);
            this.flwCommandSelections.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.flwCommandSelections.Name = "flwCommandSelections";
            this.tlpMainLayout.SetRowSpan(this.flwCommandSelections, 2);
            this.flwCommandSelections.Size = new System.Drawing.Size(353, 565);
            this.flwCommandSelections.TabIndex = 2;
            // 
            // uiBtnCancel
            // 
            this.uiBtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnCancel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnCancel.DisplayText = "Close";
            this.uiBtnCancel.DisplayTextBrush = System.Drawing.Color.White;
            this.uiBtnCancel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("uiBtnCancel.Image")));
            this.uiBtnCancel.IsMouseOver = false;
            this.uiBtnCancel.Location = new System.Drawing.Point(124, 5);
            this.uiBtnCancel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.uiBtnCancel.Name = "uiBtnCancel";
            this.uiBtnCancel.Size = new System.Drawing.Size(107, 63);
            this.uiBtnCancel.TabIndex = 17;
            this.uiBtnCancel.TabStop = false;
            this.uiBtnCancel.Click += new System.EventHandler(this.uiBtnCancel_Click);
            // 
            // uiBtnAdd
            // 
            this.uiBtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnAdd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnAdd.DisplayText = "Add";
            this.uiBtnAdd.DisplayTextBrush = System.Drawing.Color.White;
            this.uiBtnAdd.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("uiBtnAdd.Image")));
            this.uiBtnAdd.IsMouseOver = false;
            this.uiBtnAdd.Location = new System.Drawing.Point(7, 5);
            this.uiBtnAdd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.uiBtnAdd.Name = "uiBtnAdd";
            this.uiBtnAdd.Size = new System.Drawing.Size(107, 63);
            this.uiBtnAdd.TabIndex = 16;
            this.uiBtnAdd.TabStop = false;
            this.uiBtnAdd.Click += new System.EventHandler(this.uiBtnAdd_Click);
            // 
            // flwCommandDescription
            // 
            this.flwCommandDescription.AutoScroll = true;
            this.flwCommandDescription.BackColor = System.Drawing.Color.SteelBlue;
            this.flwCommandDescription.Controls.Add(this.lblCommandName);
            this.flwCommandDescription.Controls.Add(this.lblFunctionalDescription);
            this.flwCommandDescription.Controls.Add(this.lblImplementationDescription);
            this.flwCommandDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwCommandDescription.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwCommandDescription.Location = new System.Drawing.Point(810, 25);
            this.flwCommandDescription.Margin = new System.Windows.Forms.Padding(13, 25, 13, 12);
            this.flwCommandDescription.Name = "flwCommandDescription";
            this.tlpMainLayout.SetRowSpan(this.flwCommandDescription, 2);
            this.flwCommandDescription.Size = new System.Drawing.Size(469, 553);
            this.flwCommandDescription.TabIndex = 18;
            this.flwCommandDescription.Visible = false;
            this.flwCommandDescription.Paint += new System.Windows.Forms.PaintEventHandler(this.flwCommandDescription_Paint);
            // 
            // lblCommandName
            // 
            this.lblCommandName.AutoSize = true;
            this.lblCommandName.BackColor = System.Drawing.Color.Transparent;
            this.lblCommandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommandName.ForeColor = System.Drawing.Color.White;
            this.lblCommandName.Location = new System.Drawing.Point(4, 0);
            this.lblCommandName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommandName.Name = "lblCommandName";
            this.lblCommandName.Size = new System.Drawing.Size(276, 39);
            this.lblCommandName.TabIndex = 19;
            this.lblCommandName.Text = "CommandName";
            // 
            // lblFunctionalDescription
            // 
            this.lblFunctionalDescription.AutoSize = true;
            this.lblFunctionalDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblFunctionalDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunctionalDescription.ForeColor = System.Drawing.Color.White;
            this.lblFunctionalDescription.Location = new System.Drawing.Point(4, 39);
            this.lblFunctionalDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFunctionalDescription.Name = "lblFunctionalDescription";
            this.lblFunctionalDescription.Size = new System.Drawing.Size(203, 31);
            this.lblFunctionalDescription.TabIndex = 8;
            this.lblFunctionalDescription.Text = "FunctionalDesc";
            // 
            // lblImplementationDescription
            // 
            this.lblImplementationDescription.AutoSize = true;
            this.lblImplementationDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblImplementationDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImplementationDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblImplementationDescription.Location = new System.Drawing.Point(4, 70);
            this.lblImplementationDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImplementationDescription.Name = "lblImplementationDescription";
            this.lblImplementationDescription.Size = new System.Drawing.Size(309, 36);
            this.lblImplementationDescription.TabIndex = 9;
            this.lblImplementationDescription.Text = "Implementation Desc";
            // 
            // tlpMainLayout
            // 
            this.tlpMainLayout.BackColor = System.Drawing.Color.SteelBlue;
            this.tlpMainLayout.ColumnCount = 3;
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 444F));
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.Controls.Add(this.flwCommandCategories, 0, 0);
            this.tlpMainLayout.Controls.Add(this.flwCommandDescription, 2, 0);
            this.tlpMainLayout.Controls.Add(this.flwCommandSelections, 1, 0);
            this.tlpMainLayout.Controls.Add(this.pnlControls, 0, 1);
            this.tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpMainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMainLayout.Name = "tlpMainLayout";
            this.tlpMainLayout.RowCount = 2;
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tlpMainLayout.Size = new System.Drawing.Size(1292, 590);
            this.tlpMainLayout.TabIndex = 19;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.uiBtnAdd);
            this.pnlControls.Controls.Add(this.uiBtnCancel);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 517);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(444, 73);
            this.pnlControls.TabIndex = 19;
            // 
            // frmCommandBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundChangeIndex = 255;
            this.ClientSize = new System.Drawing.Size(1292, 590);
            this.Controls.Add(this.tlpMainLayout);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCommandBrowser";
            this.Text = "Command Explorer";
            this.Load += new System.EventHandler(this.frmCommandSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnAdd)).EndInit();
            this.flwCommandDescription.ResumeLayout(false);
            this.flwCommandDescription.PerformLayout();
            this.tlpMainLayout.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flwCommandCategories;
        private System.Windows.Forms.FlowLayoutPanel flwCommandSelections;
        private sharpRPA.UI.CustomControls.UIPictureButton uiBtnCancel;
        private sharpRPA.UI.CustomControls.UIPictureButton uiBtnAdd;
        private System.Windows.Forms.FlowLayoutPanel flwCommandDescription;
        private System.Windows.Forms.Label lblFunctionalDescription;
        private System.Windows.Forms.Label lblImplementationDescription;
        public System.Windows.Forms.Label lblCommandName;
        private System.Windows.Forms.TableLayoutPanel tlpMainLayout;
        private System.Windows.Forms.Panel pnlControls;
    }
}