using G_NET_88_OOP06.Classes;
using G_NET_88_OOP06.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_88_OOP06.child_classes
{
    //internal class InternationalShipment : Shipment, ITrackable, IInsurable
    //{
    //    #region Attribute
    //    private string destinationcountry;
    //    private decimal customsfee;

    //    #endregion
    //    #region constructor
    //    public InternationalShipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination, string destinationcountry, decimal customsfee) : base(trackingcode, description, weight, deliveryfee, destination)
    //    {
    //        DestinationCountry = destinationcountry;
    //        CustomFee = customsfee;
    //        ShipmentType = "International";
    //    }
    //    #region properity
    //    public string DestinationCountry { get; set; }

    //    public decimal CustomFee { get; set; }


    //    #endregion
    //    public override decimal EstimatedCost
    //    {
    //        get { return Deliveryfee + (Weight * 5) + CustomFee; }
    //    }

    //    #endregion
    //    public override void PrintShipment()

    //    {
    //        Console.WriteLine();
    //        Console.WriteLine("International Shipment");
    //        Console.WriteLine($"Tracking Code   : {Trackingcode}");



    //        Console.WriteLine($"Destination Country :{DestinationCountry}");


    //        Console.WriteLine($"Estimated Cost  : {EstimatedCost} EGP");
    //    }
    //    public virtual void GenerateCustomsReport()
    //    {
    //        Console.WriteLine($"Customs Report for Country: {DestinationCountry}");

    //    }

    //    public string GetTrackingStatus()
    //    {
    //        return $"Shipment {Trackingcode} has been Delivered.";
    //    }

    //    public decimal CalculateInsurance()
    //    {
    //        Console.Write($"International Shipment Insurance :");
    //        return EstimatedCost * 0.12m;
    //    }
    //}
}
