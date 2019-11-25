using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;

namespace demo
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            //axMapControl1.AddShapeFile("D:\\Study\\Study_地理信息技术课程\\地信\\实训\\Data\\1.1", "Export_Output.shp");
            
        }
        //加载地图文档
        //private void loadMapDocument()
        //{
        //    System.Windows.Forms.OpenFileDialog openFileDialog;
        //    openFileDialog = new OpenFileDialog();
        //    openFileDialog.Title = "打开地图文档";
        //    openFileDialog.Filter = "map documents(*.mxd)|*.mxd";
        //    openFileDialog.ShowDialog();
        //    string filePath = openFileDialog.FileName;
        //    if (axMapControl1.CheckMxFile(filePath))
        //    {
        //        axMapControl1.MousePointer = esriControlsMousePointer.esriPointerHourglass;
        //        axMapControl1.LoadMxFile(filePath, 0, Type.Missing);
        //        axMapControl1.MousePointer = esriControlsMousePointer.esriPointerDefault;
        //    }
        //    else
        //    {
        //        MessageBox.Show(filePath + "不是有效的地图文档");
        //    }
        //}
        ////IMap pMap = axMapControl1.Map;
        ////IActiveView pActiveView = pMap as IActiveView;
        ////IFeatureLayer pFeatureLayer = pMap.get_Layer(0) as IFeatureLayer;
        ////IFeatureClass pFeatureClass = pFeatureLayer.FeatureClass;

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    //预加载书签列表
        //    cmb_Bookmark.Text = "书签";
        //}
        

        //private void toolSCB_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string index = toolSCB.SelectedIndex.ToString();
        //    Console.WriteLine(index);
        //    if (index == "0")
        //    {
        //        pan_mapSX.Visible = false;
        //        panel1.Visible = true;
        //        Console.WriteLine("0000000");
        //    }
        //    if (index == "2")
        //    {
        //        pan_mapSX.Visible = true;
        //        Console.WriteLine("success");
        //    }
        //}

        //public Boolean oneBookmark(string name)
        //{
        //    IMapBookmarks bookmarks = axMapControl1.Map as IMapBookmarks;
        //    IEnumSpatialBookmark enumSpatialBookmark = bookmarks.Bookmarks;

        //    enumSpatialBookmark.Reset();
        //    ISpatialBookmark spatialBookmark = enumSpatialBookmark.Next();
        //    while (spatialBookmark != null)
        //    {
        //        if (name == spatialBookmark.Name)
        //        {
        //            return false;
        //        }

        //        spatialBookmark = enumSpatialBookmark.Next();
        //    }
        //    return true;
        //}
        //public Boolean CreatBookmark(string sBookmarkName)
        //{
        //    Console.WriteLine(sBookmarkName);
        //    IAOIBookmark aoiBookmark = new AOIBookmark();
        //    if(aoiBookmark!=null)
        //    {
        //        aoiBookmark.Location = axMapControl1.ActiveView.Extent;
        //        aoiBookmark.Name = sBookmarkName;
        //    }

        //    IMapBookmarks bookmarks = axMapControl1.Map as IMapBookmarks;
        //    if(bookmarks!=null )
        //    {
        //        bookmarks.AddBookmark(aoiBookmark);
        //        cmb_Bookmark.Items.Add(aoiBookmark.Name);
        //        return true;
        //    }
        //    return false;
        //}


        //private void but_addbm_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void cmb_Bookmark_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    IMapBookmarks bookmarks = axMapControl1.Map as IMapBookmarks;
        //    IEnumSpatialBookmark enumSpatialBookmark = bookmarks.Bookmarks;

        //    enumSpatialBookmark.Reset();
        //    ISpatialBookmark spatialBookmark = enumSpatialBookmark.Next();
        //    while (spatialBookmark != null)
        //    {
        //        string index = cmb_Bookmark.SelectedIndex.ToString();
        //        string bm_name = cmb_Bookmark.Items[Convert.ToInt32(index)].ToString();
        //        //Console.WriteLine(bm_name + " "+ spatialBookmark.Name);

        //        if (bm_name == spatialBookmark.Name)
        //        {
        //            spatialBookmark.ZoomTo((IMap)axMapControl1.ActiveView);
        //            axMapControl1.ActiveView.Refresh();
        //            break;
        //        }

        //        spatialBookmark = enumSpatialBookmark.Next();
        //    }

        //    btn_bmDEL.Visible = true;
            
        //}
        //private void btn_bmDEL_Click(object sender, EventArgs e)
        //{
        //    cmb_Bookmark.Items.Remove(cmb_Bookmark.SelectedItem);
        //    cmb_Bookmark.Text="";
        //    if (cmb_Bookmark.Items.Count == 0)
        //        cmb_Bookmark.Text = "无书签";

        //}

        //private void btn_bilichi_Click(object sender, EventArgs e)
        //{
        //    bilichi blc = new bilichi(axMapControl1.MapScale.ToString());
        //    blc.Show();
        //    Console.WriteLine(axMapControl1.MapScale.ToString());
        //}

        //private void axMapControl1_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        //{
        //    //实时获取鼠标坐标
        //}

        //// 获取要素类
        //private static IFeatureClass GetFeatureClass(string filePath)
        //{
        //    Console.WriteLine("jinkailei");
        //    IWorkspaceFactory pWorkspaceFactory = new ShapefileWorkspaceFactory();
        //    IWorkspaceFactoryLockControl pWorkspaceFactoryLockControl = pWorkspaceFactory as IWorkspaceFactoryLockControl;
        //    if (pWorkspaceFactoryLockControl.SchemaLockingEnabled)
        //    {
        //        pWorkspaceFactoryLockControl.DisableSchemaLocking();
        //    }
        //    IWorkspace pWorkspace = pWorkspaceFactory.OpenFromFile(System.IO.Path.GetDirectoryName(filePath), 0);
        //    IFeatureWorkspace pFeatureWorkspace = pWorkspace as IFeatureWorkspace;
        //    IFeatureClass pFeatureClass = pFeatureWorkspace.OpenFeatureClass(System.IO.Path.GetFileName(filePath));
        //    return pFeatureClass;
        //}
        //// 获取要素属性表
        //private static DataTable GetAttributesTable(IFeatureClass pFeatureClass)
        //{
        //    string geometryType = string.Empty;
        //    if (pFeatureClass.ShapeType == esriGeometryType.esriGeometryPoint)
        //    {
        //        geometryType = "点";
        //    }
        //    if (pFeatureClass.ShapeType == esriGeometryType.esriGeometryMultipoint)
        //    {
        //        geometryType = "点集";
        //    }
        //    if (pFeatureClass.ShapeType == esriGeometryType.esriGeometryPolyline)
        //    {
        //        geometryType = "折线";
        //    }
        //    if (pFeatureClass.ShapeType == esriGeometryType.esriGeometryPolygon)
        //    {
        //        geometryType = "面";
        //    }
        //    Console.WriteLine(geometryType);
        //    // 字段集合
        //    IFields pFields = pFeatureClass.Fields;
        //    int fieldsCount = pFields.FieldCount;

        //    // 写入字段名
        //    DataTable dataTable = new DataTable();
        //    for (int i = 0; i < fieldsCount; i++)
        //    {
        //        dataTable.Columns.Add(pFields.get_Field(i).Name);
        //        Console.WriteLine(pFields.get_Field(i).Name);
        //    }

        //    // 要素游标
        //    IFeatureCursor pFeatureCursor = pFeatureClass.Search(null, true);
        //    IFeature pFeature = pFeatureCursor.NextFeature();
        //    if (pFeature == null)
        //    {
        //        return dataTable;
        //    }

        //    // 获取MZ值
        //    IMAware pMAware = pFeature.Shape as IMAware;
        //    IZAware pZAware = pFeature.Shape as IZAware;
        //    if (pMAware.MAware)
        //    {
        //        geometryType += " M";
        //    }
        //    if (pZAware.ZAware)
        //    {
        //        geometryType += "Z";
        //    }

        //    // 写入字段值
        //    while (pFeature != null)
        //    {
        //        DataRow dataRow = dataTable.NewRow();
        //        for (int i = 0; i < fieldsCount; i++)
        //        {
        //            if (pFields.get_Field(i).Type == esriFieldType.esriFieldTypeGeometry)
        //            {
        //                dataRow[i] = geometryType;
        //            }
        //            else
        //            {
        //                dataRow[i] = pFeature.get_Value(i).ToString();
        //            }
        //        }
        //        dataTable.Rows.Add(dataRow);
        //        pFeature = pFeatureCursor.NextFeature();
        //    }

        //    // 释放游标
        //    System.Runtime.InteropServices.Marshal.ReleaseComObject(pFeatureCursor);
        //    return dataTable;
        //}
        //// 读取
        //private void btnShowTable_Click_1(object sender, EventArgs e)
        //{
        //    IFeatureClass pFeatureClass = GetFeatureClass
        //        (@"D:\\Study\\Study_地理信息技术课程\\地信\\实训\\Data\\1.1\Export_Output.shp");
        //    DataTable dataTable = GetAttributesTable(pFeatureClass);
        //    dgvAttributesTable.DataSource = dataTable;
        //}
        ////漫游标记
        //private int flag_sc = 0;
        //private int flag_select_three = 0;

        //private Boolean select_three = false;


        //private void but_zoomin_Click(object sender, EventArgs e)
        //{
        //    axMapControl1.CurrentTool = null;
            
        //    axMapControl1.MousePointer = esriControlsMousePointer.esriPointerPageZoomIn;
        //    flag_sc = 1;
           
        //}
        //private void btu_zoomout_Click(object sender, EventArgs e)
        //{
        //    axMapControl1.MousePointer = esriControlsMousePointer.esriPointerPageZoomOut;
        //    flag_sc = 2;
        //}
        //private void btn_pan_Click(object sender, EventArgs e)
        //{
        //    axMapControl1.MousePointer = esriControlsMousePointer.esriPointerPan;
        //    flag_sc = 3;
        //}

        //private void btn_pointsele_Click(object sender, EventArgs e)
        //{
        //    flag_select_three = 1;
        //    select_three = true;
        //}

        //private void btn_circlesele_Click(object sender, EventArgs e)
        //{
        //    flag_select_three = 2;
        //    select_three = true;
        //}

        //private void btn_juxingsele_Click(object sender, EventArgs e)
        //{
        //    flag_select_three = 3;
        //    select_three = true;
        //}
        //private void btn_moresele_Click(object sender, EventArgs e)
        //{
        //    flag_select_three = 4;
        //    select_three = true;
        //}
        ////清除选择
        //private void btn_nosele_Click(object sender, EventArgs e)
        //{
            
        //    IActiveView pActiveView = (IActiveView)(axMapControl1.Map);
        //    pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, axMapControl1.get_Layer(0), null);
        //    axMapControl1.Map.ClearSelection();
        //    pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, axMapControl1.get_Layer(0), null);
        //}
        //private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        //{
        //    IEnvelope ipenv = axMapControl1.TrackRectangle();
        //    axMapControl1.MousePointer = esriControlsMousePointer.esriPointerCrosshair;
        //    IGeometry geometry = null;
        //    Console.Write(flag_sc);

        //    switch (flag_sc)
        //    {
        //        case 1:
        //            //放大
        //            axMapControl1.Extent = ipenv;
        //            break;
        //        case 2:
        //            //缩小
        //            ipenv = axMapControl1.Extent;
        //            ipenv.Expand(2, 2, true);
        //            axMapControl1.Extent = ipenv;
        //            break;
        //        case 3:
        //            //平移
        //            ipenv = axMapControl1.Extent;
        //            axMapControl1.Pan();
        //            break;
        //    }
        //    flag_sc = 0;


        //    if (select_three == true)
        //    {
        //        switch (flag_select_three)
        //        {
        //            case 1:
        //                ESRI.ArcGIS.Geometry.Point point = new ESRI.ArcGIS.Geometry.Point();
        //                point.X = e.mapX;
        //                point.Y = e.mapY;
        //                geometry = point as IGeometry;
        //                break;
        //            case 2:
        //                geometry = axMapControl1.TrackCircle();
        //                break;
        //            case 3:
        //                geometry = axMapControl1.TrackRectangle();
        //                break;
        //            case 4:
        //                geometry = axMapControl1.TrackPolygon();
        //                break;
        //        }
        //        axMapControl1.Map.SelectByShape(geometry, null, false);
        //        axMapControl1.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null);
        //        select_three = false;

        //    }
        //}

        //private void btn_zoomin_gd_Click(object sender, EventArgs e)
        //{
        //    flag_sc = 0;
        //    this.axMapControl1.CurrentTool = null;
        //    ICommand pCommand = new ControlsMapZoomInTool();
        //    ITool pTool = pCommand as ITool;
        //    pCommand.OnCreate(this.axMapControl1.Object);
        //    this.axMapControl1.CurrentTool = pTool;
        //}

        //private void btn_zoomout_gd_Click(object sender, EventArgs e)
        //{
        //    flag_sc = 0;
        //    this.axMapControl1.CurrentTool = null;
        //    ICommand pCommand = new ControlsMapZoomOutTool();
        //    ITool pTool = pCommand as ITool;
        //    pCommand.OnCreate(this.axMapControl1.Object);
        //    this.axMapControl1.CurrentTool = pTool;
        //}

        //private void toolSCB_Click(object sender, EventArgs e)
        //{

        //}

        //private void axTbControl_top_main_OnMouseDown(object sender, IToolbarControlEvents_OnMouseDownEvent e)
        //{

        //}
    }
    
}
