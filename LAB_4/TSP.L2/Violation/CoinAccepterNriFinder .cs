using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INET.Lab4.Violation
{
    public class CoinAccepterNriPortFinder : IPortFinder
    {
        public SerialPort Find()
        {
            var port = new SerialPort();
            port.BaudRate = 19200;
            port.Parity = Parity.Odd;
            port.Handshake = Handshake.XOnXOff;

            return port;
        }
    }
}
