using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Globalization;

namespace WpfApp1
{
    class CurrencyParser
    {
        string Url = "http://apilayer.net/api/live?access_key=a11e77b739848f3775d31c7ac61c1c43&currencies=rub&source=USD&format=1";
        public double GetRate()
        {
            try
            {
                WebClient Web = new WebClient();
                string Json = Web.DownloadString(Url);
                JcRates rates=(JcRates) Newtonsoft.Json.JsonConvert.DeserializeObject(Json, typeof(JcRates));
                return rates.quotes.USDRUB;

            }
            catch
            {
                return 0.00;
            }
        }

        class JcRates
        {
            public string Success;
            public string Terms;
            public string Privacy;
            public long Timestamp;
            public string Source;
            public JcQuotes quotes; 

        }
        class JcQuotes
        {
            public double USDRUB;
        }
    }
}
