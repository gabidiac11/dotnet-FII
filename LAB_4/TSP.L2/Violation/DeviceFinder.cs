using INET.Lab4.Violation;
using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace SOLID.OCP.Violation
{
    public class DeviceFinder
    {
        private Dictionary<DeviceModel, IPortFinder> strategies = new Dictionary<DeviceModel, IPortFinder>();

        public DeviceFinder()
        {
            strategies.Add(DeviceModel.BillAccepterCashCode, new BillAccepterCashCodePortFinder());
            strategies.Add(DeviceModel.BillDispenserEcdm, new BillDispenserEcdmPortFinder());
            strategies.Add(DeviceModel.CoinAccepterNri, new CoinAccepterNriPortFinder());
            strategies.Add(DeviceModel.CoinDispenserCube4, new CoinDispenserCube4PortFinder());
            strategies.Add(DeviceModel.CoinDispsenerSch2, new CoinDispsenerSch2PortFinder());
        }
        public string FindDevice(DeviceModel model)
        {
            var port = strategies[model].Find();

            string[] names = SerialPort.GetPortNames();
            foreach (string name in names)
            {
                port.Write("special code");
                if (port.ReadByte() == 0)
                    return name;
            }
            return null;
        }
    }
}
