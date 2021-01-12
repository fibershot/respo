using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUILearning
{
    public partial class Form1 : Form
    {
        private bool first = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void plusButton_Click(object sender, EventArgs e)
        {
            if (first == false) 
            { 
                MessageBox.Show("Stop pressing this button", "Leave");
                plusButton.Text = ("Don't do it");
                first = true;
            }
            else
            {
                MessageBox.Show("Shutting down.", "Shutdown");
                Application.Exit();
            }
        }
    }
}
