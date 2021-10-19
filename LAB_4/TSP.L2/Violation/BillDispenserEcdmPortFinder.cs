using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INET.Lab4.Violation
{
    public class BillDispenserEcdmPortFinder : IPortFinder
    {
        public SerialPort Find()
        {
            var port = new SerialPort();
            port.BaudRate = 4800;
            port.Parity = Parity.Mark;
            port.Handshake = Handshake.RequestToSendXOnXOff;

            return port;
        }
    }
}
