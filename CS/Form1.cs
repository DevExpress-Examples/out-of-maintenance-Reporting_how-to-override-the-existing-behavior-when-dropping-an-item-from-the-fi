using System;
using System.Drawing.Design;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Browsing;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Design;

namespace WindowsApplication1 {
    public partial class Form1 : DevExpress.XtraReports.UserDesigner.XRDesignFormEx {
        static BarButtonItem bbiCustomControl;
        static Form1() {
        }
        public Form1() {
            InitializeComponent();
            XtraReport1 rep = new XtraReport1();
            rep.DesignerLoaded += new DevExpress.XtraReports.UserDesigner.DesignerLoadedEventHandler(rep_DesignerLoaded);
            this.xrDesignPanel.OpenReport(rep);

        }
        void rep_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e) {
            e.DesignerHost.RemoveService(typeof(IFieldListDragDropService));
            e.DesignerHost.AddService(typeof(IFieldListDragDropService),new MyFieldListDragDropService(e.DesignerHost));
        }
    }
    public class MyFieldListDragDropService : IFieldListDragDropService{
        IDesignerHost host;
        public MyFieldListDragDropService(IDesignerHost host){this.host = host;}
        public IDragHandler GetDragHandler() {
            return new MyFieldDragHandler(host);
        }
    }
    public class MyFieldDragHandler : FieldDragHandler {
        IDesignerHost host;
        public MyFieldDragHandler(IDesignerHost host)
            : base(host) {
            this.host = host;
        }
        static bool MIsContolContainer(XRControl control) {
            return control is Band || control is XRPanel;
        }
        public override void HandleDragDrop(object sender, DragEventArgs e) {

            Point dropPoint = new Point(e.X, e.Y);
            DataInfo[] droppedData = e.Data.GetData(typeof(DataInfo[])) as DataInfo[];
            XRControl control = bandViewSvc.GetControlByScreenPoint(dropPoint);
            
            if(MIsContolContainer(control)) {
                Size size = new Size(100,25);
                Point location = bandViewSvc.PointToClient(dropPoint, control);
                XRRichText l = null;
                for(int i = 0; i < droppedData.Length; i++) {
                    l = new XRRichText();
                    l.Size = size;
                    l.Location = location;
                    l.DataBindings.Add("Rtf", droppedData[i].Source, droppedData[i].Member);
                    ReportDesigner.AddToContainer(host, l);
                    control.Controls.Add(l);
                    location.X += 100;
                }
            }
            else
                base.HandleDragDrop(sender, e);

        }
    }
}