Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Layout.Core
Imports DevExpress.Xpf.Docking

Namespace DXDocking_DockingInCode
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "#1"
		Private Sub Button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			' Dock the Properties panel at the bottom of the Output panel.
			dockManager1.DockController.Dock(paneProperties, paneOutput, DockType.Bottom)
		End Sub

		Private Sub Button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			' Dock the Properties panel to the Output panel, creating a tab container.
			dockManager1.DockController.Dock(paneProperties, paneOutput, DockType.Fill)
		End Sub
		#End Region ' #1

		Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			paneProperties = CType(dockManager1.GetItem("paneProperties"), LayoutPanel)
			paneOutput = CType(dockManager1.GetItem("paneOutput"), LayoutPanel)
		End Sub
	End Class
End Namespace
