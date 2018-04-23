Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace WindowsApplication1
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private myButtonEdit1 As WindowsApplication1.MyButtonEdit
		Private myButtonEdit2 As MyButtonEdit
		Private myButtonEdit3 As MyButtonEdit
		Private myButtonEdit4 As MyButtonEdit
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataSet1 = New System.Data.DataSet()
			Me.myButtonEdit4 = New WindowsApplication1.MyButtonEdit()
			Me.myButtonEdit3 = New WindowsApplication1.MyButtonEdit()
			Me.myButtonEdit2 = New WindowsApplication1.MyButtonEdit()
			Me.myButtonEdit1 = New WindowsApplication1.MyButtonEdit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myButtonEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myButtonEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' myButtonEdit4
			' 
			Me.myButtonEdit4.EditValue = "myButtonEdit4"
			Me.myButtonEdit4.Location = New System.Drawing.Point(12, 198)
			Me.myButtonEdit4.Name = "myButtonEdit4"
			Me.myButtonEdit4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.myButtonEdit4.Properties.Appearance.Options.UseFont = True
			Me.myButtonEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myButtonEdit4.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
			Me.myButtonEdit4.Properties.ButtonsAlignment = DevExpress.Utils.VertAlignment.Bottom
			Me.myButtonEdit4.Properties.ButtonsHeight = 25
			Me.myButtonEdit4.Size = New System.Drawing.Size(375, 51)
			Me.myButtonEdit4.TabIndex = 3
			' 
			' myButtonEdit3
			' 
			Me.myButtonEdit3.EditValue = "myButtonEdit3"
			Me.myButtonEdit3.Location = New System.Drawing.Point(13, 141)
			Me.myButtonEdit3.Name = "myButtonEdit3"
			Me.myButtonEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.myButtonEdit3.Properties.Appearance.Options.UseFont = True
			Me.myButtonEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myButtonEdit3.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True)})
			Me.myButtonEdit3.Properties.ButtonsAlignment = DevExpress.Utils.VertAlignment.Center
			Me.myButtonEdit3.Properties.ButtonsHeight = 25
			Me.myButtonEdit3.Size = New System.Drawing.Size(375, 51)
			Me.myButtonEdit3.TabIndex = 2
			' 
			' myButtonEdit2
			' 
			Me.myButtonEdit2.EditValue = "myButtonEdit2"
			Me.myButtonEdit2.Location = New System.Drawing.Point(13, 84)
			Me.myButtonEdit2.Name = "myButtonEdit2"
			Me.myButtonEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.myButtonEdit2.Properties.Appearance.Options.UseFont = True
			Me.myButtonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myButtonEdit2.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", Nothing, Nothing, True)})
			Me.myButtonEdit2.Properties.ButtonsAlignment = DevExpress.Utils.VertAlignment.Top
			Me.myButtonEdit2.Properties.ButtonsHeight = 25
			Me.myButtonEdit2.Size = New System.Drawing.Size(375, 51)
			Me.myButtonEdit2.TabIndex = 1
			' 
			' myButtonEdit1
			' 
			Me.myButtonEdit1.EditValue = "myButtonEdit1"
			Me.myButtonEdit1.Location = New System.Drawing.Point(13, 12)
			Me.myButtonEdit1.Name = "myButtonEdit1"
			Me.myButtonEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.myButtonEdit1.Properties.Appearance.Options.UseFont = True
			Me.myButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myButtonEdit1.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", Nothing, Nothing, True)})
			Me.myButtonEdit1.Properties.ButtonsAlignment = DevExpress.Utils.VertAlignment.Default
			Me.myButtonEdit1.Properties.ButtonsHeight = 0
			Me.myButtonEdit1.Size = New System.Drawing.Size(375, 51)
			Me.myButtonEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(400, 259)
			Me.Controls.Add(Me.myButtonEdit4)
			Me.Controls.Add(Me.myButtonEdit3)
			Me.Controls.Add(Me.myButtonEdit2)
			Me.Controls.Add(Me.myButtonEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myButtonEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myButtonEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

	End Class
End Namespace
