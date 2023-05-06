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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(227, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 31);
            textBox2.TabIndex = 1;
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
            label1.Click += label1_Click;
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
            // textBox3
            // 
            textBox3.Location = new Point(227, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(227, 199);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(227, 309);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(236, 31);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(227, 363);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(236, 31);
            textBox6.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(506, 428);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "User data display";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}