namespace DateAlgorithmAdaptation
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnFileLocation = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(167, 215);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(99, 22);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert File";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 125);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(135, 20);
            this.txtResult.TabIndex = 1;
            // 
            // btnFileLocation
            // 
            this.btnFileLocation.Location = new System.Drawing.Point(12, 151);
            this.btnFileLocation.Name = "btnFileLocation";
            this.btnFileLocation.Size = new System.Drawing.Size(91, 23);
            this.btnFileLocation.TabIndex = 2;
            this.btnFileLocation.Text = "Input File";
            this.btnFileLocation.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(349, 151);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(91, 23);
            this.btnOutput.TabIndex = 4;
            this.btnOutput.Text = "Output Location";
            this.btnOutput.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 273);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFileLocation);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnFileLocation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOutput;
    }
}

