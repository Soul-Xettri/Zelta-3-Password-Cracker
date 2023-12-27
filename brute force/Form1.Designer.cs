
namespace brute_force
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
            this.list1 = new System.Windows.Forms.ListBox();
            this.brute = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 15;
            this.list1.Location = new System.Drawing.Point(154, 47);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(370, 199);
            this.list1.TabIndex = 0;
            // 
            // brute
            // 
            this.brute.Location = new System.Drawing.Point(299, 268);
            this.brute.Name = "brute";
            this.brute.Size = new System.Drawing.Size(75, 23);
            this.brute.TabIndex = 1;
            this.brute.Text = "button1";
            this.brute.UseVisualStyleBackColor = true;
            this.brute.Click += new System.EventHandler(this.brute_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(551, 212);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(139, 23);
            this.password.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password);
            this.Controls.Add(this.brute);
            this.Controls.Add(this.list1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.Button brute;
        private System.Windows.Forms.TextBox password;
    }
}

