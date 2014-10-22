using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace Paint
{
    public class SerialSenderFactory
    {
        bool m_bFake;

        public SerialSenderFactory(bool p_bFake)
        {
            m_bFake = p_bFake;
        }

        public ISerialSender GenerateSerialSender()
        {

                return new SerialSender();
        }

        public ISerialSender GenerateSerialSender(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits )
        {

                return new SerialSender(portName,baudRate,parity,dataBits,stopBits);
        }
    }
}
