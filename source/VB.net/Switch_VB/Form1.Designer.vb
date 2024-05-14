
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    Private WithEvents btn_close_n As System.Windows.Forms.Button

    Friend WithEvents btn_connect As System.Windows.Forms.Button

    Private WithEvents btn_flash As System.Windows.Forms.Button

    Private WithEvents btn_open_n As System.Windows.Forms.Button

    Private WithEvents button1 As System.Windows.Forms.Button

    Private WithEvents button10 As System.Windows.Forms.Button

    Private WithEvents button11 As System.Windows.Forms.Button

    Private WithEvents button12 As System.Windows.Forms.Button

    Private WithEvents button13 As System.Windows.Forms.Button

    Private WithEvents button14 As System.Windows.Forms.Button

    Private WithEvents button15 As System.Windows.Forms.Button

    Private WithEvents button16 As System.Windows.Forms.Button

    Private WithEvents button17 As System.Windows.Forms.Button

    Private WithEvents button18 As System.Windows.Forms.Button

    Private WithEvents button19 As System.Windows.Forms.Button

    Private WithEvents button2 As System.Windows.Forms.Button

    Private WithEvents button20 As System.Windows.Forms.Button

    Private WithEvents button21 As System.Windows.Forms.Button

    Private WithEvents button3 As System.Windows.Forms.Button

    Private WithEvents button4 As System.Windows.Forms.Button

    Private WithEvents button5 As System.Windows.Forms.Button

    Private WithEvents button6 As System.Windows.Forms.Button

    Private WithEvents button7 As System.Windows.Forms.Button

    Private WithEvents button8 As System.Windows.Forms.Button

    Private WithEvents button9 As System.Windows.Forms.Button

    WithEvents comBox_COM As System.Windows.Forms.ComboBox

    Private WithEvents components As System.ComponentModel.IContainer = Nothing

    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox

    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox

    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox

    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox

    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox

    Private WithEvents groupBox6 As System.Windows.Forms.GroupBox

    Private WithEvents groupBox7 As System.Windows.Forms.GroupBox

    Private WithEvents groupBox8 As System.Windows.Forms.GroupBox

    Private WithEvents label1 As System.Windows.Forms.Label

    Private WithEvents label10 As System.Windows.Forms.Label

    Private WithEvents label11 As System.Windows.Forms.Label

    Private WithEvents label12 As System.Windows.Forms.Label

    Private WithEvents label13 As System.Windows.Forms.Label

    Private WithEvents label14 As System.Windows.Forms.Label

    Private WithEvents label15 As System.Windows.Forms.Label

    Private WithEvents label16 As System.Windows.Forms.Label

    Private WithEvents label17 As System.Windows.Forms.Label

    Private WithEvents label18 As System.Windows.Forms.Label

    Private WithEvents label19 As System.Windows.Forms.Label

    Private WithEvents label2 As System.Windows.Forms.Label

    Private WithEvents label20 As System.Windows.Forms.Label

    Private WithEvents label21 As System.Windows.Forms.Label

    Private WithEvents label22 As System.Windows.Forms.Label

    Private WithEvents label23 As System.Windows.Forms.Label

    Private WithEvents label24 As System.Windows.Forms.Label

    Private WithEvents label25 As System.Windows.Forms.Label

    Private WithEvents label26 As System.Windows.Forms.Label

    Private WithEvents label27 As System.Windows.Forms.Label

    Private WithEvents label28 As System.Windows.Forms.Label

    Private WithEvents label29 As System.Windows.Forms.Label

    Private WithEvents label3 As System.Windows.Forms.Label

    Private WithEvents label30 As System.Windows.Forms.Label

    Private WithEvents label4 As System.Windows.Forms.Label

    Private WithEvents label5 As System.Windows.Forms.Label

    Private WithEvents label6 As System.Windows.Forms.Label

    Private WithEvents label7 As System.Windows.Forms.Label

    Private WithEvents label8 As System.Windows.Forms.Label

    Private WithEvents label9 As System.Windows.Forms.Label

    Private WithEvents textBox1 As System.Windows.Forms.TextBox

    Private WithEvents textBox10 As System.Windows.Forms.TextBox

    Private WithEvents textBox11 As System.Windows.Forms.TextBox

    Private WithEvents textBox12 As System.Windows.Forms.TextBox

    Private WithEvents textBox13 As System.Windows.Forms.TextBox

    Private WithEvents textBox14 As System.Windows.Forms.TextBox

    Private WithEvents textBox15 As System.Windows.Forms.TextBox

    Private WithEvents textBox16 As System.Windows.Forms.TextBox

    Private WithEvents textBox17 As System.Windows.Forms.TextBox

    Private WithEvents textBox18 As System.Windows.Forms.TextBox

    Private WithEvents textBox19 As System.Windows.Forms.TextBox

    Private WithEvents textBox2 As System.Windows.Forms.TextBox

    Private WithEvents textBox20 As System.Windows.Forms.TextBox

    Private WithEvents textBox21 As System.Windows.Forms.TextBox

    Private WithEvents textBox3 As System.Windows.Forms.TextBox

    Private WithEvents textBox4 As System.Windows.Forms.TextBox

    Private WithEvents textBox5 As System.Windows.Forms.TextBox

    Private WithEvents textBox6 As System.Windows.Forms.TextBox

    Private WithEvents textBox7 As System.Windows.Forms.TextBox

    Private WithEvents textBox8 As System.Windows.Forms.TextBox

    Private WithEvents textBox9 As System.Windows.Forms.TextBox

    Private WithEvents txt_back As System.Windows.Forms.TextBox

    Private WithEvents txt_close_n As System.Windows.Forms.TextBox

    Private WithEvents txt_open_n As System.Windows.Forms.TextBox

    Private WithEvents txt_open_y As System.Windows.Forms.TextBox

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso Me.components IsNot Nothing Then
            Me.components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Public Sub InitializeComponent()
        Me.comBox_COM = New System.Windows.Forms.ComboBox()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txt_close_n = New System.Windows.Forms.TextBox()
        Me.txt_open_n = New System.Windows.Forms.TextBox()
        Me.txt_open_y = New System.Windows.Forms.TextBox()
        Me.btn_open_n = New System.Windows.Forms.Button()
        Me.btn_close_n = New System.Windows.Forms.Button()
        Me.btn_flash = New System.Windows.Forms.Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_back = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox16 = New System.Windows.Forms.TextBox()
        Me.textBox17 = New System.Windows.Forms.TextBox()
        Me.button9 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.textBox7 = New System.Windows.Forms.TextBox()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.label18 = New System.Windows.Forms.Label()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label21 = New System.Windows.Forms.Label()
        Me.textBox8 = New System.Windows.Forms.TextBox()
        Me.textBox9 = New System.Windows.Forms.TextBox()
        Me.textBox10 = New System.Windows.Forms.TextBox()
        Me.button10 = New System.Windows.Forms.Button()
        Me.button11 = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.groupBox6 = New System.Windows.Forms.GroupBox()
        Me.label22 = New System.Windows.Forms.Label()
        Me.label23 = New System.Windows.Forms.Label()
        Me.label24 = New System.Windows.Forms.Label()
        Me.textBox11 = New System.Windows.Forms.TextBox()
        Me.textBox12 = New System.Windows.Forms.TextBox()
        Me.textBox13 = New System.Windows.Forms.TextBox()
        Me.button13 = New System.Windows.Forms.Button()
        Me.button14 = New System.Windows.Forms.Button()
        Me.button15 = New System.Windows.Forms.Button()
        Me.groupBox7 = New System.Windows.Forms.GroupBox()
        Me.label25 = New System.Windows.Forms.Label()
        Me.label26 = New System.Windows.Forms.Label()
        Me.label27 = New System.Windows.Forms.Label()
        Me.textBox14 = New System.Windows.Forms.TextBox()
        Me.textBox15 = New System.Windows.Forms.TextBox()
        Me.textBox18 = New System.Windows.Forms.TextBox()
        Me.button16 = New System.Windows.Forms.Button()
        Me.button17 = New System.Windows.Forms.Button()
        Me.button18 = New System.Windows.Forms.Button()
        Me.groupBox8 = New System.Windows.Forms.GroupBox()
        Me.label28 = New System.Windows.Forms.Label()
        Me.label29 = New System.Windows.Forms.Label()
        Me.label30 = New System.Windows.Forms.Label()
        Me.textBox19 = New System.Windows.Forms.TextBox()
        Me.textBox20 = New System.Windows.Forms.TextBox()
        Me.textBox21 = New System.Windows.Forms.TextBox()
        Me.button19 = New System.Windows.Forms.Button()
        Me.button20 = New System.Windows.Forms.Button()
        Me.button21 = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        Me.groupBox6.SuspendLayout()
        Me.groupBox7.SuspendLayout()
        Me.groupBox8.SuspendLayout()
        Me.SuspendLayout()
        Me.comBox_COM.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.comBox_COM.FormattingEnabled = True
        Me.comBox_COM.Location = New System.Drawing.Point(128, 49)
        Me.comBox_COM.Name = "comBox_COM"
        Me.comBox_COM.Size = New System.Drawing.Size(110, 29)
        Me.comBox_COM.TabIndex = 0
        Me.comBox_COM.Text = "请选择串口"
        Me.btn_connect.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.btn_connect.Location = New System.Drawing.Point(254, 49)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(75, 27)
        Me.btn_connect.TabIndex = 1
        Me.btn_connect.Text = "连接"
        Me.btn_connect.UseVisualStyleBackColor = True

        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label2.Location = New System.Drawing.Point(11, 60)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 21)
        Me.label2.TabIndex = 2
        Me.label2.Text = "关闭"
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label3.Location = New System.Drawing.Point(11, 94)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(42, 21)
        Me.label3.TabIndex = 2
        Me.label3.Text = "闪烁"
        Me.txt_close_n.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.txt_close_n.Location = New System.Drawing.Point(57, 57)
        Me.txt_close_n.Name = "txt_close_n"
        Me.txt_close_n.Size = New System.Drawing.Size(110, 29)
        Me.txt_close_n.TabIndex = 3
        Me.txt_close_n.Text = "A0 01 00 A1"
        Me.txt_open_n.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.txt_open_n.Location = New System.Drawing.Point(57, 23)
        Me.txt_open_n.Name = "txt_open_n"
        Me.txt_open_n.Size = New System.Drawing.Size(110, 29)
        Me.txt_open_n.TabIndex = 3
        Me.txt_open_n.Text = "A0 01 01 A2"
        Me.txt_open_y.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.txt_open_y.Location = New System.Drawing.Point(57, 91)
        Me.txt_open_y.Name = "txt_open_y"
        Me.txt_open_y.Size = New System.Drawing.Size(110, 29)
        Me.txt_open_y.TabIndex = 3
        Me.txt_open_y.Text = "A0 01 02 A3"
        Me.btn_open_n.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_open_n.Enabled = False
        Me.btn_open_n.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.btn_open_n.Location = New System.Drawing.Point(183, 26)
        Me.btn_open_n.Name = "btn_open_n"
        Me.btn_open_n.Size = New System.Drawing.Size(75, 27)
        Me.btn_open_n.TabIndex = 4
        Me.btn_open_n.Text = "打开"
        Me.btn_open_n.UseVisualStyleBackColor = False
        'AddHandler Me.btn_open_n.Click, New System.EventHandler(Me.btn_open_n_Click)
        Me.btn_close_n.BackColor = System.Drawing.Color.LightPink
        Me.btn_close_n.Enabled = False
        Me.btn_close_n.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.btn_close_n.Location = New System.Drawing.Point(183, 60)
        Me.btn_close_n.Name = "btn_close_n"
        Me.btn_close_n.Size = New System.Drawing.Size(75, 27)
        Me.btn_close_n.TabIndex = 4
        Me.btn_close_n.Text = "关闭"
        Me.btn_close_n.UseVisualStyleBackColor = False
        'AddHandler Me.btn_close_n.Click, New System.EventHandler(Me.btn_close_n_Click)
        Me.btn_flash.Enabled = False
        Me.btn_flash.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.btn_flash.Location = New System.Drawing.Point(183, 91)
        Me.btn_flash.Name = "btn_flash"
        Me.btn_flash.Size = New System.Drawing.Size(75, 27)
        Me.btn_flash.TabIndex = 4
        Me.btn_flash.Text = "闪烁"
        Me.btn_flash.UseVisualStyleBackColor = True
        'AddHandler Me.btn_flash.Click, New System.EventHandler(Me.btn_close_y_Click)
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label7.Location = New System.Drawing.Point(375, 49)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(58, 21)
        Me.label7.TabIndex = 2
        Me.label7.Text = "返回值"
        Me.txt_back.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.txt_back.Location = New System.Drawing.Point(439, 46)
        Me.txt_back.Name = "txt_back"
        Me.txt_back.Size = New System.Drawing.Size(192, 29)
        Me.txt_back.TabIndex = 3
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label8.Location = New System.Drawing.Point(70, 52)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(58, 21)
        Me.label8.TabIndex = 2
        Me.label8.Text = "串口号"
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.txt_close_n)
        Me.groupBox1.Controls.Add(Me.txt_open_n)
        Me.groupBox1.Controls.Add(Me.txt_open_y)
        Me.groupBox1.Controls.Add(Me.btn_flash)
        Me.groupBox1.Controls.Add(Me.btn_close_n)
        Me.groupBox1.Controls.Add(Me.btn_open_n)
        Me.groupBox1.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.groupBox1.Location = New System.Drawing.Point(16, 101)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(264, 125)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "黄灯控制"
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label1.Location = New System.Drawing.Point(11, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(42, 21)
        Me.label1.TabIndex = 2
        Me.label1.Text = "打开"
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label11.Location = New System.Drawing.Point(39, 367)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(107, 20)
        Me.label11.TabIndex = 10
        Me.label11.Text = "通讯协议说明："
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label12.Location = New System.Drawing.Point(39, 397)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(866, 20)
        Me.label12.TabIndex = 11
        Me.label12.Text = "指令用16进制发送数据：数据1--启始标识（默认为0xA0）；数据2--开关地址码；数据3--操作数据；数据4--校验码（前面三个数据加和）"
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label13.Location = New System.Drawing.Point(39, 431)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(983, 20)
        Me.label13.TabIndex = 12
        Me.label13.Text = "地址数据说明：0x00为所有灯+蜂鸣器，0x01为黄灯，0x02为绿灯，0x03为红灯，0x04为蜂鸣器，0x05为黄灯+蜂鸣，0x06为绿灯+蜂鸣，0x07为红" & "灯+蜂鸣"
        Me.groupBox3.Controls.Add(Me.label4)
        Me.groupBox3.Controls.Add(Me.label5)
        Me.groupBox3.Controls.Add(Me.label6)
        Me.groupBox3.Controls.Add(Me.textBox2)
        Me.groupBox3.Controls.Add(Me.textBox16)
        Me.groupBox3.Controls.Add(Me.textBox17)
        Me.groupBox3.Controls.Add(Me.button9)
        Me.groupBox3.Controls.Add(Me.button8)
        Me.groupBox3.Controls.Add(Me.button7)
        Me.groupBox3.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.groupBox3.Location = New System.Drawing.Point(16, 237)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(264, 125)
        Me.groupBox3.TabIndex = 14
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "绿灯控制"
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label4.Location = New System.Drawing.Point(11, 26)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(42, 21)
        Me.label4.TabIndex = 2
        Me.label4.Text = "打开"
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label5.Location = New System.Drawing.Point(11, 60)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(42, 21)
        Me.label5.TabIndex = 2
        Me.label5.Text = "关闭"
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label6.Location = New System.Drawing.Point(11, 94)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(42, 21)
        Me.label6.TabIndex = 2
        Me.label6.Text = "闪烁"
        Me.textBox2.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox2.Location = New System.Drawing.Point(57, 58)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(110, 29)
        Me.textBox2.TabIndex = 3
        Me.textBox2.Text = "A0 02 00 A2"
        Me.textBox16.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox16.Location = New System.Drawing.Point(57, 24)
        Me.textBox16.Name = "textBox16"
        Me.textBox16.Size = New System.Drawing.Size(110, 29)
        Me.textBox16.TabIndex = 3
        Me.textBox16.Text = "A0 02 01 A3"
        Me.textBox17.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox17.Location = New System.Drawing.Point(57, 92)
        Me.textBox17.Name = "textBox17"
        Me.textBox17.Size = New System.Drawing.Size(110, 29)
        Me.textBox17.TabIndex = 3
        Me.textBox17.Text = "A0 02 02 A4"
        Me.button9.Enabled = False
        Me.button9.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button9.Location = New System.Drawing.Point(183, 92)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(75, 27)
        Me.button9.TabIndex = 4
        Me.button9.Text = "闪烁"
        Me.button9.UseVisualStyleBackColor = True
        'AddHandler Me.button9.Click, New System.EventHandler(Me.button9_Click)
        Me.button8.BackColor = System.Drawing.Color.LightPink
        Me.button8.Enabled = False
        Me.button8.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button8.Location = New System.Drawing.Point(183, 61)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(75, 27)
        Me.button8.TabIndex = 4
        Me.button8.Text = "关闭"
        Me.button8.UseVisualStyleBackColor = False
        'AddHandler Me.button8.Click, New System.EventHandler(Me.button8_Click)
        Me.button7.BackColor = System.Drawing.Color.PaleGreen
        Me.button7.Enabled = False
        Me.button7.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button7.Location = New System.Drawing.Point(183, 27)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(75, 27)
        Me.button7.TabIndex = 4
        Me.button7.Text = "打开"
        Me.button7.UseVisualStyleBackColor = False
        'AddHandler Me.button7.Click, New System.EventHandler(Me.button7_Click)
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.label14)
        Me.groupBox2.Controls.Add(Me.textBox1)
        Me.groupBox2.Controls.Add(Me.textBox3)
        Me.groupBox2.Controls.Add(Me.textBox4)
        Me.groupBox2.Controls.Add(Me.button1)
        Me.groupBox2.Controls.Add(Me.button2)
        Me.groupBox2.Controls.Add(Me.button3)
        Me.groupBox2.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.groupBox2.Location = New System.Drawing.Point(287, 237)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(263, 125)
        Me.groupBox2.TabIndex = 16
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "蜂鸣控制"
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label9.Location = New System.Drawing.Point(8, 26)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(42, 21)
        Me.label9.TabIndex = 2
        Me.label9.Text = "长鸣"
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label10.Location = New System.Drawing.Point(8, 60)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(42, 21)
        Me.label10.TabIndex = 2
        Me.label10.Text = "关闭"
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label14.Location = New System.Drawing.Point(8, 94)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(42, 21)
        Me.label14.TabIndex = 2
        Me.label14.Text = "间断"
        Me.textBox1.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox1.Location = New System.Drawing.Point(53, 57)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(110, 29)
        Me.textBox1.TabIndex = 3
        Me.textBox1.Text = "A0 04 00 A4"
        Me.textBox3.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox3.Location = New System.Drawing.Point(53, 23)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(110, 29)
        Me.textBox3.TabIndex = 3
        Me.textBox3.Text = "A0 04 01 A5"
        Me.textBox4.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox4.Location = New System.Drawing.Point(53, 91)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(110, 29)
        Me.textBox4.TabIndex = 3
        Me.textBox4.Text = "A0 04 02 A6"
        Me.button1.Enabled = False
        Me.button1.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button1.Location = New System.Drawing.Point(179, 91)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 27)
        Me.button1.TabIndex = 4
        Me.button1.Text = "间断"
        Me.button1.UseVisualStyleBackColor = True
        'AddHandler Me.button1.Click, New System.EventHandler(Me.button1_Click)
        Me.button2.BackColor = System.Drawing.Color.LightPink
        Me.button2.Enabled = False
        Me.button2.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button2.Location = New System.Drawing.Point(179, 60)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 27)
        Me.button2.TabIndex = 4
        Me.button2.Text = "关闭"
        Me.button2.UseVisualStyleBackColor = False
        'AddHandler Me.button2.Click, New System.EventHandler(Me.button2_Click)
        Me.button3.BackColor = System.Drawing.Color.PaleGreen
        Me.button3.Enabled = False
        Me.button3.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button3.Location = New System.Drawing.Point(179, 26)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 27)
        Me.button3.TabIndex = 4
        Me.button3.Text = "长鸣"
        Me.button3.UseVisualStyleBackColor = False
        'AddHandler Me.button3.Click, New System.EventHandler(Me.button3_Click)
        Me.groupBox4.Controls.Add(Me.label15)
        Me.groupBox4.Controls.Add(Me.label16)
        Me.groupBox4.Controls.Add(Me.label17)
        Me.groupBox4.Controls.Add(Me.textBox5)
        Me.groupBox4.Controls.Add(Me.textBox6)
        Me.groupBox4.Controls.Add(Me.textBox7)
        Me.groupBox4.Controls.Add(Me.button4)
        Me.groupBox4.Controls.Add(Me.button5)
        Me.groupBox4.Controls.Add(Me.button6)
        Me.groupBox4.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.groupBox4.Location = New System.Drawing.Point(287, 101)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(263, 125)
        Me.groupBox4.TabIndex = 15
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "红灯控制"
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label15.Location = New System.Drawing.Point(8, 27)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(42, 21)
        Me.label15.TabIndex = 2
        Me.label15.Text = "打开"
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label16.Location = New System.Drawing.Point(8, 60)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(42, 21)
        Me.label16.TabIndex = 2
        Me.label16.Text = "关闭"
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label17.Location = New System.Drawing.Point(8, 94)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(42, 21)
        Me.label17.TabIndex = 2
        Me.label17.Text = "闪烁"
        Me.textBox5.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox5.Location = New System.Drawing.Point(53, 59)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(110, 29)
        Me.textBox5.TabIndex = 3
        Me.textBox5.Text = "A0 03 00 A3"
        Me.textBox6.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox6.Location = New System.Drawing.Point(53, 25)
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(110, 29)
        Me.textBox6.TabIndex = 3
        Me.textBox6.Text = "A0 03 01 A4"
        Me.textBox7.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox7.Location = New System.Drawing.Point(53, 93)
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New System.Drawing.Size(110, 29)
        Me.textBox7.TabIndex = 3
        Me.textBox7.Text = "A0 03 02 A5"
        Me.button4.Enabled = False
        Me.button4.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button4.Location = New System.Drawing.Point(179, 93)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(75, 27)
        Me.button4.TabIndex = 4
        Me.button4.Text = "闪烁"
        Me.button4.UseVisualStyleBackColor = True
        'AddHandler Me.button4.Click, New System.EventHandler(Me.button4_Click)
        Me.button5.BackColor = System.Drawing.Color.LightPink
        Me.button5.Enabled = False
        Me.button5.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button5.Location = New System.Drawing.Point(179, 62)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(75, 27)
        Me.button5.TabIndex = 4
        Me.button5.Text = "关闭"
        Me.button5.UseVisualStyleBackColor = False
        'AddHandler Me.button5.Click, New System.EventHandler(Me.button5_Click)
        Me.button6.BackColor = System.Drawing.Color.PaleGreen
        Me.button6.Enabled = False
        Me.button6.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button6.Location = New System.Drawing.Point(179, 28)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(75, 27)
        Me.button6.TabIndex = 4
        Me.button6.Text = "打开"
        Me.button6.UseVisualStyleBackColor = False
        'AddHandler Me.button6.Click, New System.EventHandler(Me.button6_Click)
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label18.Location = New System.Drawing.Point(39, 461)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(360, 20)
        Me.label18.TabIndex = 17
        Me.label18.Text = "操作数据说明：0x00为关，0x01为开，0x02为闪烁/间断"
        Me.groupBox5.Controls.Add(Me.label19)
        Me.groupBox5.Controls.Add(Me.label20)
        Me.groupBox5.Controls.Add(Me.label21)
        Me.groupBox5.Controls.Add(Me.textBox8)
        Me.groupBox5.Controls.Add(Me.textBox9)
        Me.groupBox5.Controls.Add(Me.textBox10)
        Me.groupBox5.Controls.Add(Me.button10)
        Me.groupBox5.Controls.Add(Me.button11)
        Me.groupBox5.Controls.Add(Me.button12)
        Me.groupBox5.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.groupBox5.Location = New System.Drawing.Point(827, 237)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(263, 125)
        Me.groupBox5.TabIndex = 21
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "全局控制"
        Me.label19.AutoSize = True
        Me.label19.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label19.Location = New System.Drawing.Point(8, 26)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(42, 21)
        Me.label19.TabIndex = 2
        Me.label19.Text = "打开"
        Me.label20.AutoSize = True
        Me.label20.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label20.Location = New System.Drawing.Point(8, 60)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(42, 21)
        Me.label20.TabIndex = 2
        Me.label20.Text = "关闭"
        Me.label21.AutoSize = True
        Me.label21.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label21.Location = New System.Drawing.Point(8, 94)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(42, 21)
        Me.label21.TabIndex = 2
        Me.label21.Text = "闪烁"
        Me.textBox8.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox8.Location = New System.Drawing.Point(53, 57)
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New System.Drawing.Size(110, 29)
        Me.textBox8.TabIndex = 3
        Me.textBox8.Text = "A0 00 00 A0"
        Me.textBox9.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox9.Location = New System.Drawing.Point(53, 23)
        Me.textBox9.Name = "textBox9"
        Me.textBox9.Size = New System.Drawing.Size(110, 29)
        Me.textBox9.TabIndex = 3
        Me.textBox9.Text = "A0 00 01 A1"
        Me.textBox10.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox10.Location = New System.Drawing.Point(53, 91)
        Me.textBox10.Name = "textBox10"
        Me.textBox10.Size = New System.Drawing.Size(110, 29)
        Me.textBox10.TabIndex = 3
        Me.textBox10.Text = "A0 00 02 A2"
        Me.button10.Enabled = False
        Me.button10.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button10.Location = New System.Drawing.Point(179, 91)
        Me.button10.Name = "button10"
        Me.button10.Size = New System.Drawing.Size(75, 27)
        Me.button10.TabIndex = 4
        Me.button10.Text = "闪烁"
        Me.button10.UseVisualStyleBackColor = True
        'AddHandler Me.button10.Click, New System.EventHandler(Me.button10_Click)
        Me.button11.BackColor = System.Drawing.Color.LightPink
        Me.button11.Enabled = False
        Me.button11.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button11.Location = New System.Drawing.Point(179, 60)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(75, 27)
        Me.button11.TabIndex = 4
        Me.button11.Text = "关闭"
        Me.button11.UseVisualStyleBackColor = False
        'AddHandler Me.button11.Click, New System.EventHandler(Me.button11_Click)
        Me.button12.BackColor = System.Drawing.Color.PaleGreen
        Me.button12.Enabled = False
        Me.button12.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button12.Location = New System.Drawing.Point(179, 26)
        Me.button12.Name = "button12"
        Me.button12.Size = New System.Drawing.Size(75, 27)
        Me.button12.TabIndex = 4
        Me.button12.Text = "打开"
        Me.button12.UseVisualStyleBackColor = False
        'AddHandler Me.button12.Click, New System.EventHandler(Me.button12_Click)
        Me.groupBox6.Controls.Add(Me.label22)
        Me.groupBox6.Controls.Add(Me.label23)
        Me.groupBox6.Controls.Add(Me.label24)
        Me.groupBox6.Controls.Add(Me.textBox11)
        Me.groupBox6.Controls.Add(Me.textBox12)
        Me.groupBox6.Controls.Add(Me.textBox13)
        Me.groupBox6.Controls.Add(Me.button13)
        Me.groupBox6.Controls.Add(Me.button14)
        Me.groupBox6.Controls.Add(Me.button15)
        Me.groupBox6.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.groupBox6.Location = New System.Drawing.Point(827, 101)
        Me.groupBox6.Name = "groupBox6"
        Me.groupBox6.Size = New System.Drawing.Size(263, 125)
        Me.groupBox6.TabIndex = 20
        Me.groupBox6.TabStop = False
        Me.groupBox6.Text = "红灯+蜂鸣控制"
        Me.label22.AutoSize = True
        Me.label22.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label22.Location = New System.Drawing.Point(8, 27)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(42, 21)
        Me.label22.TabIndex = 2
        Me.label22.Text = "打开"
        Me.label23.AutoSize = True
        Me.label23.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label23.Location = New System.Drawing.Point(8, 60)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(42, 21)
        Me.label23.TabIndex = 2
        Me.label23.Text = "关闭"
        Me.label24.AutoSize = True
        Me.label24.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label24.Location = New System.Drawing.Point(8, 94)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(42, 21)
        Me.label24.TabIndex = 2
        Me.label24.Text = "闪烁"
        Me.textBox11.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox11.Location = New System.Drawing.Point(53, 59)
        Me.textBox11.Name = "textBox11"
        Me.textBox11.Size = New System.Drawing.Size(110, 29)
        Me.textBox11.TabIndex = 3
        Me.textBox11.Text = "A0 07 00 A7"
        Me.textBox12.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox12.Location = New System.Drawing.Point(53, 25)
        Me.textBox12.Name = "textBox12"
        Me.textBox12.Size = New System.Drawing.Size(110, 29)
        Me.textBox12.TabIndex = 3
        Me.textBox12.Text = "A0 07 01 A8"
        Me.textBox13.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox13.Location = New System.Drawing.Point(53, 93)
        Me.textBox13.Name = "textBox13"
        Me.textBox13.Size = New System.Drawing.Size(110, 29)
        Me.textBox13.TabIndex = 3
        Me.textBox13.Text = "A0 07 02 A9"
        Me.button13.Enabled = False
        Me.button13.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button13.Location = New System.Drawing.Point(179, 93)
        Me.button13.Name = "button13"
        Me.button13.Size = New System.Drawing.Size(75, 27)
        Me.button13.TabIndex = 4
        Me.button13.Text = "闪烁"
        Me.button13.UseVisualStyleBackColor = True
        'AddHandler Me.button13.Click, New System.EventHandler(Me.button13_Click)
        Me.button14.BackColor = System.Drawing.Color.LightPink
        Me.button14.Enabled = False
        Me.button14.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button14.Location = New System.Drawing.Point(179, 62)
        Me.button14.Name = "button14"
        Me.button14.Size = New System.Drawing.Size(75, 27)
        Me.button14.TabIndex = 4
        Me.button14.Text = "关闭"
        Me.button14.UseVisualStyleBackColor = False
        'AddHandler Me.button14.Click, New System.EventHandler(Me.button14_Click)
        Me.button15.BackColor = System.Drawing.Color.PaleGreen
        Me.button15.Enabled = False
        Me.button15.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button15.Location = New System.Drawing.Point(179, 28)
        Me.button15.Name = "button15"
        Me.button15.Size = New System.Drawing.Size(75, 27)
        Me.button15.TabIndex = 4
        Me.button15.Text = "打开"
        Me.button15.UseVisualStyleBackColor = False
        'AddHandler Me.button15.Click, New System.EventHandler(Me.button15_Click)
        Me.groupBox7.Controls.Add(Me.label25)
        Me.groupBox7.Controls.Add(Me.label26)
        Me.groupBox7.Controls.Add(Me.label27)
        Me.groupBox7.Controls.Add(Me.textBox14)
        Me.groupBox7.Controls.Add(Me.textBox15)
        Me.groupBox7.Controls.Add(Me.textBox18)
        Me.groupBox7.Controls.Add(Me.button16)
        Me.groupBox7.Controls.Add(Me.button17)
        Me.groupBox7.Controls.Add(Me.button18)
        Me.groupBox7.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.groupBox7.Location = New System.Drawing.Point(557, 237)
        Me.groupBox7.Name = "groupBox7"
        Me.groupBox7.Size = New System.Drawing.Size(264, 125)
        Me.groupBox7.TabIndex = 19
        Me.groupBox7.TabStop = False
        Me.groupBox7.Text = "绿灯+蜂鸣控制"
        Me.label25.AutoSize = True
        Me.label25.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label25.Location = New System.Drawing.Point(11, 26)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(42, 21)
        Me.label25.TabIndex = 2
        Me.label25.Text = "打开"
        Me.label26.AutoSize = True
        Me.label26.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label26.Location = New System.Drawing.Point(11, 60)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(42, 21)
        Me.label26.TabIndex = 2
        Me.label26.Text = "关闭"
        Me.label27.AutoSize = True
        Me.label27.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label27.Location = New System.Drawing.Point(11, 94)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(42, 21)
        Me.label27.TabIndex = 2
        Me.label27.Text = "闪烁"
        Me.textBox14.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox14.Location = New System.Drawing.Point(57, 58)
        Me.textBox14.Name = "textBox14"
        Me.textBox14.Size = New System.Drawing.Size(110, 29)
        Me.textBox14.TabIndex = 3
        Me.textBox14.Text = "A0 06 00 A6"
        Me.textBox15.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox15.Location = New System.Drawing.Point(57, 24)
        Me.textBox15.Name = "textBox15"
        Me.textBox15.Size = New System.Drawing.Size(110, 29)
        Me.textBox15.TabIndex = 3
        Me.textBox15.Text = "A0 06 01 A7"
        Me.textBox18.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox18.Location = New System.Drawing.Point(57, 92)
        Me.textBox18.Name = "textBox18"
        Me.textBox18.Size = New System.Drawing.Size(110, 29)
        Me.textBox18.TabIndex = 3
        Me.textBox18.Text = "A0 06 02 A8"
        Me.button16.Enabled = False
        Me.button16.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button16.Location = New System.Drawing.Point(183, 92)
        Me.button16.Name = "button16"
        Me.button16.Size = New System.Drawing.Size(75, 27)
        Me.button16.TabIndex = 4
        Me.button16.Text = "闪烁"
        Me.button16.UseVisualStyleBackColor = True
        'AddHandler Me.button16.Click, New System.EventHandler(Me.button16_Click)
        Me.button17.BackColor = System.Drawing.Color.LightPink
        Me.button17.Enabled = False
        Me.button17.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button17.Location = New System.Drawing.Point(183, 61)
        Me.button17.Name = "button17"
        Me.button17.Size = New System.Drawing.Size(75, 27)
        Me.button17.TabIndex = 4
        Me.button17.Text = "关闭"
        Me.button17.UseVisualStyleBackColor = False
        'AddHandler Me.button17.Click, New System.EventHandler(Me.button17_Click)
        Me.button18.BackColor = System.Drawing.Color.PaleGreen
        Me.button18.Enabled = False
        Me.button18.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button18.Location = New System.Drawing.Point(183, 27)
        Me.button18.Name = "button18"
        Me.button18.Size = New System.Drawing.Size(75, 27)
        Me.button18.TabIndex = 4
        Me.button18.Text = "打开"
        Me.button18.UseVisualStyleBackColor = False
        'AddHandler Me.button18.Click, New System.EventHandler(Me.button18_Click)
        Me.groupBox8.Controls.Add(Me.label28)
        Me.groupBox8.Controls.Add(Me.label29)
        Me.groupBox8.Controls.Add(Me.label30)
        Me.groupBox8.Controls.Add(Me.textBox19)
        Me.groupBox8.Controls.Add(Me.textBox20)
        Me.groupBox8.Controls.Add(Me.textBox21)
        Me.groupBox8.Controls.Add(Me.button19)
        Me.groupBox8.Controls.Add(Me.button20)
        Me.groupBox8.Controls.Add(Me.button21)
        Me.groupBox8.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.groupBox8.Location = New System.Drawing.Point(557, 101)
        Me.groupBox8.Name = "groupBox8"
        Me.groupBox8.Size = New System.Drawing.Size(264, 125)
        Me.groupBox8.TabIndex = 18
        Me.groupBox8.TabStop = False
        Me.groupBox8.Text = "黄灯+蜂鸣控制"
        Me.label28.AutoSize = True
        Me.label28.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label28.Location = New System.Drawing.Point(11, 26)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(42, 21)
        Me.label28.TabIndex = 2
        Me.label28.Text = "打开"
        Me.label29.AutoSize = True
        Me.label29.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label29.Location = New System.Drawing.Point(11, 60)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(42, 21)
        Me.label29.TabIndex = 2
        Me.label29.Text = "关闭"
        Me.label30.AutoSize = True
        Me.label30.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.label30.Location = New System.Drawing.Point(11, 94)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(42, 21)
        Me.label30.TabIndex = 2
        Me.label30.Text = "闪烁"
        Me.textBox19.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox19.Location = New System.Drawing.Point(57, 57)
        Me.textBox19.Name = "textBox19"
        Me.textBox19.Size = New System.Drawing.Size(110, 29)
        Me.textBox19.TabIndex = 3
        Me.textBox19.Text = "A0 05 00 A5"
        Me.textBox20.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox20.Location = New System.Drawing.Point(57, 23)
        Me.textBox20.Name = "textBox20"
        Me.textBox20.Size = New System.Drawing.Size(110, 29)
        Me.textBox20.TabIndex = 3
        Me.textBox20.Text = "A0 05 01 A6"
        Me.textBox21.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.textBox21.Location = New System.Drawing.Point(57, 91)
        Me.textBox21.Name = "textBox21"
        Me.textBox21.Size = New System.Drawing.Size(110, 29)
        Me.textBox21.TabIndex = 3
        Me.textBox21.Text = "A0 05 02 A7"
        Me.button19.Enabled = False
        Me.button19.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button19.Location = New System.Drawing.Point(183, 91)
        Me.button19.Name = "button19"
        Me.button19.Size = New System.Drawing.Size(75, 27)
        Me.button19.TabIndex = 4
        Me.button19.Text = "闪烁"
        Me.button19.UseVisualStyleBackColor = True
        'AddHandler Me.button19.Click, New System.EventHandler(Me.button19_Click)
        Me.button20.BackColor = System.Drawing.Color.LightPink
        Me.button20.Enabled = False
        Me.button20.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button20.Location = New System.Drawing.Point(183, 60)
        Me.button20.Name = "button20"
        Me.button20.Size = New System.Drawing.Size(75, 27)
        Me.button20.TabIndex = 4
        Me.button20.Text = "关闭"
        Me.button20.UseVisualStyleBackColor = False
        'AddHandler Me.button20.Click, New System.EventHandler(Me.button20_Click)
        Me.button21.BackColor = System.Drawing.Color.PaleGreen
        Me.button21.Enabled = False
        Me.button21.Font = New System.Drawing.Font("微软雅黑", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((134))))
        Me.button21.Location = New System.Drawing.Point(183, 26)
        Me.button21.Name = "button21"
        Me.button21.Size = New System.Drawing.Size(75, 27)
        Me.button21.TabIndex = 4
        Me.button21.Text = "打开"
        Me.button21.UseVisualStyleBackColor = False
        'AddHandler Me.button21.Click, New System.EventHandler(Me.button21_Click)
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 12.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 495)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.groupBox6)
        Me.Controls.Add(Me.groupBox7)
        Me.Controls.Add(Me.groupBox8)
        Me.Controls.Add(Me.label18)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.txt_back)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.btn_connect)
        Me.Controls.Add(Me.comBox_COM)
        Me.Name = "Form1"
        Me.Text = "USB串口控制报警器测试程序"
        'AddHandler Me.Load, New System.EventHandler(Me.Form1_Load)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.groupBox6.ResumeLayout(False)
        Me.groupBox6.PerformLayout()
        Me.groupBox7.ResumeLayout(False)
        Me.groupBox7.PerformLayout()
        Me.groupBox8.ResumeLayout(False)
        Me.groupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class