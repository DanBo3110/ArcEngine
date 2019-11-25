using System;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Output;

namespace demo
{
    class pagelayout_element
    {
        private AxPageLayoutControl pageLayoutControl;
        private UID uid;
        private IEnvelope envelope;
        private IGraphicsContainer graphicsContainer;
        private IMapFrame mapFrame;
        private IMapSurroundFrame mapSurroundFrame;
        private IElement element;
        private ITrackCancel trackCancel;
        private IMap map;
        private IActiveView activeView;
        public pagelayout_element(AxPageLayoutControl pageLayout, IEnvelope envelope)
        {
            this.pageLayoutControl = pageLayout;
            this.element = element;

        }
        public void add_northarrow()
        {
            add("esriCarto.MarkerNorthArrow", 15, 23, 25, 30);
        }
        public void add_lenged()
        {
            add("esriCarto.legend", 2, 2, 3, 3);
        }
        public void add_scler()
        {
            add("esriCarto.ScaleLine", 1, 1, 10, 5);
        }

        public void add_rr_sclar()
        {
            add("esriCarto.ScaleText",4,4,5,5);
        }

        public void add_rr()
        {
            ITextElement textElement;
            ITextSymbol textSymbol;
            IColor color;
            activeView = pageLayoutControl.PageLayout as IActiveView;
            envelope = new Envelope() as IEnvelope;
            envelope.PutCoords(7, 20, 15, 30);
            textElement = new TextElement() as ITextElement;
            element = textElement as IElement;
            element.Geometry = envelope;
            textElement.Text = "实验五地图";
            textSymbol = new TextSymbol();
            color = C_S_R.getRGB(0,0,0);
            textSymbol.Color = color;
            textSymbol.Size = 30;
            textElement.Symbol = textSymbol;
            graphicsContainer = activeView as IGraphicsContainer;
            graphicsContainer.AddElement(element, 0);
        }

        public void add(string value,double xmin,double ymin, double xmax, double ymax)
        {
            uid = new UID();
            uid.Value = value;
            envelope = new Envelope() as IEnvelope;
            envelope.PutCoords(xmin, ymin, xmax, ymax);
            graphicsContainer = pageLayoutControl.PageLayout as IGraphicsContainer;
            mapFrame = graphicsContainer.FindFrame(pageLayoutControl.ActiveView.FocusMap) as IMapFrame;
            mapSurroundFrame = mapFrame.CreateSurroundFrame(uid, null);
            element = mapSurroundFrame as IElement;
            element.Geometry = envelope;
            element.Activate(pageLayoutControl.ActiveView.ScreenDisplay);
            trackCancel = new CancelTracker();
            element.Draw(pageLayoutControl.ActiveView.ScreenDisplay, trackCancel);
            graphicsContainer.AddElement(element, 0);
        }

        public void add_grid()
        {
            activeView = pageLayoutControl.PageLayout as IActiveView;
            map = activeView.FocusMap;

            IMapGrid mapGrid;
            IMeasuredGrid measuredGrid;
            measuredGrid = new MeasuredGrid() as IMeasuredGrid;
            mapGrid = measuredGrid as IMapGrid;
            measuredGrid.FixedOrigin = true;
            measuredGrid.Units = map.MapUnits;
            measuredGrid.XIntervalSize = 10;
            measuredGrid.YIntervalSize = 10;
            measuredGrid.XOrigin = -180;
            measuredGrid.YOrigin = -90;

            IProjectedGrid projectedGrid;
            projectedGrid = measuredGrid as IProjectedGrid;
            projectedGrid.SpatialReference = map.SpatialReference;
            mapGrid.Name = "Measured Grid";
            IMapFrame mapFrame;
            IGraphicsContainer graphicsContainer;
            graphicsContainer = activeView as IGraphicsContainer;
            mapFrame = graphicsContainer.FindFrame(map) as IMapFrame;
            IMapGrids mapGrids = mapFrame as IMapGrids;
            mapGrids.AddMapGrid(mapGrid);
            activeView.PartialRefresh(esriViewDrawPhase.esriViewBackground, null, null);
        }

        public Boolean PrintPageLayout()
        {
            try
            {
                if (pageLayoutControl.Printer != null)
                {
                    IPrinter pPrinter = pageLayoutControl.Printer;
                    if (pPrinter.Paper.Orientation != pageLayoutControl.Page.Orientation)
                    {
                        pPrinter.Paper.Orientation = pageLayoutControl.Page.Orientation;
                    }
                    pageLayoutControl.PrintPageLayout(1, 0, 0);
                }
                return true;
            }
            catch (Exception)
            {

                throw;
                return false;
            }
        }
    }
}
