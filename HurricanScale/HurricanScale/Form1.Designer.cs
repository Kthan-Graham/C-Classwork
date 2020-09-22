namespace HurricanScale
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
            this.label1 = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.TextBox();
            this.notificationText = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter Wind Speed here:";
            // 
            // windSpeed
            // 
            this.windSpeed.AcceptsReturn = true;
            this.windSpeed.Location = new System.Drawing.Point(194, 58);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(100, 20);
            this.windSpeed.TabIndex = 1;
            this.windSpeed.TextChanged += new System.EventHandler(this.windSpeed_TextChanged);
            // 
            // notificationText
            // 
            this.notificationText.AutoSize = true;
            this.notificationText.ForeColor = System.Drawing.Color.Black;
            this.notificationText.Location = new System.Drawing.Point(33, 103);
            this.notificationText.Name = "notificationText";
            this.notificationText.Size = new System.Drawing.Size(485, 13);
            this.notificationText.TabIndex = 2;
            this.notificationText.Text = "Based off of the Saffir-Simpson Hurrican Scale the Wind Speed you entered above i" +
    "s equivalient to a:";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.ForeColor = System.Drawing.Color.Black;
            this.Output.Location = new System.Drawing.Point(524, 103);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 13);
            this.Output.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(300, 56);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 5;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.notificationText);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox windSpeed;
        private System.Windows.Forms.Label notificationText;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Enter;
    }
}

