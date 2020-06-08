using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Coding_Problems
{
    class WebScraping
    {
        
        public static void Scrape()
        {
            //npm install selenium-webdriver
            //npm install chromedriver

            //var chromeDriver = new ChromeDriver();
            //chromeDriver.Navigate().GoToUrl("https://reddit.com");

            //chromeDriver.FindElementByXPath("/html/body/div[1]/div/div[2]/div[1]/header/div/div[1]/div[2]/div/form/input").Click();
            //chromeDriver.Keyboard.SendKeys("Test");
            //chromeDriver.Keyboard.SendKeys(Keys.Enter);
            //*[@id=\"search\"]input[1]

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://za.indeed.com/";

            IWebElement elementWhat = driver.FindElement(By.Id("text-input-what"));
            elementWhat.SendKeys("junior software");
            IWebElement elementWhere = driver.FindElement(By.Id("text-input-where"));
            elementWhere.SendKeys("Johannesburg, Gauteng");
            elementWhere.SendKeys(Keys.Enter);

            Indeed(driver);

            driver.Close();

            IWebDriver driverTwo = new ChromeDriver();
            driverTwo.Url = "https://za.indeed.com/";

            IWebElement elementWhatTwo = driverTwo.FindElement(By.Id("text-input-what"));
            elementWhatTwo.SendKeys("junior developer");
            IWebElement elementWhereTwo = driverTwo.FindElement(By.Id("text-input-where"));
            elementWhereTwo.SendKeys("Johannesburg, Gauteng");
            elementWhereTwo.SendKeys(Keys.Enter);

            Indeed(driverTwo);

            driverTwo.Close();
        }

        public static void Indeed(IWebDriver driver)
        {
            var titles = driver.FindElements(By.ClassName("title"));
            var summary = driver.FindElements(By.ClassName("summary"));
            var daysAgo = driver.FindElements(By.ClassName("jobsearch-SerpJobCard-footer"));
            var link = driver.FindElements(By.TagName("a"));

            for (int i = 0; i < titles.Count; i++)
            {
                if (!daysAgo[i].Text.Contains("30"))
                {
                    Console.WriteLine("\n\n" + titles[i].Text + "\n" + summary[i].Text + "\n" + daysAgo[i].Text);

                    for (int j = 0; j < link.Count; j++)
                    {
                        if (link[j].Text == titles[i].Text)
                        {
                            Console.WriteLine(link[j].GetAttribute("href"));
                        }
                    }
                }
            }
            
            try
            {
                driver.FindElement(By.XPath("//*[@id=\"resultsCol\"]/nav/div/ul/li[7]/a")).Click();
                Console.WriteLine("CLICK!");
                Indeed(driver);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nEND!");
                //Console.WriteLine(ex + "\n");
                try
            {
                
                driver.FindElement(By.XPath("//*[@id=\"resultsCol\"]/nav/div/ul/li[6]/a")).Click();
                Console.WriteLine("\nCLICK!!");
                Indeed(driver);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nEND!!");
                //Console.WriteLine(e);
            }
            }
            
            
        }
    }
}