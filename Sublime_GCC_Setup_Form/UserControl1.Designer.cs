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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MinGWDownloadLink = new System.Windows.Forms.LinkLabel();
            this.ST2DownloadLink = new System.Windows.Forms.LinkLabel();
            this.MinGWDescription = new System.Windows.Forms.Label();
            this.SetEverythingUp = new System.Windows.Forms.Button();
            this.MinGWLaunchPicker = new System.Windows.Forms.Button();
            this.MinGWPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MinGWPathPicker
            // 
            this.MinGWPathPicker.Description = "Please select where MinGW is installed";
            this.MinGWPathPicker.HelpRequest += new System.EventHandler(this.MinGWPathPicker_HelpRequest);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 104);
            this.label3.TabIndex = 21;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 143);
            this.label2.TabIndex = 20;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Instructions";
            // 
            // MinGWDownloadLink
            // 
            this.MinGWDownloadLink.AutoSize = true;
            this.MinGWDownloadLink.Location = new System.Drawing.Point(483, 38);
            this.MinGWDownloadLink.Name = "MinGWDownloadLink";
            this.MinGWDownloadLink.Size = new System.Drawing.Size(154, 13);
            this.MinGWDownloadLink.TabIndex = 18;
            this.MinGWDownloadLink.TabStop = true;
            this.MinGWDownloadLink.Text = "Click here to download MinGW";
            this.MinGWDownloadLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MinGWDownloadLink_LinkClicked);
            this.MinGWDownloadLink.Click += new System.EventHandler(this.label2_Click);
            // 
            // ST2DownloadLink
            // 
            this.ST2DownloadLink.AutoSize = true;
            this.ST2DownloadLink.Location = new System.Drawing.Point(449, 67);
            this.ST2DownloadLink.Name = "ST2DownloadLink";
            this.ST2DownloadLink.Size = new System.Drawing.Size(188, 13);
            this.ST2DownloadLink.TabIndex = 17;
            this.ST2DownloadLink.TabStop = true;
            this.ST2DownloadLink.Text = "Click here to download Sublime Text 2";
            this.ST2DownloadLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ST2DownloadLink_LinkClicked);
            this.ST2DownloadLink.Click += new System.EventHandler(this.label1_Click);
            // 
            // MinGWDescription
            // 
            this.MinGWDescription.AutoSize = true;
            this.MinGWDescription.Location = new System.Drawing.Point(25, 227);
            this.MinGWDescription.Name = "MinGWDescription";
            this.MinGWDescription.Size = new System.Drawing.Size(245, 13);
            this.MinGWDescription.TabIndex = 16;
            this.MinGWDescription.Text = "Path to MinGW installation (typically \"C:\\MinGW\" )";
            // 
            // SetEverythingUp
            // 
            this.SetEverythingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetEverythingUp.Location = new System.Drawing.Point(168, 293);
            this.SetEverythingUp.Name = "SetEverythingUp";
            this.SetEverythingUp.Size = new System.Drawing.Size(222, 66);
            this.SetEverythingUp.TabIndex = 15;
            this.SetEverythingUp.Text = "Complete set up!";
            this.SetEverythingUp.UseVisualStyleBackColor = true;
            this.SetEverythingUp.Click += new System.EventHandler(this.SetEverythingUp_Click);
            // 
            // MinGWLaunchPicker
            // 
            this.MinGWLaunchPicker.Location = new System.Drawing.Point(293, 255);
            this.MinGWLaunchPicker.Name = "MinGWLaunchPicker";
            this.MinGWLaunchPicker.Size = new System.Drawing.Size(98, 25);
            this.MinGWLaunchPicker.TabIndex = 14;
            this.MinGWLaunchPicker.Text = "Browse for folder";
            this.MinGWLaunchPicker.UseVisualStyleBackColor = true;
            this.MinGWLaunchPicker.Click += new System.EventHandler(this.MinGWLaunchPicker_Click);
            // 
            // MinGWPath
            // 
            this.MinGWPath.Location = new System.Drawing.Point(27, 255);
            this.MinGWPath.Name = "MinGWPath";
            this.MinGWPath.Size = new System.Drawing.Size(243, 20);
            this.MinGWPath.TabIndex = 13;
            this.MinGWPath.Text = "C:\\MinGW";
            this.MinGWPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinGWDownloadLink);
            this.Controls.Add(this.ST2DownloadLink);
            this.Controls.Add(this.MinGWDescription);
            this.Controls.Add(this.SetEverythingUp);
            this.Controls.Add(this.MinGWLaunchPicker);
            this.Controls.Add(this.MinGWPath);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(662, 383);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog MinGWPathPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel MinGWDownloadLink;
        private System.Windows.Forms.LinkLabel ST2DownloadLink;
        private System.Windows.Forms.Label MinGWDescription;
        private System.Windows.Forms.Button SetEverythingUp;
        private System.Windows.Forms.Button MinGWLaunchPicker;
        private System.Windows.Forms.TextBox MinGWPath;
    }
}
