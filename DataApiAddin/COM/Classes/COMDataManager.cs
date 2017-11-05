using DataApi.XLAddin.COM.Classes.Interfaces;
using DataApi.XLAddin.COM.Mapper;
using DataApi.XLAddin.COM.Model;
using DataApi.Core;
using DataApi.Model;
using System.Runtime.InteropServices;
using System;
using log4net;
using System.Collections.Generic;

namespace DataApi.XLAddin.COM.Classes
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class COMDataManager : ICOMDataManager
    {
        // Set in private, as DataManager is not a COM visible class.
        // Possibility to set in public, as what is COM Visible is defined in ICOMDataManager interface.
        private DataManager _dataManager;

        private static readonly ILog log = LogManager.GetLogger(typeof(COMDataManager));

        // Add a public contructor to init properties.
        public COMDataManager()
        {
            _dataManager = new DataManager();
        }

        public string[] GetUnderlyingProductTypes()
        {
            log.DebugFormat("Call GetUnderlyingProductTypes");
            List<string> results = _dataManager.GetUnderlyingProductTypes();
            return results.ToArray();
        }

        public string[] GetUnderlyingSourceTypes()
        {
            log.DebugFormat("Call GetUnderlyingSourceTypes");
            List<string> results = _dataManager.GetUnderlyingSourceTypes();
            return results.ToArray();
        }
    }
}
