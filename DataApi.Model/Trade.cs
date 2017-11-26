using System;
using System.Collections.Generic;
using System.Linq;

namespace DataApi.Model
{
    public class Trade
    {
        public Guid Id { get; set; }

        public string OperatorName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public List<Underlying> Underlyings { get; set; }

        public string[] AdditionnalInfos { get; set; }

        public override string ToString()
        {
            string strUnderlyingsInfos = string.Empty;
            if (this.Underlyings != null && this.Underlyings.Any())
                this.Underlyings.ForEach(u =>
                strUnderlyingsInfos += string.Format("[{0}/{1}/{2}]",
                                                u.SourceType.ToString(),
                                                u.ProductType.ToString(),
                                                u.Code));

            string strAdditionnalInfos = string.Empty;
            if (this.AdditionnalInfos != null && this.AdditionnalInfos.Any())
            {
                for (int i = 0; i < this.AdditionnalInfos.Length; i++)
                {
                    strAdditionnalInfos += string.Format("[{0}]", this.AdditionnalInfos[i]);
                }
            }

            return string.Format("{0} {1} {2} @ {3} | Underlyings : {4} | AdditionnalInfos: {5}",
                                 this.OperatorName,
                                 this.Quantity >= 0 ? "BUY" : "SELL",
                                 Math.Abs(this.Quantity),
                                 this.Price,
                                 strUnderlyingsInfos,
                                 strAdditionnalInfos);
        }
    }
}
