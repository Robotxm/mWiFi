Public Class Form3

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If TextBoxX1.Text <> "" Then
            'ChangeName(TextBoxX1.Text)
            Dim TmpStr As String = ""
            For Each TmpLitem In Form1.ListViewEx1.SelectedItems
                TmpStr += TmpLitem.SubItems.Item(0).Text.Trim
            Next
            For Each TmpLitem As ListViewItem In Form1.ListViewEx1.SelectedItems
                If TmpLitem.Text = TmpStr Then
                    WriteINIFile(Application.StartupPath & "\DeviceInfo.db", "MACTable", TmpLitem.SubItems(1).Text, TextBoxX1.Text)
                    TmpLitem.Text = TextBoxX1.Text
                End If
            Next
            TextBoxX1.Text = ""
            Form1.Timer1.Enabled = True
            Me.Close()
        Else
            MsgBox("请输入新设备名称。", MsgBoxStyle.Critical, "错误")
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        TextBoxX1.Text = ""
        Me.Close()
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        theNewName = theOName
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "原设备名称:   " & theOName
    End Sub

    Private Sub TextBoxX1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxX1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call ButtonX1_Click(sender, e)
        End If
    End Sub
End Class