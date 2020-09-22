namespace AverageCalc
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
            this.test = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Grade1 = new System.Windows.Forms.TextBox();
            this.Grade2 = new System.Windows.Forms.TextBox();
            this.Grade3 = new System.Windows.Forms.TextBox();
            this.Grade4 = new System.Windows.Forms.TextBox();
            this.Grade5 = new System.Windows.Forms.TextBox();
            this.Calc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(24, 28);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(118, 13);
            this.test.TabIndex = 0;
            this.test.Text = "Please enter first grade:";
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter second grade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please enter third grade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please enter fourth grade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Please enter fifth grade:";
            // 
            // Grade1
            // 
            this.Grade1.Location = new System.Drawing.Point(187, 28);
            this.Grade1.Name = "Grade1";
            this.Grade1.Size = new System.Drawing.Size(100, 20);
            this.Grade1.TabIndex = 5;
            // 
            // Grade2
            // 
            this.Grade2.Location = new System.Drawing.Point(187, 60);
            this.Grade2.Name = "Grade2";
            this.Grade2.Size = new System.Drawing.Size(100, 20);
            this.Grade2.TabIndex = 6;
            // 
            // Grade3
            // 
            this.Grade3.Location = new System.Drawing.Point(187, 95);
            this.Grade3.Name = "Grade3";
            this.Grade3.Size = new System.Drawing.Size(100, 20);
            this.Grade3.TabIndex = 7;
            // 
            // Grade4
            // 
            this.Grade4.Location = new System.Drawing.Point(187, 129);
            this.Grade4.Name = "Grade4";
            this.Grade4.Size = new System.Drawing.Size(100, 20);
            this.Grade4.TabIndex = 8;
            // 
            // Grade5
            // 
            this.Grade5.Location = new System.Drawing.Point(187, 166);
            this.Grade5.Name = "Grade5";
            this.Grade5.Size = new System.Drawing.Size(100, 20);
            this.Grade5.TabIndex = 9;
            // 
            // Calc
            // 
            this.Calc.BackColor = System.Drawing.Color.Chartreuse;
            this.Calc.Location = new System.Drawing.Point(198, 202);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 10;
            this.Calc.Text = "Calculate";
            this.Calc.UseVisualStyleBackColor = false;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Results:";
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(355, 209);
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.Size = new System.Drawing.Size(100, 20);
            this.Results.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 246);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.Grade5);
            this.Controls.Add(this.Grade4);
            this.Controls.Add(this.Grade3);
            this.Controls.Add(this.Grade2);
            this.Controls.Add(this.Grade1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Grade1;
        private System.Windows.Forms.TextBox Grade2;
        private System.Windows.Forms.TextBox Grade3;
        private System.Windows.Forms.TextBox Grade4;
        private System.Windows.Forms.TextBox Grade5;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Results;
    }
}

