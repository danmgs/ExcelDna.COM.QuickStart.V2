using DataApi.XLAddin.COM.Model.Enums;
using System.Runtime.InteropServices;

namespace DataApi.XLAddin.COM.Model.Interfaces
{
    [ComVisible(true)]
    public interface ICOMUnderlying
    {
        COMEnumUnderlyingSourceType SourceType { get; set; }

        COMEnumUnderlyingProductType ProductType { get; set; }

        string Code { get; set; }
    }
}
