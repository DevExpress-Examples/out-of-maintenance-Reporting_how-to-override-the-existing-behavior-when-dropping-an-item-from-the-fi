Imports Microsoft.VisualBasic
Imports System.ComponentModel.Design
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Data.Browsing
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.UI

Namespace FieldListDragDrop
	Public Class MyFieldListDragDropService
		Implements IFieldListDragDropService
		Private host As IDesignerHost
		Public Sub New(ByVal host As IDesignerHost)
			Me.host = host
		End Sub
        Public Function GetDragHandler() As IDragHandler Implements IFieldListDragDropService.GetDragHandler
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

            Dim dropPoint As System.Drawing.Point = New System.Drawing.Point(e.X, e.Y)
			Dim droppedData() As DataInfo = TryCast(e.Data.GetData(GetType(DataInfo())), DataInfo())
			Dim control As XRControl = bandViewSvc.GetControlByScreenPoint(dropPoint)

			If MIsContolContainer(control) Then
				Dim size As New Size(100, 25)
				Dim dragData As DragDataObject = GetDragData(e.Data)
				Dim location As PointF = bandViewSvc.PointToClient(dropPoint, dragData, control)
				Dim l As XRRichText = Nothing
				For i As Integer = 0 To droppedData.Length - 1
					l = New XRRichText()
					l.Size = size
					l.Location = System.Drawing.Point.Ceiling(location)
					l.DataBindings.Add("Rtf", droppedData(i).Source, droppedData(i).Member)
					ReportDesigner.AddToContainer(mhost, l)
					control.Controls.Add(l)
					location.X += 100
				Next i
			Else
				MyBase.HandleDragDrop(sender, e)
			End If

		End Sub

		Private Shared Function GetDragData(ByVal dataObject As IDataObject) As DragDataObject
			Return CType(dataObject.GetData(GetType(DragDataObject)), DragDataObject)
		End Function

	End Class
End Namespace