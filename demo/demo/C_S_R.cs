using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class C_S_R
    {
        private static AxMapControl CSR_mapControl;
        public C_S_R(AxMapControl mapcontrol)
        {
            CSR_mapControl = mapcontrol;
        }
        #region 各类专题图均用的函数
        /// <summary>
        /// 获得颜色的函数
        /// </summary>
        public static IRgbColor getRGB(int r, int g, int b)
        {
            IRgbColor pColor = new RgbColor();
            pColor.Red = r;
            pColor.Green = g;
            pColor.Blue = b;
            return pColor;
        }
        /// <summary>
        /// 获取渲染图层
        /// </summary>
        public static IGeoFeatureLayer getGeoLayer(string layerName)
        {
            ILayer pLayer; //定义图层
            IGeoFeatureLayer pGeoFeatureLayer; //定义要素图层
                                               //遍历图层
            Console.Write("CSR_mapControl" + CSR_mapControl.LayerCount);
            for (int i = 0; i < CSR_mapControl.LayerCount; i++)
            {
                pLayer = CSR_mapControl.get_Layer(i);
                //若当前图层不为空且与与layerName的值相同
                if (pLayer != null && pLayer.Name == layerName)
                {
                    //强转成IGeoFeatureLayer
                    pGeoFeatureLayer = pLayer as IGeoFeatureLayer;
                    //返回pGeoFeatureLayer对象
                    return pGeoFeatureLayer;
                }
            }
            Console.Write("fanhui"+123);

            return null; //返回null
        }
        #endregion

        public static ISymbol GetSymbolFromLayer(ILayer player)
        {
            if (player == null) return null;

            IFeatureLayer pfeaturelayer = player as IFeatureLayer;
            IFeatureCursor pfeaturecursor = pfeaturelayer.Search(null, false);
            IFeature pfeature = pfeaturecursor.NextFeature();

            IGeoFeatureLayer pgeofeaturelayer = pfeaturelayer as IGeoFeatureLayer;
            IFeatureRenderer pfeaturerenger = pgeofeaturelayer.Renderer;

            ISymbol psymbol = pfeaturerenger.get_SymbolByFeature(pfeature);
            return psymbol;
        }

        public static string GetRendererTypeByLayer(ILayer player)
        {
            IFeatureLayer pfeaturelayer = player as IFeatureLayer;
            IGeoFeatureLayer pgeofeaturelayer = player as IGeoFeatureLayer;
            IFeatureRenderer pfeaturerenger = pgeofeaturelayer.Renderer;

            if (pfeaturelayer is ISimpleRenderer) return "SimpleRenderer";
            else if (pfeaturelayer is IUniqueValueRenderer) return "UniqueValueRenderer";
            else if (pfeaturelayer is IDotDensityRenderer) return "DotDensityRenderer";
            else if (pfeaturelayer is IChartRenderer) return "ChartRenderer";
            else if (pfeaturelayer is IProportionalSymbolRenderer) return "ProportionalSymbolRenderer";
            else if (pfeaturelayer is IRepresentationRenderer) return "RepresentationRenderer";
            else if (pfeaturelayer is IClassBreaksRenderer) return "ClassBreaksRenderer";
            else if (pfeaturelayer is IBivariateRenderer) return "BivariateRenderer";

            return "error";


        }
        public static bool RenderSimply(ILayer player, IColor pcolor)
        {
            ISymbol psymbol = GetSymbolFromLayer(player);
            IFeatureLayer pfeaturelayer = player as IFeatureLayer;
            IFeatureClass pfeatureclass = pfeaturelayer.FeatureClass;
            esriGeometryType geotype = pfeatureclass.ShapeType;
            switch (geotype)
            {
                case esriGeometryType.esriGeometryPoint:
                    {
                        IMarkerSymbol pmarksymbol = psymbol as IMarkerSymbol;
                        pmarksymbol.Color = pcolor;
                        break;
                    }
                case esriGeometryType.esriGeometryMultipoint:
                    {
                        IMarkerSymbol pmarksymbol = psymbol as IMarkerSymbol;
                        pmarksymbol.Color = pcolor;
                        break;
                    }
                case esriGeometryType.esriGeometryPolyline:
                    {
                        ISimpleLineSymbol psimplelinesymbol = psymbol as ISimpleLineSymbol;
                        psimplelinesymbol.Color = pcolor;
                        break;
                    }
                case esriGeometryType.esriGeometryPolygon:
                    {
                        IFillSymbol pfillsymbol = psymbol as IFillSymbol;
                        pfillsymbol.Color = pcolor;
                        break;
                    }
                default: return false;
            }

            ISimpleRenderer psimolerenderer = new SimpleRenderer();
            psimolerenderer.Symbol = psymbol;
            IFeatureRenderer pfeaturerender = psimolerenderer as IFeatureRenderer;

            IGeoFeatureLayer pgeofeaturelayer = pfeaturelayer as IGeoFeatureLayer;
            pgeofeaturelayer.Renderer = pfeaturerender;
            return true;

        }


        //简单渲染，面符号
        public static void easy_xrender(string filename, IRgbColor fill_rgb, int width)
        {
            //实例化ISimpleFillSysmbol变量, 提供简单的填充符号类型
            ISimpleFillSymbol pSimpleFillSymbol = new SimpleFillSymbol();
            pSimpleFillSymbol.Style = esriSimpleFillStyle.esriSFSDiagonalCross;
            pSimpleFillSymbol.Color = fill_rgb;
            ISimpleLineSymbol pSimpleLineSymbol = new SimpleLineSymbol();
            pSimpleLineSymbol.Width = width;
            pSimpleFillSymbol.Outline = pSimpleLineSymbol;

            ISimpleRenderer pSimpleRender = new SimpleRenderer();
            //设置pSimpleRender的符号样式
            pSimpleRender.Symbol = pSimpleFillSymbol as ISymbol;

            Render_tool(pSimpleRender, filename);
        }
        //简单渲染，面符号和边线
        public static void easy_xrender(string filename,IRgbColor fill_rgb, IRgbColor line_rgb, int width)
        {
            //实例化ISimpleFillSysmbol变量, 提供简单的填充符号类型
            ISimpleFillSymbol pSimpleFillSymbol = new SimpleFillSymbol();
            pSimpleFillSymbol.Style = esriSimpleFillStyle.esriSFSDiagonalCross;
            pSimpleFillSymbol.Color = fill_rgb;

            //创建边线符号变量
            ISimpleLineSymbol pSimpleLineSymbol = new SimpleLineSymbol();
            pSimpleLineSymbol.Color = line_rgb;
            pSimpleLineSymbol.Width = width;
            pSimpleFillSymbol.Outline = pSimpleLineSymbol;

            ISimpleRenderer pSimpleRender = new SimpleRenderer();
            //设置pSimpleRender的符号样式
            pSimpleRender.Symbol = pSimpleFillSymbol as ISymbol;

            Render_tool(pSimpleRender, filename);
        }
        //简单渲染，线符号
        public static void easy_line(string filename, IRgbColor point_rgb, int width)
        {
            Console.WriteLine("++++++++++++++"+filename);
            //实例化ISimpleFillSysmbol变量, 提供简单的填充符号类型
            ISimpleLineSymbol pSimplelineSymbol = new SimpleLineSymbol();
            pSimplelineSymbol.Color = point_rgb;
            pSimplelineSymbol.Width = width;

            ISimpleRenderer pSimpleRender = new SimpleRenderer();
            //设置pSimpleRender的符号样式
            pSimpleRender.Symbol = pSimplelineSymbol as ISymbol;

            Render_tool(pSimpleRender, filename);
        }
        //简单渲染，点符号
        public static void easy_point(string filename, IRgbColor point_rgb, int width)
        {
            //实例化ISimpleFillSysmbol变量, 提供简单的填充符号类型
            ISimpleMarkerSymbol pSimplemarkerSymbol = new SimpleMarkerSymbol();
            pSimplemarkerSymbol.Color = point_rgb;
            pSimplemarkerSymbol.OutlineSize = width;

            //实例化简单渲染变量
            ISimpleRenderer pSimpleRender = new SimpleRenderer();
            //设置pSimpleRender的符号样式
            pSimpleRender.Symbol = pSimplemarkerSymbol as ISymbol;

            Render_tool(pSimpleRender, filename);
        }
        private static void Render_tool(ISimpleRenderer pSimpleRenderer, string filename)
        {
            //提供要素图层对成员控制地理特征渲染的入口,获取渲染图层
            IGeoFeatureLayer pGeoFeatureLayer = getGeoLayer(filename);
            if (pGeoFeatureLayer != null)
            {
                //调用Renderer属性, 具体说明如何通过图层要素渲染器渲染图层
                pGeoFeatureLayer.Renderer = pSimpleRenderer as IFeatureRenderer;
            }
            CSR_mapControl.ActiveView.ContentsChanged();
            CSR_mapControl.ActiveView.Refresh();
        }
    }

}
