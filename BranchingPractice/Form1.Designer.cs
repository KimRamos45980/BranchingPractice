namespace BranchingPractice
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
            this.BtnDisplayGreeting = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDisplayGreeting
            // 
            this.BtnDisplayGreeting.Location = new System.Drawing.Point(116, 293);
            this.BtnDisplayGreeting.Name = "BtnDisplayGreeting";
            this.BtnDisplayGreeting.Size = new System.Drawing.Size(266, 101);
            this.BtnDisplayGreeting.TabIndex = 0;
            this.BtnDisplayGreeting.Text = "Display Greeting";
            this.BtnDisplayGreeting.UseVisualStyleBackColor = true;
            this.BtnDisplayGreeting.Click += new System.EventHandler(this.BtnDisplayGreeting_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(83, 121);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(332, 47);
            this.TxtName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 502);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnDisplayGreeting);
            this.Name = "Form1";
            this.Text = "Branching Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnDisplayGreeting;
        private TextBox TxtName;
    }
}