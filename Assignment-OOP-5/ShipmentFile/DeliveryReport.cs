using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop_04.ShipmentFile
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine($"{shipment.GetTrackingStatus()}   --  {shipment.GetType().Name} ");
        }
        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"{shipment.CalculateInsurance()}   --  {shipment.GetType().Name} ");
        }
    }
}
