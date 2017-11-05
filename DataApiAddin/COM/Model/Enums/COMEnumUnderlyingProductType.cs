using System.ComponentModel;
using System.Runtime.InteropServices;

namespace DataApi.XLAddin.COM.Model.Enums
{
    [ComVisible(true)]
    public enum COMEnumUnderlyingProductType
    {
        [Description("INDEX")]
        INDEX,

        [Description("BOND")]
        BOND,

        [Description("STOCK")]
        STOCK        
    }
}
