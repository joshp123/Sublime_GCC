﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using Microsoft.Win32; // for registry

namespace Sublime_GCC_Setup_Form
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // code to check that mingw exists there
        }

        private void ST2LaunchPicker_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void SetEverythingUp_Click(object sender, EventArgs e)
        {          
            
            if (System.IO.File.Exists(Path.Combine(MinGWPath.Text, @"bin\gcc.exe")) == false)
            {
                MessageBox.Show("MinGW not found at specified location, please check again!");
                return;
            }
            
            // add path variable
            try
            {
                string keyName = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment\";
                string existingPathFolderVariable = (string)Registry.LocalMachine.OpenSubKey(keyName).GetValue("PATH", "", RegistryValueOptions.DoNotExpandEnvironmentNames);
                if (existingPathFolderVariable.Contains(MinGWPath.Text + "\\bin") == false)
                {
                    string newPathFolderVariable = existingPathFolderVariable + ";" + MinGWPath.Text + "\\bin";
                    // only append it to the path variable if it's not already there so you don't get multiple occurences
                    System.Environment.SetEnvironmentVariable("Path", newPathFolderVariable, EnvironmentVariableTarget.Machine);
                }
                
            }
            catch (System.Security.SecurityException)
            {
                MessageBox.Show("You appear to not have the required privileges. Please close the application and start it again as an administrator (right click -> run as admin)");
                Application.Exit();
            }

            
            // add C.sublime build in appdata
            string appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string sublimeTextUserPackagePath = @"Sublime Text 2\Packages\User\C.sublime-build";
            var fileName = Path.Combine(appdataPath,sublimeTextUserPackagePath);

            if (System.IO.File.Exists(fileName) == false)
            {
                if (System.IO.Directory.Exists(Path.GetDirectoryName(fileName)) == false)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(fileName));
                }
            }

            try
            {
                System.IO.File.WriteAllBytes(fileName, Sublime_GCC_Setup_Form.Properties.Resources.C);
            }
            catch (Exception)
            {
                MessageBox.Show("Error accessing C.sublime-build, please ensure that nothing is opening it");
            }

            MessageBox.Show("All done! Hopefully it all works, if not, uh, oops.");
            Application.Exit();
        }

        private void MinGWLaunchPicker_Click(object sender, EventArgs e)
        {
            if (MinGWPathPicker.ShowDialog() == DialogResult.OK)
            {
                MinGWPath.Text = MinGWPathPicker.SelectedPath;
            }
        }

        private void MinGWPathPicker_HelpRequest(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void MinGWDownloadLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please simply select the default options the installer presents. Change nothing!");
            Process.Start("http://sourceforge.net/projects/mingw/files/latest/download?source=files");
        }

        private void ST2DownloadLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Environment.Is64BitOperatingSystem == true)
            {
                MessageBox.Show("64 bit operating system detected: please pick the Windows (64 bit) installer, and don't change anything in the installer!");
            }
            else
            {
                MessageBox.Show("Please pick the normal Windows installer (not 64 bit), and don't change anything in the installer!");
            }

            Process.Start("http://www.sublimetext.com/2");
        }
    }
}
