using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V124.Runtime;
using OpenQA.Selenium.DevTools.V124.WebAuthn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluuation
{
    public class Login
    {
        public void TestInvalidLogin(string username, string password, string expectedErrorMessage)
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
             Evaluation Login = new LoginPage(driver);
            loginPage.loginPage(username, password);
            string actualErrorMessage = loginPage.GetErrorMessage();
            Assert.AreEqual(expectedErrorMessage, actualErrorMessage, "Invalid Credentials");
        }

    }
}
