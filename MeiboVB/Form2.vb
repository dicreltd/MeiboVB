Public Class FormEdit
    Public member As Member

    Private Sub FormEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (member IsNot Nothing) Then
            textBoxName.Text = member.Name
            textBoxTel.Text = member.Tel
            textBoxAge.Text = member.Age.ToString()
        End If

    End Sub

    Private Sub buttonOK_Click(sender As Object, e As EventArgs) Handles buttonOK.Click
        Dim name As String = textBoxName.Text
        Dim tel As String = textBoxTel.Text
        Dim age As Integer
        age = Int(textBoxAge.Text)
        If member Is Nothing Then
            member = New Member(name, tel, age)
        Else
            member.Name = name
            member.Tel = tel
            member.Age = age
        End If
        DialogResult = DialogResult.OK

    End Sub

End Class