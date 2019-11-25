using System;
using System.Windows.Forms;

using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
namespace demo
{
    public partial class map_zoom : UserControl
    {
        private AxMapControl map_control;
        public map_zoom()
        {
            InitializeComponent();
        }
        public Boolean map_zoom_init(AxMapControl map)
        {
            if (map != null)
            {
                this.map_control = map;
                return true;
            }
            return false;
        }
        private void but_zoomin_Click(object sender, EventArgs e)
        {
            this.map_control.CurrentTool = null;
            ICommand pCommand = new ControlsMapZoomInTool();
            pcommandTool(pCommand);

        }

        private void but_zoomout_Click(object sender, EventArgs e)
        {
            this.map_control.CurrentTool = null;
            ICommand pCommand = new ControlsMapZoomOutTool();
            pcommandTool(pCommand);

        }

        private void but_head_Click(object sender, EventArgs e)
        {
            this.map_control.CurrentTool = null;
            ICommand pCommand = new ControlsMapPanTool();
            pcommandTool(pCommand);

        }
        private void but_selectfea_Click(object sender, EventArgs e)
        {
            this.map_control.CurrentTool = null;
            ICommand pCommand = new ControlsSelectFeaturesTool();
            pcommandTool(pCommand);
        }
        private void but_celiang_Click(object sender, EventArgs e)
        {
            this.map_control.CurrentTool = null;
            ICommand pCommand = new ControlsMapMeasureTool();
            pcommandTool(pCommand);
        }
        private void but_shuxing_Click(object sender, EventArgs e)
        {
            this.map_control.CurrentTool = null;
            ICommand pCommand = new ControlsMapIdentifyTool();
            pcommandTool(pCommand);
        }
        //ControlsMapIdentifyTool

        /// <summary>
        /// button提取
        /// </summary>
        private void pcommandTool(ICommand pCommand)
        {
            ITool pTool = pCommand as ITool;
            pCommand.OnCreate(this.map_control.Object);
            this.map_control.CurrentTool = pTool;
        }
        
        private void but_zoomin_MouseEnter(object sender, EventArgs e)
        {
            tooltip_zoomin.SetToolTip(this.but_zoomin, "固定放大");
        }

        private void but_zoomout_MouseEnter(object sender, EventArgs e)
        {
            tooltip_zoomout.SetToolTip(this.but_zoomout, "固定缩小");
        }

        private void but_head_MouseEnter(object sender, EventArgs e)
        {
            tooltip_head.SetToolTip(this.but_head, "漫游");
            
        }

        private void but_selectfea_MouseEnter(object sender, EventArgs e)
        {
            toolTip_selectfea.SetToolTip(this.but_selectfea, "选择元素");
            
        }

        private void but_celiang_MouseEnter(object sender, EventArgs e)
        {
            toolTip_celiang.SetToolTip(this.but_celiang, "测距");
        }

        private void but_shuxing_MouseEnter(object sender, EventArgs e)
        {
            toolTip_celiang.SetToolTip(this.but_shuxing, "属性识别");
        }
    }
}
