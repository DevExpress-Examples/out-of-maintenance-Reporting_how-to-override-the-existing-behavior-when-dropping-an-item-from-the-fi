using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UI;

namespace FieldListDragDrop {
    public class MyFieldListDragDropService : IFieldListDragDropService {
        IDesignerHost host;
        public MyFieldListDragDropService(IDesignerHost host) { this.host = host; }
        public IDragHandler GetDragHandler() {
            return new MyFieldDragHandler(host);
        }
    }
    public class MyFieldDragHandler : FieldDragHandler {
        IDesignerHost mhost;
        public MyFieldDragHandler(IDesignerHost host)
            : base(host) {
            this.mhost = host;
        }
        static bool MIsContolContainer(XRControl control) {
            return control is Band || control is XRPanel;
        }
        public override void HandleDragDrop(object sender, DragEventArgs e) {
            AdornerService.ResetSnapping();
            RulerService.HideShadows();

            XRControl parent = bandViewSvc.GetControlByScreenPoint(new Point(e.X, e.Y));
            if (parent == null)
                return;

            XRControl control = (XRControl)Activator.CreateInstance(typeof(XRControl));

            PointF basePoint = EvalBasePoint(e);
            RectangleF controlRect = new RectangleF(basePoint, control.BoundsF.Size);
            PointF dropPoint = bandViewSvc.PointToClientRelativeToBand(basePoint,
                new DragDataObject(new XRControl[] { control }, control, 
                    new RectangleF[] { controlRect }, controlRect));
            XRRichText xRLabel = new XRRichText();

            DesignTool.AddToContainer(host, xRLabel);

            PointF location = PointToClient(xRLabel, dropPoint);

            xRLabel.LocationF = location;
            xRLabel.Size = new Size(100, 25);
            xRLabel.DataBindings.Add("Rtf", null, "test");


        }
        static DragDataObject GetDragData(IDataObject dataObject) {
            return (DragDataObject)dataObject.GetData(typeof(DragDataObject));
        }
        PointF PointToClient(XRControl control, PointF screenPoint) {
            return ZoomService.GetInstance(host).
                FromScaledPixels(bandViewSvc.PointToClient(screenPoint, null, control), ReportDpi);
        }
        protected float ReportDpi {
            get {
                return ((XtraReport)host.RootComponent).Dpi;
            }
        }
    }
}