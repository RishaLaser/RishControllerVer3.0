using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace Paint
{
    public abstract class ISerialSender
    {
        public abstract void Open();
        public abstract void Close();
        public abstract string ReadLine();
        public abstract void Write(string p_str);
        public abstract bool IsOpen { get; }
        public abstract event SerialDataReceivedEventHandler DataReceived;
        public abstract Handshake Handshake { get; set; }
        public bool DtrEnable { set; private get; }
        public bool RtsEnable { set; private get;  }

    }
}
