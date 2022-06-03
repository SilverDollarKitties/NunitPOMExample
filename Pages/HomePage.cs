using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NunitPOMExample.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/";
        public IWebElement studentCount => driver.FindElement(By.CssSelector("body > p > b"));
        public int GetStudentCount()
        {
            return int.Parse(studentCount.Text);
        }
    }
}
