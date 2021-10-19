using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INET.Lab4.Violation
{
    public class BillAccepterCashCodePortFinder : IPortFinder
    {
        public SerialPort Find()
        {
            var port = new SerialPort();
            port.BaudRate = 9600;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.RequestToSend;

            return port;
        }
    }
}
