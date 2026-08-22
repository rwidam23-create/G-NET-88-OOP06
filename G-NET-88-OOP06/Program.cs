using G_NET_88_OOP06.child_classes;
using G_NET_88_OOP06.Classes;
using System.Threading.Channels;

namespace G_NET_88_OOP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            //(a)It doesn't store the object itself, but rather its address.
            //(b)NO,It is possible for two different names to refer to the same object.
            //(c)Reference copying: You copy the "address," but both references point to the same location in memory.
            //Copying the actual object: You create a completely new location in memory and copy the values ​​into it,
            //resulting in two entirely independent objects where a change to one does not affect the other at all.
            #endregion

            #region Question02
            //(a)create A new object and copied all value type fields.
            //(b)create A new object and recursively copies all nested objects.
            //(c)refrence still shired between original and copy.
            //(d)The reference members are actually copied (a new address, a new object, completely independent).
            //(e)Use a deep copy when it is crucial that modifications to one copy do not affect the other—specifically, in any scenario involving an
            //object that shares sensitive reference members
            //(such as an address, customer details, or payment data)
            //where you require complete independence between them.
            #endregion

            #region Question03
            // (a) static :belong to a class not object
            //instance field:variable for which each object gets its own private copy, completely separate from the other objects.
            //(b)static Method:The class method calls her by the class name,NO
            //(c)A static constructor: is a special constructor used to initialize a class's static members (such as static fields),
            //rather than a specific object, execute one time.
            //(d)A static class :is a class where all its members must be static—meaning it contains absolutely no instance fields or
            //instance methods; everything inside it belongs to the class itself, not to an object, cannot do object.
            #endregion

            #region Question04
            //(a)An extension method allows you to "add" a new method to an existing class—even
            //if you don't own the class or if it is a built-in type like `int` or `string`—
            //without modifying the original class itself and without using inheritance.
            //(b)this 
            //(c)static class
            //(d)NO
            #endregion

            #region Question05
            //(a)A partial class is a single class whose definition can be split across multiple files, rather than writing the entire class in one file.
            //You use the `partial` keyword before `class` in each part.
            //(b)organize large classes ,improve maintability and readibilty.
            //(c)decleration without an implementation in the class,it can be optionally implemented in onther part.
            //(d)There's no problem, and no error. The compiler simply removes the entire declaration from the final code during compilation, as if it were never written at all—not only the method itself, but any calls to it are also automatically removed.
            #endregion


          #region Part02
//            Console.WriteLine("=================================================================");
//            Console.WriteLine("Smart Delivery Management System");
//            Console.WriteLine("=================================================================");



//            Console.WriteLine();
//            int trigger = Shipment.TotalShipmentsCreated;
//            Console.WriteLine();

//            Console.WriteLine("==========================================");
//            Console.WriteLine("Creating Shipments...");
//            Console.WriteLine("==========================================");
//            Console.WriteLine();

//            StandardShipment shipment1 = new StandardShipment(
//                "SH001", "Books", 3, 50,
//                new DeliveryAddress("Cairo", "Street 1", 12345));
//            Console.WriteLine("Standard Shipment Created");

//            Console.WriteLine();
//            ExpressShipment shipment2 = new ExpressShipment("SH002", "Electronics", 2, 70, new DeliveryAddress("Giza", "Street 2", 12346), 40);
//            shipment2.TrackingStatus = "Out For Delivery";
//            InternationalShipment shipment3 = new InternationalShipment("SH003", "Clothes", 8, 90, new DeliveryAddress("Alexandria", "Street 3", 12347), "alex", 40);
//            shipment3.TrackingStatus = "Delivered";
//            Console.WriteLine("International Shipment Created");
//            Console.WriteLine();

//            Console.WriteLine($"Total Shipments Created : {Shipment.TotalShipmentsCreated}");
//            Console.WriteLine();
//            #region Object copying
//            Console.WriteLine("==========================================");
//            Console.WriteLine("Object Copying");
//            Console.WriteLine("==========================================");
//            Console.WriteLine();

//            Shipment shipmentAssigned = shipment1;

//            Console.WriteLine($"Original Shipment  : {shipment1.Trackingcode}");
//            Console.WriteLine($"Assigned Shipment  : {shipmentAssigned.Trackingcode}");
//            Console.WriteLine();
//            Console.WriteLine("Same Object : " + ReferenceEquals(shipment1, shipmentAssigned));
//            #endregion

//            #region  Shallow Copy
//            Console.WriteLine("----------------------------------------------------");
//            Console.WriteLine("Shallow Copy");
//            Console.WriteLine("----------------------------------------------------");
//            StandardShipment original = new StandardShipment("SH001", "Books", 3, 50, new DeliveryAddress("Cairo", "Street 1", 12345));
//            StandardShipment shallow = (StandardShipment)original.ShallowCopy();
//            Console.WriteLine($"original Shipment Address          :     {original.Destination.City}");
//            Console.WriteLine($" Copied Shipment Address          :      {shallow.Destination.City}");
//            Console.WriteLine();
//            Console.WriteLine("Changing copied shipment address...");
//            Console.WriteLine();
//            shallow.Destination.City = "Giza";
//            Console.WriteLine($"original Shipment Address     :    {original.Destination.City}");
//            Console.WriteLine($" Copied Shipment Address      :    {shallow.Destination.City}");
//            Console.WriteLine("Same DeliveryAddress Object : " + ReferenceEquals(original.Destination, shallow.Destination));
//            #endregion

//            #region Deep copy
//            Console.WriteLine("-------------------------------------------------");
//            Console.WriteLine("Deep Copy");
//            Console.WriteLine("-------------------------------------------------");
//            StandardShipment Original = new StandardShipment("SH001", "Books", 3, 50, new DeliveryAddress("Cairo", "Street 1", 12345));
//            StandardShipment deep = (StandardShipment)Original.DeepCopy();
//            Console.WriteLine($"original Shipment Address:{Original.Destination.City}");
//            Console.WriteLine($"Deep Shipment Address:{deep.Destination.City}");
//            Console.WriteLine();
//            Console.WriteLine("Changing copied shipment address...");
//            Console.WriteLine();
//            deep.Destination.City = "Giza";
//            Console.WriteLine($"original Shipment Address:{Original.Destination.City}");
//            Console.WriteLine($"Deep Shipment Address:{deep.Destination.City}");
//            Console.WriteLine();
//            Console.WriteLine("Same DeliveryAddress Object : " + ReferenceEquals(Original.Destination, deep.Destination));
//            #endregion

//            #region Extention Method
            
//            Console.WriteLine("==========================================");
//            Console.WriteLine("Extension Method");
//            Console.WriteLine("==========================================");
//            Console.WriteLine();

//            Console.WriteLine(shipment1.GetSummary());
            
//            Console.WriteLine(shipment2.GetSummary());
            
//            Console.WriteLine(shipment3.GetSummary());
//            Console.WriteLine();

//            Console.WriteLine($"{shipment1.Trackingcode} Is Delivered : {shipment1.IsDelivered()}");
//            Console.WriteLine($"{shipment3.Trackingcode} Is Delivered : {shipment3.IsDelivered()}");
//            #endregion


            
//            #region Tracking Status
//            Console.WriteLine("==========================================");
//            Console.WriteLine("Tracking Status");
//            Console.WriteLine("==========================================");
//            Console.WriteLine();

//            shipment1.UpdateTrackingStatus("Out For Delivery");
//            #endregion
            


//            #region Static Utilities
//            DeliveryUtilities.PrintSeparator();
//            Console.WriteLine("Static Utilities");
//            DeliveryUtilities.PrintSeparator();
//            Console.WriteLine();

//            Console.WriteLine("------------------------------------------");
//            DeliveryUtilities.PrintSystemTitle();
//            Console.WriteLine("------------------------------------------");
//            Console.WriteLine();

//            Console.WriteLine($"Total Shipments Created : {Shipment.TotalShipmentsCreated}");
//            #endregion
//            #region Partial Method
//            DeliveryUtilities.PrintSeparator();
//            Console.WriteLine("Partial Method");
//            DeliveryUtilities.PrintSeparator();
//            Console.WriteLine();

//            shipment1.UpdateTrackingStatus("Delivered");
//            #endregion

//            Console.WriteLine();
//            DeliveryUtilities.PrintSeparator();
//            Console.WriteLine("Assignment Completed");
//            DeliveryUtilities.PrintSeparator();
            #endregion




//        }
//    }

