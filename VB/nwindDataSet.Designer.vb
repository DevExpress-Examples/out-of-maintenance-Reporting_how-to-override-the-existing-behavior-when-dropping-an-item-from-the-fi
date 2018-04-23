'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

'TODO: INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning disable 1591


Imports Microsoft.VisualBasic
	Imports System
Namespace WindowsApplication1


	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), Serializable(), System.ComponentModel.DesignerCategoryAttribute("code"), System.ComponentModel.ToolboxItem(True), System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"), System.Xml.Serialization.XmlRootAttribute("nwindDataSet"), System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")> _
	Partial Public Class nwindDataSet
		Inherits System.Data.DataSet

		Private tableCategories As CategoriesDataTable

		Private _schemaSerializationMode As System.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Sub New()
			Me.BeginInit()
			Me.InitClass()
			Dim schemaChangedHandler As New System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
			AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
			AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
			Me.EndInit()
		End Sub

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
			MyBase.New(info, context, False)
			If (Me.IsBinarySerialized(info, context) = True) Then
				Me.InitVars(False)
				Dim schemaChangedHandler1 As New System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
				AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
				AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
				Return
			End If
			Dim strSchema As String = (CStr(info.GetValue("XmlSchema", GetType(String))))
			If (Me.DetermineSchemaSerializationMode(info, context) = System.Data.SchemaSerializationMode.IncludeSchema) Then
				Dim ds As New System.Data.DataSet()
				ds.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
				If (ds.Tables("Categories") IsNot Nothing) Then
					MyBase.Tables.Add(New CategoriesDataTable(ds.Tables("Categories")))
				End If
				Me.DataSetName = ds.DataSetName
				Me.Prefix = ds.Prefix
				Me.Namespace = ds.Namespace
				Me.Locale = ds.Locale
				Me.CaseSensitive = ds.CaseSensitive
				Me.EnforceConstraints = ds.EnforceConstraints
				Me.Merge(ds, False, System.Data.MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
			End If
			Me.GetSerializationData(info, context)
			Dim schemaChangedHandler As New System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
			AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
			AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
		End Sub

		<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.Browsable(False), System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property Categories() As CategoriesDataTable
			Get
				Return Me.tableCategories
			End Get
		End Property

		<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.BrowsableAttribute(True), System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)> _
		Public Overrides Property SchemaSerializationMode() As System.Data.SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(ByVal value As System.Data.SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Tables() As System.Data.DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Relations() As System.Data.DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Sub InitializeDerivedDataSet()
			Me.BeginInit()
			Me.InitClass()
			Me.EndInit()
		End Sub

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Overrides Function Clone() As System.Data.DataSet
			Dim cln As nwindDataSet = (CType(MyBase.Clone(), nwindDataSet))
			cln.InitVars()
			cln.SchemaSerializationMode = Me.SchemaSerializationMode
			Return cln
		End Function

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Function ShouldSerializeRelations() As Boolean
			Return False
		End Function

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Sub ReadXmlSerializable(ByVal reader As System.Xml.XmlReader)
			If (Me.DetermineSchemaSerializationMode(reader) = System.Data.SchemaSerializationMode.IncludeSchema) Then
				Me.Reset()
				Dim ds As New System.Data.DataSet()
				ds.ReadXml(reader)
				If (ds.Tables("Categories") IsNot Nothing) Then
					MyBase.Tables.Add(New CategoriesDataTable(ds.Tables("Categories")))
				End If
				Me.DataSetName = ds.DataSetName
				Me.Prefix = ds.Prefix
				Me.Namespace = ds.Namespace
				Me.Locale = ds.Locale
				Me.CaseSensitive = ds.CaseSensitive
				Me.EnforceConstraints = ds.EnforceConstraints
				Me.Merge(ds, False, System.Data.MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXml(reader)
				Me.InitVars()
			End If
		End Sub

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
			Dim stream As New System.IO.MemoryStream()
			Me.WriteXmlSchema(New System.Xml.XmlTextWriter(stream, Nothing))
			stream.Position = 0
			Return System.Xml.Schema.XmlSchema.Read(New System.Xml.XmlTextReader(stream), Nothing)
		End Function

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Friend Sub InitVars()
			Me.InitVars(True)
		End Sub

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Friend Sub InitVars(ByVal initTable As Boolean)
			Me.tableCategories = (CType(MyBase.Tables("Categories"), CategoriesDataTable))
			If (initTable = True) Then
				If (Me.tableCategories IsNot Nothing) Then
					Me.tableCategories.InitVars()
				End If
			End If
		End Sub

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub InitClass()
			Me.DataSetName = "nwindDataSet"
			Me.Prefix = ""
			Me.Namespace = "http://tempuri.org/nwindDataSet.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			Me.tableCategories = New CategoriesDataTable()
			MyBase.Tables.Add(Me.tableCategories)
		End Sub

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Function ShouldSerializeCategories() As Boolean
			Return False
		End Function

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
			If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
				Me.InitVars()
			End If
		End Sub

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Shared Function GetTypedDataSetSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
			Dim ds As New nwindDataSet()
			Dim type As New System.Xml.Schema.XmlSchemaComplexType()
			Dim sequence As New System.Xml.Schema.XmlSchemaSequence()
			xs.Add(ds.GetSchemaSerializable())
			Dim any As New System.Xml.Schema.XmlSchemaAny()
			any.Namespace = ds.Namespace
			sequence.Items.Add(any)
			type.Particle = sequence
			Return type
		End Function

		Public Delegate Sub CategoriesRowChangeEventHandler(ByVal sender As Object, ByVal e As CategoriesRowChangeEvent)

		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), System.Serializable(), System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
		Partial Public Class CategoriesDataTable
			Inherits System.Data.DataTable
			Implements System.Collections.IEnumerable

			Private columnCategoryID As System.Data.DataColumn

			Private columnCategoryName As System.Data.DataColumn

			Private columnDescription As System.Data.DataColumn

			Private columnPicture As System.Data.DataColumn

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub New()
				Me.TableName = "Categories"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Friend Sub New(ByVal table As System.Data.DataTable)
				Me.TableName = table.TableName
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property CategoryIDColumn() As System.Data.DataColumn
				Get
					Return Me.columnCategoryID
				End Get
			End Property

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property CategoryNameColumn() As System.Data.DataColumn
				Get
					Return Me.columnCategoryName
				End Get
			End Property

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property DescriptionColumn() As System.Data.DataColumn
				Get
					Return Me.columnDescription
				End Get
			End Property

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property PictureColumn() As System.Data.DataColumn
				Get
					Return Me.columnPicture
				End Get
			End Property

			<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Default Public ReadOnly Property Item(ByVal index As Integer) As CategoriesRow
				Get
					Return (CType(Me.Rows(index), CategoriesRow))
				End Get
			End Property

			Public Event CategoriesRowChanging As CategoriesRowChangeEventHandler

			Public Event CategoriesRowChanged As CategoriesRowChangeEventHandler

			Public Event CategoriesRowDeleting As CategoriesRowChangeEventHandler

			Public Event CategoriesRowDeleted As CategoriesRowChangeEventHandler

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub AddCategoriesRow(ByVal row As CategoriesRow)
				Me.Rows.Add(row)
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function AddCategoriesRow(ByVal CategoryName As String, ByVal Description As String, ByVal Picture() As Byte) As CategoriesRow
				Dim rowCategoriesRow As CategoriesRow = (CType(Me.NewRow(), CategoriesRow))
				rowCategoriesRow.ItemArray = New Object() { Nothing, CategoryName, Description, Picture}
				Me.Rows.Add(rowCategoriesRow)
				Return rowCategoriesRow
			End Function

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function FindByCategoryID(ByVal CategoryID As Integer) As CategoriesRow
				Return (CType(Me.Rows.Find(New Object() { CategoryID}), CategoriesRow))
			End Function

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Overridable Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
				Return Me.Rows.GetEnumerator()
			End Function

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Overrides Function Clone() As System.Data.DataTable
				Dim cln As CategoriesDataTable = (CType(MyBase.Clone(), CategoriesDataTable))
				cln.InitVars()
				Return cln
			End Function

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Function CreateInstance() As System.Data.DataTable
				Return New CategoriesDataTable()
			End Function

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Friend Sub InitVars()
				Me.columnCategoryID = MyBase.Columns("CategoryID")
				Me.columnCategoryName = MyBase.Columns("CategoryName")
				Me.columnDescription = MyBase.Columns("Description")
				Me.columnPicture = MyBase.Columns("Picture")
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Private Sub InitClass()
				Me.columnCategoryID = New System.Data.DataColumn("CategoryID", GetType(Integer), Nothing, System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnCategoryID)
				Me.columnCategoryName = New System.Data.DataColumn("CategoryName", GetType(String), Nothing, System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnCategoryName)
				Me.columnDescription = New System.Data.DataColumn("Description", GetType(String), Nothing, System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnDescription)
				Me.columnPicture = New System.Data.DataColumn("Picture", GetType(Byte()), Nothing, System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnPicture)
				Me.Constraints.Add(New System.Data.UniqueConstraint("Constraint1", New System.Data.DataColumn() { Me.columnCategoryID}, True))
				Me.columnCategoryID.AutoIncrement = True
				Me.columnCategoryID.AllowDBNull = False
				Me.columnCategoryID.Unique = True
				Me.columnCategoryName.MaxLength = 15
				Me.columnDescription.MaxLength = 536870910
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function NewCategoriesRow() As CategoriesRow
				Return (CType(Me.NewRow(), CategoriesRow))
			End Function

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Function NewRowFromBuilder(ByVal builder As System.Data.DataRowBuilder) As System.Data.DataRow
				Return New CategoriesRow(builder)
			End Function

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Function GetRowType() As System.Type
				Return GetType(CategoriesRow)
			End Function

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowChanged(ByVal e As System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Me.CategoriesRowChangedEvent IsNot Nothing) Then
					RaiseEvent CategoriesRowChanged(Me, New CategoriesRowChangeEvent((CType(e.Row, CategoriesRow)), e.Action))
				End If
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowChanging(ByVal e As System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Me.CategoriesRowChangingEvent IsNot Nothing) Then
					RaiseEvent CategoriesRowChanging(Me, New CategoriesRowChangeEvent((CType(e.Row, CategoriesRow)), e.Action))
				End If
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowDeleted(ByVal e As System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Me.CategoriesRowDeletedEvent IsNot Nothing) Then
					RaiseEvent CategoriesRowDeleted(Me, New CategoriesRowChangeEvent((CType(e.Row, CategoriesRow)), e.Action))
				End If
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowDeleting(ByVal e As System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Me.CategoriesRowDeletingEvent IsNot Nothing) Then
					RaiseEvent CategoriesRowDeleting(Me, New CategoriesRowChangeEvent((CType(e.Row, CategoriesRow)), e.Action))
				End If
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub RemoveCategoriesRow(ByVal row As CategoriesRow)
				Me.Rows.Remove(row)
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Shared Function GetTypedTableSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
				Dim type As New System.Xml.Schema.XmlSchemaComplexType()
				Dim sequence As New System.Xml.Schema.XmlSchemaSequence()
				Dim ds As New nwindDataSet()
				xs.Add(ds.GetSchemaSerializable())
				Dim any1 As New System.Xml.Schema.XmlSchemaAny()
				any1.Namespace = "http://www.w3.org/2001/XMLSchema"
				any1.MinOccurs = New Decimal(0)
				any1.MaxOccurs = Decimal.MaxValue
				any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any1)
				Dim any2 As New System.Xml.Schema.XmlSchemaAny()
				any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				any2.MinOccurs = New Decimal(1)
				any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute1 As New System.Xml.Schema.XmlSchemaAttribute()
				attribute1.Name = "namespace"
				attribute1.FixedValue = ds.Namespace
				type.Attributes.Add(attribute1)
				Dim attribute2 As New System.Xml.Schema.XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "CategoriesDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Return type
			End Function
		End Class

		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
		Partial Public Class CategoriesRow
			Inherits System.Data.DataRow

			Private tableCategories As CategoriesDataTable

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Friend Sub New(ByVal rb As System.Data.DataRowBuilder)
				MyBase.New(rb)
				Me.tableCategories = (CType(Me.Table, CategoriesDataTable))
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Property CategoryID() As Integer
				Get
					Return (CInt(Fix(Me(Me.tableCategories.CategoryIDColumn))))
				End Get
				Set(ByVal value As Integer)
					Me(Me.tableCategories.CategoryIDColumn) = value
				End Set
			End Property

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Property CategoryName() As String
				Get
					Try
						Return (CStr(Me(Me.tableCategories.CategoryNameColumn)))
					Catch e As System.InvalidCastException
						Throw New System.Data.StrongTypingException("The value for column 'CategoryName' in table 'Categories' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableCategories.CategoryNameColumn) = value
				End Set
			End Property

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Property Description() As String
				Get
					Try
						Return (CStr(Me(Me.tableCategories.DescriptionColumn)))
					Catch e As System.InvalidCastException
						Throw New System.Data.StrongTypingException("The value for column 'Description' in table 'Categories' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableCategories.DescriptionColumn) = value
				End Set
			End Property

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Property Picture() As Byte()
				Get
					Try
						Return (CType(Me(Me.tableCategories.PictureColumn), Byte()))
					Catch e As System.InvalidCastException
						Throw New System.Data.StrongTypingException("The value for column 'Picture' in table 'Categories' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Byte())
					Me(Me.tableCategories.PictureColumn) = value
				End Set
			End Property

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function IsCategoryNameNull() As Boolean
				Return Me.IsNull(Me.tableCategories.CategoryNameColumn)
			End Function

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub SetCategoryNameNull()
				Me(Me.tableCategories.CategoryNameColumn) = System.Convert.DBNull
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function IsDescriptionNull() As Boolean
				Return Me.IsNull(Me.tableCategories.DescriptionColumn)
			End Function

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub SetDescriptionNull()
				Me(Me.tableCategories.DescriptionColumn) = System.Convert.DBNull
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function IsPictureNull() As Boolean
				Return Me.IsNull(Me.tableCategories.PictureColumn)
			End Function

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub SetPictureNull()
				Me(Me.tableCategories.PictureColumn) = System.Convert.DBNull
			End Sub
		End Class

		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
		Public Class CategoriesRowChangeEvent
			Inherits System.EventArgs

			Private eventRow As CategoriesRow

			Private eventAction As System.Data.DataRowAction

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub New(ByVal row As CategoriesRow, ByVal action As System.Data.DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property Row() As CategoriesRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property Action() As System.Data.DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class
	End Class
End Namespace
Namespace WindowsApplication1.nwindDataSetTableAdapters


	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), System.ComponentModel.DesignerCategoryAttribute("code"), System.ComponentModel.ToolboxItem(True), System.ComponentModel.DataObjectAttribute(True), System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" & ", Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
	Partial Public Class CategoriesTableAdapter
		Inherits System.ComponentModel.Component

		Private _adapter As System.Data.OleDb.OleDbDataAdapter

		Private _connection As System.Data.OleDb.OleDbConnection

		Private _commandCollection() As System.Data.OleDb.OleDbCommand

		Private _clearBeforeFill As Boolean

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Sub New()
			Me.ClearBeforeFill = True
		End Sub

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private ReadOnly Property Adapter() As System.Data.OleDb.OleDbDataAdapter
			Get
				If (Me._adapter Is Nothing) Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Friend Property Connection() As System.Data.OleDb.OleDbConnection
			Get
				If (Me._connection Is Nothing) Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbConnection)
				Me._connection = value
				If (Me.Adapter.InsertCommand IsNot Nothing) Then
					Me.Adapter.InsertCommand.Connection = value
				End If
				If (Me.Adapter.DeleteCommand IsNot Nothing) Then
					Me.Adapter.DeleteCommand.Connection = value
				End If
				If (Me.Adapter.UpdateCommand IsNot Nothing) Then
					Me.Adapter.UpdateCommand.Connection = value
				End If
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					If (Me.CommandCollection(i) IsNot Nothing) Then
						CType(Me.CommandCollection(i), System.Data.OleDb.OleDbCommand).Connection = value
					End If
					i = (i + 1)
				Loop
			End Set
		End Property

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected ReadOnly Property CommandCollection() As System.Data.OleDb.OleDbCommand()
			Get
				If (Me._commandCollection Is Nothing) Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Property ClearBeforeFill() As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set(ByVal value As Boolean)
				Me._clearBeforeFill = value
			End Set
		End Property

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub InitAdapter()
			Me._adapter = New System.Data.OleDb.OleDbDataAdapter()
			Dim tableMapping As New System.Data.Common.DataTableMapping()
			tableMapping.SourceTable = "Table"
			tableMapping.DataSetTable = "Categories"
			tableMapping.ColumnMappings.Add("CategoryID", "CategoryID")
			tableMapping.ColumnMappings.Add("CategoryName", "CategoryName")
			tableMapping.ColumnMappings.Add("Description", "Description")
			tableMapping.ColumnMappings.Add("Picture", "Picture")
			Me._adapter.TableMappings.Add(tableMapping)
			Me._adapter.DeleteCommand = New System.Data.OleDb.OleDbCommand()
			Me._adapter.DeleteCommand.Connection = Me.Connection
			Me._adapter.DeleteCommand.CommandText = "DELETE FROM `Categories` WHERE ((`CategoryID` = ?) AND ((? = 1 AND `CategoryName`" & " IS NULL) OR (`CategoryName` = ?)))"
			Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
			Me._adapter.DeleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, False, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("IsNull_CategoryName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Original, True, Nothing))
			Me._adapter.DeleteCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CategoryName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Original, False, Nothing))
			Me._adapter.InsertCommand = New System.Data.OleDb.OleDbCommand()
			Me._adapter.InsertCommand.Connection = Me.Connection
			Me._adapter.InsertCommand.CommandText = "INSERT INTO `Categories` (`CategoryName`, `Description`, `Picture`) VALUES (?, ?," & " ?)"
			Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
			Me._adapter.InsertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("CategoryName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Current, False, Nothing))
			Me._adapter.InsertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, System.Data.ParameterDirection.Input, (CByte(0)), (CByte(0)), "Description", System.Data.DataRowVersion.Current, False, Nothing))
			Me._adapter.InsertCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.LongVarBinary, 0, System.Data.ParameterDirection.Input, (CByte(0)), (CByte(0)), "Picture", System.Data.DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand = New System.Data.OleDb.OleDbCommand()
			Me._adapter.UpdateCommand.Connection = Me.Connection
			Me._adapter.UpdateCommand.CommandText = "UPDATE `Categories` SET `CategoryName` = ?, `Description` = ?, `Picture` = ? WHER" & "E ((`CategoryID` = ?) AND ((? = 1 AND `CategoryName` IS NULL) OR (`CategoryName`" & " = ?)))"
			Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
			Me._adapter.UpdateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("CategoryName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, System.Data.ParameterDirection.Input, (CByte(0)), (CByte(0)), "Description", System.Data.DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.LongVarBinary, 0, System.Data.ParameterDirection.Input, (CByte(0)), (CByte(0)), "Picture", System.Data.DataRowVersion.Current, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, False, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("IsNull_CategoryName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Original, True, Nothing))
			Me._adapter.UpdateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CategoryName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Original, False, Nothing))
		End Sub

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub InitConnection()
			Me._connection = New System.Data.OleDb.OleDbConnection()
			Me._connection.ConnectionString = My.Settings.Default.nwindConnectionString
		End Sub

		<System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub InitCommandCollection()
			Me._commandCollection = New System.Data.OleDb.OleDbCommand(0){}
			Me._commandCollection(0) = New System.Data.OleDb.OleDbCommand()
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories"
			Me._commandCollection(0).CommandType = System.Data.CommandType.Text
		End Sub

		<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)> _
		Public Overridable Function Fill(ByVal dataTable As nwindDataSet.CategoriesDataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			If (Me.ClearBeforeFill = True) Then
				dataTable.Clear()
			End If
			Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
			Return returnValue
		End Function

		<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
		Public Overridable Function GetData() As nwindDataSet.CategoriesDataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim dataTable As New nwindDataSet.CategoriesDataTable()
			Me.Adapter.Fill(dataTable)
			Return dataTable
		End Function

		<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
		Public Overridable Function Update(ByVal dataTable As nwindDataSet.CategoriesDataTable) As Integer
			Return Me.Adapter.Update(dataTable)
		End Function

		<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
		Public Overridable Function Update(ByVal dataSet As nwindDataSet) As Integer
			Return Me.Adapter.Update(dataSet, "Categories")
		End Function

		<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
		Public Overridable Function Update(ByVal dataRow As System.Data.DataRow) As Integer
			Return Me.Adapter.Update(New System.Data.DataRow() { dataRow})
		End Function

		<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
		Public Overridable Function Update(ByVal dataRows() As System.Data.DataRow) As Integer
			Return Me.Adapter.Update(dataRows)
		End Function

		<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
		Public Overridable Function Delete(ByVal Original_CategoryID As Integer, ByVal Original_CategoryName As String) As Integer
			Me.Adapter.DeleteCommand.Parameters(0).Value = (CInt(Fix(Original_CategoryID)))
			If (Original_CategoryName Is Nothing) Then
				Throw New System.ArgumentNullException("Original_CategoryName")
			Else
				Me.Adapter.DeleteCommand.Parameters(1).Value = (CObj(0))
				Me.Adapter.DeleteCommand.Parameters(2).Value = (CStr(Original_CategoryName))
			End If
			Dim previousConnectionState As System.Data.ConnectionState = Me.Adapter.DeleteCommand.Connection.State
			If ((Me.Adapter.DeleteCommand.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open) Then
				Me.Adapter.DeleteCommand.Connection.Open()
			End If
			Try
				Dim returnValue As Integer = Me.Adapter.DeleteCommand.ExecuteNonQuery()
				Return returnValue
			Finally
				If (previousConnectionState = System.Data.ConnectionState.Closed) Then
					Me.Adapter.DeleteCommand.Connection.Close()
				End If
			End Try
		End Function

		<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
		Public Overridable Function Insert(ByVal CategoryName As String, ByVal Description As String, ByVal Picture() As Byte) As Integer
			If (CategoryName Is Nothing) Then
				Throw New System.ArgumentNullException("CategoryName")
			Else
				Me.Adapter.InsertCommand.Parameters(0).Value = (CStr(CategoryName))
			End If
			If (Description Is Nothing) Then
				Me.Adapter.InsertCommand.Parameters(1).Value = System.DBNull.Value
			Else
				Me.Adapter.InsertCommand.Parameters(1).Value = (CStr(Description))
			End If
			If (Picture Is Nothing) Then
				Me.Adapter.InsertCommand.Parameters(2).Value = System.DBNull.Value
			Else
				Me.Adapter.InsertCommand.Parameters(2).Value = (CType(Picture, Byte()))
			End If
			Dim previousConnectionState As System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
			If ((Me.Adapter.InsertCommand.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open) Then
				Me.Adapter.InsertCommand.Connection.Open()
			End If
			Try
				Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery()
				Return returnValue
			Finally
				If (previousConnectionState = System.Data.ConnectionState.Closed) Then
					Me.Adapter.InsertCommand.Connection.Close()
				End If
			End Try
		End Function

		<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
		Public Overridable Function Update(ByVal CategoryName As String, ByVal Description As String, ByVal Picture() As Byte, ByVal Original_CategoryID As Integer, ByVal Original_CategoryName As String) As Integer
			If (CategoryName Is Nothing) Then
				Throw New System.ArgumentNullException("CategoryName")
			Else
				Me.Adapter.UpdateCommand.Parameters(0).Value = (CStr(CategoryName))
			End If
			If (Description Is Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(1).Value = System.DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(1).Value = (CStr(Description))
			End If
			If (Picture Is Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(2).Value = System.DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(2).Value = (CType(Picture, Byte()))
			End If
			Me.Adapter.UpdateCommand.Parameters(3).Value = (CInt(Fix(Original_CategoryID)))
			If (Original_CategoryName Is Nothing) Then
				Throw New System.ArgumentNullException("Original_CategoryName")
			Else
				Me.Adapter.UpdateCommand.Parameters(4).Value = (CObj(0))
				Me.Adapter.UpdateCommand.Parameters(5).Value = (CStr(Original_CategoryName))
			End If
			Dim previousConnectionState As System.Data.ConnectionState = Me.Adapter.UpdateCommand.Connection.State
			If ((Me.Adapter.UpdateCommand.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open) Then
				Me.Adapter.UpdateCommand.Connection.Open()
			End If
			Try
				Dim returnValue As Integer = Me.Adapter.UpdateCommand.ExecuteNonQuery()
				Return returnValue
			Finally
				If (previousConnectionState = System.Data.ConnectionState.Closed) Then
					Me.Adapter.UpdateCommand.Connection.Close()
				End If
			End Try
		End Function
	End Class
End Namespace

'TODO: INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning restore 1591