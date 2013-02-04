namespace Sublime_GCC_Setup_Form
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MinGWPathPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MinGWDescription = new System.Windows.Forms.Label();
            this.SetEverythingUp = new System.Windows.Forms.Button();
            this.MinGWLaunchPicker = new System.Windows.Forms.Button();
            this.MinGWPath = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ST2DownloadLink = new System.Windows.Forms.LinkLabel();
            this.MinGWDownloadLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinGWPathPicker
            // 
            this.MinGWPathPicker.Description = "Please select where MinGW is installed";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MinGWDownloadLink);
            this.splitContainer1.Panel1.Controls.Add(this.ST2DownloadLink);
            this.splitContainer1.Panel1.Controls.Add(this.MinGWDescription);
            this.splitContainer1.Panel1.Controls.Add(this.SetEverythingUp);
            this.splitContainer1.Panel1.Controls.Add(this.MinGWLaunchPicker);
            this.splitContainer1.Panel1.Controls.Add(this.MinGWPath);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Size = new System.Drawing.Size(428, 321);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 1;
            // 
            // MinGWDescription
            // 
            this.MinGWDescription.AutoSize = true;
            this.MinGWDescription.Location = new System.Drawing.Point(22, 144);
            this.MinGWDescription.Name = "MinGWDescription";
            this.MinGWDescription.Size = new System.Drawing.Size(245, 13);
            this.MinGWDescription.TabIndex = 7;
            this.MinGWDescription.Text = "Path to MinGW installation (typically \"C:\\MinGW\" )";
            this.MinGWDescription.Click += new System.EventHandler(this.label2_Click);
            // 
            // SetEverythingUp
            // 
            this.SetEverythingUp.Location = new System.Drawing.Point(157, 254);
            this.SetEverythingUp.Name = "SetEverythingUp";
            this.SetEverythingUp.Size = new System.Drawing.Size(134, 25);
            this.SetEverythingUp.TabIndex = 3;
            this.SetEverythingUp.Text = "Complete set up!";
            this.SetEverythingUp.UseVisualStyleBackColor = true;
            this.SetEverythingUp.Click += new System.EventHandler(this.SetEverythingUp_Click);
            // 
            // MinGWLaunchPicker
            // 
            this.MinGWLaunchPicker.Location = new System.Drawing.Point(281, 163);
            this.MinGWLaunchPicker.Name = "MinGWLaunchPicker";
            this.MinGWLaunchPicker.Size = new System.Drawing.Size(98, 25);
            this.MinGWLaunchPicker.TabIndex = 2;
            this.MinGWLaunchPicker.Text = "Browse for folder";
            this.MinGWLaunchPicker.UseVisualStyleBackColor = true;
            // 
            // MinGWPath
            // 
            this.MinGWPath.Location = new System.Drawing.Point(22, 163);
            this.MinGWPath.Name = "MinGWPath";
            this.MinGWPath.Size = new System.Drawing.Size(243, 20);
            this.MinGWPath.TabIndex = 1;
            this.MinGWPath.Text = "C:\\MinGW";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(428, 25);
            this.progressBar1.TabIndex = 0;
            // 
            // ST2DownloadLink
            // 
            this.ST2DownloadLink.AutoSize = true;
            this.ST2DownloadLink.Location = new System.Drawing.Point(57, 44);
            this.ST2DownloadLink.Name = "ST2DownloadLink";
            this.ST2DownloadLink.Size = new System.Drawing.Size(188, 13);
            this.ST2DownloadLink.TabIndex = 8;
            this.ST2DownloadLink.TabStop = true;
            this.ST2DownloadLink.Text = "Click here to download Sublime Text 2";
            this.ST2DownloadLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MinGWDownloadLink
            // 
            this.MinGWDownloadLink.AutoSize = true;
            this.MinGWDownloadLink.Location = new System.Drawing.Point(57, 71);
            this.MinGWDownloadLink.Name = "MinGWDownloadLink";
            this.MinGWDownloadLink.Size = new System.Drawing.Size(154, 13);
            this.MinGWDownloadLink.TabIndex = 9;
            this.MinGWDownloadLink.TabStop = true;
            this.MinGWDownloadLink.Text = "Click here to download MinGW";
            this.MinGWDownloadLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(428, 321);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog MinGWPathPicker;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button SetEverythingUp;
        private System.Windows.Forms.Button MinGWLaunchPicker;
        private System.Windows.Forms.TextBox MinGWPath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label MinGWDescription;
        private System.Windows.Forms.LinkLabel ST2DownloadLink;
        private System.Windows.Forms.LinkLabel MinGWDownloadLink;
    }
}
