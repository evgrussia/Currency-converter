using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CurrencyRate
    {
        double Rate;
        public CurrencyRate(double Rate)
        {
            this.Rate = Rate;
        }
        public double CovertFromUSDtoRUB(double Money)
        {
            return Money * Rate;
        }
        public string CovertFromUSDtoRUB(string Money)
        {
            try
            {
                return CovertFromUSDtoRUB(double.Parse(Money)).ToString("0.00");

            }
            catch
            {
                return "0.00";
            }

        }
    }
}
