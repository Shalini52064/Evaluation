using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Evaluuation
{
    public class BaseTest
    {
        public void Setup()
        {

            IWebDriver obj = new ChromeDriver();
            obj.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

            obj.Manage().Window.Maximize();
            Console.WriteLine(obj.Title);
            obj.Quit();
        }
            


        
        
    }
}
