Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting

Namespace WindowsApplication1

    Public Partial Class XtraForm1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Public ReadOnly Property ExportOptions As XlsExportOptions
            Get
                Return New XlsExportOptions(If(checkEdit2.Checked, TextExportMode.Value, TextExportMode.Text), checkEdit1.Checked, checkEdit3.Checked)
            End Get
        End Property

        Public ReadOnly Property SheetName As String
            Get
                Return textEdit1.Text
            End Get
        End Property

        Public ReadOnly Property ExportToDiffrentSheets As Boolean
            Get
                Return checkEdit4.Checked
            End Get
        End Property

        Private Sub checkEdit4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            textEdit1.Enabled = Not checkEdit4.Checked
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            DialogResult = DialogResult.OK
            Close()
        End Sub
    End Class
End Namespace
