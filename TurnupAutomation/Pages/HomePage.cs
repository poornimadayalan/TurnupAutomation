using OpenQA.Selenium;
using System.Threading;

namespace TurnupAutomation.Pages

{
    public class HomePage

    {

        public void GoToTimeAndMaterialPage(IWebDriver driver)

        {
            // Navigate to Administration Module
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));

            administrationDropdown.Click();


            // Select Time and Material Module
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]"));

            tmOption.Click();

            Thread.Sleep(5000);

        }
    }
}
