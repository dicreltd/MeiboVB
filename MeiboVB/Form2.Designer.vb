<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEdit
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonOK = New System.Windows.Forms.Button()
        Me.textBoxAge = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.textBoxTel = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBoxName = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonCancel
        '
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.buttonCancel.Location = New System.Drawing.Point(194, 156)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(119, 35)
        Me.buttonCancel.TabIndex = 15
        Me.buttonCancel.Text = "キャンセル"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'buttonOK
        '
        Me.buttonOK.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.buttonOK.Location = New System.Drawing.Point(22, 156)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(119, 35)
        Me.buttonOK.TabIndex = 14
        Me.buttonOK.Text = "OK"
        Me.buttonOK.UseVisualStyleBackColor = True
        '
        'textBoxAge
        '
        Me.textBoxAge.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.textBoxAge.Location = New System.Drawing.Point(107, 96)
        Me.textBoxAge.Name = "textBoxAge"
        Me.textBoxAge.Size = New System.Drawing.Size(52, 27)
        Me.textBoxAge.TabIndex = 13
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label3.Location = New System.Drawing.Point(33, 99)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(49, 20)
        Me.label3.TabIndex = 12
        Me.label3.Text = "年齢"
        '
        'textBoxTel
        '
        Me.textBoxTel.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.textBoxTel.Location = New System.Drawing.Point(107, 54)
        Me.textBoxTel.Name = "textBoxTel"
        Me.textBoxTel.Size = New System.Drawing.Size(130, 27)
        Me.textBoxTel.TabIndex = 11
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label2.Location = New System.Drawing.Point(33, 57)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 20)
        Me.label2.TabIndex = 10
        Me.label2.Text = "TEL"
        '
        'textBoxName
        '
        Me.textBoxName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.textBoxName.Location = New System.Drawing.Point(107, 12)
        Me.textBoxName.Name = "textBoxName"
        Me.textBoxName.Size = New System.Drawing.Size(130, 27)
        Me.textBoxName.TabIndex = 9
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label1.Location = New System.Drawing.Point(33, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 20)
        Me.label1.TabIndex = 8
        Me.label1.Text = "名前"
        '
        'FormEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 211)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonOK)
        Me.Controls.Add(Me.textBoxAge)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.textBoxTel)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textBoxName)
        Me.Controls.Add(Me.label1)
        Me.Name = "FormEdit"
        Me.Text = "編集"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonCancel As Button
    Private WithEvents buttonOK As Button
    Private WithEvents textBoxAge As TextBox
    Private WithEvents label3 As Label
    Private WithEvents textBoxTel As TextBox
    Private WithEvents label2 As Label
    Private WithEvents textBoxName As TextBox
    Private WithEvents label1 As Label
End Class
