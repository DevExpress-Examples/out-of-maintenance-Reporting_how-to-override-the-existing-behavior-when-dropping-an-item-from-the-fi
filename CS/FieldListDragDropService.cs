using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data.Browsing;
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

            System.Drawing.Point dropPoint = new Point(e.X, e.Y);
            DataInfo[] droppedData = e.Data.GetData(typeof(DataInfo[])) as DataInfo[];
            XRControl control = bandViewSvc.GetControlByScreenPoint(dropPoint);

            if (MIsContolContainer(control)) {
                Size size = new Size(100, 25);
                DragDataObject dragData = GetDragData(e.Data);
                PointF location = bandViewSvc.PointToClient(dropPoint, dragData, control);
                XRRichText l = null;
                for (int i = 0; i < droppedData.Length; i++) {
                    l = new XRRichText();
                    l.Size = size;
                    l.Location = System.Drawing.Point.Ceiling(location);
                    l.DataBindings.Add("Rtf", droppedData[i].Source, droppedData[i].Member);
                    ReportDesigner.AddToContainer(mhost, l);
                    control.Controls.Add(l);
                    location.X += 100;
                }
            }
            else
                base.HandleDragDrop(sender, e);

        }

        static DragDataObject GetDragData(IDataObject dataObject) {
            return (DragDataObject)dataObject.GetData(typeof(DragDataObject));
        }

    }
}