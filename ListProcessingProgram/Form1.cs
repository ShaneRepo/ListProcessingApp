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
            MessageBox.Show("The app allows you to manipulate a list of integers, search & sort the list, and save and load the list to a file.");
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
        }
        // method to convert listbox items to list
        public void ToList()
        {
            numList.Clear();          
             foreach (int nums in lstboxList.Items)
             {
                 numList.Add(nums);
             }         
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
        // search for a number and occurences + validation/user-proof
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int count = 0;
            ToList();
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                int search = int.Parse(txtSearch.Text);
                if (numList.Contains(search))
                {
                    foreach (int number in numList)
                    {
                        if (number == search)
                        {
                            count++;
                        }
                    }
                    MessageBox.Show("Your number is in the list " + count + " time(s).");
                }
                else
                {
                    MessageBox.Show("Your number is not in the list.");
                }
                txtSearch.Text = "";
                txtSearch.Focus();
            }
            else
            {
                MessageBox.Show("Enter a integer into the textbox you want to search for.");
                txtSearch.Focus();
            }
            
        }
        // allow only numbers entered in textbox
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        // click event to sum the list
        private void btnTotal_Click(object sender, EventArgs e)
        {
            ToList();
            int sum = numList.Sum();
            MessageBox.Show("The sum of the list is: " + sum);
        }
        // click event for displaying the mean
        private void btnMean_Click(object sender, EventArgs e)
        {
            ToList();
            double mean = numList.Average();
            MessageBox.Show("The mean of the list is: " + mean);
        }
        // get the medium
        private void btnMedium_Click(object sender, EventArgs e)
        {
            ToList();
            int numberCount = numList.Count(); 
            int halfIndex = numList.Count()/2; 
            var sortedNumbers = numList.OrderBy(n=>n); 
            double median; 
            if ((numberCount % 2) == 0) 
            { 
                median = ((sortedNumbers.ElementAt(halfIndex) + sortedNumbers.ElementAt((halfIndex - 1)))/ 2); 
            } 
            else 
            { 
                median = sortedNumbers.ElementAt(halfIndex); 
            }
            MessageBox.Show("The median of the list is: " + median);
        }
        // get the mode
        private void btnMode_Click(object sender, EventArgs e)
        {
            ToList();
            int? mode = numList
            .GroupBy(x => x)
            .OrderByDescending(x => x.Count()).ThenBy(x => x.Key)
            .Select(x => (int?)x.Key)
            .FirstOrDefault();
            MessageBox.Show("The mode of the list is: " + mode);
        }
        // get the highest value
        private void btnHigh_Click(object sender, EventArgs e)
        {
            ToList();
            var max = numList.Max();
            MessageBox.Show("The highest value of the list is: " + max);
        }
        // get the lowest value
        private void btnLow_Click(object sender, EventArgs e)
        {
            ToList();
            var min = numList.Min();
            MessageBox.Show("The lowest value of the list is: " + min);
        }
        // load a file from bin\debug folder
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile = File.OpenText("list.txt");
                while (!inputFile.EndOfStream)
                {
                    lstboxList.Items.Add(int.Parse(inputFile.ReadLine()));
                }
                inputFile.Close();
                MessageBox.Show("Your file has been loaded into the listbox.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No file to load. Save a file first then try loading.");
            }
        }
        // save a file to bin\debug folder
        private void btnSave_Click(object sender, EventArgs e)
        {
            ToList();
            try
            {
                StreamWriter outputFile = File.CreateText("list.txt");
                foreach (int i in numList)
                {
                    outputFile.WriteLine(i);
                }
                outputFile.Close();
                MessageBox.Show("Your file has been saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No data to save. Enter values into the list first.");
            }
        }
        // sort ascending order
        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            ToList();
            var ascendingOrder = numList.OrderBy(i => i).ToList();
            numList = ascendingOrder;
            lstboxList.Items.Clear();
            //lstboxList.Items.Add(numList);
            foreach (int item in numList)
            {
                lstboxList.Items.Add(item);
            }
        }
        // sort descending order
        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            ToList();
            var descendingOrder = numList.OrderByDescending(i => i).ToList();
            numList = descendingOrder;
            lstboxList.Items.Clear();
            //lstboxList.Items.Add(numList);
            foreach (int item in numList)
            {
                lstboxList.Items.Add(item);
            }         
        }
    }
    
}
