Namespace WindowsApplication1

    Partial Class XtraForm1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit3 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit4 = New DevExpress.XtraEditors.CheckEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.Location = New System.Drawing.Point(16, 8)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Show grid lines"
            Me.checkEdit1.Size = New System.Drawing.Size(96, 19)
            Me.checkEdit1.TabIndex = 0
            ' 
            ' checkEdit2
            ' 
            Me.checkEdit2.Location = New System.Drawing.Point(16, 32)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = "Export values using their format"
            Me.checkEdit2.Size = New System.Drawing.Size(184, 19)
            Me.checkEdit2.TabIndex = 1
            ' 
            ' checkEdit3
            ' 
            Me.checkEdit3.Location = New System.Drawing.Point(16, 56)
            Me.checkEdit3.Name = "checkEdit3"
            Me.checkEdit3.Properties.Caption = "Export hyperlinks"
            Me.checkEdit3.Size = New System.Drawing.Size(184, 19)
            Me.checkEdit3.TabIndex = 2
            ' 
            ' checkEdit4
            ' 
            Me.checkEdit4.Location = New System.Drawing.Point(16, 80)
            Me.checkEdit4.Name = "checkEdit4"
            Me.checkEdit4.Properties.Caption = "Export groups in different sheets"
            Me.checkEdit4.Size = New System.Drawing.Size(184, 19)
            Me.checkEdit4.TabIndex = 3
            AddHandler Me.checkEdit4.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit4_CheckedChanged)
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(20, 107)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(57, 13)
            Me.labelControl1.TabIndex = 4
            Me.labelControl1.Text = "Sheet name"
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.EditValue = "Sheet1"
            Me.textEdit1.Location = New System.Drawing.Point(88, 104)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New System.Drawing.Size(108, 20)
            Me.textEdit1.TabIndex = 5
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(16, 128)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
            Me.simpleButton1.TabIndex = 6
            Me.simpleButton1.Text = "OK"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.Location = New System.Drawing.Point(120, 128)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(75, 23)
            Me.simpleButton2.TabIndex = 7
            Me.simpleButton2.Text = "Cancel"
            AddHandler Me.simpleButton2.Click, New System.EventHandler(AddressOf Me.simpleButton2_Click)
            ' 
            ' XtraForm1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(207, 156)
            Me.Controls.Add(Me.simpleButton2)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.textEdit1)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.checkEdit4)
            Me.Controls.Add(Me.checkEdit3)
            Me.Controls.Add(Me.checkEdit2)
            Me.Controls.Add(Me.checkEdit1)
            Me.Name = "XtraForm1"
            Me.Text = "XtraForm1"
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

'#End Region
        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit

        Private checkEdit2 As DevExpress.XtraEditors.CheckEdit

        Private checkEdit3 As DevExpress.XtraEditors.CheckEdit

        Private checkEdit4 As DevExpress.XtraEditors.CheckEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private textEdit1 As DevExpress.XtraEditors.TextEdit

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private simpleButton2 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
