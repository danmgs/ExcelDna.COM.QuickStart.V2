using DataApi.XLAddin.COM.Model;
using System.Runtime.InteropServices;

namespace DataApi.XLAddin.COM.Classes.Interfaces
{
    [ComVisible(true)]
    public interface ICOMDataManager
    {
        string[] GetUnderlyingProductTypes();

        string[] GetUnderlyingSourceTypes();
    }
}
