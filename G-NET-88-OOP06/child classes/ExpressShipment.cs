using G_NET_88_OOP06.Classes;
using G_NET_88_OOP06.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_88_OOP06.child_classes
{
    //internal class ExpressShipment : Shipment, ITrackable, IInsurable
    //{
    //    private decimal extrafee;
    //    private decimal ExtraFee { get; set; }
    //    public ExpressShipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination, decimal extrafee) : base(trackingcode, description, weight, deliveryfee, destination)
    //    {
    //        ExtraFee = extrafee;
    //        ShipmentType = "Express";
           
    //    }

    //    public override decimal EstimatedCost => Deliveryfee + (Weight * 5) + ExtraFee;

    //    public override void PrintShipment()
    //    {

    //        Console.WriteLine($"Tracking Code   : {Trackingcode}");

    //        Console.WriteLine($"ExtraFee           :{ExtraFee}");
    //        Console.WriteLine($"Estimated Cost  : {EstimatedCost} EGP");

    //    }

    //    public string GetTrackingStatus()
    //    {
    //        return $"Shipment {Trackingcode} is Out for Delivery.";
    //    }

    //    public decimal CalculateInsurance()
    //    {
    //        Console.Write($"Express Shipment Insurance :");
    //        return EstimatedCost * 0.08m;
    //    }
    //}
}
