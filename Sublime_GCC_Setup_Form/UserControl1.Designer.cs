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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.MinGWPathPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MinGWDownloadLink = new System.Windows.Forms.LinkLabel();
            this.ST2DownloadLink = new System.Windows.Forms.LinkLabel();
            this.MinGWDescription = new System.Windows.Forms.Label();
            this.SetEverythingUp = new System.Windows.Forms.Button();
            this.MinGWLaunchPicker = new System.Windows.Forms.Button();
            this.MinGWPath = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinGWPathPicker
            // 
            this.MinGWPathPicker.Description = "Please select where MinGW is installed";
            this.MinGWPathPicker.HelpRequest += new System.EventHandler(this.MinGWPathPicker_HelpRequest);
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
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
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
            this.splitContainer1.Size = new System.Drawing.Size(651, 448);
            this.splitContainer1.SplitterDistance = 407;
            this.splitContainer1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 143);
            this.label2.TabIndex = 11;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Instructions";
            // 
            // MinGWDownloadLink
            // 
            this.MinGWDownloadLink.AutoSize = true;
            this.MinGWDownloadLink.Location = new System.Drawing.Point(480, 43);
            this.MinGWDownloadLink.Name = "MinGWDownloadLink";
            this.MinGWDownloadLink.Size = new System.Drawing.Size(154, 13);
            this.MinGWDownloadLink.TabIndex = 9;
            this.MinGWDownloadLink.TabStop = true;
            this.MinGWDownloadLink.Text = "Click here to download MinGW";
            this.MinGWDownloadLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ST2DownloadLink
            // 
            this.ST2DownloadLink.AutoSize = true;
            this.ST2DownloadLink.Location = new System.Drawing.Point(446, 81);
            this.ST2DownloadLink.Name = "ST2DownloadLink";
            this.ST2DownloadLink.Size = new System.Drawing.Size(188, 13);
            this.ST2DownloadLink.TabIndex = 8;
            this.ST2DownloadLink.TabStop = true;
            this.ST2DownloadLink.Text = "Click here to download Sublime Text 2";
            this.ST2DownloadLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MinGWDescription
            // 
            this.MinGWDescription.AutoSize = true;
            this.MinGWDescription.Location = new System.Drawing.Point(22, 213);
            this.MinGWDescription.Name = "MinGWDescription";
            this.MinGWDescription.Size = new System.Drawing.Size(245, 13);
            this.MinGWDescription.TabIndex = 7;
            this.MinGWDescription.Text = "Path to MinGW installation (typically \"C:\\MinGW\" )";
            this.MinGWDescription.Click += new System.EventHandler(this.label2_Click);
            // 
            // SetEverythingUp
            // 
            this.SetEverythingUp.Location = new System.Drawing.Point(234, 341);
            this.SetEverythingUp.Name = "SetEverythingUp";
            this.SetEverythingUp.Size = new System.Drawing.Size(134, 25);
            this.SetEverythingUp.TabIndex = 3;
            this.SetEverythingUp.Text = "Complete set up!";
            this.SetEverythingUp.UseVisualStyleBackColor = true;
            this.SetEverythingUp.Click += new System.EventHandler(this.SetEverythingUp_Click);
            // 
            // MinGWLaunchPicker
            // 
            this.MinGWLaunchPicker.Location = new System.Drawing.Point(290, 241);
            this.MinGWLaunchPicker.Name = "MinGWLaunchPicker";
            this.MinGWLaunchPicker.Size = new System.Drawing.Size(98, 25);
            this.MinGWLaunchPicker.TabIndex = 2;
            this.MinGWLaunchPicker.Text = "Browse for folder";
            this.MinGWLaunchPicker.UseVisualStyleBackColor = true;
            this.MinGWLaunchPicker.Click += new System.EventHandler(this.MinGWLaunchPicker_Click);
            // 
            // MinGWPath
            // 
            this.MinGWPath.Location = new System.Drawing.Point(24, 241);
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
            this.progressBar1.Size = new System.Drawing.Size(651, 37);
            this.progressBar1.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(651, 448);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
