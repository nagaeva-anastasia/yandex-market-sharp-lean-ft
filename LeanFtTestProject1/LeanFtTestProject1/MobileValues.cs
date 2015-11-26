using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LeanFtTestProject1
{
    public class MobileValues
    {
        public string priceTo;
        public string priceFrom;
        public string platform;
        public string type;

        public MobileValues(DataRow row)
        {
            priceFrom = row["priceFrom"].ToString();
            priceTo = row["priceTo"].ToString();
            type = row["type"].ToString();
            platform = row["platform"].ToString();
        }
    }
}
