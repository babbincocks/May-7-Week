namespace Phonebook
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
            this.lbNames = new System.Windows.Forms.ListBox();
            this.txtPhoneOutput = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNames
            // 
            this.lbNames.FormattingEnabled = true;
            this.lbNames.Location = new System.Drawing.Point(14, 32);
            this.lbNames.Name = "lbNames";
            this.lbNames.Size = new System.Drawing.Size(187, 134);
            this.lbNames.TabIndex = 0;
            this.lbNames.SelectedIndexChanged += new System.EventHandler(this.lbNames_SelectedIndexChanged);
            // 
            // txtPhoneOutput
            // 
            this.txtPhoneOutput.Location = new System.Drawing.Point(228, 121);
            this.txtPhoneOutput.Name = "txtPhoneOutput";
            this.txtPhoneOutput.ReadOnly = true;
            this.txtPhoneOutput.Size = new System.Drawing.Size(129, 20);
            this.txtPhoneOutput.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(146, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 24);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPhoneOutput);
            this.Controls.Add(this.lbNames);
            this.Name = "Form1";
            this.Text = "Phonebook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNames;
        private System.Windows.Forms.TextBox txtPhoneOutput;
        private System.Windows.Forms.Button btnExit;
    }
}

