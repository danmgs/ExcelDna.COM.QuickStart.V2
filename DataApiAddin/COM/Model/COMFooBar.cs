using System.Runtime.InteropServices;

namespace DataApi.XLAddin.COM.Model
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    // In AutoDual, we do not need to declare an interface ICOMFooBar to define what will be explicitely COM Visible. 
    // However, default methods such as : 
    // Equals(), GetHashCode(), GetType(), ToString() 
    // will appeared as COM Visible and available for use in EXCEL VBA.
    public class COMFooBar
    {
        public string Foo { get; set; }
        public int Bar { get; set; }
    }
}
