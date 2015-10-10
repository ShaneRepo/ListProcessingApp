﻿using System;
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
        List<int> numList = new List<int>();
  
        // method to define instructions
        public void Help()
        {
            MessageBox.Show("The app allows you to add numbers to a list, sort them,\n remove them and save/read to/from file.");
        }
        // method to display the list
        public void DisplayList(List<int> numList)
        {
            int[] array = numList.ToArray();
            string output = string.Empty;
            foreach (int item in array)
            {
                output += item + "\n";
            }
            MessageBox.Show(output);
            //Array.Clear(array, 0, array.Length);
            //output = string.Empty;
        }
        // method to convert listbox items to list
        public void ToList()
        {
            numList.Clear();
            //List<string> lb = new List<string>();
             foreach (int nums in lstboxList.Items)
             {
                 numList.Add(nums);
             }
            // numList = lb.ConvertAll<int>(Convert.ToInt32);
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
            Help();
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
            if (!string.IsNullOrWhiteSpace(txtboxAdd.Text))
            {
                int someNum = int.Parse(txtboxAdd.Text);
                lstboxList.Items.Add(someNum).ToString();
                txtboxAdd.Clear();
                txtboxAdd.Focus();
            }
            else
            {
                MessageBox.Show("Enter a integer into the textbox you want to add.");
                txtboxAdd.Focus();
            }
        }
        // give textbox focus on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            txtboxAdd.Focus();
        }
        // clear listbox
        private void button1_Click(object sender, EventArgs e)
        {
            lstboxList.Items.Clear();
        }
        // remove a number from list, clear textbox and validation check
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtboxRemove.Text))
            {
                int someNum = int.Parse(txtboxRemove.Text);
                lstboxList.Items.Remove(someNum);
                txtboxRemove.Clear();
                txtboxRemove.Focus();
            }
            else
            {
                MessageBox.Show("Enter a integer into the textbox you want to remove.");
                txtboxRemove.Focus();
            }
        }
        // allow only numbers entered in textbox
        private void txtboxRemove_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            ToList();
            DisplayList(numList);
        }
    }
    
}
