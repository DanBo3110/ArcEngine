using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
namespace demo
{
    class mapTool
    {
        private AxMapControl mapcontrol;

        public mapTool(AxMapControl map)
        {
            this.mapcontrol = map;
        }
        /*
        private void but_zoomin_Click(object sender, EventArgs e)
        {
            mapControl.CurrentTool = null;

            mapControl.MousePointer = esriControlsMousePointer.esriPointerPageZoomIn;
            flag_sc = 1;

        }
        private void btu_zoomout_Click(object sender, EventArgs e)
        {
            mapControl.MousePointer = esriControlsMousePointer.esriPointerPageZoomOut;
            flag_sc = 2;
        }
        private void btn_pan_Click(object sender, EventArgs e)
        {
            mapControl.MousePointer = esriControlsMousePointer.esriPointerPan;
            flag_sc = 3;
        }
        private void btn_pointsele_Click(object sender, EventArgs e)
        {
            flag_select_three = 1;
            select_three = true;
        }
        private void btn_circlesele_Click(object sender, EventArgs e)
        {
            flag_select_three = 2;
            select_three = true;
        }
        private void btn_juxingsele_Click(object sender, EventArgs e)
        {
            flag_select_three = 3;
            select_three = true;
        }
        private void btn_moresele_Click(object sender, EventArgs e)
        {
            flag_select_three = 4;
            select_three = true;
        }
        //清除选择
        private void btn_nosele_Click(object sender, EventArgs e)
        {

            IActiveView pActiveView = (IActiveView)(mapControl.Map);
            pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, mapControl.get_Layer(0), null);
            mapControl.Map.ClearSelection();
            pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, mapControl.get_Layer(0), null);
        }
        private void mapControl_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            IEnvelope ipenv = mapControl.TrackRectangle();
            mapControl.MousePointer = esriControlsMousePointer.esriPointerCrosshair;
            IGeometry geometry = null;
            Console.Write(flag_sc);

            switch (flag_sc)
            {
                case 1:
                    //放大
                    mapControl.Extent = ipenv;
                    break;
                case 2:
                    //缩小
                    ipenv = mapControl.Extent;
                    ipenv.Expand(2, 2, true);
                    mapControl.Extent = ipenv;
                    break;
                case 3:
                    //平移
                    ipenv = mapControl.Extent;
                    mapControl.Pan();
                    break;
            }

            if (select_three == true)
            {
                switch (flag_select_three)
                {
                    case 1:
                        ESRI.ArcGIS.Geometry.Point point = new ESRI.ArcGIS.Geometry.Point();
                        point.X = e.mapX;
                        point.Y = e.mapY;
                        geometry = point as IGeometry;
                        break;
                    case 2:
                        geometry = mapControl.TrackCircle();
                        break;
                    case 3:
                        geometry = mapControl.TrackRectangle();
                        break;
                    case 4:
                        geometry = mapControl.TrackPolygon();
                        break;
                }
                mapControl.Map.SelectByShape(geometry, null, false);
                mapControl.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null);
                

            }
        }
    */
    }
}
