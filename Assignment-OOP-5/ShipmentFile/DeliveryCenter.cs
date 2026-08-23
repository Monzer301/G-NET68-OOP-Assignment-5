using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop_04.ShipmentFile
{
    internal class DeliveryCenter
    {
        public string CenterName { get; set; }
        public Driver Driver { get; set; }
        private DeliveryReport report = new DeliveryReport();

        private Shipment[] shipments = new Shipment[20];
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }

                return null;
            }

            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (var shipment in shipments)
                {
                    if (shipment != null && shipment.TrackingCode == trackingCode)
                    {
                        return shipment;
                    }
                }
                return null;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }
            return false;
        }
        public void PrintAllShipments()
        {
            foreach (var shipment in shipments)
            {
                if (shipment != null)
                {
                    shipment.PrintShipment();
                    Console.WriteLine("-------------------------");
                }
            }
        }
        public void PrintTrackingStatuses()
        {
            foreach (var shipment in shipments)
            {
                if (shipment != null && shipment is ITrackable trackableShipment)
                {
                    Console.WriteLine(trackableShipment.GetTrackingStatus());
                }
            }
        }
        public void PrintInsuranceCosts()
        {
            foreach (var shipment in shipments)
            {
                if (shipment != null && shipment is IInsurable insurableShipment)
                {
                    Console.WriteLine($"{shipment.TrackingCode}: {insurableShipment.CalculateInsurance():C}");
                }
            }
        }
    }
}
