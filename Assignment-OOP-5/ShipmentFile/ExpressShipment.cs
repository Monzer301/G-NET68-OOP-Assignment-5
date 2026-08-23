using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop_04.ShipmentFile
{
    internal class ExpressShipment : Shipment,ITrackable,IInsurable
    {
        decimal extraFee;

        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }
        public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + ExtraFee;
        public ExpressShipment(string trackingCode) : base(trackingCode)
        {
            ExtraFee = 0;
        }
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"TrackingCode: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: {DeliveryFee:C}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost:C}");        
            Console.WriteLine($"Extra Fee: {ExtraFee:C}");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}


