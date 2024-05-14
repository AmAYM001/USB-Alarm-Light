Imports System.IO.Ports


Partial Public Class Form1
    Inherits Form

    Public wport As SerialPort

    Public Sub New()
        Me.InitializeComponent()
    End Sub

    Private Sub btn_close_n_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_close_n.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 1, 0, 161}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btn_close_y_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_flash.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 1, 2, 163}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btn_connect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_connect.Click
        If Me.wport IsNot Nothing Then

            Try
                RemoveHandler Me.wport.DataReceived, AddressOf Me.wport_DataReceived
                Me.wport.Dispose()
                Me.wport.Close()
                Me.wport = Nothing
                Me.btn_connect.Text = "连接"
                Me.btn_close_n.Enabled = False
                Me.btn_open_n.Enabled = False
                Me.btn_flash.Enabled = False
                Me.button1.Enabled = False
                Me.button2.Enabled = False
                Me.button3.Enabled = False
                Me.button4.Enabled = False
                Me.button5.Enabled = False
                Me.button6.Enabled = False
                Me.button7.Enabled = False
                Me.button8.Enabled = False
                Me.button9.Enabled = False
                Me.button10.Enabled = False
                Me.button11.Enabled = False
                Me.button12.Enabled = False
                Me.button13.Enabled = False
                Me.button14.Enabled = False
                Me.button15.Enabled = False
                Me.button16.Enabled = False
                Me.button17.Enabled = False
                Me.button18.Enabled = False
                Me.button19.Enabled = False
                Me.button20.Enabled = False
                Me.button21.Enabled = False
            Catch ex As Exception
                Me.wport = Nothing
                MessageBox.Show(ex.ToString())
            End Try
        ElseIf Me.comBox_COM.Text = "请选择串口" Then
            MessageBox.Show("请选择正确的串口")
        Else

            Try
                Me.wport = New SerialPort(Me.comBox_COM.Text, 921600)
                Me.wport.DataBits = 8
                Me.wport.Parity = Parity.None
                Me.wport.StopBits = StopBits.One
                Me.wport.Open()
                AddHandler Me.wport.DataReceived, AddressOf Me.wport_DataReceived
                Me.btn_connect.Text = "断开"
                Me.btn_close_n.Enabled = True
                Me.btn_open_n.Enabled = True
                Me.btn_flash.Enabled = True
                Me.button1.Enabled = True
                Me.button2.Enabled = True
                Me.button3.Enabled = True
                Me.button4.Enabled = True
                Me.button5.Enabled = True
                Me.button6.Enabled = True
                Me.button7.Enabled = True
                Me.button8.Enabled = True
                Me.button9.Enabled = True
                Me.button10.Enabled = True
                Me.button11.Enabled = True
                Me.button12.Enabled = True
                Me.button13.Enabled = True
                Me.button14.Enabled = True
                Me.button15.Enabled = True
                Me.button16.Enabled = True
                Me.button17.Enabled = True
                Me.button18.Enabled = True
                Me.button19.Enabled = True
                Me.button20.Enabled = True
                Me.button21.Enabled = True
            Catch ex As Exception
                Me.wport = Nothing
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Function btn_connect_Click() As EventHandler
        Throw New NotImplementedException
    End Function

    Private Sub btn_open_n_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_open_n.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 1, 1, 162}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 4, 2, 166}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button10.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 0, 2, 162}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button11.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 0, 0, 160}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button12.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 0, 1, 161}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button13.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 7, 2, 169}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button14_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button14.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 7, 0, 167}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button15_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button15.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 7, 1, 168}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button16_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button16.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 6, 2, 168}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button17_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button17.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 6, 0, 166}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button18_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button18.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 6, 1, 167}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button19_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button19.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 5, 2, 167}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 4, 0, 164}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button20_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button20.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 5, 0, 165}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button21_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button21.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 5, 1, 166}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 4, 1, 165}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 3, 2, 165}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button5.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 3, 0, 163}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button6.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 3, 1, 164}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button7.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 2, 1, 163}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button8.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 2, 0, 162}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub button9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button9.Click
        Me.txt_back.Text = ""

        Try
            Dim buffer As Byte() = New Byte() {160, 2, 2, 164}
            Me.wport.Write(buffer, 0, 4)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        For Each item As String In SerialPort.GetPortNames()
            Me.comBox_COM.Items.Add(item)
        Next
    End Sub
    Private Sub wport_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        Dim bytesToRead As Integer = Me.wport.BytesToRead
        Dim buf As Byte() = New Byte(bytesToRead - 1) {}
        Me.wport.Read(buf, 0, bytesToRead)
        MyBase.Invoke(New EventHandler(Sub(ByVal param0 As Object, ByVal param1 As EventArgs)

                                           For i As Integer = 0 To buf.Length - 1
                                               Dim textBoxBase As TextBoxBase = Me.txt_back
                                               Dim num As Integer = CInt(buf(i))
                                               textBoxBase.AppendText(num.ToString("X2") & " ")
                                           Next
                                       End Sub))
    End Sub
End Class