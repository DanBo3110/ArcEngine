namespace demo
{
    partial class render
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
            this.splt_all = new System.Windows.Forms.SplitContainer();
            this.pan_l_choose = new System.Windows.Forms.Panel();
            this.listBox_layer = new System.Windows.Forms.ListBox();
            this.panel_r = new System.Windows.Forms.Panel();
            this.panel_line = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_lg = new System.Windows.Forms.TextBox();
            this.textBox_lb = new System.Windows.Forms.TextBox();
            this.textBox_lr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_render = new System.Windows.Forms.ComboBox();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.label_width = new System.Windows.Forms.Label();
            this.radioButton_plon = new System.Windows.Forms.RadioButton();
            this.radioButton_line = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton_point = new System.Windows.Forms.RadioButton();
            this.label_rgb = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_r = new System.Windows.Forms.TextBox();
            this.textBox_g = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splt_all)).BeginInit();
            this.splt_all.Panel1.SuspendLayout();
            this.splt_all.Panel2.SuspendLayout();
            this.splt_all.SuspendLayout();
            this.pan_l_choose.SuspendLayout();
            this.panel_r.SuspendLayout();
            this.panel_line.SuspendLayout();
            this.SuspendLayout();
            // 
            // splt_all
            // 
            this.splt_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_all.Location = new System.Drawing.Point(0, 0);
            this.splt_all.Name = "splt_all";
            // 
            // splt_all.Panel1
            // 
            this.splt_all.Panel1.Controls.Add(this.pan_l_choose);
            // 
            // splt_all.Panel2
            // 
            this.splt_all.Panel2.Controls.Add(this.panel_r);
            this.splt_all.Size = new System.Drawing.Size(260, 209);
            this.splt_all.SplitterDistance = 120;
            this.splt_all.TabIndex = 0;
            // 
            // pan_l_choose
            // 
            this.pan_l_choose.Controls.Add(this.listBox_layer);
            this.pan_l_choose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_l_choose.Location = new System.Drawing.Point(0, 0);
            this.pan_l_choose.Name = "pan_l_choose";
            this.pan_l_choose.Size = new System.Drawing.Size(120, 209);
            this.pan_l_choose.TabIndex = 0;
            // 
            // listBox_layer
            // 
            this.listBox_layer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_layer.FormattingEnabled = true;
            this.listBox_layer.ItemHeight = 12;
            this.listBox_layer.Location = new System.Drawing.Point(0, 0);
            this.listBox_layer.Name = "listBox_layer";
            this.listBox_layer.Size = new System.Drawing.Size(120, 209);
            this.listBox_layer.TabIndex = 2;
            // 
            // panel_r
            // 
            this.panel_r.Controls.Add(this.panel_line);
            this.panel_r.Controls.Add(this.label1);
            this.panel_r.Controls.Add(this.comboBox_render);
            this.panel_r.Controls.Add(this.textBox_width);
            this.panel_r.Controls.Add(this.label_width);
            this.panel_r.Controls.Add(this.radioButton_plon);
            this.panel_r.Controls.Add(this.radioButton_line);
            this.panel_r.Controls.Add(this.button1);
            this.panel_r.Controls.Add(this.radioButton_point);
            this.panel_r.Controls.Add(this.label_rgb);
            this.panel_r.Controls.Add(this.textBox_b);
            this.panel_r.Controls.Add(this.textBox_r);
            this.panel_r.Controls.Add(this.textBox_g);
            this.panel_r.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_r.Location = new System.Drawing.Point(0, 0);
            this.panel_r.Name = "panel_r";
            this.panel_r.Size = new System.Drawing.Size(136, 209);
            this.panel_r.TabIndex = 0;
            // 
            // panel_line
            // 
            this.panel_line.Controls.Add(this.label2);
            this.panel_line.Controls.Add(this.textBox_lg);
            this.panel_line.Controls.Add(this.textBox_lb);
            this.panel_line.Controls.Add(this.textBox_lr);
            this.panel_line.Location = new System.Drawing.Point(3, 104);
            this.panel_line.Name = "panel_line";
            this.panel_line.Size = new System.Drawing.Size(130, 38);
            this.panel_line.TabIndex = 21;
            this.panel_line.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "Line:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_lg
            // 
            this.textBox_lg.Location = new System.Drawing.Point(71, 9);
            this.textBox_lg.Name = "textBox_lg";
            this.textBox_lg.Size = new System.Drawing.Size(23, 21);
            this.textBox_lg.TabIndex = 19;
            this.textBox_lg.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_lb
            // 
            this.textBox_lb.Location = new System.Drawing.Point(100, 9);
            this.textBox_lb.Name = "textBox_lb";
            this.textBox_lb.Size = new System.Drawing.Size(23, 21);
            this.textBox_lb.TabIndex = 20;
            this.textBox_lb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_lr
            // 
            this.textBox_lr.Location = new System.Drawing.Point(42, 9);
            this.textBox_lr.Name = "textBox_lr";
            this.textBox_lr.Size = new System.Drawing.Size(23, 21);
            this.textBox_lr.TabIndex = 18;
            this.textBox_lr.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "渲染：";
            // 
            // comboBox_render
            // 
            this.comboBox_render.FormattingEnabled = true;
            this.comboBox_render.Items.AddRange(new object[] {
            "简单渲染",
            "唯一值渲染"});
            this.comboBox_render.Location = new System.Drawing.Point(45, 152);
            this.comboBox_render.Name = "comboBox_render";
            this.comboBox_render.Size = new System.Drawing.Size(81, 20);
            this.comboBox_render.TabIndex = 15;
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(43, 45);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(83, 21);
            this.textBox_width.TabIndex = 14;
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(6, 48);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(41, 12);
            this.label_width.TabIndex = 13;
            this.label_width.Text = "Size：";
            // 
            // radioButton_plon
            // 
            this.radioButton_plon.AutoSize = true;
            this.radioButton_plon.Location = new System.Drawing.Point(89, 10);
            this.radioButton_plon.Name = "radioButton_plon";
            this.radioButton_plon.Size = new System.Drawing.Size(35, 16);
            this.radioButton_plon.TabIndex = 12;
            this.radioButton_plon.TabStop = true;
            this.radioButton_plon.Text = "面";
            this.radioButton_plon.UseVisualStyleBackColor = true;
            this.radioButton_plon.CheckedChanged += new System.EventHandler(this.radioButton_plon_CheckedChanged);
            // 
            // radioButton_line
            // 
            this.radioButton_line.AutoSize = true;
            this.radioButton_line.Location = new System.Drawing.Point(48, 10);
            this.radioButton_line.Name = "radioButton_line";
            this.radioButton_line.Size = new System.Drawing.Size(35, 16);
            this.radioButton_line.TabIndex = 11;
            this.radioButton_line.TabStop = true;
            this.radioButton_line.Text = "线";
            this.radioButton_line.UseVisualStyleBackColor = true;
            this.radioButton_line.CheckedChanged += new System.EventHandler(this.radioButton_line_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton_point
            // 
            this.radioButton_point.AutoSize = true;
            this.radioButton_point.Location = new System.Drawing.Point(7, 10);
            this.radioButton_point.Name = "radioButton_point";
            this.radioButton_point.Size = new System.Drawing.Size(35, 16);
            this.radioButton_point.TabIndex = 10;
            this.radioButton_point.TabStop = true;
            this.radioButton_point.Text = "点";
            this.radioButton_point.UseVisualStyleBackColor = true;
            this.radioButton_point.CheckedChanged += new System.EventHandler(this.radioButton_point_CheckedChanged);
            // 
            // label_rgb
            // 
            this.label_rgb.AutoSize = true;
            this.label_rgb.Location = new System.Drawing.Point(6, 80);
            this.label_rgb.Name = "label_rgb";
            this.label_rgb.Size = new System.Drawing.Size(29, 12);
            this.label_rgb.TabIndex = 3;
            this.label_rgb.Text = "RGB:";
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(103, 77);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(23, 21);
            this.textBox_b.TabIndex = 6;
            // 
            // textBox_r
            // 
            this.textBox_r.Location = new System.Drawing.Point(45, 77);
            this.textBox_r.Name = "textBox_r";
            this.textBox_r.Size = new System.Drawing.Size(23, 21);
            this.textBox_r.TabIndex = 4;
            // 
            // textBox_g
            // 
            this.textBox_g.Location = new System.Drawing.Point(74, 77);
            this.textBox_g.Name = "textBox_g";
            this.textBox_g.Size = new System.Drawing.Size(23, 21);
            this.textBox_g.TabIndex = 5;
            // 
            // render
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 209);
            this.Controls.Add(this.splt_all);
            this.Name = "render";
            this.Text = "Render";
            this.Load += new System.EventHandler(this.render_Load);
            this.splt_all.Panel1.ResumeLayout(false);
            this.splt_all.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_all)).EndInit();
            this.splt_all.ResumeLayout(false);
            this.pan_l_choose.ResumeLayout(false);
            this.panel_r.ResumeLayout(false);
            this.panel_r.PerformLayout();
            this.panel_line.ResumeLayout(false);
            this.panel_line.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splt_all;
        private System.Windows.Forms.Panel pan_l_choose;
        private System.Windows.Forms.Label label_rgb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_g;
        private System.Windows.Forms.TextBox textBox_r;
        private System.Windows.Forms.ListBox listBox_layer;
        private System.Windows.Forms.RadioButton radioButton_plon;
        private System.Windows.Forms.RadioButton radioButton_line;
        private System.Windows.Forms.RadioButton radioButton_point;
        private System.Windows.Forms.Panel panel_r;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_render;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_lb;
        private System.Windows.Forms.TextBox textBox_lr;
        private System.Windows.Forms.TextBox textBox_lg;
        private System.Windows.Forms.Panel panel_line;
    }
}