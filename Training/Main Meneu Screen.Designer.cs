namespace Training
{
    partial class fmMainMenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMainMenue));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNumberRepeated = new Guna.UI2.WinForms.Guna2Button();
            this.btnGenerateRrandomCharacters = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(241, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Main Meneu*";
            // 
            // btnNumberRepeated
            // 
            this.btnNumberRepeated.BackColor = System.Drawing.Color.Transparent;
            this.btnNumberRepeated.BorderRadius = 30;
            this.btnNumberRepeated.CheckedState.Parent = this.btnNumberRepeated;
            this.btnNumberRepeated.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNumberRepeated.CustomImages.Parent = this.btnNumberRepeated;
            this.btnNumberRepeated.FillColor = System.Drawing.Color.Red;
            this.btnNumberRepeated.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberRepeated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNumberRepeated.HoverState.Parent = this.btnNumberRepeated;
            this.btnNumberRepeated.Location = new System.Drawing.Point(248, 176);
            this.btnNumberRepeated.Name = "btnNumberRepeated";
            this.btnNumberRepeated.ShadowDecoration.Parent = this.btnNumberRepeated;
            this.btnNumberRepeated.Size = new System.Drawing.Size(263, 56);
            this.btnNumberRepeated.TabIndex = 1;
            this.btnNumberRepeated.Text = "Number repeated";
            this.btnNumberRepeated.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGenerateRrandomCharacters
            // 
            this.btnGenerateRrandomCharacters.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateRrandomCharacters.BorderRadius = 30;
            this.btnGenerateRrandomCharacters.CheckedState.Parent = this.btnGenerateRrandomCharacters;
            this.btnGenerateRrandomCharacters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateRrandomCharacters.CustomImages.Parent = this.btnGenerateRrandomCharacters;
            this.btnGenerateRrandomCharacters.FillColor = System.Drawing.Color.Red;
            this.btnGenerateRrandomCharacters.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRrandomCharacters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnGenerateRrandomCharacters.HoverState.Parent = this.btnGenerateRrandomCharacters;
            this.btnGenerateRrandomCharacters.Location = new System.Drawing.Point(248, 289);
            this.btnGenerateRrandomCharacters.Name = "btnGenerateRrandomCharacters";
            this.btnGenerateRrandomCharacters.ShadowDecoration.Parent = this.btnGenerateRrandomCharacters;
            this.btnGenerateRrandomCharacters.Size = new System.Drawing.Size(263, 56);
            this.btnGenerateRrandomCharacters.TabIndex = 2;
            this.btnGenerateRrandomCharacters.Text = "Generate random characters";
            this.btnGenerateRrandomCharacters.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 30;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(248, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(263, 56);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btn_Click);
            // 
            // fmMainMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(769, 551);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerateRrandomCharacters);
            this.Controls.Add(this.btnNumberRepeated);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fmMainMenue";
            this.Text = "Training Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnNumberRepeated;
        private Guna.UI2.WinForms.Guna2Button btnGenerateRrandomCharacters;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}

