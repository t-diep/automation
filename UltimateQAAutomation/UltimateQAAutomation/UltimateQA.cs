using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Linq;
using System.Collections.Generic;

namespace UltimateQAAutomation
{
	public class UltimateQA
	{
		IWebDriver driver;
		IJavaScriptExecutor jexe;

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
			driver.Dispose();
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
			driver.Dispose();
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
			driver.Dispose();
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
			driver.Dispose();
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
			driver.Dispose();
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
			driver.Dispose();
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
			driver.Dispose();
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
			driver.Dispose();
		}

		/// <summary>
		/// Verifies that a user can click on the Click Me button
		/// </summary>
		[Fact]
		public void CanClickOnClickMeButton()
		{
			InitializeChromeBrowser();

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();
			driver.FindElement(By.XPath("//button[text()='Click Me!']")).Click();

			string expected = "https://ultimateqa.com/?";

			Assert.Equal(expected, driver.Url);

			driver.Quit();
			driver.Dispose();
		}

		/// <summary>
		/// Verifies that a user can click on a button that can be located using its ID 
		/// </summary>
		[Fact]
		public void CanClickOnButtonUsingId()
		{
			InitializeChromeBrowser();

			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();
			driver.FindElement(By.Id("idExample")).Click();

			string expected = "https://ultimateqa.com/button-success";

			Assert.Equal(expected, driver.Url);

			driver.Quit();
			driver.Dispose();
		}

		/// <summary>
		/// This test is similar to CanClickButtonUsingId except that this test 
		/// verifies that a web element containing the text "Button success" exists
		/// </summary>
		[Fact]
		public void CanClickOnButtonsUsingIDButtonSuccess()
		{
			InitializeChromeBrowser();

			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();
			driver.FindElement(By.Id("idExample")).Click();

			string expected = "Button success";

			Assert.True(driver.FindElement(By.CssSelector("h1")).Displayed);
			Assert.Equal(expected, driver.FindElement(By.CssSelector("h1")).Text);

			driver.Quit();
			driver.Dispose();
		}

		/// <summary>
		/// Verifies that a user can click on a button using its class name
		/// </summary>
		[Fact]
		public void CanClickOnButtonUsingClassName()
		{
			InitializeChromeBrowser();

			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();
			driver.FindElement(By.ClassName("buttonClass")).Click();

			string expected = "Button success";

			Assert.True(driver.FindElement(By.CssSelector("h1")).Displayed);
			Assert.Equal(expected, driver.FindElement(By.CssSelector("h1")).Text);

			driver.Quit();
			driver.Dispose();
		}

		/// <summary>
		/// Verifies that a user can click on a button using its name
		/// </summary>
		[Fact]
		public void CanClickButtonUsingName()
		{
			InitializeChromeBrowser();

			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();
			driver.FindElement(By.Name("button1")).Click();

			string expected = "Button success";

			Assert.True(driver.FindElement(By.CssSelector("h1")).Displayed);
			Assert.Equal(expected, driver.FindElement(By.CssSelector("h1")).Text);

			driver.Quit();
			driver.Dispose();
		}

		/// <summary>
		/// Verifies that a user can click on a button that is inside the green div
		/// </summary>
		[Fact]
		public void CanClickOnButtonInsideGreenDiv()
		{
			InitializeChromeBrowser();

			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();

			jexe = (IJavaScriptExecutor)driver;

			jexe.ExecuteScript("window.scrollBy(0, 500)");
			driver.FindElement(By.XPath("//div//a[text()='Click Me']")).Click();		

			string expected = "Button success";

			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

			Assert.True(wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("h1"))).Displayed);
			Assert.Equal(expected, driver.FindElement(By.CssSelector("h1")).Text);

			driver.Quit();
			driver.Dispose();
		}

		/// <summary>
		/// Verifies that a user can select the male radio button
		/// </summary>
		[Fact]
		public void CanClickOnMaleRadioButton()
		{
			InitializeChromeBrowser();

			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();

			jexe = (IJavaScriptExecutor)driver;

			jexe.ExecuteScript("window.scrollBy(0, 500)");

			var radioButtons = driver.FindElements(By.XPath("//input[@type='radio']"));

			radioButtons[0].Click();
			Assert.True(radioButtons[0].Selected);
			Assert.Equal("male", radioButtons[0].GetAttribute("value"));

			driver.Quit();
		}

		/// <summary>
		/// Verifies that a user can select the male radio button
		/// </summary>
		[Fact]
		public void CanClickOnFemaleRadioButton()
		{
			InitializeChromeBrowser();

			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();

			jexe = (IJavaScriptExecutor)driver;

			jexe.ExecuteScript("window.scrollBy(0, 500)");

			var radioButtons = driver.FindElements(By.XPath("//input[@type='radio']"));

			radioButtons[1].Click();
			Assert.True(radioButtons[1].Selected);
			Assert.Equal("female", radioButtons[1].GetAttribute("value"));

			driver.Quit();
		}

		/// <summary>
		/// Verifies that a user can select the male radio button
		/// </summary>
		[Fact]
		public void CanClickOnOtherRadioButton()
		{
			InitializeChromeBrowser();

			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();

			jexe = (IJavaScriptExecutor)driver;

			jexe.ExecuteScript("window.scrollBy(0, 500)");

			var radioButtons = driver.FindElements(By.XPath("//input[@type='radio']"));

			radioButtons[2].Click();
			Assert.True(radioButtons[2].Selected);
			Assert.Equal("other", radioButtons[2].GetAttribute("value"));

			driver.Quit();
		}

		/// <summary>
		/// Verifies that the bike checkbox can be selected
		/// </summary>
		[Fact]
		public void CanClickOnBikeCheckbox()
		{
			InitializeChromeBrowser();

			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();

			jexe = (IJavaScriptExecutor)driver;

			jexe.ExecuteScript("window.scrollBy(0, 500)");

			var checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"));

			checkboxes[0].Click();

			Assert.True(checkboxes[0].Selected);
			Assert.Equal("Bike", checkboxes[0].GetAttribute("value"));

			driver.Quit();
		}

		/// <summary>
		/// Verifies that the car checkbox can be selected
		/// </summary>
		[Fact]
		public void CanClickOnCarCheckbox()
		{
			InitializeChromeBrowser();

			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();

			jexe = (IJavaScriptExecutor)driver;

			jexe.ExecuteScript("window.scrollBy(0, 500)");

			var checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"));

			checkboxes[1].Click();

			Assert.True(checkboxes[1].Selected);
			Assert.Equal("Car", checkboxes[1].GetAttribute("value"));

			driver.Quit();
		}

		/// <summary>
		/// Verifies that a user can click on the clickable icon (the arrow) 
		/// </summary>
		[Fact]
		public void CanClickOnClickableIcon()
		{
			InitializeChromeBrowser();

			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();

			jexe = (IJavaScriptExecutor)driver;

			jexe.ExecuteScript("window.scrollBy(0, 500)");

			driver.FindElement(By.XPath("//div//a[@href='/link-success/']")).Click();

			string expected = "Link success";

			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

			Assert.True(wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("h1"))).Displayed);
			Assert.Equal(expected, driver.FindElement(By.CssSelector("h1")).Text);

			driver.Quit();
		}

		/// <summary>
		/// Verifies that the car checkbox can be selected
		/// </summary>
		[Fact]
		public void CanClickOnDropdownItems()
		{
			InitializeChromeBrowser();

			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

			driver.FindElement(By.PartialLinkText("Interactions ")).Click();

			jexe = (IJavaScriptExecutor)driver;

			jexe.ExecuteScript("window.scrollBy(0, 500)");

			var selectOptions = driver.FindElements(By.CssSelector("select > option")).ToList();

			foreach(var option in selectOptions)
			{
				option.Click();
				Assert.True(option.Selected);
			}

			driver.Quit();
		}
	}
}
