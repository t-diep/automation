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
		/// Sets up Chrome browser
		/// </summary>
		private void InitializeChromeBrowser()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl(ultimateQAURL);
		}

		/// <summary>
		/// Verifies that a user can navigate to the Ultimate QA website
		/// </summary>
		[Fact]
		public void CanNavigateToUltimateQA()
		{
			InitializeChromeBrowser();

			Assert.Equal(ultimateQAURL, driver.Url);

			driver.Quit();
		}

		/// <summary>
		/// Verifies that a user can navigate to the first hyperlink on the homepage
		/// </summary>
		[Fact]
		public void CanNavigateToBigPageWithManyElements()
		{
			InitializeChromeBrowser();

			driver.FindElement(By.PartialLinkText("Big page with ")).Click();

			string expected = "https://ultimateqa.com/complicated-page";

			Assert.Equal(expected, driver.Url);

			driver.Quit();
		}

		/// <summary>
		/// Verifies that a user can navigate to the fake pricing page
		/// </summary>
		[Fact]
		public void CanNavigateToFakeLandingPage()
		{
			InitializeChromeBrowser();

			driver.FindElement(By.PartialLinkText("Fake Landing ")).Click();

			string expected = "https://ultimateqa.com/fake-landing-page";

			Assert.Equal(expected, driver.Url);

			driver.Quit();
		}

		///// <summary>
		///// 
		///// </summary>
		//[Fact]
		//public void VerifyNumberOfButtons()
		//{
		//	InitializeChromeBrowser();

		//	driver.Quit();
		//}
	}
}
