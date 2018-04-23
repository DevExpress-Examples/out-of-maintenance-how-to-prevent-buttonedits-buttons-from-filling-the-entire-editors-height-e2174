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
	Public Class MyButtonEditPainter
		Inherits ButtonEditPainter

		Public Sub New()

		End Sub

		Protected Overrides Sub DrawContent(ByVal info As ControlGraphicsInfoArgs)
			Dim backColor As Color = info.ViewInfo.Appearance.GetBackColor()
			If backColor = Color.Empty Then
				backColor = Color.White
			End If
			Dim brush As Brush = New SolidBrush(backColor)
			info.Graphics.FillRectangle(brush, info.Bounds)
			MyBase.DrawContent(info)
		End Sub
	End Class
End Namespace
