namespace CSV_Reader
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
            this.lbAverages = new System.Windows.Forms.ListBox();
            this.btnScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAverages
            // 
            this.lbAverages.FormattingEnabled = true;
            this.lbAverages.Location = new System.Drawing.Point(12, 12);
            this.lbAverages.Name = "lbAverages";
            this.lbAverages.Size = new System.Drawing.Size(268, 212);
            this.lbAverages.TabIndex = 0;
            // 
            // btnScores
            // 
            this.btnScores.Location = new System.Drawing.Point(12, 235);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(109, 26);
            this.btnScores.TabIndex = 1;
            this.btnScores.Text = "Retrieve Scores";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(171, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.lbAverages);
            this.Name = "Form1";
            this.Text = "CSV Reader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAverages;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Button btnExit;
    }
}

