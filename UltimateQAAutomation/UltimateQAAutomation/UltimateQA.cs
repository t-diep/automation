using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UltimateQAAutomation
{
	public class UltimateQA
	{
		IWebDriver driver;
		const string ultimateQAURL = "https://ultimateqa.com/automation/";

		/// <summary>
		/// Verifies that a user can navigate to the Ultimate QA website
		/// </summary>
		[Fact]
		public void CanNavigateToUltimateQA()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl(ultimateQAURL);

			Assert.Equal(ultimateQAURL, driver.Url);

			driver.Close();
		}
	}
}
