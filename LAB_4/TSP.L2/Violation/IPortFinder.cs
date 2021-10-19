
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INET.Lab4.Violation
{
    public interface IPortFinder
    {
        SerialPort Find();
    }
}
