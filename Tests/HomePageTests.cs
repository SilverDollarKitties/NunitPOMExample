using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NunitPOMExample.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitPOMExample.Tests
{
    public class HomePageTests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
        }

        [TearDown]
        public void ShutDownBrowser()
        {
            driver.Quit();
        }

        [Test]
        public void TestHomePageUrlHeadingTitle()
        {
            var home_Page = new HomePage(driver);
            home_Page.Open();
            Assert.That(driver.Url, Is.EqualTo(home_Page.GetPageUrl()));
            Assert.That(home_Page.GetPageHeading(), Is.EqualTo("Students Registry"));
            Assert.That(home_Page.GetPageTitle(), Is.EqualTo("MVC Example"));
        }

        [Test]
        public void TestHomePageLink()
        {
            var home_Page = new HomePage(driver);
            home_Page.Open();
            home_Page.HomeLink.Click();
            Assert.That(home_Page.GetPageTitle(), Is.EqualTo("MVC Example"));

        }

        [Test]
        public void TestHomePageViewStudents()
        {
            var home_Page = new HomePage(driver);
            home_Page.Open();
            home_Page.HomeLink.Click();
            Assert.That(home_Page.GetPageTitle(), Is.EqualTo("MVC Example"));

        }
        [Test]
        public void TestHomePageViewStudentCount()
        {
            var home_Page = new HomePage(driver);
            home_Page.Open();
            home_Page.HomeLink.Click();
            Assert.Greater(home_Page.GetStudentCount(), 0);
        }
    }   
}