namespace FemtoControl
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
            this.Run_Scripts = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Run_Scripts
            // 
            this.Run_Scripts.Location = new System.Drawing.Point(12, 12);
            this.Run_Scripts.Name = "Run_Scripts";
            this.Run_Scripts.Size = new System.Drawing.Size(75, 23);
            this.Run_Scripts.TabIndex = 0;
            this.Run_Scripts.Text = "Run_Scripts";
            this.Run_Scripts.UseVisualStyleBackColor = true;
            this.Run_Scripts.Click += new System.EventHandler(this.Run_Scripts_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(608, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 457);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 483);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Run_Scripts);
            this.Name = "Form1";
            this.Text = "FemtoControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Run_Scripts;
        private System.Windows.Forms.TextBox textBox1;
    }
}

