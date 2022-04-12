using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System.IO;
namespace selenimyoutube
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 250;
            Console.WriteLine("Hello World!");
            IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.youtube.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("SIGN IN")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector("#identifierId")).SendKeys("saitejabalusu3" + Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input")).SendKeys("YOURPASSWORD" + Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            for (int i = 1; i <=n; i++)
            {
                //driver.FindElement(By.ClassName("dropdown-trigger.style-scope.ytd-menu-renderer")).Click();
                try
                { 
                driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-browse/ytd-two-column-browse-results-renderer/div[1]/ytd-rich-grid-renderer/div[5]/ytd-rich-item-renderer[1]/div/ytd-rich-grid-media/div["+i+"]/div/div[2]/ytd-menu-renderer/yt-icon-button/button/yt-icon")).Click();
                }
                catch
                {
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-browse/ytd-two-column-browse-results-renderer/div[1]/ytd-rich-grid-renderer/div[5]/ytd-rich-item-renderer["+i+"]/div/ytd-rich-grid-media/div[1]/div/div[2]/ytd-menu-renderer/yt-icon-button/button/yt-icon")).Click();
                }
                                               // "/html/body/ytd-app/div/ytd-page-manager/ytd-browse/ytd-two-column-browse-results-renderer/div[1]/ytd-rich-grid-renderer/div[5]/ytd-rich-item-renderer[2]/div/ytd-rich-grid-media/div[1]/div/div[2]/ytd-menu-renderer/yt-icon-button/button/yt-icon"
                                               // "/html/body/ytd-app/div/ytd-page-manager/ytd-browse/ytd-two-column-browse-results-renderer/div[1]/ytd-rich-grid-renderer/div[5]/ytd-rich-item-renderer[3]/div/ytd-rich-grid-media/div[1]/div/div[2]/ytd-menu-renderer/yt-icon-button/button/yt-icon"

                try                          
                {
                   


                    driver.FindElement(By.XPath("/html/body/ytd-app/ytd-popup-container/iron-dropdown/div/ytd-menu-popup-renderer/paper-listbox/ytd-menu-service-item-renderer[4]/paper-item")).Click();
                    n = n + 1;
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("number of video deleted  " + i);

                }
                catch
                {
                    

                    driver.FindElement(By.XPath("/html/body/ytd-app/ytd-popup-container/iron-dropdown/div/ytd-menu-popup-renderer/paper-listbox/ytd-menu-service-item-renderer/paper-item")).Click();

                    Console.WriteLine("number of video deleted  " + i);

                }
              
               
            }

            Console.WriteLine("over");
        }
    }
}
