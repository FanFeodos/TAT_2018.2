using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace task_DEV_10._0.pages
{
    class PageLogin
    {
        /// <summary>Login Field</summary>
        [FindsBy(How = How.CssSelector, Using = "input#login")]
        public IWebElement LoginField { get; set; }

        /// <summary>Passord Field</summary>
        [FindsBy(How = How.CssSelector, Using = "input#password")]
        public IWebElement PasswordField { get; set; }

        /// <summary>Enter system button</summary>
        [FindsBy(How = How.CssSelector, Using = "input.commandExButton")]
        public IWebElement EnterSystemButton { get; set; }

    }
}