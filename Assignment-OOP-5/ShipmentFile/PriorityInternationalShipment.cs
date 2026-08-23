using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_5.ShipmentFile
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode) : base(trackingCode)
        {
        }

        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, DeliveryAddress destination, decimal deliveryFee, string customsDeclaration, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination, customsDeclaration, customsFee)
        {
        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine($"Priority Customs Report for {DestinationCountry1}");
            Console.WriteLine($"Customs Fee: {CustomsFee1} EGP");
        }
    }
}
