<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.buttonDel = New System.Windows.Forms.Button()
        Me.buttonEdit = New System.Windows.Forms.Button()
        Me.buttonAdd = New System.Windows.Forms.Button()
        Me.listBoxMember = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'buttonDel
        '
        Me.buttonDel.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.buttonDel.Location = New System.Drawing.Point(264, 91)
        Me.buttonDel.Name = "buttonDel"
        Me.buttonDel.Size = New System.Drawing.Size(123, 34)
        Me.buttonDel.TabIndex = 7
        Me.buttonDel.Text = "削除"
        Me.buttonDel.UseVisualStyleBackColor = True
        '
        'buttonEdit
        '
        Me.buttonEdit.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.buttonEdit.Location = New System.Drawing.Point(264, 52)
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.Size = New System.Drawing.Size(123, 34)
        Me.buttonEdit.TabIndex = 6
        Me.buttonEdit.Text = "編集"
        Me.buttonEdit.UseVisualStyleBackColor = True
        '
        'buttonAdd
        '
        Me.buttonAdd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.buttonAdd.Location = New System.Drawing.Point(264, 12)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(123, 34)
        Me.buttonAdd.TabIndex = 5
        Me.buttonAdd.Text = "追加"
        Me.buttonAdd.UseVisualStyleBackColor = True
        '
        'listBoxMember
        '
        Me.listBoxMember.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.listBoxMember.FormattingEnabled = True
        Me.listBoxMember.ItemHeight = 20
        Me.listBoxMember.Location = New System.Drawing.Point(12, 12)
        Me.listBoxMember.Name = "listBoxMember"
        Me.listBoxMember.Size = New System.Drawing.Size(221, 264)
        Me.listBoxMember.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 296)
        Me.Controls.Add(Me.buttonDel)
        Me.Controls.Add(Me.buttonEdit)
        Me.Controls.Add(Me.buttonAdd)
        Me.Controls.Add(Me.listBoxMember)
        Me.Name = "Form1"
        Me.Text = "名簿"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents buttonDel As Button
    Private WithEvents buttonEdit As Button
    Private WithEvents buttonAdd As Button
    Private WithEvents listBoxMember As ListBox
End Class
