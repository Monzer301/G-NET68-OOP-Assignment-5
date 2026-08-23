using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop_04.ShipmentFile
{
    internal class StandardShipment : Shipment,ITrackable,IInsurable
    {
        public StandardShipment(string trackingCode) : base(trackingCode)
        {
        }
        public StandardShipment(string trackingCode, string description, decimal weight, DeliveryAddress destination, decimal deliveryFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override decimal EstimatedCost => DeliveryFee + (Weight * 5);

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }

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
