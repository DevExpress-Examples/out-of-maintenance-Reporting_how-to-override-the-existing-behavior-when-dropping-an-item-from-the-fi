Imports System
Imports System.ComponentModel.Design
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.UI

Namespace FieldListDragDrop
    Public Class MyFieldListDragDropService
        Implements IFieldListDragDropService
        Private host As IDesignerHost
        Public Sub New(ByVal host As IDesignerHost)
            Me.host = host
        End Sub
        Public Function GetDragHandler() As IDragHandler _
        Implements IFieldListDragDropService.GetDragHandler
            Return New MyFieldDragHandler(host)
        End Function
    End Class

    Public Class MyFieldDragHandler
        Inherits FieldDragHandler
        Private mhost As IDesignerHost
        Public Sub New(ByVal host As IDesignerHost)
            MyBase.New(host)
            Me.mhost = host
        End Sub
        Private Shared Function MIsContolContainer(ByVal control As XRControl) As Boolean
            Return TypeOf control Is Band OrElse TypeOf control Is XRPanel
        End Function
        Public Overrides Sub HandleDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            AdornerService.ResetSnapping()
            RulerService.HideShadows()

            Dim parent As XRControl = _
                bandViewSvc.GetControlByScreenPoint(New System.Drawing.Point(e.X, e.Y))
            If parent Is Nothing Then
                Return
            End If

            Dim control As XRControl = CType(Activator.CreateInstance(GetType(XRControl)), XRControl)

            Dim basePoint As PointF = EvalBasePoint(e)
            Dim controlRect As New RectangleF(basePoint, control.BoundsF.Size)
            Dim dropPoint As PointF = bandViewSvc.PointToClientRelativeToBand(basePoint, _
                New DragDataObject(New XRControl() {control}, control, New RectangleF() _
                                   {controlRect}, controlRect))
            Dim xRLabel As New XRRichText()

            DesignTool.AddToContainer(host, xRLabel)

            Dim location As PointF = PointToClient(xRLabel, dropPoint)

            xRLabel.LocationF = location
            xRLabel.Size = New Size(100, 25)
            xRLabel.DataBindings.Add("Rtf", Nothing, "test")


        End Sub
        Private Shared Function GetDragData(ByVal dataObject As IDataObject) As DragDataObject
            Return CType(dataObject.GetData(GetType(DragDataObject)), DragDataObject)
        End Function
        Private Function PointToClient(ByVal control As XRControl, ByVal screenPoint As PointF) As PointF
            Return ZoomService.GetInstance(host).FromScaledPixels(bandViewSvc.PointToClient(screenPoint, _
                                                                                            Nothing, control), ReportDpi)
        End Function
        Protected ReadOnly Property ReportDpi() As Single
            Get
                Return (CType(host.RootComponent, XtraReport)).Dpi
            End Get
        End Property
    End Class
End Namespace