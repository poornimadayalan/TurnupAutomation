using NUnit.Framework;
using TurnupAutomation.Pages;
using TurnupAutomation.Utilities;
using OpenQA.Selenium.Chrome;

namespace TurnupAutomation.Tests
{
    [TestFixture]
    public class TimeandMaterialTests : CommonDriver
    {
        [SetUp]
        public void SetupTM()
        {
            // Open Chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Perform the login
            Loginpage loginPageObject = new Loginpage();
            loginPageObject.LoginActions(driver);

            //Go to the Time and Material page
            HomePage homePageObject = new HomePage();
            homePageObject.GoToTimeAndMaterialPage(driver);

        }

        // Test 1: Create time record
        [Test, Order(1)]
        public void TestCreateTimeRecord()
        {
            TimeAndMaterialPage timeAndMaterialObj = new TimeAndMaterialPage();
            timeAndMaterialObj.CreateTimeAndMaterialRecord(driver);
        }

        // Test 2: Edit time record
        [Test, Order(2)]
        public void TestEditTimeRecord()

        {
            TimeAndMaterialPage timeAndMaterialObj = new TimeAndMaterialPage();
            timeAndMaterialObj.EditTimeAndMaterialRecord(driver);
        }


        // Test 3: Delete time record
        [Test, Order(3)]
        public void TestDeleteTimeRecord()
        {
            TimeAndMaterialPage timeAndMaterialObj = new TimeAndMaterialPage();
            timeAndMaterialObj.DeleteTimeAndMaterialRecord(driver);
        }


        [TearDown]
        public void CloseTest()
        {
            driver.Quit();
        }
    }   
}
