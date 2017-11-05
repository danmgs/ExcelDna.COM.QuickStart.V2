using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.XLAddin.COM.Model
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class COMTradeInputData
    {
        public string OperatorName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}
