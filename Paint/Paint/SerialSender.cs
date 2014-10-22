using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace Paint
{
    class SerialSender : ISerialSender
    {
        SerialPort m_serialPort; 

        public SerialSender()
        {
            m_serialPort = new SerialPort();

        }
        public SerialSender(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {

            m_serialPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);

        }
        public override void Open()
        {
            m_serialPort.Open();

        }

        public override void Close()
        {

            m_serialPort.Close();
        }


        public override string ReadLine()
        {
            return m_serialPort.ReadLine();

        }

        public override void Write(string p_str)
        {

            m_serialPort.Write(p_str);

        }


        public override bool IsOpen
        {   
            get
            {
                return m_serialPort.IsOpen;

            }
            

        }

        public override event SerialDataReceivedEventHandler DataReceived
        {
            add
            {
                m_serialPort.DataReceived += value;
            }

            remove
            {
                m_serialPort.DataReceived -= value;
            }
        }


        public override Handshake Handshake
        {
            get
            {

                return m_serialPort.Handshake;
            }

            set { m_serialPort.Handshake = value; }
        }


    
    
    }
}
