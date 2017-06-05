namespace myCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 45);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(13, 65);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(59, 38);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(12, 109);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(59, 38);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(12, 153);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(59, 38);
            this.three.TabIndex = 4;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(78, 65);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(59, 38);
            this.four.TabIndex = 3;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(78, 109);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(59, 38);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(77, 153);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(59, 38);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(143, 65);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(59, 38);
            this.seven.TabIndex = 7;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(143, 109);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(59, 38);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(143, 153);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(59, 38);
            this.nine.TabIndex = 9;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(12, 197);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(59, 38);
            this.zero.TabIndex = 10;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(78, 197);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(59, 38);
            this.Dot.TabIndex = 11;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(143, 197);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(59, 38);
            this.clear.TabIndex = 12;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(208, 65);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(59, 38);
            this.divide.TabIndex = 13;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiple
            // 
            this.multiple.Location = new System.Drawing.Point(208, 109);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(59, 38);
            this.multiple.TabIndex = 14;
            this.multiple.Text = "*";
            this.multiple.UseVisualStyleBackColor = true;
            this.multiple.Click += new System.EventHandler(this.multiple_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(208, 153);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(59, 38);
            this.add.TabIndex = 15;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(208, 197);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(59, 38);
            this.subtract.TabIndex = 16;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(13, 239);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(254, 38);
            this.equals.TabIndex = 17;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 289);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.three);
            this.Controls.Add(this.four);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button equals;
    }
}

