namespace Password_Validation
{
    partial class frmMain
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
            this.btnPassCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPassCheck
            // 
            this.btnPassCheck.Location = new System.Drawing.Point(38, 211);
            this.btnPassCheck.Name = "btnPassCheck";
            this.btnPassCheck.Size = new System.Drawing.Size(89, 37);
            this.btnPassCheck.TabIndex = 0;
            this.btnPassCheck.Text = "Check Password";
            this.btnPassCheck.UseVisualStyleBackColor = true;
            this.btnPassCheck.Click += new System.EventHandler(this.btnPassCheck_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(156, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 37);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(81, 166);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(130, 20);
            this.txtInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = "Make sure your password has:\r\n\r\n1. At least 8 characters.\r\n2. At least 1 uppercas" +
    "e letter.\r\n3.At least 1 lowercase letter.\r\n4.At least 1 numeric digit.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPassCheck);
            this.Name = "frmMain";
            this.Text = "Password Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPassCheck;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
    }
}

