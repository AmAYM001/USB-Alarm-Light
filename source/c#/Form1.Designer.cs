namespace USB_Switch
{
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.comBox_COM = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_close_n = new System.Windows.Forms.TextBox();
            this.txt_open_n = new System.Windows.Forms.TextBox();
            this.txt_open_y = new System.Windows.Forms.TextBox();
            this.btn_open_n = new System.Windows.Forms.Button();
            this.btn_close_n = new System.Windows.Forms.Button();
            this.btn_flash = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_back = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // comBox_COM
            // 
            this.comBox_COM.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comBox_COM.FormattingEnabled = true;
            this.comBox_COM.Location = new System.Drawing.Point(128, 49);
            this.comBox_COM.Name = "comBox_COM";
            this.comBox_COM.Size = new System.Drawing.Size(110, 29);
            this.comBox_COM.TabIndex = 0;
            this.comBox_COM.Text = "请选择串口";
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_connect.Location = new System.Drawing.Point(254, 49);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 27);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "关闭";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "闪烁";
            // 
            // txt_close_n
            // 
            this.txt_close_n.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_close_n.Location = new System.Drawing.Point(57, 57);
            this.txt_close_n.Name = "txt_close_n";
            this.txt_close_n.Size = new System.Drawing.Size(110, 29);
            this.txt_close_n.TabIndex = 3;
            this.txt_close_n.Text = "A0 01 00 A1";
            // 
            // txt_open_n
            // 
            this.txt_open_n.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_open_n.Location = new System.Drawing.Point(57, 23);
            this.txt_open_n.Name = "txt_open_n";
            this.txt_open_n.Size = new System.Drawing.Size(110, 29);
            this.txt_open_n.TabIndex = 3;
            this.txt_open_n.Text = "A0 01 01 A2";
            // 
            // txt_open_y
            // 
            this.txt_open_y.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_open_y.Location = new System.Drawing.Point(57, 91);
            this.txt_open_y.Name = "txt_open_y";
            this.txt_open_y.Size = new System.Drawing.Size(110, 29);
            this.txt_open_y.TabIndex = 3;
            this.txt_open_y.Text = "A0 01 02 A3";
            // 
            // btn_open_n
            // 
            this.btn_open_n.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_open_n.Enabled = false;
            this.btn_open_n.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_open_n.Location = new System.Drawing.Point(183, 26);
            this.btn_open_n.Name = "btn_open_n";
            this.btn_open_n.Size = new System.Drawing.Size(75, 27);
            this.btn_open_n.TabIndex = 4;
            this.btn_open_n.Text = "打开";
            this.btn_open_n.UseVisualStyleBackColor = false;
            this.btn_open_n.Click += new System.EventHandler(this.btn_open_n_Click);
            // 
            // btn_close_n
            // 
            this.btn_close_n.BackColor = System.Drawing.Color.LightPink;
            this.btn_close_n.Enabled = false;
            this.btn_close_n.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_close_n.Location = new System.Drawing.Point(183, 60);
            this.btn_close_n.Name = "btn_close_n";
            this.btn_close_n.Size = new System.Drawing.Size(75, 27);
            this.btn_close_n.TabIndex = 4;
            this.btn_close_n.Text = "关闭";
            this.btn_close_n.UseVisualStyleBackColor = false;
            this.btn_close_n.Click += new System.EventHandler(this.btn_close_n_Click);
            // 
            // btn_flash
            // 
            this.btn_flash.Enabled = false;
            this.btn_flash.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_flash.Location = new System.Drawing.Point(183, 91);
            this.btn_flash.Name = "btn_flash";
            this.btn_flash.Size = new System.Drawing.Size(75, 27);
            this.btn_flash.TabIndex = 4;
            this.btn_flash.Text = "闪烁";
            this.btn_flash.UseVisualStyleBackColor = true;
            this.btn_flash.Click += new System.EventHandler(this.btn_close_y_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(375, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "返回值";
            // 
            // txt_back
            // 
            this.txt_back.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_back.Location = new System.Drawing.Point(439, 46);
            this.txt_back.Name = "txt_back";
            this.txt_back.Size = new System.Drawing.Size(192, 29);
            this.txt_back.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(70, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "串口号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_close_n);
            this.groupBox1.Controls.Add(this.txt_open_n);
            this.groupBox1.Controls.Add(this.txt_open_y);
            this.groupBox1.Controls.Add(this.btn_flash);
            this.groupBox1.Controls.Add(this.btn_close_n);
            this.groupBox1.Controls.Add(this.btn_open_n);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(16, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 125);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "黄灯控制";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "打开";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(39, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "通讯协议说明：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(39, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(866, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "指令用16进制发送数据：数据1--启始标识（默认为0xA0）；数据2--开关地址码；数据3--操作数据；数据4--校验码（前面三个数据加和）";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(39, 431);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(983, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "地址数据说明：0x00为所有灯+蜂鸣器，0x01为黄灯，0x02为绿灯，0x03为红灯，0x04为蜂鸣器，0x05为黄灯+蜂鸣，0x06为绿灯+蜂鸣，0x07为红" +
    "灯+蜂鸣";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox16);
            this.groupBox3.Controls.Add(this.textBox17);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(16, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 125);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "绿灯控制";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "打开";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(11, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "关闭";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(11, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "闪烁";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(57, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 29);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "A0 02 00 A2";
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox16.Location = new System.Drawing.Point(57, 24);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(110, 29);
            this.textBox16.TabIndex = 3;
            this.textBox16.Text = "A0 02 01 A3";
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox17.Location = new System.Drawing.Point(57, 92);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(110, 29);
            this.textBox17.TabIndex = 3;
            this.textBox17.Text = "A0 02 02 A4";
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(183, 92);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 27);
            this.button9.TabIndex = 4;
            this.button9.Text = "闪烁";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightPink;
            this.button8.Enabled = false;
            this.button8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(183, 61);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 27);
            this.button8.TabIndex = 4;
            this.button8.Text = "关闭";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.PaleGreen;
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(183, 27);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 27);
            this.button7.TabIndex = 4;
            this.button7.Text = "打开";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(287, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 125);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "蜂鸣控制";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(8, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "长鸣";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(8, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "关闭";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(8, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 21);
            this.label14.TabIndex = 2;
            this.label14.Text = "间断";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(53, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "A0 04 00 A4";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(53, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 29);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "A0 04 01 A5";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(53, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 29);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "A0 04 02 A6";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(179, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "间断";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(179, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(179, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "长鸣";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(287, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 125);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "红灯控制";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(8, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "打开";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(8, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "关闭";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(8, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 21);
            this.label17.TabIndex = 2;
            this.label17.Text = "闪烁";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(53, 59);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(110, 29);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "A0 03 00 A3";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(53, 25);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(110, 29);
            this.textBox6.TabIndex = 3;
            this.textBox6.Text = "A0 03 01 A4";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7.Location = new System.Drawing.Point(53, 93);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(110, 29);
            this.textBox7.TabIndex = 3;
            this.textBox7.Text = "A0 03 02 A5";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(179, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "闪烁";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightPink;
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(179, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "关闭";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PaleGreen;
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(179, 28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 27);
            this.button6.TabIndex = 4;
            this.button6.Text = "打开";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(39, 461);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(360, 20);
            this.label18.TabIndex = 17;
            this.label18.Text = "操作数据说明：0x00为关，0x01为开，0x02为闪烁/间断";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.textBox8);
            this.groupBox5.Controls.Add(this.textBox9);
            this.groupBox5.Controls.Add(this.textBox10);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(827, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(263, 125);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "全局控制";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(8, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 21);
            this.label19.TabIndex = 2;
            this.label19.Text = "打开";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(8, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 21);
            this.label20.TabIndex = 2;
            this.label20.Text = "关闭";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(8, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 21);
            this.label21.TabIndex = 2;
            this.label21.Text = "闪烁";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8.Location = new System.Drawing.Point(53, 57);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(110, 29);
            this.textBox8.TabIndex = 3;
            this.textBox8.Text = "A0 00 00 A0";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Location = new System.Drawing.Point(53, 23);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(110, 29);
            this.textBox9.TabIndex = 3;
            this.textBox9.Text = "A0 00 01 A1";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox10.Location = new System.Drawing.Point(53, 91);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(110, 29);
            this.textBox10.TabIndex = 3;
            this.textBox10.Text = "A0 00 02 A2";
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.Location = new System.Drawing.Point(179, 91);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 27);
            this.button10.TabIndex = 4;
            this.button10.Text = "闪烁";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightPink;
            this.button11.Enabled = false;
            this.button11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button11.Location = new System.Drawing.Point(179, 60);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 27);
            this.button11.TabIndex = 4;
            this.button11.Text = "关闭";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.PaleGreen;
            this.button12.Enabled = false;
            this.button12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button12.Location = new System.Drawing.Point(179, 26);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 27);
            this.button12.TabIndex = 4;
            this.button12.Text = "打开";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.textBox11);
            this.groupBox6.Controls.Add(this.textBox12);
            this.groupBox6.Controls.Add(this.textBox13);
            this.groupBox6.Controls.Add(this.button13);
            this.groupBox6.Controls.Add(this.button14);
            this.groupBox6.Controls.Add(this.button15);
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(827, 101);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(263, 125);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "红灯+蜂鸣控制";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(8, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 21);
            this.label22.TabIndex = 2;
            this.label22.Text = "打开";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(8, 60);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 21);
            this.label23.TabIndex = 2;
            this.label23.Text = "关闭";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(8, 94);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 21);
            this.label24.TabIndex = 2;
            this.label24.Text = "闪烁";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox11.Location = new System.Drawing.Point(53, 59);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(110, 29);
            this.textBox11.TabIndex = 3;
            this.textBox11.Text = "A0 07 00 A7";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox12.Location = new System.Drawing.Point(53, 25);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(110, 29);
            this.textBox12.TabIndex = 3;
            this.textBox12.Text = "A0 07 01 A8";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox13.Location = new System.Drawing.Point(53, 93);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(110, 29);
            this.textBox13.TabIndex = 3;
            this.textBox13.Text = "A0 07 02 A9";
            // 
            // button13
            // 
            this.button13.Enabled = false;
            this.button13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button13.Location = new System.Drawing.Point(179, 93);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 27);
            this.button13.TabIndex = 4;
            this.button13.Text = "闪烁";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LightPink;
            this.button14.Enabled = false;
            this.button14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button14.Location = new System.Drawing.Point(179, 62);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 27);
            this.button14.TabIndex = 4;
            this.button14.Text = "关闭";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.PaleGreen;
            this.button15.Enabled = false;
            this.button15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button15.Location = new System.Drawing.Point(179, 28);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 27);
            this.button15.TabIndex = 4;
            this.button15.Text = "打开";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.textBox14);
            this.groupBox7.Controls.Add(this.textBox15);
            this.groupBox7.Controls.Add(this.textBox18);
            this.groupBox7.Controls.Add(this.button16);
            this.groupBox7.Controls.Add(this.button17);
            this.groupBox7.Controls.Add(this.button18);
            this.groupBox7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(557, 237);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(264, 125);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "绿灯+蜂鸣控制";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(11, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 21);
            this.label25.TabIndex = 2;
            this.label25.Text = "打开";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(11, 60);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 21);
            this.label26.TabIndex = 2;
            this.label26.Text = "关闭";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(11, 94);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 21);
            this.label27.TabIndex = 2;
            this.label27.Text = "闪烁";
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox14.Location = new System.Drawing.Point(57, 58);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(110, 29);
            this.textBox14.TabIndex = 3;
            this.textBox14.Text = "A0 06 00 A6";
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox15.Location = new System.Drawing.Point(57, 24);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(110, 29);
            this.textBox15.TabIndex = 3;
            this.textBox15.Text = "A0 06 01 A7";
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox18.Location = new System.Drawing.Point(57, 92);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(110, 29);
            this.textBox18.TabIndex = 3;
            this.textBox18.Text = "A0 06 02 A8";
            // 
            // button16
            // 
            this.button16.Enabled = false;
            this.button16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button16.Location = new System.Drawing.Point(183, 92);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 27);
            this.button16.TabIndex = 4;
            this.button16.Text = "闪烁";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.LightPink;
            this.button17.Enabled = false;
            this.button17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button17.Location = new System.Drawing.Point(183, 61);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 27);
            this.button17.TabIndex = 4;
            this.button17.Text = "关闭";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.PaleGreen;
            this.button18.Enabled = false;
            this.button18.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button18.Location = new System.Drawing.Point(183, 27);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 27);
            this.button18.TabIndex = 4;
            this.button18.Text = "打开";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.label29);
            this.groupBox8.Controls.Add(this.label30);
            this.groupBox8.Controls.Add(this.textBox19);
            this.groupBox8.Controls.Add(this.textBox20);
            this.groupBox8.Controls.Add(this.textBox21);
            this.groupBox8.Controls.Add(this.button19);
            this.groupBox8.Controls.Add(this.button20);
            this.groupBox8.Controls.Add(this.button21);
            this.groupBox8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.Location = new System.Drawing.Point(557, 101);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(264, 125);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "黄灯+蜂鸣控制";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(11, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 21);
            this.label28.TabIndex = 2;
            this.label28.Text = "打开";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(11, 60);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 21);
            this.label29.TabIndex = 2;
            this.label29.Text = "关闭";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(11, 94);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 21);
            this.label30.TabIndex = 2;
            this.label30.Text = "闪烁";
            // 
            // textBox19
            // 
            this.textBox19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox19.Location = new System.Drawing.Point(57, 57);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(110, 29);
            this.textBox19.TabIndex = 3;
            this.textBox19.Text = "A0 05 00 A5";
            // 
            // textBox20
            // 
            this.textBox20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox20.Location = new System.Drawing.Point(57, 23);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(110, 29);
            this.textBox20.TabIndex = 3;
            this.textBox20.Text = "A0 05 01 A6";
            // 
            // textBox21
            // 
            this.textBox21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox21.Location = new System.Drawing.Point(57, 91);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(110, 29);
            this.textBox21.TabIndex = 3;
            this.textBox21.Text = "A0 05 02 A7";
            // 
            // button19
            // 
            this.button19.Enabled = false;
            this.button19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button19.Location = new System.Drawing.Point(183, 91);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 27);
            this.button19.TabIndex = 4;
            this.button19.Text = "闪烁";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.LightPink;
            this.button20.Enabled = false;
            this.button20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button20.Location = new System.Drawing.Point(183, 60);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 27);
            this.button20.TabIndex = 4;
            this.button20.Text = "关闭";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.PaleGreen;
            this.button21.Enabled = false;
            this.button21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button21.Location = new System.Drawing.Point(183, 26);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 27);
            this.button21.TabIndex = 4;
            this.button21.Text = "打开";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 495);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.comBox_COM);
            this.Name = "Form1";
            this.Text = "USB串口控制报警器测试程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.ComboBox comBox_COM;

		private global::System.Windows.Forms.Button btn_connect;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.TextBox txt_close_n;

		private global::System.Windows.Forms.TextBox txt_open_n;

		private global::System.Windows.Forms.TextBox txt_open_y;

		private global::System.Windows.Forms.Button btn_open_n;

		private global::System.Windows.Forms.Button btn_close_n;

		private global::System.Windows.Forms.Button btn_flash;

		private global::System.Windows.Forms.Label label7;

		private global::System.Windows.Forms.TextBox txt_back;

		private global::System.Windows.Forms.Label label8;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.Label label11;

		private global::System.Windows.Forms.Label label12;

		private global::System.Windows.Forms.Label label13;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.GroupBox groupBox3;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.Label label5;

		private global::System.Windows.Forms.Label label6;

		private global::System.Windows.Forms.TextBox textBox2;

		private global::System.Windows.Forms.TextBox textBox16;

		private global::System.Windows.Forms.TextBox textBox17;

		private global::System.Windows.Forms.Button button9;

		private global::System.Windows.Forms.Button button8;

		private global::System.Windows.Forms.Button button7;

		private global::System.Windows.Forms.GroupBox groupBox2;

		private global::System.Windows.Forms.Label label9;

		private global::System.Windows.Forms.Label label10;

		private global::System.Windows.Forms.Label label14;

		private global::System.Windows.Forms.TextBox textBox1;

		private global::System.Windows.Forms.TextBox textBox3;

		private global::System.Windows.Forms.TextBox textBox4;

		private global::System.Windows.Forms.Button button1;

		private global::System.Windows.Forms.Button button2;

		private global::System.Windows.Forms.Button button3;

		private global::System.Windows.Forms.GroupBox groupBox4;

		private global::System.Windows.Forms.Label label15;

		private global::System.Windows.Forms.Label label16;

		private global::System.Windows.Forms.Label label17;

		private global::System.Windows.Forms.TextBox textBox5;

		private global::System.Windows.Forms.TextBox textBox6;

		private global::System.Windows.Forms.TextBox textBox7;

		private global::System.Windows.Forms.Button button4;

		private global::System.Windows.Forms.Button button5;

		private global::System.Windows.Forms.Button button6;

		private global::System.Windows.Forms.Label label18;

		private global::System.Windows.Forms.GroupBox groupBox5;

		private global::System.Windows.Forms.Label label19;

		private global::System.Windows.Forms.Label label20;

		private global::System.Windows.Forms.Label label21;

		private global::System.Windows.Forms.TextBox textBox8;

		private global::System.Windows.Forms.TextBox textBox9;

		private global::System.Windows.Forms.TextBox textBox10;

		private global::System.Windows.Forms.Button button10;

		private global::System.Windows.Forms.Button button11;

		private global::System.Windows.Forms.Button button12;

		private global::System.Windows.Forms.GroupBox groupBox6;

		private global::System.Windows.Forms.Label label22;

		private global::System.Windows.Forms.Label label23;

		private global::System.Windows.Forms.Label label24;

		private global::System.Windows.Forms.TextBox textBox11;

		private global::System.Windows.Forms.TextBox textBox12;

		private global::System.Windows.Forms.TextBox textBox13;

		private global::System.Windows.Forms.Button button13;

		private global::System.Windows.Forms.Button button14;

		private global::System.Windows.Forms.Button button15;

		private global::System.Windows.Forms.GroupBox groupBox7;

		private global::System.Windows.Forms.Label label25;

		private global::System.Windows.Forms.Label label26;

		private global::System.Windows.Forms.Label label27;

		private global::System.Windows.Forms.TextBox textBox14;

		private global::System.Windows.Forms.TextBox textBox15;

		private global::System.Windows.Forms.TextBox textBox18;

		private global::System.Windows.Forms.Button button16;

		private global::System.Windows.Forms.Button button17;

		private global::System.Windows.Forms.Button button18;

		private global::System.Windows.Forms.GroupBox groupBox8;

		private global::System.Windows.Forms.Label label28;

		private global::System.Windows.Forms.Label label29;

		private global::System.Windows.Forms.Label label30;

		private global::System.Windows.Forms.TextBox textBox19;

		private global::System.Windows.Forms.TextBox textBox20;

		private global::System.Windows.Forms.TextBox textBox21;

		private global::System.Windows.Forms.Button button19;

		private global::System.Windows.Forms.Button button20;

		private global::System.Windows.Forms.Button button21;
    }
}
