using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_5.ShipmentFile
{
    internal partial class Shipment
    {
        private string trackingStatus;

        partial void OnTrackingStatusChanged(string newStatus);

        public string GetTrackingStatus()
        {
            return trackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            trackingStatus = newStatus;

            OnTrackingStatusChanged(newStatus);
        }

    }
}
