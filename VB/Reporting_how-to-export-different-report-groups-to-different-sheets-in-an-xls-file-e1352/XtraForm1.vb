Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting

Namespace WindowsApplication1
    Partial Public Class XtraForm1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Public ReadOnly Property ExportOptions() As XlsExportOptions
            Get
                Return New XlsExportOptions((If(checkEdit2.Checked, TextExportMode.Value, TextExportMode.Text)),checkEdit1.Checked,checkEdit3.Checked)
            End Get
        End Property
        Public ReadOnly Property SheetName() As String
            Get
                Return textEdit1.Text
            End Get
        End Property
        Public ReadOnly Property ExportToDiffrentSheets() As Boolean
            Get
                Return checkEdit4.Checked
            End Get
        End Property
        Private Sub checkEdit4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit4.CheckedChanged
            textEdit1.Enabled = Not checkEdit4.Checked
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub
    End Class
End Namespace
