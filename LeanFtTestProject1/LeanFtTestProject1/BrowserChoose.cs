using HP.LFT.SDK.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanFtTestProject1
{
    public class BrowserChoose
    {
        public static IBrowser GetBrowser(DataRow row)
        {
            switch (row["browser"].ToString())
            {
                case "IE":
                case "Internet Explorer":
                    return BrowserFactory.Launch(BrowserType.InternetExplorer);                    

                case "FF":
                case "Firefox":
                    return BrowserFactory.Launch(BrowserType.Firefox);                    

                case "Chrome":
                default:
                    return BrowserFactory.Launch(BrowserType.Chrome);                    
            }            
        }
    }
}
