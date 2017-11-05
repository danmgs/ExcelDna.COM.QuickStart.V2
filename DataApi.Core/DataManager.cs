using DataApi.Model;
using DataApi.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataApi.Core
{
    public class DataManager
    {
        public List<string> GetUnderlyingProductTypes()
        {
            return Enum.GetNames(typeof(EnumUnderlyingProductType)).ToList();
        }

        public List<string> GetUnderlyingSourceTypes()
        {
            return Enum.GetNames(typeof(EnumUnderlyingSourceType)).ToList();
        }
    }
}
