Imports DevComponents.DotNetBar
Imports System.Text.RegularExpressions
Imports System.Text
Imports Microsoft.Win32
Imports System.Threading
Imports System.Net
Imports DevComponents.DotNetBar.Controls
Imports System.Windows.Forms.ListView

Public Class Form1
    Public TempName As String = "", WType As String

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ExitmWiFi1 = 0 Then
            e.Cancel = True
            Me.Hide()
            nIcon.ShowBalloonTip(3, "mWiFi - 提示", "mWiFi 正在后台运行中，双击任务栏图标显示主窗体。", ToolTipIcon.Info)
        Else
            If btnCon.Text = "停止共享" Then
                Call btnCon_Click(sender, e)
            End If
                WriteINI("AllFlow", thisv + AllFlow + thiss)
            nIcon.Icon = Nothing
            Me.Dispose()
            End
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Form.CheckForIllegalCrossThreadCalls = False
        Dim OSVer As String = (Environment.OSVersion.Version.Major & "." & Environment.OSVersion.Version.Minor)
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\config.cfg") = False Then
            LoadNewConfig()
        End If
        ReadForMem()
        ReadForCon(cbStartup, cbAuto, cbXFC, cbTask, cbNoStart, cbNoStop, cbNoNew, cbHideMe, cbEnd, cbCheck)
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\update.bat") = True Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\update.bat")
        End If
        If OSVer < 6.1 Then
            MsgBox("目前 mWiFi 仅支持 Windows 7、Windows 8、Windows 8.1、Windows 8.1 Update 1，不支持 Windows XP、Windows Vista。", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
            End
        End If
        If My.Computer.Network.IsAvailable = False Then
            If MsgBox("你的电脑没有连接到网络，这可能会导致 mWiFi 运行异常。" & Chr(13) & "确定要使用吗？", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "网络故障") = MsgBoxResult.No Then
                End
            End If
        End If
        If HideMe1 = 1 Then
            Me.Hide()
        End If
        Me.StartPosition = FormStartPosition.Manual
        Me.Top = Screen.PrimaryScreen.Bounds.Height / 2 - Me.Height / 2
        Me.Left = Screen.PrimaryScreen.Bounds.Width / 2 - Me.Width / 2
        Label12.Text = "累计节省流量: " & GetFlow(AllFlow)
        If ShowIcon1 = 1 Then
            nIcon.Icon = Me.Icon
        End If
        TextBox1.Text = RunCmd("netsh wlan show hostednetwork")
        Dim i As Integer, result
        Dim isload As Boolean, isopen As Boolean
        For i = 0 To TextBox1.Lines.Length - 1
            If Mid(TextBox1.Lines(i), 5, 2) = "状态" And TextBox1.Lines(i) <> "承载网络状态   " Then
                If Mid(TextBox1.Lines(i), 26, 3) = "未启动" Then
                    isopen = False
                Else
                    isopen = True
                End If
                isload = True
            End If
        Next
        If isopen = True Then
            RunCmd("netsh wlan stop hostednetwork")
        End If
        cbCon.BeginUpdate()
        Dim nics() As System.Net.NetworkInformation.NetworkInterface
        nics = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
        Dim vi As Boolean
        If nics.Length > 0 Then
            For Each netState In nics
                If netState.OperationalStatus = 1 And netState.GetIPv4Statistics.BytesReceived <> 0 Then
                    cbCon.Text = netState.Name
                End If
                If OSVer > 6.1 Then
                    If InStr(netState.Description, "Microsoft 托管网络虚拟适配器") <> 0 Or InStr(netState.Description, "Microsoft Wi-Fi Direct 虚拟适配器") Then
                        vi = True
                    End If
                    If netState.Name = "Loopback Pseudo-Interface 1" Then
                        GoTo endloop
                    End If
                ElseIf OSVer = 6.1 Then
                    If InStr(netState.Description, "Microsoft Virtual WiFi Miniport Adapter") <> 0 Then
                        vi = True
                    End If
                    If netState.Name = "Loopback Pseudo-Interface 1" Then
                        GoTo endloop
                    End If
                End If
                cbCon.Items.Add(netState.Name)
            Next
        End If
endloop:
        cbCon.EndUpdate()
        For i = 0 To TextBox1.Lines.Length - 1
            If Mid(TextBox1.Lines(i), 5, 7) = "SSID 名称" Then
                SSIDName = Mid(TextBox1.Lines(i), 28, Len(TextBox1.Lines(i)) - 28)
            End If
            If Mid(TextBox1.Lines(i), 5, 6) = "最多客户端数" Then
                MaxUser = Val(Mid(TextBox1.Lines(i), 14, Len(TextBox1.Lines(i))))
            End If
        Next
        TextBox1.Text = RunCmd("netsh wlan show hostednetwork setting=security")
        For i = 0 To TextBox1.Lines.Length - 1
            If Mid(TextBox1.Lines(i), 5, 6) = "用户安全密钥" Then
                On Error Resume Next
                SSIDKey = Mid(TextBox1.Lines(i), 19, Len(TextBox1.Lines(i)) - 18)
            End If
        Next
        Dim res As Byte() = System.Text.Encoding.UTF8.GetBytes(SSIDName)
        Dim ret As String = System.Text.Encoding.UTF8.GetString(res)
        Dim sr As Byte() = System.Text.Encoding.Convert(Encoding.UTF8, Encoding.Default, res)
        ret = System.Text.Encoding.Default.GetString(sr)
        TextBoxX1.Text = ret
        Label11.Text = "设备数量上限: " & MaxUser
        TextBoxX2.Text = SSIDKey
        If AutoSharing1 = 1 Then
            Call btnCon_Click(sender, e)
        End If
        If Check1 = 1 Then
            On Error GoTo errline
            nIcon.Icon = Me.Icon
            nIcon.ShowBalloonTip(1, "mWiFi - 检查更新", "正在自动检查更新，请稍后..." & vbCrLf & "如果有新版本的 mWiFi 将会提示你更新。", ToolTipIcon.Info)
            Dim web As New WebClient
            Dim TempS As String = web.DownloadString("http://mwifi.moefactory.com/update.php?ver=" & My.Application.Info.Version.Revision)
            If TempS.StartsWith("1") = True Then
                Dim NewVersion As String = Microsoft.VisualBasic.Right(TempS, Len(TempS) - 2)
                Form4.ShowDialog()
            End If
        End If
        If ShowForm1 = 1 Then
            Form2.Show()
        End If
        If ShowIcon1 = 1 Then
            nIcon.Icon = Me.Icon
        End If
errline:
        If Err.Number <> 5 And Err.Number <> 0 Then
            MsgBox("错误 " & Err.Number & ": " & Err.Description & vbCrLf & "检查更新失败，请检查你的网络是否正常。", MsgBoxStyle.Critical, "检查更新失败")
            nIcon.Icon = Nothing
        End If
        If ShowIcon1 = 1 Then
            nIcon.Icon = Me.Icon
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("explorer.exe http://mwifi.moefactory.com")
    End Sub

    Private Sub cbShow_CheckedChanged(sender As Object, e As EventArgs) Handles cbShow.CheckedChanged
        TextBoxX2.UseSystemPasswordChar = Not cbShow.Checked
    End Sub

    Public Sub btnCon_Click(sender As Object, e As EventArgs) Handles btnCon.Click
        TempName = ""
        If btnCon.Text = "开始共享" Then
            Dim regX As New Regex("[\u4e00-\u9fa5]")
            If Len(TextBoxX2.Text) < 8 Then
                ReadImage(PictureBox1, "error.png")
                ShowToast(Me, "无线网络密码必须在 8~22 位之间。", 3, 3)
                Exit Sub
            End If
            If regX.IsMatch(TextBoxX2.Text) Then
                ReadImage(PictureBox1, "error.png")
                ShowToast(Me, "无线网络密码不能包含中文字符。", 3, 3)
                Exit Sub
            End If
            If cbCon.Text = "请选择网卡" Then
                ReadImage(PictureBox1, "error.png")
                ShowToast(Me, "请选择用来共享连接的网卡。", 3, 3)
                Exit Sub
            End If
            If TextBoxX1.Text = "" Then
                ReadImage(PictureBox1, "error.png")
                ShowToast(Me, "请输入无线网络名称。", 3, 3)
                Exit Sub
            End If
            If TextBoxX1.Text.Contains("哦") = True Then
                MsgBox("检测到无线网络名称包含了""哦""这个中文字符，很抱歉目前 mWiFi 无法处理这个字符。建议你将哦和其他中文字符、符号搭配使用以防止出现无法搜索到 WiFi 的情况。", MsgBoxStyle.Exclamation, "警告")
            End If
            Dim by As Byte() = System.Text.Encoding.Default.GetBytes(TextBoxX1.Text)
            Dim sr As Byte() = System.Text.Encoding.Convert(Encoding.Default, Encoding.UTF8, by)
            Dim ret As String = System.Text.Encoding.UTF8.GetString(sr)
            Shell("netsh wlan set hostednetwork mode=allow ssid=""" & ret & """ key=""" & TextBoxX2.Text & """", vbHide, True)
            Dim temp2 As String
            temp2 = RunCmd("netsh wlan start hostednetwork")
            If (temp2 <> "已启动承载网络。" & vbCrLf & "" & vbCrLf & "") Then
                ReadImage(PictureBox1, "error.png")
                ShowToast(Me, "出现未知错误，共享网络失败。" & vbCrLf & vbCrLf & "错误详细信息:" & vbCrLf & temp2, 3, 3)
            Else
                If NoStart1 = 1 Then
                    nIcon.ShowBalloonTip(3, "mWiFi - 无线网络共享已启动", "无线网络名称: " & TextBoxX1.Text & vbCrLf & "无线网络密码: " & TextBoxX2.Text, ToolTipIcon.Info)
                End If
                ReadImage(PictureBox1, "4.png")
                cbCon.Enabled = False
                TextBoxX1.Enabled = False
                TextBoxX2.Enabled = False
                LastB = 0
                LastV = 0
                virtal = GetVi()
                btnCon.Text = "停止共享"
                If virtal = -1 Then
                    ReadImage(PictureBox1, "error.png")
                    ShowToast(Me, "没有找到虚拟无线网卡，可能是物理无线网卡或驱动不支持，请尝试更新驱动。" & vbCrLf & "如果问题依旧，可能是物理无线网卡不支持。", 3, 3)
                    GoTo errorfind
                End If
                EnableSharing(cbCon.Text, 0)
                EnableSharing(virtalname, 1)
                TextBox1.Text = RunCmd("netsh wlan show hostednetwork")
                For i = 0 To TextBox1.Lines.Length - 1
                    If Mid(TextBox1.Lines(i), 5, 5) = "BSSID" Then
                        BSSID = Mid(TextBox1.Lines(i), 29, Len(TextBox1.Lines(i)) - 28)
                    End If
                    If Mid(TextBox1.Lines(i), 5, 2) = "频道" Then
                        SSIDMode = Val(Mid(TextBox1.Lines(i), 25, Len(TextBox1.Lines(i)) - 24))
                    End If
                    If Mid(TextBox1.Lines(i), 5, 4) = "客户端数" Then
                        NowUser = Val(Mid(TextBox1.Lines(i), 17, Len(TextBox1.Lines(i)) - 16))
                    End If
                    If Mid(TextBox1.Lines(i), 5, 5) = "无线电类型" Then
                        WType = Mid(TextBox1.Lines(i), 24, Len(TextBox1.Lines(i)) - 23)
                    End If
                Next
                Form2.Timer1.Enabled = True
                Label10.Text = "已连接设备数: " & NowUser
                Label9.Text = "无线网络频道: " & SSIDMode
                Label8.Text = "网络物理地址: " & UCase(BSSID)
                Label17.Text = "无线电波类型: " & WType
                Timer1.Enabled = True
                Timer2.Enabled = True
                Dim iskhdxyg As Boolean, temp3 As String
                iskhdxyg = False
                If NowUser <> 0 Then
                    For i = 0 To TextBox1.Lines.Length - 1
                        If iskhdxyg = False Then
                            If Mid(TextBox1.Lines(i), 5, 4) = "客户端数" Then
                                i = i + 1
                                iskhdxyg = True
                            End If
                        Else
                            temp3 = TextBox1.Lines(i).TrimStart
                            Dim Count As Integer = ListViewEx1.Items.Count
                            ListViewEx1.Items.Add(GetMachineName(Mid(temp3, 1, 17)))
                            ListViewEx1.Items(Count).SubItems.Add(UCase(Mid(temp3, 1, 17)))
                        End If
                    Next
                End If
            End If
        Else
errorfind:
            Dim temisopen As String
            temisopen = RunCmd("netsh wlan stop hostednetwork")
            If (temisopen <> "已停止承载网络。" & vbCrLf & "" & vbCrLf & "") Then
                ReadImage(PictureBox1, "error.png")
                ShowToast(Me, "无法停止共享，请稍后再试。", 3, 3)
            Else
                Form2.Label1.Text = "设备数量: 0" & vbCrLf & "当前速度: 0 KB/s" & vbCrLf & "节省流量: " & GetFlow(thiss + AllFlow + thisv)
                Form2.Timer1.Enabled = False
                If NoStop1 = 1 Then
                    nIcon.ShowBalloonTip(3, "mWiFi - 无线网络共享已停止", "已关闭无线网络共享，所有已连接的设备将断开。", ToolTipIcon.Info)
                End If
                NowUser = 0
                WriteINI("AllFlow", thisv + AllFlow + thiss)
                AllFlow = thiss + AllFlow + thisv
                Label8.Text = "网络物理地址: 不详"
                Label9.Text = "无线网络频道: 不详"
                Label10.Text = "已连接设备数: 0"
                Label11.Text = "设备数量上限: " & MaxUser
                Label12.Text = "累计节省流量: " & GetFlow(AllFlow)
                Label13.Text = "设备发送流量: 0 KB"
                Label17.Text = "无线电波类型: 不详"
                Label18.Text = "设备接收流量: 0 KB"
                Label14.Text = "设备下载速度: 0 KB/s"
                Label16.Text = "设备上传速度: 0 KB/s"
                ReadImage(PictureBox1, "3.png")
                ListViewEx1.Items.Clear()
                btnCon.Text = "开始共享"
                cbCon.Enabled = True
                TextBoxX1.Enabled = True
                TextBoxX2.Enabled = True
                Timer1.Enabled = False
                Timer2.Enabled = False
            End If
        End If
    End Sub

    Public Function ReadImage(PictureBox As PictureBox, Name As String)
        Dim tobjStream As IO.Stream = Me.GetType.Assembly.GetManifestResourceStream("mWiFi." & Name)
        Dim tobjStreamReader As New IO.StreamReader(tobjStream, System.Text.Encoding.Default)
        Dim pic As New Bitmap(tobjStream)
        PictureBox.Image = pic
    End Function

    Public Function GetSpeed(Speed As Integer) As String
        If Speed < 1024 Then
            Return Speed & " KB/s"
        Else
            Return FormatNumber(Speed / 1024, 2) & " MB/s"
        End If
    End Function

    Public Function GetFlow(Flow As Integer) As String
        If Flow < 1024 Then
            Return Flow & " KB"
        Else
            Return FormatNumber(Flow / 1024, 2) & " MB"
        End If
    End Function

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim t As Thread = New Thread(AddressOf ShowSpeed)
        t.Start()
    End Sub

    Public Sub ShowSpeed()
        thisv = GetSv()
        thiss = GetRv()
        Label12.Text = "累计节省流量: " & GetFlow(thisv + AllFlow + thiss)
        Label13.Text = "设备发送流量: " & GetFlow(thiss)
        Label14.Text = "设备下载速度: " & GetSpeed(thisv - LastV)
        gSpeed = thisv - LastV
        LastV = thisv
        Label16.Text = "设备上传速度: " & GetSpeed(thiss - LastB)
        LastB = thiss
        Label18.Text = "设备接收流量: " & GetFlow(thisv)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim t As Thread = New Thread(AddressOf RefreshDevice)
        t.Start()
    End Sub

    Public Sub RefreshDevice()
        TextBox1.Text = RunCmd("netsh wlan show hostednetwork")
        Dim TempUser As Integer = NowUser
        For i = 0 To TextBox1.Lines.Length - 1
            If Mid(TextBox1.Lines(i), 5, 4) = "客户端数" Then
                NowUser = Val(Mid(TextBox1.Lines(i), 17, Len(TextBox1.Lines(i)) - 16))
            End If
        Next
        Label10.Text = "已连接设备数: " & NowUser
        Dim iskhdxyg As Boolean, temp3 As String
        iskhdxyg = False
        ListViewEx1.Items.Clear()
        If NowUser <> 0 Then
            For i = 0 To TextBox1.Lines.GetUpperBound(0)
                If iskhdxyg = False Then
                    If Mid(TextBox1.Lines(i), 5, 4) = "客户端数" Then
                        iskhdxyg = True
                    End If
                Else
                    On Error Resume Next
                    temp3 = TextBox1.Lines(i).TrimStart
                    If temp3 <> "" Then
                        Dim Count As Integer = ListViewEx1.Items.Count
                        If Mid(temp3, 1, 17).Contains(".") = True Then
                            Exit Sub
                        End If
                        ListViewEx1.Items.Add(GetMachineName(Mid(temp3, 1, 17)))
                        ListViewEx1.Items(Count).SubItems.Add(UCase(Mid(temp3, 1, 17)))
                        RemoveUnknown()
                        If TempUser < NowUser Then
                            If NoStart1 = 1 Then
                                If UCase(Mid(temp3, 1, 17)).Contains(".") = False Then
                                    nIcon.ShowBalloonTip(3, "mWiFi - 有新设备连接", "设备名称: " & GetMachineName(Mid(temp3, 1, 17)) & vbCrLf & "设备 MAC 地址: " & UCase(Mid(temp3, 1, 17)) & vbCrLf & vbCrLf & "如果你不认识此设备，则无线网络的密码很可能已被破解，请立即修改密码以保证安全。", ToolTipIcon.Info)
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        WriteConfig(cbStartup, cbAuto, cbXFC, cbTask, cbNoStart, cbNoStop, cbNoNew, cbHideMe, cbEnd, cbCheck)
        ReadForMem()
        ReadForCon(cbStartup, cbAuto, cbXFC, cbTask, cbNoStart, cbNoStop, cbNoNew, cbHideMe, cbEnd, cbCheck)
        If Startup1 = 1 Then
            Dim regname As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\microsoft\\windows\\currentversion\\run", True)
            regname.SetValue("mWiFi", """" & Application.ExecutablePath & """")
        Else
            On Error Resume Next
            Dim regname As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\microsoft\\windows\\currentversion\\run", True)
            regname.DeleteSubKey("mWiFi")
        End If
        MsgBox("保存设置成功！", MsgBoxStyle.Information, "mWiFi 提示")
    End Sub

    Private Sub cbTask_CheckedChanged(sender As Object, e As EventArgs) Handles cbTask.CheckedChanged
        GroupBox1.Enabled = cbTask.Checked
    End Sub

    Private Sub nIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles nIcon.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            cms.Show(System.Windows.Forms.Cursor.Position.X.ToString, System.Windows.Forms.Cursor.Position.Y.ToString)
        End If
    End Sub

    Private Sub nIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles nIcon.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub cmsShow_Click(sender As Object, e As EventArgs) Handles cmsShow.Click
        Me.Show()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        If btnCon.Text = "停止共享" Then
            Call btnCon_Click(sender, e)
        End If
        nIcon.Icon = Nothing
        End
    End Sub


    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            nIcon.ShowBalloonTip(3, "mWiFi - 提示", "mWiFi 正在后台运行中，双击任务栏图标显示主窗体。", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub ListViewEx1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewEx1.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            On Error Resume Next
            Timer1.Enabled = False
            Dim TmpLitem As ListViewItem
            Dim TmpStr As String = ""
            For Each TmpLitem In Me.ListViewEx1.SelectedItems
                TmpStr += TmpLitem.SubItems.Item(0).Text.Trim
            Next
            If TmpStr <> "" Then
                Timer1.Enabled = False
                PreChangeName(TmpStr)
            End If
        Timer1.Enabled = True
        End If
    End Sub

    Public Sub RemoveUnknown()
        On Error Resume Next
        Dim temp3 As String, Count As Integer = ListViewEx1.Items.Count
        TextBox1.Text = RunCmd("arp -a")
        Dim item As ListViewItem
        Dim TempString As String, TempIP As String, TempMac As String
        For Each item In ListViewEx1.Items
            For i2 = 0 To TextBox1.Lines.Length - 1
                temp3 = TextBox1.Lines(i2).Trim()
                temp3 = temp3.Replace(vbCrLf, "")
                TempMac = LCase(item.SubItems(1).Text)
                TempMac = TempMac.Replace(":", "-")
                If temp3.Contains(TempMac) = True Then
                    TempIP = Microsoft.VisualBasic.Left(temp3, 15)
                    TempIP = TempIP.Trim()
                    ListViewEx1.Items(Count - 1).SubItems.Add(TempIP)
                End If
            Next
            If item.SubItems(1).Text.Contains(".") = True Then
                item.Remove()
            End If
        Next
    End Sub

    Private Sub cbCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbCon.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        On Error GoTo errline
        nIcon.Icon = Me.Icon
        nIcon.ShowBalloonTip(1, "mWiFi - 检查更新", "正在自动检查更新，请稍后..." & vbCrLf & "如果有新版本的 mWiFi 将会提示你更新。", ToolTipIcon.Info)
        Dim web As New WebClient
        Dim TempS As String = web.DownloadString("http://mwifi.moefactory.com/update.php?ver=1") ' & My.Application.Info.Version.Revision)
        If TempS.StartsWith("1") = True Then
            Dim NewVersion As String = Microsoft.VisualBasic.Right(TempS, Len(TempS) - 2)
            Form4.ShowDialog()
        Else
            MsgBox("当前版本的 mWiFi 已是最新。", MsgBoxStyle.Information, "检查更新")
        End If
ErrLine:
        If Err.Number <> 0 Then
            MsgBox("错误 " & Err.Number & ": " & Err.Description & vbCrLf & "检查更新失败，请检查你的网络是否正常。", MsgBoxStyle.Critical, "检查更新失败")
        End If
    End Sub
End Class
