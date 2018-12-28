using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace task_DEV_10._0.pages
{
    class PageRoutes
    {
        /// <summary>Departure Station Field</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:textDepStat")]
        public IWebElement DepartureStationField { get; set; }

        /// <summary>Arrival Station Field</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:textArrStat")]
        public IWebElement ArrivalStationField { get; set; }

        /// <summary>Change Stations Trigger</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed6176b")]
        public IWebElement ChangeStationsTrigger { get; set; }

        /// <summary>Departure Date Field</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:dob")]
        public IWebElement DepartureDateField { get; set; }

        /// <summary>Departure Date Trigger</summary>
        [FindsBy(How = How.XPath, Using = "*[@id='dateInfo']/tbody/tr[1]/td/img")]
        public IWebElement DepartureTrigger { get; set; }

        /// <summary>is used to work with timebox method </summary>
        [FindsBy(How = How.ClassName, Using = "time")]
        private IWebElement TimeBoxes;

        ///<summary> </summary> 
        [FindsBy(How=How.LinkText,Using ="Поезд")]
        public IWebElement TrainTab { get; set; }

        /// <summary>Departure Time Boxes </summary>
        public IWebElement TimeBox(int numberOfBox)
        {
            IList<IWebElement> timeBoxes = new List<IWebElement>();
            timeBoxes = TimeBoxes.FindElements(By.TagName("a"));
            return timeBoxes[numberOfBox];
        }

        /// <summary>Choose all time boxes</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed6129a")]
        public IWebElement TimeBoxesChooseAllButton { get; set; }

        /// <summary>Reset all time boxes</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed612ad")]
        public IWebElement TimeBoxesResetTimeButton { get; set; }

        /// <summary>E-registration Button</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:onlyER")]
        public IWebElement ERegistrationButton { get; set; }

        /// <summary>Continue Button</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:buttonSearch")]
        public IWebElement ContinueButton { get; set; }

        /// <summary>Reset Button</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:buttonCancel")]
        public IWebElement ResetButton { get; set; }

        /// <summary>Widget of Date</summary>
        [FindsBy(How = How.ClassName, Using = "ui-datepicker-trigger")]
        public IWebElement DatePickerTrigger { get; set; }

        /// <summary>Widget of Today Date</summary>
        [FindsBy(How = How.CssSelector, Using = "#ui-datepicker-div > div.ui-datepicker-group.ui-datepicker-group-first > table > tbody > tr:nth-child(5) > td.ui-datepicker-days-cell-over.ui-datepicker-current-day.ui-datepicker-today")]
        public IWebElement TodayDateDepature { set; get; }

        /// <summary>Helper of Region Centres, your can just click</summary>
        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1 > div.block_blue > table > tbody > tr:nth-child(1) > td:nth-child(5)")]
        public IWebElement RegionalCentresDepature { set; get; }

        [FindsBy(How = How.CssSelector, Using = "#viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_\\3a form1 > div.block_blue > table > tbody > tr:nth-child(3) > td:nth-child(4)")]
        public IWebElement RegionalCentresArrival { set; get; }

        /// <summary>Choose one of regional centres</summary>
        public IWebElement DepatureLinks(int number)
        {
            IList<IWebElement> DepLinks = new List<IWebElement>();
            DepLinks =RegionalCentresDepature.FindElements(By.TagName("a"));
            return DepLinks[number];
        }
        /// <summary>Choose one of regional centrs</summary>
        public IWebElement ArrivalLinks(int number)
        {
            IList<IWebElement> ArrLinks = new List<IWebElement>();
            ArrLinks = RegionalCentresArrival.FindElements(By.TagName("a"));
            return ArrLinks[number];
        }

        /// <summary>start typing, it help</summary>
        [FindsBy(How = How.CssSelector, Using = "#ui-id-2")]
        public IWebElement AutoCompleteMenu { set; get; }
        ///<summary>choose one of auto variant</summary>
        public IWebElement DepartAuto(int number)
        {
            IList<IWebElement> ArrLinks = new List<IWebElement>();
            ArrLinks = AutoCompleteMenu.FindElements(By.TagName("a"));
            return ArrLinks[number];
        }
    }
}