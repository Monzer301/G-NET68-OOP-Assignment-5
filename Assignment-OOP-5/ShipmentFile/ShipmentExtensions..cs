using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_5.ShipmentFile
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            // Tracking status may be provided by shipment.GetTrackingStatus() if available
            string status = null;
            try
            {
                status = shipment.GetTrackingStatus();
            }
            catch
            {
                status = "Unknown";
            }

            return $"{shipment.TrackingCode} | {shipment.GetType().Name} | {shipment.Weight} KG | {status}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            try
            {
                return string.Equals(shipment.GetTrackingStatus(), "Delivered", StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                return false;
            }
        }
    }
}
