using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using task_DEV_10._0.pages;
using System;
using System.Threading;

namespace task_DEV_10._0
{
    [TestFixture]
    public class Test
    {
        IWebDriver driver = new ChromeDriver();

        [OneTimeSetUp] 
        public void OneTimeSetUp()
        {

        }

        [OneTimeTearDown] 
        public void OneTimeTearDown()
        {
            driver.Quit();
        }

        [SetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl("https://poezd.rw.by");

        }

        [TearDown] 
        public void TearDown()
        {
           
        }

        [Test]
        public void TestLoginPageOpen()
        {
            bool result = false;
            bool expected = true;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.LoginPageButton.Click();
            PageLogin pageLogin = new PageLogin();
            PageFactory.InitElements(driver, pageLogin);
            result = pageLogin.EnterSystemButton.Displayed;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestLoginPositive()
        {
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.LoginPageButton.Click();
            PageLogin pageLogin = new PageLogin();
            PageFactory.InitElements(driver, pageLogin);
            pageLogin.LoginField.SendKeys("FakeDev10");
            pageLogin.PasswordField.SendKeys("4GmMTJm27WrjYJ2");
            pageLogin.EnterSystemButton.Click();
            PageFactory.InitElements(driver, pageHome);
            pageHome.LogoutButton.Click();
        }

        [Test]
        public void TestLoginWrongPassword()
        {
            bool expected = true;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.LoginPageButton.Click();
            PageLogin pageLogin = new PageLogin();
            PageFactory.InitElements(driver, pageLogin);
            pageLogin.LoginField.SendKeys("FakeDev10");
            pageLogin.PasswordField.SendKeys("4GmMTJm27WrjYJ");
            pageLogin.EnterSystemButton.Click();
            bool result = pageLogin.EnterSystemButton.Displayed;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestLoginWrongUsername()
        {
            bool expected = true;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.LoginPageButton.Click();
            PageLogin pageLogin = new PageLogin();
            PageFactory.InitElements(driver, pageLogin);
            pageLogin.LoginField.SendKeys("FakeDev1");
            pageLogin.PasswordField.SendKeys("4GmMTJm27WrjYJ");
            pageLogin.EnterSystemButton.Click();
            bool result = pageLogin.EnterSystemButton.Displayed;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestLoginEmptyPassword()
        {
            bool result = false;
            bool expected = true;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.LoginPageButton.Click();
            PageLogin pageLogin = new PageLogin();
            PageFactory.InitElements(driver, pageLogin);
            pageLogin.LoginField.SendKeys("FakeDev10");
            pageLogin.EnterSystemButton.Click();
            result = pageLogin.EnterSystemButton.Displayed;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestLoginEmptyUsername()
        {
            bool result = false;
            bool expected = true;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.LoginPageButton.Click();
            PageLogin pageLogin = new PageLogin();
            PageFactory.InitElements(driver, pageLogin);
            pageLogin.PasswordField.SendKeys("4GmMTJm27WrjYJ");
            pageLogin.EnterSystemButton.Click();
            result = pageLogin.EnterSystemButton.Displayed;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestLoginEmptyAll()
        {
            bool result = false;
            bool expected = true;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.LoginPageButton.Click();
            PageLogin pageLogin = new PageLogin();
            PageFactory.InitElements(driver, pageLogin);
            pageLogin.EnterSystemButton.Click();
            result = pageLogin.EnterSystemButton.Displayed;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestRoutePageOpen()
        {
            bool result = false;
            bool expected = true;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);     
            result = pageRoutes.ContinueButton.Displayed;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestRouteDepatureFieldIsEmpty()
        {
            DateTime date1 = DateTime.Now;
            string today = date1.ToShortDateString();
            bool expected = false;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.DepartureStationField.SendKeys("");
            pageRoutes.ArrivalStationField.SendKeys("Борисов");
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.DepartureDateField.SendKeys(today);
            pageRoutes.ContinueButton.Click();
            bool result = pageRoutes.TrainTab.Selected;
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void TestRouteArrivalFieldIsEmpty()
        {
            DateTime date1 = DateTime.Now;
            string today = date1.ToShortDateString();
            bool expected = false;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.DepartureStationField.SendKeys("МИНСК");
            pageRoutes.ArrivalStationField.SendKeys("");
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.DepartureDateField.SendKeys(today);
            pageRoutes.ContinueButton.Click();
            bool result = pageRoutes.TrainTab.Selected;
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void TestRouteDateFieldIsEmpty()
        {
            bool expected = false;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.DepartureStationField.SendKeys("Минск");
            pageRoutes.ArrivalStationField.SendKeys("Борисов");
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ContinueButton.Click();
            bool result = pageRoutes.TrainTab.Selected;
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void TestRouteAllFieldisEmpty()
        {
            bool expected = false;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.ContinueButton.Click();
            bool result = pageRoutes.TrainTab.Selected;
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void TestRouteChangeStations()
        {
            string depKey = "ОТПРАВЛЕНИЕ";
            string arrKey = "ПРИБЫТИЕ";
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.DepartureStationField.SendKeys(depKey);
            pageRoutes.ArrivalStationField.SendKeys(arrKey);
            pageRoutes.ChangeStationsTrigger.Click();
            string resultArr = pageRoutes.ArrivalStationField.GetAttribute("value");
            Assert.AreEqual(depKey, resultArr);
            string resultDep = pageRoutes.DepartureStationField.GetAttribute("value");
            Assert.AreEqual(arrKey, resultDep);

        }

        [Test]
        public void TestRouteDateSetClickable()
        {
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.TimeBoxesResetTimeButton.Click();
            pageRoutes.TimeBox(1).Click();
            pageRoutes.TimeBox(7).Click();
        }
        [Test]
        public void TestRoutesPositive()
        {
            DateTime date1 = DateTime.Now;
            string today = date1.ToShortDateString(); //todays date
            bool expected = true;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.DepartureStationField.SendKeys("Минск");
            pageRoutes.ArrivalStationField.SendKeys("Борисов");
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.DepartureDateField.SendKeys(today);
            pageRoutes.ContinueButton.Click();
            bool result = pageRoutes.TrainTab.Displayed;
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void TesteWidgetTodayPositive()
        {
            DateTime date1 = DateTime.Now;
            string expected = date1.ToShortDateString(); //todays date
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.DatePickerTrigger.Click();
            pageRoutes.TodayDateDepature.Click();
            string result =pageRoutes.DepartureDateField.GetAttribute("value");
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void TestRouteHaveNotTrain()
        {
            DateTime date1 = DateTime.Now;
            string today = date1.ToShortDateString();
            bool expected = false;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.DepartureStationField.SendKeys("ЛОНДОН ЛИВЕРПУЛЬ СТРИТ");
            pageRoutes.ArrivalStationField.SendKeys("Вилейка");
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.DepartureDateField.SendKeys(today);
            pageRoutes.ContinueButton.Click();
            bool result = pageRoutes.TrainTab.Selected;
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void TestDateIsMoreThen45DaysFromToday()
        {
            DateTime date1 = DateTime.Now;
            date1 = date1.AddDays(61); // railway station son't seal tickets on date more then 60 days from today
            string someday = date1.ToShortDateString();
            bool expected = false;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.DepartureStationField.SendKeys("Минск");
            pageRoutes.ArrivalStationField.SendKeys("Гомель");
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.DepartureDateField.SendKeys(someday);
            pageRoutes.ContinueButton.Click();
            bool result = pageRoutes.TrainTab.Selected;
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void TestDateIsSmallerThenToday() //try to vuy ticket on yesterday train 
        {
            DateTime date1 = DateTime.Now;
            date1 = date1.AddDays(-5);
            string someday = date1.ToShortDateString();
            bool expected = false;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.DepartureStationField.SendKeys("Минск");
            pageRoutes.ArrivalStationField.SendKeys("Гомель");
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.DepartureDateField.SendKeys(someday);
            pageRoutes.ContinueButton.Click();
            bool result = pageRoutes.TrainTab.Selected;
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void TestRouteTheSameStations() 
        {
            DateTime date1 = DateTime.Now;
            string today = date1.ToShortDateString();
            bool expected = false;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.DepartureStationField.SendKeys("Минск");
            pageRoutes.ArrivalStationField.SendKeys("Минск");
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.DepartureDateField.SendKeys(today);
            pageRoutes.ContinueButton.Click();
            bool result = pageRoutes.TrainTab.Selected;
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void TestRouteHaveNotTime() 
        {
            DateTime date1 = DateTime.Now;
            string today = date1.ToShortDateString();
            bool expected = false;
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.DepartureStationField.SendKeys("Минск");
            pageRoutes.ArrivalStationField.SendKeys("Жлобин");
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.DepartureDateField.SendKeys(today);
            pageRoutes.TimeBoxesResetTimeButton.Click();
            pageRoutes.ContinueButton.Click();
            bool result = pageRoutes.TrainTab.Selected;
            Assert.AreEqual(result, expected);
        }


        [Test]
        public void TestRouteResetStation() 
        {
            string expected = "";
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.DepartureStationField.SendKeys("Минск");
            pageRoutes.ArrivalStationField.SendKeys("Жлобин");
            pageRoutes.ResetButton.Click();
            string resultArr = pageRoutes.ArrivalStationField.GetAttribute("value");
            string resultDep = pageRoutes.DepartureStationField.GetAttribute("value");
            Assert.AreEqual(expected, resultArr);
            Assert.AreEqual(expected, resultArr);
        }

        [Test]
        public void TestRouteCheckHintRegionalCentres() //hyperlink, which rw can help us
        {
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            IWebElement depLink=pageRoutes.DepatureLinks(1);
            IWebElement arrLink=pageRoutes.ArrivalLinks(2);
            depLink.Click();
            arrLink.Click();
            Assert.AreEqual(depLink.Text, pageRoutes.DepartureStationField.GetAttribute("value"));
            Assert.AreEqual(arrLink.Text, pageRoutes.ArrivalStationField.GetAttribute("value"));
        }

        [Test]
        public void TestRoutesAutoCompleteMenu() //start typing service testing
        {
            string beginning = "М";
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.RoutesPageButton.Click();
            PageRoutes pageRoutes = new PageRoutes();
            PageFactory.InitElements(driver, pageRoutes);
            pageRoutes.DepartureStationField.Clear();
            pageRoutes.DepartureDateField.Clear();
            pageRoutes.ArrivalStationField.Clear();
            pageRoutes.DepartureStationField.SendKeys(beginning);
            pageRoutes.DepartureStationField.Click();
            Thread.Sleep(1000);
            IWebElement autoDep=pageRoutes.DepartAuto(5);
            string expected = autoDep.Text;
            int usefulind = expected.IndexOf(',');
            expected = expected.Substring(0, usefulind);
            autoDep.Click();
            Assert.AreEqual(expected, pageRoutes.DepartureStationField.GetAttribute("value"));
        }


    }
}