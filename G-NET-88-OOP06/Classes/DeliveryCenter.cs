using G_NET_88_OOP06.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_88_OOP06.Classes
{
    //internal class DeliveryCenter
    //{

    //    #region Attribute
    //    private Shipment[] shipments;
    //    #endregion
    //    #region property
    //    public string CenterName { get; set; }
    //    public Driver Driver { get; set; }
    //    #endregion
    //    #region constructor
    //    public DeliveryCenter(string centername)
    //    {
    //        CenterName = centername;
    //        shipments = new Shipment[20];
    //    }
    //    #endregion

    //    public Shipment this[int index]
    //    {
    //        get
    //        {
    //            if (index < 0 && index > shipments.Length)
    //                throw new ArgumentOutOfRangeException("index");
    //            return shipments[index];
    //            return default;
    //        }
    //        set
    //        {
    //            if (index >= 0 && index < shipments.Length)
    //                shipments[index] = value;
    //        }
    //    }

    //    public Shipment this[string trackingcode]
    //    {
    //        get
    //        {
    //            foreach (var Shipment in shipments)
    //            {
    //                if (Shipment.Trackingcode == trackingcode)
    //                    return Shipment;
    //            }
    //            return default;

    //        }
    //    }
    //    public bool AddShipment(Shipment shipment)
    //    {
    //        for (int i = 0; i < shipments.Length; i++)
    //        {
    //            if (shipments[i] == null)
    //            {
    //                shipments[i] = shipment;
    //                return true;
    //            }
    //        }
    //        return false;
    //    }
    //    public bool RemoveShipment(string trackingcode)
    //    {

    //        for (int i = 0; i < shipments.Length; i++)
    //        {
    //            if (shipments[i] != null && shipments[i].Trackingcode == trackingcode)
    //            {
    //                return true;
    //            }

    //        }
    //        return false;
    //    }

    //    public void Printallshipment()
    //    {
    //        foreach (var shipment in shipments)
    //        {
    //            if (shipment != null)
    //                shipment.PrintShipment();
    //        }
    //    }

    //    public void PrintTrackingStatus()
    //    {
    //        foreach (var shipment in shipments)
    //        {
    //            if (shipment is ITrackable trackable)
    //            {
    //                Console.WriteLine(trackable.GetTrackingStatus());
    //            }
    //        }

    //    }
    //}
}
