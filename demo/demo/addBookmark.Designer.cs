namespace demo
{
    partial class addBookmark
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
            this.bm_text = new System.Windows.Forms.TextBox();
            this.but_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bm_text
            // 
            this.bm_text.Location = new System.Drawing.Point(92, 90);
            this.bm_text.Name = "bm_text";
            this.bm_text.Size = new System.Drawing.Size(100, 21);
            this.bm_text.TabIndex = 0;
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(216, 90);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(75, 23);
            this.but_ok.TabIndex = 1;
            this.but_ok.Text = "确认";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // addBookmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 217);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.bm_text);
            this.Name = "addBookmark";
            this.Text = "addBookmark";
            this.Load += new System.EventHandler(this.addBookmark_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bm_text;
        private System.Windows.Forms.Button but_ok;
    }
}