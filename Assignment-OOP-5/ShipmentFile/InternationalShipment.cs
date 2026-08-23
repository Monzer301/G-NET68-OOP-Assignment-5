using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_5.ShipmentFile
{
    internal class InternationalShipment : Shipment,ITrackable,IInsurable
    {
        string DestinationCountry;
        decimal CustomsFee;

        public string DestinationCountry1
        {
            get { return DestinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    DestinationCountry = value;
                }
            }
        }
        public decimal CustomsFee1
        {
            get { return CustomsFee; }
            set
            {
                if (value >= 0)
                {
                    CustomsFee = value;
                }
            }
        }


        public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + CustomsFee1;

        public InternationalShipment(string trackingCode) : base(trackingCode)
        {
            DestinationCountry1 = "Unknown";
            CustomsFee1 = 0;
        }
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry1 = destinationCountry;
            CustomsFee1 = customsFee;
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"TrackingCode: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: {DeliveryFee:C}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost:C}");
            Console.WriteLine($"Destination Country: {DestinationCountry1}");
            Console.WriteLine($"Customs Fee: {CustomsFee1:C}");
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report for {DestinationCountry1}");
            Console.WriteLine($"Customs Fee: {CustomsFee1:C}");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }

        public decimal CalculateInsurance()
        {
           return EstimatedCost * 0.12m;
        }
    }
}
