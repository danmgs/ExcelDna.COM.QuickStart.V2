using DataApi.XLAddin.COM.Classes.Interfaces;
using DataApi.XLAddin.COM.Mapper;
using DataApi.XLAddin.COM.Model;
using DataApi.Core;
using DataApi.Model;
using System.Runtime.InteropServices;
using System;
using log4net;

namespace DataApi.XLAddin.COM.Classes
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class COMOrderBookingManager : ICOMOrderBookingManager
    {
        // Set in private, as OrderBookingManager is not a COM visible class.
        // Possibility to set in public, as what is COM Visible is defined in ICOMOrderBookingManager interface.
        private OrderBookingManager _orderBookingManager;

        private static readonly ILog log = LogManager.GetLogger(typeof(COMOrderBookingManager));

        // Add a public contructor to init properties.
        public COMOrderBookingManager()
        {
            _orderBookingManager = new OrderBookingManager();
        }
        
        public string Send(COMTrade COMTrade)
        {
            log.DebugFormat("Call Send");
            return _orderBookingManager.Send(COMTrade.Trade);
        }
    }
}
