using DataApi.XLAddin.COM.Model.Enums;
using DataApi.XLAddin.COM.Model.Interfaces;
using System.Runtime.InteropServices;

namespace DataApi.XLAddin.COM.Model
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class COMUnderlying: ICOMUnderlying
    {
        public COMEnumUnderlyingSourceType SourceType { get; set; }

        public COMEnumUnderlyingProductType ProductType { get; set; }

        public string Code { get; set; }
    }
}
