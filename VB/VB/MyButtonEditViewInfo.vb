Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing

Namespace WindowsApplication1
	Public Class MyButtonEditViewInfo
		Inherits ButtonEditViewInfo
		Public ReadOnly Property MyRepositoryItem() As RepositoryItemMyButtonEdit
			Get
				Return TryCast(Me.Item, RepositoryItemMyButtonEdit)
			End Get
		End Property

		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)

		End Sub

		Private Function CalcButtonsBounds(ByVal buttonBounds As Rectangle) As Rectangle
			Dim r As Rectangle = buttonBounds
			Dim buttonsHeight As Integer = MyRepositoryItem.ButtonsHeight
			If buttonsHeight > 0 AndAlso buttonsHeight < buttonBounds.Height Then
				r.Height = buttonsHeight
			End If

			If MyRepositoryItem.ButtonsAlignment = DevExpress.Utils.VertAlignment.Bottom Then
				r.Y = buttonBounds.Bottom - buttonsHeight
			End If
			If MyRepositoryItem.ButtonsAlignment = DevExpress.Utils.VertAlignment.Center Then
				r.Y = buttonBounds.Top + (buttonBounds.Height - buttonsHeight) / 2
			End If
			Return r
		End Function

		Private Sub CalcButtonsBoundsCore(ByVal collection As EditorButtonObjectCollection)
			For n As Integer = collection.Count - 1 To 0 Step -1
				Dim button As EditorButtonObjectInfoArgs = collection(n)
				button.Bounds = CalcButtonsBounds(button.Bounds)
			Next n
		End Sub

		Protected Overrides Function CalcButtons(ByVal cache As DevExpress.Utils.Drawing.GraphicsCache) As Rectangle
			Dim result As Rectangle = MyBase.CalcButtons(cache)
			CalcButtonsBoundsCore(Me.LeftButtons)
			CalcButtonsBoundsCore(Me.RightButtons)
			Return result
		End Function
	End Class
End Namespace
