
import serial #����ģ��
  
# �򿪴�������  
ser = serial.Serial('COM2', 9600, timeout=1)    
# Ҫ���͵�16��������  
hex_data2 = [0xa0,0x01,0x01,0xa2]   
# ��������  
ser.write(hex_data2) 
# �رմ�������  
ser.close()

