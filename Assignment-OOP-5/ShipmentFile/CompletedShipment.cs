using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop_04.ShipmentFile
{
    internal sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode) : base(trackingCode)
        {
        }

        public CompletedShipment(string trackingCode, string description, decimal weight, DeliveryAddress destination, decimal deliveryFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override decimal EstimatedCost => (Weight * 5) + DeliveryFee;

        public override void PrintShipment()
        {
           Console.WriteLine($"TrackingCode: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: {DeliveryFee:C}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost:C}");
        }
    }
}
