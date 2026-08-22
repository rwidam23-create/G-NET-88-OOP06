using G_NET_88_OOP06.Classes;
using G_NET_88_OOP06.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_88_OOP06.child_classes
{
    //internal class StandardShipment : Shipment, ITrackable, IInsurable
    //{

    //    public StandardShipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination) : base(trackingcode, description, weight, deliveryfee, destination)
    //    {
    //        ShipmentType = "standard";
    //    }

    //    public override decimal EstimatedCost => Deliveryfee + (Weight * 5);

    //    public decimal CalculateInsurance()
    //    {
    //        Console.Write($"Standard Shipment Insurance :");
    //        return EstimatedCost * 0.05m;
    //    }

    //    public string GetTrackingStatus()
    //    {
    //        return $"Shipment {Trackingcode} is Ready.";
    //    }

    //    public override void PrintShipment()
    //    {

    //        Console.WriteLine($"Tracking Code   : {Trackingcode}");
    //        Console.WriteLine($"Description     : {Description}");

    //        Console.WriteLine($"Estimated Cost  : {EstimatedCost} EGP");
    //    }


    //}
}
