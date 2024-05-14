using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;


namespace USB_Switch
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (string item in SerialPort.GetPortNames())
			{
				this.comBox_COM.Items.Add(item);
			}
		}

		private void btn_connect_Click(object sender, EventArgs e)
		{
			if (this.sp != null)
			{
				try
				{
					this.sp.DataReceived -= this.SpDataReceived;
					this.sp.Dispose();
					this.sp.Close();
					this.sp = null;
					this.btn_connect.Text = "连接";
					this.btn_close_n.Enabled = false;
					this.btn_open_n.Enabled = false;
					this.btn_flash.Enabled = false;
					this.button1.Enabled = false;
					this.button2.Enabled = false;
					this.button3.Enabled = false;
					this.button4.Enabled = false;
					this.button5.Enabled = false;
					this.button6.Enabled = false;
					this.button7.Enabled = false;
					this.button8.Enabled = false;
					this.button9.Enabled = false;
					this.button10.Enabled = false;
					this.button11.Enabled = false;
					this.button12.Enabled = false;
					this.button13.Enabled = false;
					this.button14.Enabled = false;
					this.button15.Enabled = false;
					this.button16.Enabled = false;
					this.button17.Enabled = false;
					this.button18.Enabled = false;
					this.button19.Enabled = false;
					this.button20.Enabled = false;
					this.button21.Enabled = false;
				}
				catch (Exception ex)
				{
					this.sp = null;
					MessageBox.Show(ex.ToString());
				}
			}
			else if (this.comBox_COM.Text == "请选择串口")
			{
				MessageBox.Show("请选择正确的串口");
			}
			else
			{
				try
				{
					this.sp = new SerialPort(this.comBox_COM.Text, 0x2580);
					this.sp.DataBits = 0x8;
					this.sp.Parity = Parity.None;
					this.sp.StopBits = StopBits.One;
					this.sp.Open();
					this.sp.DataReceived += this.SpDataReceived;
					this.btn_connect.Text = "断开";
					this.btn_close_n.Enabled = true;
					this.btn_open_n.Enabled = true;
					this.btn_flash.Enabled = true;
					this.button1.Enabled = true;
					this.button2.Enabled = true;
					this.button3.Enabled = true;
					this.button4.Enabled = true;
					this.button5.Enabled = true;
					this.button6.Enabled = true;
					this.button7.Enabled = true;
					this.button8.Enabled = true;
					this.button9.Enabled = true;
					this.button10.Enabled = true;
					this.button11.Enabled = true;
					this.button12.Enabled = true;
					this.button13.Enabled = true;
					this.button14.Enabled = true;
					this.button15.Enabled = true;
					this.button16.Enabled = true;
					this.button17.Enabled = true;
					this.button18.Enabled = true;
					this.button19.Enabled = true;
					this.button20.Enabled = true;
					this.button21.Enabled = true;
				}
				catch (Exception ex)
				{
					this.sp = null;
					MessageBox.Show(ex.ToString());
				}
			}
		}

		private void SpDataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			int bytesToRead = this.sp.BytesToRead;
			byte[] buf = new byte[bytesToRead];
			this.sp.Read(buf, 0x0, bytesToRead);
			base.Invoke(new EventHandler(delegate(object param0, EventArgs param1)
			{
				for (int i = 0x0; i < buf.Length; i++)
				{
					TextBoxBase textBoxBase = this.txt_back;
					int num = (int)buf[i];
					textBoxBase.AppendText(num.ToString("X2") + " ");
				}
			}));
		}

		private void btn_open_n_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[] { 0xA0, 0x1, 0x1, 0xA2 };
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btn_close_n_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x1,
					0x0,
					0xA1
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button19_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x5,
					0x2,
					0xA7
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button18_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x6,
					0x1,
					0xA7
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button17_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x6,
					0x0,
					0xA6
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button16_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x6,
					0x2,
					0xA8
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x7,
					0x1,
					0xA8
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x2,
					0x2,
					0xA4
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x2,
					0x0,
					0xA2
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x2,
					0x1,
					0xA3
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x3,
					0x1,
					0xA4
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x3,
					0x0,
					0xA3
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x3,
					0x2,
					0xA5
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x4,
					0x0,
					0xA4
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x7,
					0x0,
					0xA7
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x7,
					0x2,
					0xA9
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x0,
					0x1,
					0xA1
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x0,
					0x0,
					0xA0
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x0,
					0x2,
					0xA2
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x4,
					0x1,
					0xA5
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x4,
					0x2,
					0xA6
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btn_close_y_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x1,
					0x2,
					0xA3
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button20_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x5,
					0x0,
					0xA5
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button21_Click(object sender, EventArgs e)
		{
			this.txt_back.Text = "";
			try
			{
				byte[] buffer = new byte[]
				{
					0xA0,
					0x5,
					0x1,
					0xA6
				};
				this.sp.Write(buffer, 0x0, 0x4);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		public SerialPort sp;
	}
}
