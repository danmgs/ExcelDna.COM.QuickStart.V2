using ExcelDna.ComInterop;
using ExcelDna.Integration;
using System.Runtime.InteropServices;

namespace DataApiAddin
{
    [ComVisible(false)]
    public class ExcelAddin: IExcelAddIn
    {
        public void AutoOpen()
        {
            ComServer.DllRegisterServer();
        }
        public void AutoClose()
        {
            ComServer.DllUnregisterServer();
        }
    }
}
