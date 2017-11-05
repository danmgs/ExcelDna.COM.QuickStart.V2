using DataApi.XLAddin.COM.Model;
using DataApi.Model;
using System.Linq;
using DataApi.XLAddin.COM.Model.Enums;
using System;

namespace DataApi.XLAddin.COM.Mapper
{
    internal static class TradeMapper
    {
        internal static COMTrade MapFrom(Trade source)
        {
            COMTrade destination = new COMTrade();
            destination.Id = source.Id.ToString();
            destination.OperatorName = source.OperatorName;
            destination.Price = source.Price;
            destination.Quantity = source.Quantity;
            destination.UnderlyingInfos = null;
            if (source.Underlyings != null)
            {
                destination.UnderlyingInfos = new COMUnderlyingInfos();
                foreach (var udl in source.Underlyings)
                {
                    destination.UnderlyingInfos.Add(
                        new COMUnderlying()
                        {
                            SourceType = (COMEnumUnderlyingSourceType)Enum.Parse(typeof(COMEnumUnderlyingSourceType), udl.SourceType.ToString()),
                            ProductType = (COMEnumUnderlyingProductType)Enum.Parse(typeof(COMEnumUnderlyingProductType), udl.ProductType.ToString()),
                            Code = udl.Code
                        });
                }
            }

            // TODO : implement mapping for AdditionnalInfos
            //if (source.AdditionnalInfos != null && source.AdditionnalInfos.Any())
            //    destination.AdditionnalInfos = source.AdditionnalInfos;

            return destination;
        }
    }
}
