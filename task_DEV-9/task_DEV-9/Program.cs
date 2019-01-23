using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace task_DEV_9
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://vk.com");
            driver.FindElement(By.Id("index_email")).SendKeys("+375296847438");
            driver.FindElement(By.Id("index_pass")).SendKeys("Ee6847438");
            driver.FindElement(By.Id("index_login_button")).Click();
            driver.Navigate().GoToUrl("https://vk.com/im");
            //System.Threading.Thread.Sleep(3000); 
            //driver.FindElement(By.ClassName("left_count_wrap fl_r")).Click(); 
            if (string.IsNullOrEmpty(driver.FindElement(By.XPath("//*[@id='l_msg']/a/span/span[1]/span")).Text))
            {
                Console.WriteLine("No Messages");
            }
            else
            {
                driver.FindElement(By.Id("ui_rmenu_unread")).Click();
                IWebElement messageMy = driver.FindElement(By.XPath("//*[@id=\"im_dialogs\"]"));
                //foreach (var VARIABLE in COLLECTION)
                //{
                    
                //}

                Console.WriteLine("Exist Messages");
                //*[@id="im_dialogs"]/li[1]
                //*[@id="im_dialogs"]/li[2]
            }
        }
    }
}
