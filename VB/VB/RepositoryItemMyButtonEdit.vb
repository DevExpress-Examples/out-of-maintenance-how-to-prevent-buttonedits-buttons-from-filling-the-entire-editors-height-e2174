Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Drawing

Namespace WindowsApplication1
	<UserRepositoryItem("Register")> _
	Public Class RepositoryItemMyButtonEdit
		Inherits RepositoryItemButtonEdit
		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
		End Sub

		Friend Const EditorName As String = "MyButtonEdit"

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyButtonEdit), GetType(RepositoryItemMyButtonEdit), GetType(MyButtonEditViewInfo), New MyButtonEditPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property

		Private _ButtonHeight As Integer

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
		Public Property ButtonsHeight() As Integer
			Get
				Return _ButtonHeight
			End Get
			Set(ByVal value As Integer)
				_ButtonHeight = value
			End Set
		End Property

		Private _ButtonAlignment As VertAlignment

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
		Public Property ButtonsAlignment() As VertAlignment
			Get
				Return _ButtonAlignment
			End Get
			Set(ByVal value As VertAlignment)
				_ButtonAlignment = value
			End Set
		End Property
	End Class
End Namespace