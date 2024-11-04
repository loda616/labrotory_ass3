namespace labrotory_ass3
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.subjectsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.showDataTextBox = new System.Windows.Forms.TextBox();
            this.gradeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(12, 40);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(12, 68);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.studentIDTextBox.TabIndex = 2;
            this.studentIDTextBox.TextChanged += new System.EventHandler(this.studentIDTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student ID";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(239, 12);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(58, 20);
            this.maleRadioButton.TabIndex = 6;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.maleRadioButton_CheckedChanged);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(239, 40);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(74, 20);
            this.femaleRadioButton.TabIndex = 7;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.femaleRadioButton_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(240, 299);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(113, 47);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // subjectsCheckedListBox
            // 
            this.subjectsCheckedListBox.FormattingEnabled = true;
            this.subjectsCheckedListBox.Items.AddRange(new object[] {
            "Math",
            "Science",
            "Literature"});
            this.subjectsCheckedListBox.Location = new System.Drawing.Point(347, 12);
            this.subjectsCheckedListBox.Name = "subjectsCheckedListBox";
            this.subjectsCheckedListBox.Size = new System.Drawing.Size(120, 89);
            this.subjectsCheckedListBox.TabIndex = 9;
            this.subjectsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.subjectsCheckedListBox_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(121, 299);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(113, 47);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // showDataTextBox
            // 
            this.showDataTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showDataTextBox.Location = new System.Drawing.Point(12, 141);
            this.showDataTextBox.Multiline = true;
            this.showDataTextBox.Name = "showDataTextBox";
            this.showDataTextBox.Size = new System.Drawing.Size(273, 92);
            this.showDataTextBox.TabIndex = 11;
            this.showDataTextBox.Text = "First Name :\r\nLast Nmae :\r\nStudent ID : \r\nGender : \r\nSubject : ";
            this.showDataTextBox.TextChanged += new System.EventHandler(this.showDataTextBox_TextChanged);
            // 
            // gradeComboBox
            // 
            this.gradeComboBox.FormattingEnabled = true;
            this.gradeComboBox.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.gradeComboBox.Location = new System.Drawing.Point(473, 12);
            this.gradeComboBox.Name = "gradeComboBox";
            this.gradeComboBox.Size = new System.Drawing.Size(121, 24);
            this.gradeComboBox.TabIndex = 12;
            this.gradeComboBox.SelectedIndexChanged += new System.EventHandler(this.gradeComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradeComboBox);
            this.Controls.Add(this.showDataTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.subjectsCheckedListBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckedListBox subjectsCheckedListBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox showDataTextBox;
        private System.Windows.Forms.ComboBox gradeComboBox;
    }
}

