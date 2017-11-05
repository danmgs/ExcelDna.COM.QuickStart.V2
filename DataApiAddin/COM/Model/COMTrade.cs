using DataApi.Model;
using DataApi.XLAddin.COM.Model.Interfaces;
using System;
using System.Linq;
using System.Collections;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using DataApi.Model.Enums;
using log4net;

namespace DataApi.XLAddin.COM.Model
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class COMTrade : ICOMTrade
    {
        // Set in public, as what is COM Visible is defined in ICOMTrade interface.
        public Trade Trade;

        private COMUnderlyingInfos _underlyingInfos;

        private static readonly ILog log = LogManager.GetLogger(typeof(COMTrade));

        // Add a public contructor to init properties.
        public COMTrade()
        {
            Trade = new Trade();
            _underlyingInfos = new COMUnderlyingInfos();
        }

        public string Id
        {
            get { return Trade.Id.ToString(); }
            set { Trade.Id = new Guid(value); }
        }

        public string OperatorName
        {
            get { return Trade.OperatorName; }
            set { Trade.OperatorName = value; }
        }

        public double Price
        {
            get { return Trade.Price; }
            set { Trade.Price = value; }
        }

        public int Quantity
        {
            get { return Trade.Quantity; }
            set { Trade.Quantity = value; }
        }

        public COMUnderlyingInfos UnderlyingInfos
        {
            get { return _underlyingInfos; }
            set
            {
                _underlyingInfos = value;
                Trade.Underlyings = GenerateUnderlyingInfos(value);
            }
        }

        public object[] AdditionnalInfos
        {
            get { return Trade.AdditionnalInfos; }
            set { Trade.AdditionnalInfos = value; }
        }

        private List<Underlying> GenerateUnderlyingInfos(COMUnderlyingInfos comUnderlyingInfos)
        {
            List<Underlying> underlyings = new List<Underlying>();

            if (comUnderlyingInfos != null)
            {
                foreach (COMUnderlying comUdl in comUnderlyingInfos.GetValues)
                {
                    underlyings.Add(new Underlying()
                    {
                        SourceType = (EnumUnderlyingSourceType)Enum.Parse(typeof(EnumUnderlyingSourceType), comUdl.SourceType.ToString()),
                        ProductType = (EnumUnderlyingProductType)Enum.Parse(typeof(EnumUnderlyingProductType), comUdl.ProductType.ToString()),
                        Code = comUdl.Code
                    });
                }
            }

            return underlyings;
        }
    }
}
