Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing.Design
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Data.Browsing
Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Design

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits DevExpress.XtraReports.UserDesigner.XRDesignFormEx
		Private Shared bbiCustomControl As BarButtonItem
		Shared Sub New()
		End Sub
		Public Sub New()
			InitializeComponent()
			Dim rep As New XtraReport1()
			AddHandler rep.DesignerLoaded, AddressOf rep_DesignerLoaded
			Me.xrDesignPanel.OpenReport(rep)

		End Sub
		Private Sub rep_DesignerLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs)
			e.DesignerHost.RemoveService(GetType(IFieldListDragDropService))
			e.DesignerHost.AddService(GetType(IFieldListDragDropService),New MyFieldListDragDropService(e.DesignerHost))
		End Sub
	End Class
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
		Private host As IDesignerHost
		Public Sub New(ByVal host As IDesignerHost)
			MyBase.New(host)
			Me.host = host
		End Sub
		Private Shared Function MIsContolContainer(ByVal control As XRControl) As Boolean
			Return TypeOf control Is Band OrElse TypeOf control Is XRPanel
		End Function
		Public Overrides Sub HandleDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)

			Dim dropPoint As New System.Drawing.Point(e.X, e.Y)
			Dim droppedData() As DataInfo = TryCast(e.Data.GetData(GetType(DataInfo())), DataInfo())
			Dim control As XRControl = bandViewSvc.GetControlByScreenPoint(dropPoint)

			If MIsContolContainer(control) Then
				Dim size As New Size(100,25)
				Dim location As System.Drawing.Point = bandViewSvc.PointToClient(dropPoint, control)
				Dim l As XRRichText = Nothing
				For i As Integer = 0 To droppedData.Length - 1
					l = New XRRichText()
					l.Size = size
					l.Location = location
					l.DataBindings.Add("Rtf", droppedData(i).Source, droppedData(i).Member)
					ReportDesigner.AddToContainer(host, l)
					control.Controls.Add(l)
					location.X += 100
				Next i
			Else
				MyBase.HandleDragDrop(sender, e)
			End If

		End Sub
	End Class
End Namespace