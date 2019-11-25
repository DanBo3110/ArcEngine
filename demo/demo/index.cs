using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;//List<>

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;//IWorkspaceFactory\IWorkspace\IFeatureWorkspace\IFeatureClass\IRasterDataset
using ESRI.ArcGIS.DataSourcesFile;//ShapefileWorkspaceFactory
using ESRI.ArcGIS.DataSourcesRaster;//RasterWorkspaceFactory\IRasterWorkspace\IRasterPyramid
using ESRI.ArcGIS.Display;//IRgbColor\ISymbol\IColor
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.esriSystem;

namespace demo
{
    public partial class index : Form
    {
        private int flag_sc = 0;
        private int flag_select_three = 0;
        private Boolean select_three = false;
        private List<string> map_layer = new List<string>(){};
        private IPageLayout pPageLayout;
        private IActiveView pActiveView;
        private IGraphicsContainer pGraphicsContainer;
        private pagelayout_element pe;
        private IEnvelope envelope;
        public index()
        {

            //mapControl.AddShapeFile("D:\\Study\\Study_地理信息技术课程\\地信\\实训\\Data\\1.1", "Export_Output.shp");

            if (MessageBox.Show("是否立即开始测试程序？", "提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.OK)
            {
                InitializeComponent();
                TOCControl.SetBuddyControl(mapControl);
                toolbarControl.SetBuddyControl(mapControl);

                pagelayout_init();

                if (map_zoom_r != null && map_zoom_r.map_zoom_init(mapControl))
                    MessageBox.Show("Init Success");
                else
                {
                    MessageBox.Show("Init Error");
                    Application.Exit();
                }
            }
            else
                System.Environment.Exit(0);

        }

        private void pagelayout_init()
        {
            pPageLayout = this.pagelayoutcontrol.PageLayout;
            pPageLayout.ZoomToWhole();
            pActiveView = pPageLayout as IActiveView;

            pGraphicsContainer = pPageLayout as IGraphicsContainer;
            pe = new pagelayout_element(pagelayoutcontrol, envelope);
        }
        private void menu_open_Click(object sender, EventArgs e)
        {
            addMapFile();
        }
        private void menu_blc_Click(object sender, EventArgs e)
        {
            bilichi blc = new bilichi(mapControl.MapScale.ToString());
            blc.Show();
            Console.WriteLine(mapControl.MapScale.ToString());
        }
        private void toolSCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = toolSCB.SelectedIndex.ToString();
            Console.WriteLine(index);
            if (index == "0")
            {
                pan_mapXR.Visible = false;
                pan_mapSX.Visible = true;
            }
            if (index == "1")
            {
                pan_mapXR.Visible = true;
                pan_mapSX.Visible = false;
            }
        }
        private void but_addbm_Click(object sender, EventArgs e)
        {
            addBookmark add = new addBookmark(this);
            add.Show();
        }
        private void btn_bmDEL_Click(object sender, EventArgs e)
        {
            cmb_Bookmark.Items.Remove(cmb_Bookmark.SelectedItem);
            cmb_Bookmark.Text = "";
            if (cmb_Bookmark.Items.Count == 0)
                cmb_Bookmark.Text = "无书签";
            btn_bmDEL.Visible = false;
            but_addbm.Visible = true;
        }
        private void cmb_Bookmark_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMapBookmarks bookmarks = mapControl.Map as IMapBookmarks;
            IEnumSpatialBookmark enumSpatialBookmark = bookmarks.Bookmarks;

            enumSpatialBookmark.Reset();
            ISpatialBookmark spatialBookmark = enumSpatialBookmark.Next();
            while (spatialBookmark != null)
            {
                string index = cmb_Bookmark.SelectedIndex.ToString();
                string bm_name = cmb_Bookmark.Items[Convert.ToInt32(index)].ToString();
                //Console.WriteLine(bm_name + " "+ spatialBookmark.Name);

                if (bm_name == spatialBookmark.Name)
                {
                    spatialBookmark.ZoomTo((IMap)mapControl.ActiveView);
                    mapControl.ActiveView.Refresh();
                    break;
                }

                spatialBookmark = enumSpatialBookmark.Next();
            }

            btn_bmDEL.Visible = true;
            but_addbm.Visible = false;
        }
        
        
        private void btn_zoomin_gd_Click(object sender, EventArgs e)
        {
            qingchu();

            this.mapControl.CurrentTool = null;
            ICommand pCommand = new ControlsMapZoomInTool();
            ITool pTool = pCommand as ITool;
            pCommand.OnCreate(this.mapControl.Object);
            this.mapControl.CurrentTool = pTool;
        }
        private void btn_zoomout_gd_Click(object sender, EventArgs e)
        {
            qingchu();

            this.mapControl.CurrentTool = null;
            ICommand pCommand = new ControlsMapZoomOutTool();
            ITool pTool = pCommand as ITool;
            pCommand.OnCreate(this.mapControl.Object);
            this.mapControl.CurrentTool = pTool;
        }
        /// <summary>
        /// 创建书签
        /// </summary>
        public Boolean CreatBookmark(string sBookmarkName)
        {
            Console.WriteLine(sBookmarkName);
            IAOIBookmark aoiBookmark = new AOIBookmark();
            if (aoiBookmark != null)
            {
                aoiBookmark.Location = mapControl.ActiveView.Extent;
                aoiBookmark.Name = sBookmarkName;
            }

            IMapBookmarks bookmarks = mapControl.Map as IMapBookmarks;
            if (bookmarks != null)
            {
                bookmarks.AddBookmark(aoiBookmark);
                cmb_Bookmark.Items.Add(aoiBookmark.Name);
                return true;
            }
            return false;
        }
        /// <summary>
        /// 监听结束书签列表
        /// </summary>
        public Boolean oneBookmark(string name)
        {
            IMapBookmarks bookmarks = mapControl.Map as IMapBookmarks;
            IEnumSpatialBookmark enumSpatialBookmark = bookmarks.Bookmarks;

            enumSpatialBookmark.Reset();
            ISpatialBookmark spatialBookmark = enumSpatialBookmark.Next();
            while (spatialBookmark != null)
            {
                if (name == spatialBookmark.Name)
                {
                    return false;
                }

                spatialBookmark = enumSpatialBookmark.Next();
            }
            return true;
        }
        /// <summary>
        /// 加载文档
        /// </summary>
        private void addMapFile()
        {
            OpenFileDialog pOpenfileDialog = new OpenFileDialog();
            pOpenfileDialog.Filter = "全部文件|*.*" +
                "|Shape 文件|*.shp" +
                "|Mxd 文件|*.mxd" +
                "|栅格 文件|*.tif;*.tiff;*.jpep;*.jpg;*.png;*.bmp";
            if (pOpenfileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = pOpenfileDialog.FileName;
                bool shp = path.EndsWith(".shp");
                bool mxd = path.EndsWith(".mxd");
                bool tif = path.EndsWith(".tif") || path.EndsWith(".tiff") || path.EndsWith(".jpep") 
                    || path.EndsWith(".jpg") || path.EndsWith(".png") || path.EndsWith(".bmp");

                if (shp)
                {
                    openShpFile(path);
                }
                else if (mxd)
                {
                    openMXD(path);
                }
                else if (tif)
                {
                    openShanGe(path);
                }

            }
        }
        /// <summary>
        /// 打开shp数据
        /// </summary>
        private void openShpFile(string file)
        {
            int index = 0;
            //获取最后一个“\\”时的索引位置
            index = file.LastIndexOf("\\");
            //获得shp文件的路径
            string filePath = file.Substring(0, index);
            //获得shp文件名
            string fileName = file.Substring(index + 1, file.Length - (index + 1));
            //由工作空间工厂创建shp工作空间工厂类
            IWorkspaceFactory pWorkspaceFactory = new ShapefileWorkspaceFactory();
            //打开工作空间
            IWorkspace pWorkspace = pWorkspaceFactory.OpenFromFile(filePath, 0);
            //转换工作空间为要素工作空间
            IFeatureWorkspace pFeatureWorkspace = pWorkspace as IFeatureWorkspace;
            //打开要素类
            IFeatureClass pFC = pFeatureWorkspace.OpenFeatureClass(fileName);
            //创建要素图层
            IFeatureLayer pFLayer = new FeatureLayer();
            //设置图层的featureclass为上面打开的文件
            pFLayer.FeatureClass = pFC;
            //设置图层的名称
            pFLayer.Name = pFC.AliasName;
            //转换featurelayer为layer
            ILayer pLayer = pFLayer as ILayer;
            IMap pMap = mapControl.Map;
            //添加图层
            pMap.AddLayer(pLayer);
            //添加到渲染item
            string name = System.IO.Path.GetFileNameWithoutExtension(fileName);
            map_layer.Add(name);

            //刷新
            mapControl.ActiveView.Refresh();
        }
        /// <summary>
        /// 打开mxd数据
        /// </summary>
        private void openMXD(string path)
        {
            mapControl.MousePointer = esriControlsMousePointer.esriPointerHourglass;
            mapControl.LoadMxFile(path, 0, Type.Missing);
            mapControl.MousePointer = esriControlsMousePointer.esriPointerDefault;
            OpenStatus();
        }
        /// <summary>
        /// 打开栅格数据
        /// </summary>
        private void openShanGe(string Path)
        {
            string RasterPath = System.IO.Path.GetDirectoryName(Path);
            string RasterName = System.IO.Path.GetFileName(Path);
            //工作空间实例化
            IWorkspaceFactory pRasterWsF = new RasterWorkspaceFactory();
            IWorkspace pWs = pRasterWsF.OpenFromFile(RasterPath, 0);
            IRasterWorkspace pRasterWs = pWs as IRasterWorkspace;
            IRasterDataset pRasterDS = pRasterWs.OpenRasterDataset(RasterName);
            //影像金字塔的判断和创建
            IRasterPyramid pRasterPyramid = pRasterDS as IRasterPyramid;
            if ((pRasterPyramid != null)&&(!pRasterPyramid.Present))
            {
                if (MessageBox.Show("是否开始创建金字塔？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    //开始
                       pRasterPyramid.Create();
                    //结束
                    sw.Stop();
                    MessageBox.Show("创建完成，Time："+ sw.ElapsedMilliseconds.ToString()+"ms");
                }
                else
                        MessageBox.Show("放弃创建金字塔");
            }
            //新建栅格图层
            IRasterLayer pRasterLayer = new RasterLayer();
            pRasterLayer.CreateFromRaster(pRasterDS.CreateDefaultRaster());
            IMap pmap = mapControl.Map;
            //加载显示
            pmap.AddLayer(pRasterLayer);
            //mapControl.AddLayer(pRasterLayer, 0);
            mapControl.ActiveView.Refresh();
            OpenStatus();
        }

        private void OpenStatus()
        {
            MessageBox.Show("success");
            MessageBox.Show("当前比例尺：" + mapControl.MapScale.ToString());
        }

        /// <summary>
        /// 清除
        /// </summary>
        private void btn_qingchu_Click(object sender, EventArgs e)
        {
            qingchu();
        }
        public void qingchu()
        {
            flag_sc = 0;
            flag_select_three = 0;
            select_three = false;
        }

        private void toolSCB_Click(object sender, EventArgs e)
        {

        }

        public void xr_wy()
        {
            C_S_R csr = new C_S_R(mapControl);
            ILayer player = C_S_R.getGeoLayer("Export_Output");
            IRgbColor prgbcolor = C_S_R.getRGB(255, 0, 0);
            ISymbol psymbol = C_S_R.GetSymbolFromLayer(player);
            IColor pcolor = prgbcolor as IColor;

            bool bres = C_S_R.RenderSimply(player, pcolor);

            if (bres)
            {
                mapControl.ActiveView.ContentsChanged();
                mapControl.ActiveView.Refresh();
                btn_render.Enabled = false;
            }
            else
                MessageBox.Show("渲染失败");
        }

        private void btn_render_Click(object sender, EventArgs e)
        {
            //xr_wy();
            //Console.WriteLine();
            ////不带文件后缀的文件名
            //C_S_R.easy_xrender(cmb_xuanran.SelectedItem.ToString(), csr.getRGB(220, 220, 220), csr.getRGB(135, 206, 235));
            C_S_R csr = new C_S_R(mapControl);
            render render_r = new render(map_layer, csr);
            render_r.Show();
        }
        
        /// <summary>
        /// 同步布局
        /// </summary>
        public void copyToPageLayout()
        {
            IObjectCopy objectCopy = new ObjectCopy();//对象拷贝接口
            object copyFromMap = mapControl.Map;//地图对象
            object copyMap = objectCopy.Copy(copyFromMap);//将axMapControl1的地图对象拷贝
            object copyToMap = pagelayoutcontrol.ActiveView.FocusMap;//axPageLayoutControl1活动视图中的地图
            objectCopy.Overwrite(copyMap, ref copyToMap);//将axMapControl1地图对象覆盖axPageLayout1当前地图

        }

        private void mapControl_OnMapReplaced(object sender, IMapControlEvents2_OnMapReplacedEvent e)
        {
            copyToPageLayout();
        }

        private void mapControl_OnAfterScreenDraw(object sender, IMapControlEvents2_OnAfterScreenDrawEvent e)
        {
            IActiveView activeView = (IActiveView)pagelayoutcontrol.ActiveView.FocusMap;//axPageLayoutControl1的活动视图的地图
            IDisplayTransformation displayTransformation = activeView.ScreenDisplay.DisplayTransformation;//活动视图的屏幕显示的显示信息
            displayTransformation.VisibleBounds = mapControl.Extent;//将axMapControl1的范围赋值给axPageLayoutControl1的范围
            pagelayoutcontrol.ActiveView.Refresh();//刷新axPageLayoutControl1的活动视图
            copyToPageLayout();//将axMapControl1的地图拷贝到axPageLayoutControl1中
        }

        private void legend_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            pe.add_lenged();
            pagelayoutcontrol.Refresh();

        }

        private void sclar_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pe.add_scler();
            pagelayoutcontrol.Refresh();
        }

        private void rr_sclarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pe.add_rr_sclar();
            pagelayoutcontrol.Refresh();

        }

        private void grid_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pe.add_grid();
            pagelayoutcontrol.Refresh();

        }

        private void rr_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pe.add_rr();
            pagelayoutcontrol.Refresh();

        }

        private void northarrow_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pe.add_northarrow();
            pagelayoutcontrol.Refresh();

        }

        private void print_PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pe.PrintPageLayout())
                MessageBox.Show("Print Success");
            pagelayoutcontrol.Refresh();
        }

        private void choose_ele_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pGraphicsContainer.LocateElementsByEnvelope(envelope);
        }
    }
}
