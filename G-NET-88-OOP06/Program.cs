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

        }
    }
}
