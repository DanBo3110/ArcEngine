namespace demo
{
    partial class map_zoom
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(map_zoom));
            this.but_zoomin = new System.Windows.Forms.Button();
            this.but_zoomout = new System.Windows.Forms.Button();
            this.but_head = new System.Windows.Forms.Button();
            this.but_selectfea = new System.Windows.Forms.Button();
            this.tooltip_zoomin = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_zoomout = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_head = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_selectfea = new System.Windows.Forms.ToolTip(this.components);
            this.but_celiang = new System.Windows.Forms.Button();
            this.toolTip_celiang = new System.Windows.Forms.ToolTip(this.components);
            this.but_shuxing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_zoomin
            // 
            this.but_zoomin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_zoomin.BackgroundImage")));
            this.but_zoomin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_zoomin.Location = new System.Drawing.Point(3, 3);
            this.but_zoomin.Name = "but_zoomin";
            this.but_zoomin.Size = new System.Drawing.Size(30, 30);
            this.but_zoomin.TabIndex = 0;
            this.but_zoomin.UseVisualStyleBackColor = true;
            this.but_zoomin.Click += new System.EventHandler(this.but_zoomin_Click);
            this.but_zoomin.MouseEnter += new System.EventHandler(this.but_zoomin_MouseEnter);
            // 
            // but_zoomout
            // 
            this.but_zoomout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_zoomout.BackgroundImage")));
            this.but_zoomout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_zoomout.Location = new System.Drawing.Point(3, 39);
            this.but_zoomout.Name = "but_zoomout";
            this.but_zoomout.Size = new System.Drawing.Size(30, 30);
            this.but_zoomout.TabIndex = 1;
            this.but_zoomout.UseVisualStyleBackColor = true;
            this.but_zoomout.Click += new System.EventHandler(this.but_zoomout_Click);
            this.but_zoomout.MouseEnter += new System.EventHandler(this.but_zoomout_MouseEnter);
            // 
            // but_head
            // 
            this.but_head.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_head.BackgroundImage")));
            this.but_head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_head.Location = new System.Drawing.Point(3, 75);
            this.but_head.Name = "but_head";
            this.but_head.Size = new System.Drawing.Size(30, 30);
            this.but_head.TabIndex = 2;
            this.but_head.UseVisualStyleBackColor = true;
            this.but_head.Click += new System.EventHandler(this.but_head_Click);
            this.but_head.MouseEnter += new System.EventHandler(this.but_head_MouseEnter);
            // 
            // but_selectfea
            // 
            this.but_selectfea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_selectfea.BackgroundImage")));
            this.but_selectfea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_selectfea.Location = new System.Drawing.Point(3, 111);
            this.but_selectfea.Name = "but_selectfea";
            this.but_selectfea.Size = new System.Drawing.Size(30, 30);
            this.but_selectfea.TabIndex = 3;
            this.but_selectfea.UseVisualStyleBackColor = true;
            this.but_selectfea.Click += new System.EventHandler(this.but_selectfea_Click);
            this.but_selectfea.MouseEnter += new System.EventHandler(this.but_selectfea_MouseEnter);
            // 
            // but_celiang
            // 
            this.but_celiang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_celiang.BackgroundImage")));
            this.but_celiang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_celiang.Location = new System.Drawing.Point(3, 147);
            this.but_celiang.Name = "but_celiang";
            this.but_celiang.Size = new System.Drawing.Size(30, 30);
            this.but_celiang.TabIndex = 4;
            this.but_celiang.UseVisualStyleBackColor = true;
            this.but_celiang.Click += new System.EventHandler(this.but_celiang_Click);
            this.but_celiang.MouseEnter += new System.EventHandler(this.but_celiang_MouseEnter);
            // 
            // but_shuxing
            // 
            this.but_shuxing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_shuxing.BackgroundImage")));
            this.but_shuxing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_shuxing.Location = new System.Drawing.Point(3, 183);
            this.but_shuxing.Name = "but_shuxing";
            this.but_shuxing.Size = new System.Drawing.Size(30, 30);
            this.but_shuxing.TabIndex = 5;
            this.but_shuxing.UseVisualStyleBackColor = true;
            this.but_shuxing.Click += new System.EventHandler(this.but_shuxing_Click);
            this.but_shuxing.MouseEnter += new System.EventHandler(this.but_shuxing_MouseEnter);
            // 
            // map_zoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.but_shuxing);
            this.Controls.Add(this.but_celiang);
            this.Controls.Add(this.but_selectfea);
            this.Controls.Add(this.but_head);
            this.Controls.Add(this.but_zoomout);
            this.Controls.Add(this.but_zoomin);
            this.Name = "map_zoom";
            this.Size = new System.Drawing.Size(36, 217);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_zoomin;
        private System.Windows.Forms.Button but_zoomout;
        private System.Windows.Forms.Button but_head;
        private System.Windows.Forms.Button but_selectfea;
        private System.Windows.Forms.ToolTip tooltip_zoomin;
        private System.Windows.Forms.ToolTip tooltip_zoomout;
        private System.Windows.Forms.ToolTip tooltip_head;
        private System.Windows.Forms.ToolTip toolTip_selectfea;
        private System.Windows.Forms.Button but_celiang;
        private System.Windows.Forms.ToolTip toolTip_celiang;
        private System.Windows.Forms.Button but_shuxing;
    }
}
