Imports System.Net
Imports System.IO
Imports DevComponents.DotNetBar.Controls
Imports System.Threading

Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim web As New WebClient
        Dim TempS As String = web.DownloadString("http://mwifi.moefactory.com/log.php")
        TempS = TempS.Replace("\n", vbCrLf)
        TextBoxX1.Text = TempS
        Form.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        ProgressBarX1.Visible = True
        Dim t As Thread = New Thread(AddressOf DownloadLatest)
        t.Start()
    End Sub

    Private Sub DownloadLatest()
        DownFile("http://mwifi.moefactory.com/latest.exe", Application.StartupPath & "\latest.exe", ProgressBarX1)
    End Sub

    Public Shared Sub DownFile(ByVal URL As String, ByVal Filename As String, ByVal Prog As ProgressBarX)
        On Error GoTo ErrLine
        Dim Myrq As HttpWebRequest = HttpWebRequest.Create(URL)
        Dim myrp As HttpWebResponse = Myrq.GetResponse
        Static totalBytes As Long = myrp.ContentLength
        Prog.Maximum = totalBytes
        Dim st As Stream = myrp.GetResponseStream
        Dim so As Stream = New FileStream(Filename, FileMode.Create)
        Dim totalDownloadedByte As Long = 0
        Dim by(1024) As Byte
        Dim osize As Integer = st.Read(by, 0, by.Length)
        While osize > 0
            totalDownloadedByte = osize + totalDownloadedByte
            Application.DoEvents()
            so.Write(by, 0, osize)
            Prog.Value = totalDownloadedByte
            osize = st.Read(by, 0, by.LongLength)
        End While
        so.Close()
        st.Close()
        Dim UpdateFile As String
        UpdateFile = "@echo off" & vbCrLf & _
            "taskkill /im """ & Microsoft.VisualBasic.Right(Application.ExecutablePath, Application.ExecutablePath.Length - Application.StartupPath.Length - 1) & """ /f" & vbCrLf & _
            "del """ & Application.ExecutablePath & """" & vbCrLf & _
            "rename """ & Application.StartupPath & "\latest.exe"" ""mWiFi.exe""" & vbCrLf & _
            "start mWiFi.exe" & vbCrLf & _
            "exit"
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\update.bat", UpdateFile, False, System.Text.Encoding.Default)
        Dim startInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
        startInfo.FileName = Application.StartupPath & "\update.bat"
        startInfo.Verb = "RunAs"
        System.Diagnostics.Process.Start(startInfo)
        Application.Exit()
ErrLine:
        If Err.Number <> 0 Then
            MsgBox("更新失败，错误 " & Err.Number & vbCrLf & Err.Description, MsgBoxStyle.Critical, "更新失败")
            Form4.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
End Class