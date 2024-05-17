
// SerialPort  版本： 12.x.x
//https://serialport.io/docs/guide-usage
const { SerialPort } = require('serialport')

//打开com1
const port = new SerialPort({ path: 'com1', baudRate: 57600 })

// 亮灯16进制数据，比如H [0xA0, 0x01, 0x01, 0xA2],
//这里改为需要控制的指令
const hexData = [0xA0, 0x01, 0x01, 0xA2];
// 将 16 进制数据转换为 Buffer 对象
const bufferData = Buffer.from(hexData);
port.write(bufferData, function (err)
{
    if (err)
    {
        return console.log('Error on write: ', err.message)
    }
    console.log('发送的数据: ',bufferData)
})

// Open errors will be emitted as an error event
port.on('error', function (err)
{
    console.log('Error: ', err.message)
})

// Switches the port into "flowing mode"
port.on('data', function (receivedData) {
    console.log('接收到的数据:', receivedData)   
    // 在这里可以对 receivedData 进行进一步处理，例如解析数据等
})
