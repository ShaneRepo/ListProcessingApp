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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            help();
        }
    }
    
}
