using System.Runtime.InteropServices;

namespace DataApi.XLAddin.COM.Model.Interfaces
{
    [ComVisible(true)]
    public interface ICOMTrade
    {
        string Id { get; set; }

        string OperatorName { get; set; }

        double Price { get; set; }

        int Quantity { get; set; }

        COMUnderlyingInfos UnderlyingInfos { get; set; }

        object[] AdditionnalInfos { get; set; }
    }
}
