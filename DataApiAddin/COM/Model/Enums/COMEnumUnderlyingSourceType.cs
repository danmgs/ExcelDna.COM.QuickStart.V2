using System.ComponentModel;
using System.Runtime.InteropServices;

namespace DataApi.XLAddin.COM.Model.Enums
{
    [ComVisible(true)]
    public enum COMEnumUnderlyingSourceType
    {
        [Description("REUTERS")]
        REUTERS,

        [Description("BLOOMBERG")]
        BLOOMBERG
    }
}
