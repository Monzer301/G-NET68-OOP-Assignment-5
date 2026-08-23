using Assignment_oop_04.ShipmentFile;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_5.ShipmentFile
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | {shipment.GetType().Name} | {shipment.Weight} KG";
        }
       
    }
}
