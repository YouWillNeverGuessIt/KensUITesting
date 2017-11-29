﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



namespace SharedFeaturesUITesting
{
    
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }

        [TestMethod]
        public void ValidLogInAdmin()
        {
            //!Make sure to add the path to where you extracting the chromedriver.exe:
            using (IWebDriver driver = new ChromeDriver(Extensions.chromeDriverLocation))//<-Add your path
            {
                //navigate to the kenworth page
                driver.Navigate().GoToUrl(Extensions.homepage);

                //find the email box to input username info
                IWebElement emailBox = driver.FindElement(By.Id("Email"));

                //enter a valid email to login
                emailBox.SendKeys(Extensions.validEmailAdmin1);

                //find the password box to input password info    
                IWebElement passwordBox = driver.FindElement(By.Id("Password"));

                //enter a valid password
                passwordBox.SendKeys(Extensions.validPasswordAdmin1);

                //submit
                driver.FindElement(By.Name("LogInSubmit")).Click();

                //save a screenshot of the result
                try
                {
                    //take the screenshot
                    Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                    //create the name of the sceenshot
                    string ssName = Extensions.screenshotLocation + "/ValidLogInAdmin" + Extensions.CurrentDateTimeFileStringFormat() + ".jpg";

                    //store the screenshot
                    ss.SaveAsFile(ssName, ScreenshotImageFormat.Jpeg);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }

        }

        [TestMethod]
        public void ValidLogInNotAdmin()
        {
            //!Make sure to add the path to where you extracting the chromedriver.exe:
            using (IWebDriver driver = new ChromeDriver(Extensions.chromeDriverLocation))//<-Add your path
            {
                //navigate to the kenworth page
                driver.Navigate().GoToUrl(Extensions.homepage);

                //find the email box to input username info
                IWebElement emailBox = driver.FindElement(By.Id("Email"));

                //enter a valid email to login
                emailBox.SendKeys(Extensions.validEmailNotAdmin1);

                //find the password box to input password info    
                IWebElement passwordBox = driver.FindElement(By.Id("Password"));

                //enter a valid password
                passwordBox.SendKeys(Extensions.validPasswordNotAdmin1);

                //submit
                driver.FindElement(By.Name("LogInSubmit")).Click();

                //save a screenshot of the result
                try
                {
                    //take the screenshot
                    Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                    //create the name of the sceenshot
                    string ssName = Extensions.screenshotLocation + "/ValidLogInNotAdmin" + Extensions.CurrentDateTimeFileStringFormat() + ".jpg";

                    //store the screenshot
                    ss.SaveAsFile(ssName, ScreenshotImageFormat.Jpeg);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }

        }

        [TestMethod]
        public void ValidLogInAndLogOffAdmin()
        {
            //!Make sure to add the path to where you extracting the chromedriver.exe:
            using (IWebDriver driver = new ChromeDriver(Extensions.chromeDriverLocation))//<-Add your path
            {
                //set an implicit wait time before any search for an item fails
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Extensions.maxWaitTime);

                //navigate to the kenworth page
                driver.Navigate().GoToUrl(Extensions.homepage);

                //find the email box to input username info
                IWebElement emailBox = driver.FindElement(By.Id("Email"));

                //enter a valid email to login
                emailBox.SendKeys(Extensions.validEmailAdmin1);

                //find the password box to input password info    
                IWebElement passwordBox = driver.FindElement(By.Id("Password"));

                //enter a valid password
                passwordBox.SendKeys(Extensions.validPasswordAdmin1);

                //submit
                driver.FindElement(By.Name("LogInSubmit")).Click();

                //set a wait for page to render
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Extensions.maxWaitTime));

                //set a wait until
                IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.Name("LogOffSubmit")));

                //find the log out button and click it
                driver.FindElement(By.Name("LogOffSubmit")).Click();

                //save a screenshot of the result
                try
                {
                    //take the screenshot
                    Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                    //create the name of the sceenshot
                    string ssName = Extensions.screenshotLocation + "/ValidLogInAndLogOffAdmin" + Extensions.CurrentDateTimeFileStringFormat() + ".jpg";

                    //store the screenshot
                    ss.SaveAsFile(ssName, ScreenshotImageFormat.Jpeg);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }

        [TestMethod]
        public void ValidLogInAndLogOffNotAdmin()
        {
            //!Make sure to add the path to where you extracting the chromedriver.exe:
            using (IWebDriver driver = new ChromeDriver(Extensions.chromeDriverLocation))//<-Add your path
            {
                //set an implicit wait time before any search for an item fails
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Extensions.maxWaitTime);

                //navigate to the kenworth page
                driver.Navigate().GoToUrl(Extensions.homepage);

                //find the email box to input username info
                IWebElement emailBox = driver.FindElement(By.Id("Email"));

                //enter a valid email to login
                emailBox.SendKeys(Extensions.validEmailNotAdmin1);

                //find the password box to input password info    
                IWebElement passwordBox = driver.FindElement(By.Id("Password"));

                //enter a valid password
                passwordBox.SendKeys(Extensions.validPasswordNotAdmin1);

                //submit
                driver.FindElement(By.Name("LogInSubmit")).Click();

                //set a wait for page to render
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Extensions.maxWaitTime));

                //set a wait until
                IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.Name("LogOffSubmit")));

                //find the log out button and click it
                driver.FindElement(By.Name("LogOffSubmit")).Click();

                //save a screenshot of the result
                try
                {
                    //take the screenshot
                    Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                    //create the name of the sceenshot
                    string ssName = Extensions.screenshotLocation + "/ValidLogInAndLogOffNotAdmin" + Extensions.CurrentDateTimeFileStringFormat() + ".jpg";

                    //store the screenshot
                    ss.SaveAsFile(ssName, ScreenshotImageFormat.Jpeg);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }
        //add tests for
        // clicking correct links
        // logging in incorrectly
        // toggling admin privleges


        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
