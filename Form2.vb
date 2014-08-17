Imports System.Drawing.Drawing2D
Imports System.IO

Public Class Form2
    Public Declare Function SendMessageA Lib "user32" (ByVal hWnd As Integer, ByVal Msg As Integer, ByVal wParam As Integer, ByVal IParam As Integer) As Boolean
    Public Declare Function ReleaseCapture Lib "user32" Alias "ReleaseCapture" () As Boolean

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.HighQuality
        g.PixelOffsetMode = PixelOffsetMode.HighQuality
        Dim tobjStream As IO.Stream = Me.GetType.Assembly.GetManifestResourceStream("mWiFi.xfc.png")
        Dim tobjStreamReader As New IO.StreamReader(tobjStream, System.Text.Encoding.Default)
        Dim pic As New Bitmap(tobjStream)
        g.DrawImage(pic, 0, 0, pic.Width, pic.Height)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 150
        Me.Left = Screen.PrimaryScreen.Bounds.Width - 350
        Me.TransparencyKey = Me.BackColor
        Label1.Text = "设备数量: 0" & vbCrLf & "当前速度: 0 KB/s" & vbCrLf & "节省流量: " & Microsoft.VisualBasic.Right(Form1.Label12.Text, Form1.Label12.Text.Length - 8)
    End Sub

    Private Sub Form2_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            cms.Show(System.Windows.Forms.Cursor.Position.X.ToString, System.Windows.Forms.Cursor.Position.Y.ToString)
        End If
    End Sub

    Private Sub Form2_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessageA(Me.Handle, &HA1, 2, 0) '实现无标题窗口移动
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Form1.btnCon.Text <> "开始共享" Then
            Label1.Text = "设备数量: " & NowUser & vbCrLf & "当前速度: " & Form1.GetSpeed(gSpeed) & vbCrLf & "节省流量: " & Microsoft.VisualBasic.Right(Form1.Label12.Text, Form1.Label12.Text.Length - 8)
        Else
            Label1.Text = "设备数量: 0" & vbCrLf & "当前速度: 0 KB/s" & vbCrLf & "节省流量: " & Microsoft.VisualBasic.Right(Form1.Label12.Text, Form1.Label12.Text.Length - 8)
        End If
    End Sub

    Private Sub cmsShow_Click(sender As Object, e As EventArgs) Handles cmsShow.Click
        Form1.Show()
    End Sub

    Private Sub cmsExit_Click(sender As Object, e As EventArgs) Handles cmsExit.Click
        If Form1.btnCon.Text = "停止共享" Then
            Call Form1.btnCon_Click(sender, e)
        End If
        Form1.nIcon.Icon = Nothing
        End
    End Sub

    Private Sub Label1_MouseClick(sender As Object, e As MouseEventArgs) Handles Label1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            cms.Show(System.Windows.Forms.Cursor.Position.X.ToString, System.Windows.Forms.Cursor.Position.Y.ToString)
        End If
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As EventArgs) Handles Label1.MouseDown
        ReleaseCapture()
        SendMessageA(Me.Handle, &HA1, 2, 0) '实现无标题窗口移动
    End Sub
End Class