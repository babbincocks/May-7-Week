namespace Telephone_Unformat
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
            this.btnUnformat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUnformat
            // 
            this.btnUnformat.Location = new System.Drawing.Point(46, 215);
            this.btnUnformat.Name = "btnUnformat";
            this.btnUnformat.Size = new System.Drawing.Size(75, 23);
            this.btnUnformat.TabIndex = 0;
            this.btnUnformat.Text = "Unformat";
            this.btnUnformat.UseVisualStyleBackColor = true;
            this.btnUnformat.Click += new System.EventHandler(this.btnUnformat_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(171, 215);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(58, 154);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(169, 20);
            this.txtInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type a phone number here\r\n(Format: (XXX)XXX-XXXX) ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUnformat);
            this.Name = "Form1";
            this.Text = "Telephone Unformat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnformat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
    }
}

