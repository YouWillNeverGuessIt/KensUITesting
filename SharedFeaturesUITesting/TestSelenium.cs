using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace SharedFeaturesUITesting
{
    class TestSelenium
    {
        static void Main(string[] args)
        { 
        //!Make sure to add the path to where you extracting the chromedriver.exe:
        IWebDriver driver = new ChromeDriver(@"D:\Download\chromedriver"); //<-Add your path
            driver.Navigate().GoToUrl("https://joemainzone-ilyznmosqlw0zs.netdna-ssl.com/HpSupport.html");
            }
    }
}
