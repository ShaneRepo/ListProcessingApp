using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListProcessingProgram
{
    public partial class Form1 : Form
    {
        // global stream objects
        StreamWriter outputFile;
        StreamReader inputFile;
        // global list object to hold integers
        List<int> nums = new List<int>();

        // method to define instructions
        public void help()
        {
            MessageBox.Show("The app allows you to add numbers to a list, sort them,\n remove them and save/read to/from file.");
        }

        public Form1()
        {
            InitializeComponent();
        }

        // exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // button call help method
        private void btnHelp_Click(object sender, EventArgs e)
        {
            help();
        }

        // allow only numbers entered in textbox
        private void txtboxAdd_KeyPress(object sender, KeyPressEventArgs e)
        {          
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        // add a number to the listbox, clear textbox and add focus for another entry
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int someNum = int.Parse(txtboxAdd.Text);
            lstboxList.Items.Add(someNum).ToString();
            txtboxAdd.Clear();
            txtboxAdd.Focus();
        }

        // give textbox focus on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            txtboxAdd.Focus();
        }
    }
    
}
