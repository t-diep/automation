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

		/// <summary>
		/// Verifies that a user can navigate to the fake price page
		/// </summary>
		[Fact]
		public void CanNavigateToFakePricePage()
		{
			InitializeChromeBrowser();

			driver.FindElement(By.PartialLinkText("Fake Pricing ")).Click();

			string expected = "https://ultimateqa.com/automation/fake-pricing-page/";

			Assert.Equal(expected, driver.Url);

			driver.Quit();
		}

		/// <summary>
		/// Verifies that a user can navigate to the fill out forms page
		/// </summary>
		[Fact]
		public void CanNavigateToFillOutFormsPage()
		{
			InitializeChromeBrowser();

			driver.FindElement(By.PartialLinkText("Fill out ")).Click();

			string expected = "https://ultimateqa.com/filling-out-forms/";

			Assert.Equal(expected, driver.Url);

			driver.Quit();
		}

		/// <summary>
		/// Verifies that a user can navigate to the automation tutorial page
		/// </summary>
		[Fact]
		public void CanNavigateToAutomationTutorialPage()
		{
			InitializeChromeBrowser();

			driver.FindElement(By.PartialLinkText("Learn ")).Click();

			string expected = "https://ultimateqa.com/sample-application-lifecycle-sprint-1/";

			Assert.Equal(expected, driver.Url);

			driver.Quit();
		}

		/// <summary>
		/// Verifies that a user can navigate to the login automation page
		/// </summary>
		[Fact]
		public void CanNavigateToLoginAutomationPage()
		{
			InitializeChromeBrowser();

			driver.FindElement(By.PartialLinkText("Login ")).Click();

			string expected = "https://courses.ultimateqa.com/users/sign_in";

			Assert.Equal(expected, driver.Url);

			driver.Quit();
		}

		/// <summary>
		/// Verifies that a user can navigate to the interactions with simple elements page
		/// </summary>
		[Fact]
		public void CanNavigateToInteractionsWithSimpleElementsPage()
		{
			InitializeChromeBrowser();

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();

			string expected = "https://ultimateqa.com/simple-html-elements-for-automation/";

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
