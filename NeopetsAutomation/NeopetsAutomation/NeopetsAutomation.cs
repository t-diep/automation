using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Nancy.Testing;

namespace NeopetsAutomation
{
	public class NeopetsAutomation
	{
		IWebDriver driver;
		const string neopetsUrl = "http://www.neopets.com//";

		/// <summary>
		/// Login test for Chrome browser
		/// </summary>
		[Fact]
		public void LoginAccount()
		{
			driver = new ChromeDriver();

			driver.Manage().Cookies.DeleteAllCookies();
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl(neopetsUrl);
		}
	}
}
