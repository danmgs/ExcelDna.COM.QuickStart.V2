using DataApi.Model.Enums;

namespace DataApi.Model
{
    public class Underlying
    {
        public EnumUnderlyingSourceType SourceType { get; set; }

        public EnumUnderlyingProductType ProductType { get; set; }

        public string Code { get; set; }
    }
}
