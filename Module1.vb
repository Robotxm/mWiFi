Imports System
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports NETCONLib
Imports System.Net.NetworkInformation
Imports DevComponents.DotNetBar
Imports System.Runtime.InteropServices
Imports DevComponents.DotNetBar.Controls
Imports System.Drawing.Imaging
Imports System.Text

Module Module1
    <DllImportAttribute("kernel32.dll", EntryPoint:="GetPrivateProfileStringW", _
             SetLastError:=True, CharSet:=CharSet.Auto, _
             ExactSpelling:=True, _
             CallingConvention:=CallingConvention.StdCall)> _
    Private Function GetPrivateProfileString(ByVal lpApplicationName As String, _
         ByVal lpKeyName As String, ByVal lpDefault As String, _
         ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    End Function
    Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Long
    Public SSIDName As String, SSIDKey As String, MaxUser As Integer, BSSID As String, SSIDMode As Integer, NowUser As Integer
    Public LastV As Integer, LastB As Integer, virtal As Integer, virtalname As String

    Public Startup1 As Integer, AutoSharing1 As Integer, ShowForm1 As Integer, ShowIcon1 As Integer, NoStart1 As Integer
    Public NoStop1 As Integer, NoNew1 As Integer, AllFlow As Integer, AllFlow2 As Integer, HideMe1 As Integer, ExitmWiFi1 As Integer
    Public Check1 As Integer

    Public gSpeed As Integer, devicename As String

    Public thisv As Integer, thiss As Integer

    Public theNewName As String, theOName As String

    Public Function LoadNewConfig()
        WriteINI("Startup", 0)
        WriteINI("AutoSharing", 0)
        WriteINI("ShowForm", 1)
        WriteINI("ShowTaskBarIcon", 1)
        WriteINI("NotifyWhenStart", 1)
        WriteINI("NotifyWhenStop", 1)
        WriteINI("NotifyWhenNew", 1)
        WriteINI("AllFlow", 0)
        WriteINI("HideMainFormWhenStart", 0)
        WriteINI("ExitDirectly", 0)
        WriteINI("CheckUpdateWhenStart", 0)
    End Function

    Public Function ReadForMem()
        On Error GoTo ErrLine
        Startup1 = Convert.ToInt32((ReadINI("Startup")))
        AutoSharing1 = Convert.ToInt32((ReadINI("AutoSharing")))
        ShowForm1 = Convert.ToInt32((ReadINI("ShowForm")))
        ShowIcon1 = Convert.ToInt32((ReadINI("ShowTaskBarIcon")))
        NoStart1 = Convert.ToInt32((ReadINI("NotifyWhenStart")))
        NoStop1 = Convert.ToInt32((ReadINI("NotifyWhenStop")))
        NoNew1 = Convert.ToInt32((ReadINI("NotifyWhenNew")))
        AllFlow = Convert.ToInt32((ReadINI("AllFlow")))
        HideMe1 = Convert.ToInt32((ReadINI("HideMainFormWhenStart")))
        ExitmWiFi1 = Convert.ToInt32((ReadINI("ExitDirectly")))
        Check1 = Convert.ToInt32((ReadINI("CheckUpdateWhenStart")))
ErrLine:
        Select Case Err.Number
            Case 6
                MsgBox("流量统计已经超出程序最大范围，将会被清零。", MsgBoxStyle.Exclamation, "警告")
                AllFlow = 0
                WriteINI("AllFlow", 0)
        End Select
    End Function

    Public Function ReadForCon(Startup As CheckBoxX, AutoSharing As CheckBoxX, ShowForm As CheckBoxX, ShowIcon As CheckBoxX, NoStart As CheckBoxX, NoStop As CheckBoxX, NoNew As CheckBoxX, HideMe As CheckBoxX, ExitmWiFi As CheckBoxX, Check As CheckBoxX)
        Startup.CheckState = Startup1
        AutoSharing.CheckState = AutoSharing1
        ShowForm.CheckState = ShowForm1
        ShowIcon.CheckState = ShowIcon1
        NoStart.CheckState = NoStart1
        NoStop.CheckState = NoStop1
        NoNew.CheckState = NoNew1
        HideMe.CheckState = HideMe1
        ExitmWiFi.CheckState = ExitmWiFi1
        Check.CheckState = Check1
    End Function

    Public Function WriteConfig(Startup As CheckBoxX, AutoSharing As CheckBoxX, ShowForm As CheckBoxX, ShowIcon As CheckBoxX, NoStart As CheckBoxX, NoStop As CheckBoxX, NoNew As CheckBoxX, HideMe As CheckBoxX, ExitmWiFi As CheckBoxX, Check As CheckBoxX)
        WriteINI("Startup", Startup.CheckState)
        WriteINI("AutoSharing", AutoSharing.CheckState)
        WriteINI("ShowForm", ShowForm.CheckState)
        WriteINI("ShowTaskBarIcon", ShowIcon.CheckState)
        WriteINI("NotifyWhenStart", NoStart.CheckState)
        WriteINI("NotifyWhenStop", NoStop.CheckState)
        WriteINI("NotifyWhenNew", NoNew.CheckState)
        WriteINI("HideMainFormWhenStart", HideMe.CheckState)
        WriteINI("ExitDirectly", ExitmWiFi.CheckState)
        WriteINI("CheckUpdateWhenStart", Check.CheckState)
    End Function

    Public Function ReadINI(AppName As String) As String
        Dim DevName As String = ReadINIFile("mWiFiConfig", AppName, "", Application.StartupPath & "\config.cfg")
        If DevName = "" Then
            Return "未知设备"
        Else
            Return DevName
        End If
    End Function

    Public Function WriteINI(AppName As String, Value As String)
        WriteINIFile(Application.StartupPath & "\config.cfg", "mWiFiConfig", AppName, Value)
    End Function
    Public Function ReadINIFile(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As String
        Dim Str As String = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    Public Function WriteINIFile(filename As String, AppName As String, KeyName As String, NewKeyName As String)
        Dim n As Long
        n = WritePrivateProfileString(AppName, KeyName, NewKeyName, filename)
    End Function
    Public Function GetConsoleReturn(ByVal cmdline As String) As String
        Shell("cmd.exe /c " & cmdline & " >result.log", vbHide, True)
        Dim a As Stream, result As String
        a = File.OpenRead(Application.StartupPath & "\result.log")
        Dim sr As StreamReader = New StreamReader(a, System.Text.Encoding.Default)
        sr.BaseStream.Seek(0, SeekOrigin.Begin)
        result = ""
        While (sr.Peek() > -1)
            result = result + sr.ReadLine() + vbCrLf
        End While
        a = Nothing
        sr.Close()
        sr = Nothing
        Kill(Application.StartupPath & "\result.log")
        Return result
    End Function

    Public Function RunCmd(ByVal Commands As String, Optional ByVal TimeOut As Integer = 3 * 60) As String
        Dim myProcess As New Process()
        Dim myProcessStartInfo As New ProcessStartInfo("cmd.exe")
        myProcessStartInfo.UseShellExecute = False
        myProcessStartInfo.RedirectStandardOutput = True
        myProcessStartInfo.CreateNoWindow = True
        myProcessStartInfo.Arguments = "/c" & Commands
        myProcess.StartInfo = myProcessStartInfo
        myProcess.Start()
        myProcess.WaitForExit(TimeOut * 1000)
        Dim myStreamReader As StreamReader = myProcess.StandardOutput
        Dim myString As String = myStreamReader.ReadToEnd
        myProcess.Close()
        Return myString
    End Function

    Public Function GetMachineName(ByVal mac As String) As String
        Dim MaName As String = ReadINIFile("MACTable", mac, "", Application.StartupPath & "\DeviceInfo.db")
        If MaName = "" Then
            MaName = "未知设备"
        End If
        Return MaName
    End Function

    Public Function GetRv() As Integer
        Dim nics() As System.Net.NetworkInformation.NetworkInterface
        nics = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
        Return nics(virtal).GetIPv4Statistics.BytesReceived / 1024
    End Function

    Public Function GetSv() As Integer
        Dim nics() As System.Net.NetworkInformation.NetworkInterface
        nics = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
        Return nics(virtal).GetIPv4Statistics.BytesSent / 1024
    End Function

    Public Function GetVi() As Integer
        Dim nics() As System.Net.NetworkInformation.NetworkInterface
        nics = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
        Dim vi As Integer
        Dim OsVer As String = (Environment.OSVersion.Version.Major & "." & Environment.OSVersion.Version.Minor)
        If nics.Length > 0 Then
            If OsVer > 6.1 Then
                For Each netState In nics
                    If InStr(netState.Description, "Microsoft 托管网络虚拟适配器") <> 0 Or InStr(netState.Description, "Microsoft Wi-Fi Direct 虚拟适配器") <> 0 Then
                        virtalname = netState.Name
                        Return vi
                    Else
                        vi = vi + 1
                    End If
                    If netState.Name = "Loopback Pseudo-Interface 1" Then
                        GoTo endloop
                    End If
                Next
            ElseIf OsVer = 6.1 Then
                For Each netState In nics
                    If InStr(netState.Description, "Microsoft Virtual WiFi Miniport Adapter") <> 0 Then
                        virtalname = netState.Name
                        Return vi
                    Else
                        vi = vi + 1
                    End If
                    If netState.Name = "Loopback Pseudo-Interface 1" Then
                        GoTo endloop
                    End If
                Next
            End If

        End If
endloop:
        Return -1
    End Function

    Public Sub EnableSharing(ByVal devicename As String, ByVal wlanOrlan As Integer)
        Dim netSharingMgr As New NETCONLib.NetSharingManagerClass
        Dim connections As INetSharingEveryConnectionCollection = netSharingMgr.EnumEveryConnection
        For Each connection As INetConnection In connections

            Dim connSharcf As INetSharingConfiguration = netSharingMgr.INetSharingConfigurationForINetConnection((connection))
            Dim connProps As INetConnectionProps = netSharingMgr.NetConnectionProps(connection)
            Try
                If connProps.Name.Equals(devicename) Then
                    If 0 = wlanOrlan Then
                        connSharcf.EnableSharing(tagSHARINGCONNECTIONTYPE.ICSSHARINGTYPE_PUBLIC)
                    End If
                    If 1 = wlanOrlan Then
                        connSharcf.EnableSharing(tagSHARINGCONNECTIONTYPE.ICSSHARINGTYPE_PRIVATE)
                    End If
                End If
            Catch e As Exception
                MessageBox.Show(e.Message & vbCrLf & vbCrLf & "这可能影响网络的使用，你可以尝试重新运行 mWiFi。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Next
    End Sub

    '''<summary>
    '''显示 Toast 消息
    '''</summary>
    '''<param name="Form">显示 Toast 消息的父控件。</param>
    '''<param name="Message">Toast 消息内容。</param>
    '''<param name="MessageType">Toast 消息类型。0 - 无；1 - 提示；2 - 警告；3 - 错误。</param>
    '''<param name="Time">Toast 消息持续时间，单位: 秒。</param>
    Public Function ShowToast(Form As Form, Message As String, MessageType As Integer, Time As Integer)
        Dim color As Integer
        If MessageType = 0 Then
            color = 0
        ElseIf MessageType = 1 Then
            color = 2
        ElseIf MessageType = 2 Then
            color = 4
        ElseIf MessageType = 3 Then
            color = 1
        Else
            color = 0
        End If
        ToastNotification.Show(Form, Message, Nothing, Time * 1000, color, eToastPosition.MiddleCenter)
    End Function

    Public Function PreChangeName(oName As String)
        theOName = oName
        Form3.ShowDialog()
    End Function

    Public Function ChangeName(newName As String)
        theNewName = newName
    End Function


    'Public Function Unzip(FileName As String)
    '    On Error Resume Next
    'Dim bufint As Integer
    'Dim bufbytes(0) As Byte
    'Dim fs As FileStream
    'Dim Asm As [Assembly] = [Assembly].GetExecutingAssembly()
    'Dim strm As Stream = Asm.GetManifestResourceStream( _
    '                 Asm.GetName().Name + "." + FileName)
    '    fs = File.OpenWrite(Application.StartupPath & "\" & FileName)
    '    Do
    '        bufint = strm.ReadByte()
    '        If bufint = -1 Then Exit Do
    '        bufbytes(0) = Convert.ToByte(bufint)
    '        fs.Write(bufbytes, 0, bufbytes.Length)
    '    Loop
    '    fs.Close()
    '    fs.Dispose()
    '    strm.Close()
    'End Function
End Module


