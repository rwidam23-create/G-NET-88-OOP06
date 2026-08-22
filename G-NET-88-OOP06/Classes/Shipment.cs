using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_88_OOP06.Classes
{
    
    //internal abstract partial class Shipment
    //{


    //    #region  Attribute
    //    private string trackingcode;
    //    private string description;
    //    private decimal weight;
    //    private decimal deliveryfee;
    //    public static int TotalShipmentsCreated;
        
        
    //    #endregion

    //    #region constructores
    //    public Shipment(string trackingcode)
    //    {
    //        Trackingcode = trackingcode;
    //        Description = "Unknown";
    //        Weight = 1;
    //        Deliveryfee = 50;
    //        Destination = new DeliveryAddress("Unknown", "unknown", 0);
    //    }
    //    public Shipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination)
    //    {
    //        Trackingcode = trackingcode;
    //        Description = description;
    //        Weight = (decimal)weight;
    //        Deliveryfee = deliveryfee;
    //        Destination = destination;
    //        TotalShipmentsCreated++;
    //        TrackingStatus = "In Transit";


    //    }
        
    //        static Shipment()
    //        {
    //            TotalShipmentsCreated = 0;
    //            Console.WriteLine("Shipment System Initialized");
    //        }
        

    //    #endregion




    //    #region property validation

    //    public string Trackingcode
    //    {
    //        get { return trackingcode; }
    //        private set
    //        {
    //            if (!string.IsNullOrEmpty(value))
    //                trackingcode = value;
    //        }



    //    }
    //    public string Description
    //    {
    //        get { return description; }
    //        set
    //        {
    //            if (!string.IsNullOrEmpty(value))
    //                description = value;
    //        }



    //    }
    //    public decimal Weight
    //    {
    //        get { return weight; }
    //        set
    //        {
    //            if (value > 0)
    //                weight = value;
    //        }


    //    }

    //    public decimal Deliveryfee
    //    {
    //        get { return deliveryfee; }
    //        private set
    //        {
    //            if (value > 0)
    //                deliveryfee = value;
    //        }
    //    }
    //    public string ShipmentType { get; set; }
    //    public DeliveryAddress Destination { get; set; }
    //    private string trackingStatus;

        
    //    #endregion

    //    #region Method&&prperty abstract
    //    public abstract decimal EstimatedCost { get; }
    //    public abstract void PrintShipment();
    //    #endregion

    //    public void UpdateDeliveryFee(decimal newfee)
    //    {
    //        if (newfee > 0) deliveryfee = newfee;

    //    }

    //    public void UpdateWeight(decimal newweight)
    //    {
    //        if (newweight > 0)
    //            weight = newweight;
    //    }
    //    public void UpdateWeight(decimal newweight, decimal extrapackingweight)
    //    {
    //        if (newweight > 0)
    //            weight = newweight + extrapackingweight;
    //    }
    //    public Shipment CopyShipment()
    //    {
    //        return (Shipment)this.MemberwiseClone();
    //    }
    //   public Shipment ShallowCopy()
    //    {
    //        return (Shipment)this.MemberwiseClone();
    //    }


    //    public Shipment DeepCopy()
    //    {
    //        Shipment copy = (Shipment)this.MemberwiseClone();
    //        copy.Destination = new DeliveryAddress(
    //            this.Destination.City,
    //            this.Destination.Street,
    //            this.Destination.Builidingnumber

                
                
    //        );
    //        return copy;
    //    }


    //    public static int GetTotalShipmentCreated()
    //    {
    //        return TotalShipmentsCreated;
    //    }

    //}
}

