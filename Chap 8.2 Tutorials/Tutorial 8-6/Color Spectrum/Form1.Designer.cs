namespace Color_Spectrum
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
            this.lblRed = new System.Windows.Forms.Label();
            this.lblOrange = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblIndigo = new System.Windows.Forms.Label();
            this.lblViolet = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(21, 122);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(81, 27);
            this.lblRed.TabIndex = 0;
            this.lblRed.Click += new System.EventHandler(this.lblRed_Click);
            // 
            // lblOrange
            // 
            this.lblOrange.BackColor = System.Drawing.Color.Orange;
            this.lblOrange.Location = new System.Drawing.Point(79, 84);
            this.lblOrange.Name = "lblOrange";
            this.lblOrange.Size = new System.Drawing.Size(81, 27);
            this.lblOrange.TabIndex = 1;
            this.lblOrange.Click += new System.EventHandler(this.lblOrange_Click);
            // 
            // lblYellow
            // 
            this.lblYellow.BackColor = System.Drawing.Color.Yellow;
            this.lblYellow.Location = new System.Drawing.Point(131, 122);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(81, 27);
            this.lblYellow.TabIndex = 2;
            this.lblYellow.Click += new System.EventHandler(this.lblYellow_Click);
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.Green;
            this.lblGreen.Location = new System.Drawing.Point(191, 84);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(81, 27);
            this.lblGreen.TabIndex = 3;
            this.lblGreen.Click += new System.EventHandler(this.lblGreen_Click);
            // 
            // lblBlue
            // 
            this.lblBlue.BackColor = System.Drawing.Color.Blue;
            this.lblBlue.Location = new System.Drawing.Point(249, 122);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(81, 27);
            this.lblBlue.TabIndex = 4;
            this.lblBlue.Click += new System.EventHandler(this.lblBlue_Click);
            // 
            // lblIndigo
            // 
            this.lblIndigo.BackColor = System.Drawing.Color.Indigo;
            this.lblIndigo.Location = new System.Drawing.Point(303, 84);
            this.lblIndigo.Name = "lblIndigo";
            this.lblIndigo.Size = new System.Drawing.Size(81, 27);
            this.lblIndigo.TabIndex = 5;
            this.lblIndigo.Click += new System.EventHandler(this.lblIndigo_Click);
            // 
            // lblViolet
            // 
            this.lblViolet.BackColor = System.Drawing.Color.Violet;
            this.lblViolet.Location = new System.Drawing.Point(363, 122);
            this.lblViolet.Name = "lblViolet";
            this.lblViolet.Size = new System.Drawing.Size(81, 27);
            this.lblViolet.TabIndex = 6;
            this.lblViolet.Click += new System.EventHandler(this.lblViolet_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(175, 198);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(106, 20);
            this.txtColor.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblViolet);
            this.Controls.Add(this.lblIndigo);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblYellow);
            this.Controls.Add(this.lblOrange);
            this.Controls.Add(this.lblRed);
            this.Name = "Form1";
            this.Text = "Color Spectrum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblOrange;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblIndigo;
        private System.Windows.Forms.Label lblViolet;
        private System.Windows.Forms.TextBox txtColor;
    }
}

