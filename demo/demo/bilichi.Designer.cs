namespace demo
{
    partial class bilichi
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
            this.bilitext = new System.Windows.Forms.Label();
            this.bili = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bilitext
            // 
            this.bilitext.AutoSize = true;
            this.bilitext.Location = new System.Drawing.Point(98, 43);
            this.bilitext.Name = "bilitext";
            this.bilitext.Size = new System.Drawing.Size(29, 12);
            this.bilitext.TabIndex = 0;
            this.bilitext.Text = "none";
            // 
            // bili
            // 
            this.bili.AutoSize = true;
            this.bili.Location = new System.Drawing.Point(42, 43);
            this.bili.Name = "bili";
            this.bili.Size = new System.Drawing.Size(53, 12);
            this.bili.TabIndex = 1;
            this.bili.Text = "比例尺：";
            // 
            // bilichi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 103);
            this.Controls.Add(this.bili);
            this.Controls.Add(this.bilitext);
            this.Name = "bilichi";
            this.Text = "bilichi";
            this.Load += new System.EventHandler(this.bilichi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bilitext;
        private System.Windows.Forms.Label bili;
    }
}