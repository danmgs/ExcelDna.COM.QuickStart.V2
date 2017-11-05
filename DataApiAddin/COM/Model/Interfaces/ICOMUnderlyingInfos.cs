using DataApi.XLAddin.COM.Model.Enums;
using System.Runtime.InteropServices;

namespace DataApi.XLAddin.COM.Model.Interfaces
{
    [ComVisible(true)]
    public interface ICOMUnderlyingInfos
    {
        int Count { get; }

        void Add(COMUnderlying comUnderlying);

        COMUnderlying[] GetValues { get; }

        void Clear();
    }
}
