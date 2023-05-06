namespace Evaluation_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameTextBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CityTextBox = new TextBox();
            YearOfBirthTextBox = new TextBox();
            FacultyTextBox = new TextBox();
            RoleTextBox = new TextBox();
            SpecificAttributeTextBox = new TextBox();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(227, 92);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(236, 31);
            NameTextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(25, 22);
            button1.Name = "button1";
            button1.Size = new Size(152, 34);
            button1.TabIndex = 2;
            button1.Text = "Choose file ...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 95);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 3;
            label1.Text = "Full Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 147);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 4;
            label2.Text = "Year of birth : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 202);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 5;
            label3.Text = "City :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 258);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 6;
            label4.Text = "Faculty :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 312);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 7;
            label5.Text = "Role :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 366);
            label6.Name = "label6";
            label6.Size = new Size(191, 25);
            label6.TabIndex = 8;
            label6.Text = "[role specific attribute]:";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(227, 199);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(236, 31);
            CityTextBox.TabIndex = 9;
            // 
            // YearOfBirthTextBox
            // 
            YearOfBirthTextBox.Location = new Point(227, 144);
            YearOfBirthTextBox.Name = "YearOfBirthTextBox";
            YearOfBirthTextBox.Size = new Size(236, 31);
            YearOfBirthTextBox.TabIndex = 10;
            // 
            // FacultyTextBox
            // 
            FacultyTextBox.Location = new Point(227, 258);
            FacultyTextBox.Name = "FacultyTextBox";
            FacultyTextBox.Size = new Size(236, 31);
            FacultyTextBox.TabIndex = 11;
            // 
            // RoleTextBox
            // 
            RoleTextBox.Location = new Point(227, 309);
            RoleTextBox.Name = "RoleTextBox";
            RoleTextBox.Size = new Size(236, 31);
            RoleTextBox.TabIndex = 12;
            // 
            // SpecificAttributeTextBox
            // 
            SpecificAttributeTextBox.Location = new Point(227, 363);
            SpecificAttributeTextBox.Name = "SpecificAttributeTextBox";
            SpecificAttributeTextBox.Size = new Size(236, 31);
            SpecificAttributeTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(506, 428);
            Controls.Add(SpecificAttributeTextBox);
            Controls.Add(RoleTextBox);
            Controls.Add(FacultyTextBox);
            Controls.Add(YearOfBirthTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(NameTextBox);
            MaximizeBox = false;
            Name = "Form1";
            Text = "User data display";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox CityTextBox;
        private TextBox YearOfBirthTextBox;
        private TextBox FacultyTextBox;
        private TextBox RoleTextBox;
        private TextBox SpecificAttributeTextBox;
    }
}