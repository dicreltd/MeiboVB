Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listBoxMember.DisplayMember = "Name"
    End Sub

    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click
        Dim frm As New FormEdit

        If frm.ShowDialog() = DialogResult.OK Then
            listBoxMember.Items.Add(frm.member)
        End If

    End Sub

    Private Sub buttonEdit_Click(sender As Object, e As EventArgs) Handles buttonEdit.Click
        Dim frm As New FormEdit()

        frm.member = listBoxMember.SelectedItem

        If (frm.ShowDialog() = DialogResult.OK) Then
            listBoxMember.DisplayMember = Nothing
            listBoxMember.DisplayMember = "Name"
        End If

    End Sub

    Private Sub buttonDel_Click(sender As Object, e As EventArgs) Handles buttonDel.Click
        Dim member As Member = listBoxMember.SelectedItem

        If (member Is Nothing) Then
            Return
        End If

        If (MessageBox.Show(member.Name + "さんを削除しますか？", "削除", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            Dim index As Integer = listBoxMember.SelectedIndex
            listBoxMember.Items.RemoveAt(index)
        End If

    End Sub

End Class
