using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace task_DEV_10._0.pages
{
    class PageHome
    {
        /// <summary>Logout button</summary>
        [FindsBy(How = How.CssSelector, Using = "a#logoutlink")]
        public IWebElement LogoutButton { get; set; }

        /// <summary>Go To Routes Page</summary>
        [FindsBy(How = How.PartialLinkText, Using = "Расписание движения и стоимость проезда")]
        public IWebElement RoutesPageButton { get; set; }

        /// <summary>Go To Login Page</summary>
        [FindsBy(How = How.PartialLinkText, Using = "Вход в систему")]
        public IWebElement LoginPageButton { get; set; }

    }
}