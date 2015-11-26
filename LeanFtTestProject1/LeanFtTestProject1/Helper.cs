using HP.LFT.SDK.Web;
using HP.LFT.Report;
using LeanFtAppModelProject1;
using System.Linq;

namespace LeanFtTestProject1
{
    public static class Helper
    {
        public static void SelectItem(ApplicationModel.ListBoxNodeBase listBox, string pattern)
        {
            var item = listBox.Items.FirstOrDefault(x => x.Text.Equals(pattern));
            listBox.Select(item);
        }

        public static bool IsItemSelected(IBrowser browser, string pattern, uint timeout)
        {
            return browser.Describe<IWebElement>(new WebElementDescription
            {
                XPath = "//span[contains(@class,'checkbox_checked_yes')]",
                InnerText = pattern
            }).Exists(timeout);
        }

        public static void WaitAndCheckElementToExist(IWebElement element, string output, uint timeout)
        {
            var doesExist = element.Exists(timeout);
            var status = doesExist ? Status.Passed : Status.Failed;

            Reporter.ReportEvent(
                string.Format("{0} Check", output),
                string.Format("Verify that {0} value is = {1}", output, doesExist),
                status);
        }
    }
}
