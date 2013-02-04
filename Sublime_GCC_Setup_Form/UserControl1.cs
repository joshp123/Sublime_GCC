using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
            // code to check that 
        }

        private void ST2LaunchPicker_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.sublimetext.com/2");

            if (Environment.Is64BitOperatingSystem == true)
            {
                MessageBox.Show("64 bit operating system detected: please pick the Windows (64 bit) installer, and don't change anything in the installer!");
            }
            else
            {
                MessageBox.Show("Please pick the normal Windows installer (not 64 bit), and don't change anything in the installer!");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please simply select the default options the installer presents. Change nothing!");
            Process.Start("http://sourceforge.net/projects/mingw/files/latest/download?source=files");
        }
    }
}
