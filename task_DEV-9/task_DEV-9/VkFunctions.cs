using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace task_DEV_9
{
    /// <summary>
    /// class of functions VK (this task is function for out in console unread message
    /// </summary>
    class VkFunctions
    {
        public string GetUnreadMessage(string lgn, string psswd)
        {
            IWebDriver driver = new ChromeDriver(); //create an instance of ChromeDriver
            driver.Navigate().GoToUrl("https://vk.com"); // site, where account are you have
            driver.FindElement(By.Id("index_email")).SendKeys(lgn);
            driver.FindElement(By.Id("index_pass")).SendKeys(psswd);
            driver.FindElement(By.Id("index_login_button")).Click();
            driver.Navigate().GoToUrl("https://vk.com/im");
            if (string.IsNullOrEmpty(driver.FindElement(By.XPath("//*[@id='l_msg']/a/span/span[1]/span")).Text)) //check unread messages
            {
                driver.Quit();
                return "No Messages";
            }
            else
            {
                driver.FindElement(By.Id("ui_rmenu_unread")).Click(); // go to the unread messages

                var unreadMessages = new StringBuilder();
                var messagesList = driver.FindElements(By.ClassName("nim-dialog--cw")); //find all cases with unread messages

                foreach (IWebElement message in messagesList)
                {
                    unreadMessages.Append(niceInput(message.Text)  + '\n');
                }
                driver.Quit();
                return unreadMessages.ToString();
            }
        }

        private string niceInput(string uglyInput) //method for nice input, it's good
        {
            string[] tags = {"\nTime:", "\nConversation:", "\nLastMessage:", "\nUnread Messages:"}; //fields of message
            string deleteSym = "\r\n";
            var niceInput=new StringBuilder(tags[0]);
            for (int i = 1; i < tags.Length; i++)
            {
                int ind = uglyInput.IndexOf(deleteSym);
                niceInput.Append(uglyInput.Substring(0, ind) + tags[i]);
                uglyInput = uglyInput.Remove(0, ind + 2);

            }
            niceInput.Append(uglyInput);
            return niceInput.ToString();
        }
    }
}
