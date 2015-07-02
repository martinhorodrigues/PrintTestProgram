<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Cmdtest1 = New System.Windows.Forms.Button()
        Me.cmdtest2 = New System.Windows.Forms.Button()
        Me.cmdtest3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Cmdtest1
        '
        Me.Cmdtest1.Location = New System.Drawing.Point(34, 30)
        Me.Cmdtest1.Name = "Cmdtest1"
        Me.Cmdtest1.Size = New System.Drawing.Size(108, 36)
        Me.Cmdtest1.TabIndex = 0
        Me.Cmdtest1.Text = "測試1"
        Me.Cmdtest1.UseVisualStyleBackColor = True
        '
        'cmdtest2
        '
        Me.cmdtest2.Location = New System.Drawing.Point(34, 98)
        Me.cmdtest2.Name = "cmdtest2"
        Me.cmdtest2.Size = New System.Drawing.Size(108, 36)
        Me.cmdtest2.TabIndex = 1
        Me.cmdtest2.Text = "測試2"
        Me.cmdtest2.UseVisualStyleBackColor = True
        '
        'cmdtest3
        '
        Me.cmdtest3.Location = New System.Drawing.Point(34, 167)
        Me.cmdtest3.Name = "cmdtest3"
        Me.cmdtest3.Size = New System.Drawing.Size(108, 36)
        Me.cmdtest3.TabIndex = 2
        Me.cmdtest3.Text = "測試3(OK)"
        Me.cmdtest3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 349)
        Me.Controls.Add(Me.cmdtest3)
        Me.Controls.Add(Me.cmdtest2)
        Me.Controls.Add(Me.Cmdtest1)
        Me.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cmdtest1 As System.Windows.Forms.Button
    Friend WithEvents cmdtest2 As System.Windows.Forms.Button
    Friend WithEvents cmdtest3 As System.Windows.Forms.Button

End Class
