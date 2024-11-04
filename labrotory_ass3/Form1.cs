using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labrotory_ass3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void subjectsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void gradeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void studentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            // Ensure the "Student ID" field accepts only numeric input
            if (System.Text.RegularExpressions.Regex.IsMatch(studentIDTextBox.Text, @"[^0-9]"))
            {
                studentIDTextBox.Text = studentIDTextBox.Text.Remove(studentIDTextBox.Text.Length - 1);
            }
        }

        private void showDataTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Validate that all required fields are filled out
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(studentIDTextBox.Text))
            {
                MessageBox.Show("Please fill out all required fields.");
                return;
            }

            // Validate that at least one interest checkbox is selected
            bool isAnySubjectSelected = subjectsCheckedListBox.CheckedItems.Count > 0;
            if (isAnySubjectSelected)
            {
                // Display a summary of the entered data
                string summary = $"Full Name: {firstNameTextBox.Text} {lastNameTextBox.Text}\n";
                summary += $"Student ID: {studentIDTextBox.Text}\n";
                summary += $"Gender: {(maleRadioButton.Checked ? "Male" : "Female")}\n";
                summary += "Interests:\n";
                foreach (var subject in subjectsCheckedListBox.CheckedItems)
                {
                    summary += $"- {subject}\n";
                }
                summary += $"Grade Level: {gradeComboBox.SelectedItem}";

                showDataTextBox.Text = summary;
            }
            else
            {
                MessageBox.Show("Please select at least one area of interest.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Reset all form fields
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            studentIDTextBox.Text = string.Empty;
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            subjectsCheckedListBox.ClearSelected();
            gradeComboBox.SelectedIndex = -1;
            showDataTextBox.Text = string.Empty;
        }
    }
}