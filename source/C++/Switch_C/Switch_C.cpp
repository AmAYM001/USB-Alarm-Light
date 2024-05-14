

#include <windows.h>
#include <iostream>
using namespace std;

int main()
{
    HANDLE hCom;
    hCom = CreateFile(L"COM1", GENERIC_READ | GENERIC_WRITE, 0, NULL, OPEN_EXISTING, 0, NULL);//打开串口COM0
    if (hCom == INVALID_HANDLE_VALUE)
    {
        cout << "Error in opening serial port\n";
        return 0;
    }

    //串口参数设置
    DCB dcbSerialParams = { 0 };
    dcbSerialParams.DCBlength = sizeof(dcbSerialParams);
    if (!GetCommState(hCom, &dcbSerialParams))
    {
        cout << "Error in getting serial port state\n";
        CloseHandle(hCom);
        return 0;
    }
    dcbSerialParams.BaudRate = CBR_9600;
    dcbSerialParams.ByteSize = 8;
    dcbSerialParams.StopBits = ONESTOPBIT;
    dcbSerialParams.Parity = NOPARITY;
    if (!SetCommState(hCom, &dcbSerialParams))
    {
        cout << "Error in setting serial port state\n";
        CloseHandle(hCom);
        return 0;
    }

    // 配置串口超时时间
    COMMTIMEOUTS timeouts = { 0 };
    timeouts.ReadIntervalTimeout = 50;
    timeouts.ReadTotalTimeoutConstant = 50;
    timeouts.ReadTotalTimeoutMultiplier = 10;
    timeouts.WriteTotalTimeoutConstant = 50;
    timeouts.WriteTotalTimeoutMultiplier = 10;

    if (!SetCommTimeouts(hCom, &timeouts))
    {
        std::cerr << "Error setting serial port timeouts." << std::endl;
        CloseHandle(hCom);
        return 0;
    }

    //开始发送指令
    DWORD dwBytesWritten;
    BYTE byte[] = { 0xA0, 0x02, 0x02, 0xA4 };//控灯指令
    if (!WriteFile(hCom, byte, sizeof(byte), &dwBytesWritten, NULL))
    {
        cout << "Error in writing data to serial port\n";
        CloseHandle(hCom);
        return 0;
    }


    //接收数据
    BYTE buffer[1024];
    DWORD dwBytesRead;
    while (true)
    {
        if (!ReadFile(hCom, buffer, 1024, &dwBytesRead, NULL))
        {
            cout << "Error in reading data from serial port\n";
            CloseHandle(hCom);
            return 0;
        }       
        if(dwBytesRead>0)
        {            
            for (int i = 0; i < dwBytesRead; i++)
            {
                printf("0x%02X ", buffer[i]);
            }           
        }
        cout << "--\n";

    }  

    PurgeComm(hCom, PURGE_RXCLEAR);
    PurgeComm(hCom, PURGE_TXCLEAR);
    CloseHandle(hCom);

  
}
