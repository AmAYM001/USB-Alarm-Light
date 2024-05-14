
import serial #导入模块
  
# 打开串口连接  
ser = serial.Serial('COM2', 9600, timeout=1)    
# 要发送的16进制数据  
hex_data2 = [0xa0,0x01,0x01,0xa2]   
# 发送数据  
ser.write(hex_data2) 
# 关闭串口连接  
ser.close()

