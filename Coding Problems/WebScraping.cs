using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Coding_Problems
{
    class WebScraping
    {
        
        public static void Scrape()
        {
            //write files
            
            string file = @"F:\Google Drive\Visual Studio Projects\Coding Problems\Coding Problems\bin\Debug\netcoreapp3.0\jobs.txt";
            File.Create(file).Close();
            StreamWriter sw = new StreamWriter(file, true);

            //npm install selenium-webdriver
            //npm install chromedriver

            //var chromeDriver = new ChromeDriver();
            //chromeDriver.Navigate().GoToUrl("https://reddit.com");

            //chromeDriver.FindElementByXPath("/html/body/div[1]/div/div[2]/div[1]/header/div/div[1]/div[2]/div/form/input").Click();
            //chromeDriver.Keyboard.SendKeys("Test");
            //chromeDriver.Keyboard.SendKeys(Keys.Enter);
            //*[@id=\"search\"]input[1]
            //

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-popup-blocking");
            options.AddArguments("test-type");


            ////start Indeed 1
            //IWebDriver driver = new ChromeDriver(options);
            //driver.Url = "https://za.indeed.com/";
            //IWebElement elementWhat = driver.FindElement(By.Id("text-input-what"));
            //elementWhat.SendKeys("junior software");
            //IWebElement elementWhere = driver.FindElement(By.Id("text-input-where"));
            //elementWhere.SendKeys("Johannesburg, Gauteng");
            //elementWhere.SendKeys(Keys.Enter);
            //Indeed(driver,sw);
            //driver.Close();

            ////start Indeed 2
            //IWebDriver driverTwo = new ChromeDriver(options);
            //driverTwo.Url = "https://za.indeed.com/";

            //IWebElement elementWhatTwo = driverTwo.FindElement(By.Id("text-input-what"));
            //elementWhatTwo.SendKeys("junior developer");
            //IWebElement elementWhereTwo = driverTwo.FindElement(By.Id("text-input-where"));
            //elementWhereTwo.SendKeys("Johannesburg, Gauteng");
            //elementWhereTwo.SendKeys(Keys.Enter);
            //Indeed(driverTwo,sw);
            //driverTwo.Close();

            ////start Careerjunction
            //IWebDriver driverCareerjunction = new ChromeDriver(options);
            ////js dropdown issue
            //driverCareerjunction.Url = "https://www.careerjunction.co.za/jobs/results?jobtitle=&companies=&job_ref=&keywords=junior+developer&location%5B%5D=2747";
            //Careerjunction(driverCareerjunction,sw);
            //driverCareerjunction.Close();

            ////start Pnet
            //IWebDriver driverFour = new ChromeDriver(options);
            //driverFour.Url = "https://www.pnet.co.za/";
            //IWebElement elementWhatPnet = driverFour.FindElement(By.XPath("//*[@id=\"collapseSearch\"]/div/div/div/div/form/div[1]/div[1]/div/span[2]/input[2]"));
            //elementWhatPnet.SendKeys("junior developer");
            //IWebElement elementWherePnet = driverFour.FindElement(By.XPath("//*[@id=\"collapseSearch\"]/div/div/div/div/form/div[1]/div[2]/div/div/span[2]/input[2]"));
            //elementWherePnet.SendKeys("Johannesburg, Gauteng");
            //elementWhatPnet.SendKeys(Keys.Enter);
            //int pageCount = 0;
            //Pnet(driverFour,pageCount,sw);
            //driverFour.Close();

            ////start CareerJet
            //IWebDriver driverFive = new ChromeDriver(options);
            //driverFive.Url = "https://www.careerjet.co.za/";
            //IWebElement elementWhatCareerjet = driverFive.FindElement(By.Id("s"));
            //elementWhatCareerjet.SendKeys("junior software");
            //IWebElement elementWhereCareerjet = driverFive.FindElement(By.Id("l"));
            //elementWhereCareerjet.SendKeys("Johannesburg, Gauteng");
            //elementWhereCareerjet.SendKeys(Keys.Enter);
            //Careerjet(driverFive, sw);
            //driverFive.Close();

            //start Careers24
            IWebDriver driverSix = new ChromeDriver(options);
            //driverSix.Url = "https://www.careers24.com/";
            driverSix.Url = "https://www.careers24.com/jobs/lc-johannesburg/kw-junior-developer/m-true/";
            
            //driverSix.FindElement(By.XPath("//*[contains(@name, 'Johannesburg')]")).Click();

            //IWebElement elementWhatCareers24 = driverSix.FindElement(By.Id("inSearch"));
            //elementWhatCareers24.SendKeys("junior developer");
            //elementWhatCareers24.SendKeys(Keys.Enter);
            Careers24(driverSix, sw);
            //driverSix.Close();

            //end bit
            sw.Close();
            //Process.Start("notepad.exe", file);

            //this.Close();

            //////IWebElement elementWhere = driverFive.FindElement(By.Name("industries"));
            ////driverFive.FindElement(By.XPath("/html/body/div[5]/div[1]/div[1]/form/div[2]/select/option[10]")).Click();
            ////driverFive.FindElement(By.XPath("//*[@id=\"city\"]/option[4]")).Click();
            ////driverFive.FindElement(By.XPath("/html/body/div[5]/div[1]/div[1]/form/button")).Click();
        }

        public static void Careers24(IWebDriver driver, StreamWriter sw)
        {
            Thread.Sleep(5000);
            //var titles = driver.FindElements(By.Id("ctl00_contentPrimaryPlaceHolder_jobResults_repJobs_ctl00_resultContainer"));
            //var titles = driver.FindElements(By.XPath("//*[contains(@class, 'row job_search_wrapper')]"));
            var titles = driver.FindElements(By.XPath("//*[contains(@data-trigger, 'jobalertmodal')]"));

            foreach (var item in titles)
            {
                Console.WriteLine("\n\n"+item.Text);
                Console.WriteLine(item.GetAttribute("href"));

            }
            try
            {
                driver.FindElement(By.ClassName("next")).Click();
                Careers24(driver, sw);
            }
            catch(Exception e)
            {
                Console.WriteLine("NO NEXT");
                Console.WriteLine(e);
            }
        }

        public static void Careerjet(IWebDriver driver, StreamWriter sw)
        {

            for (int i = 0; i < 6; i++)
            {
                
                driver.FindElement(By.Id("more-jobs")).Click();
                Thread.Sleep(3000);
                
            }
            
            var titles = driver.FindElements(By.XPath("//*[contains(@class, 'job clicky')]"));

            foreach (var item in titles)
            {
                if (item.Text.ToLower().Contains("junior")) 
                {
                    Console.WriteLine("\n\n" + item.Text);
                    Console.WriteLine("https://www.careerjet.co.za/" + item.GetAttribute("data-url"));
                    sw.WriteLine("\n\n" + item.Text + "\n" + "https://www.careerjet.co.za/" + item.GetAttribute("data-url"));

                }

            }

            
        }

        public static void Pnet(IWebDriver driver, int pageCount, StreamWriter sw)
        {
            pageCount++;
            try
            {
                Thread.Sleep(2000);
                Actions action = new Actions(driver);
                action.SendKeys(Keys.Escape).Build().Perform();   
            }
            catch (Exception ex)
            {
                Console.WriteLine("NO POP DISMISS!\n"+ex);
            }

            //var titles = driver.FindElements(By.ClassName("col-lg-9"));
            var titles = driver.FindElements(By.XPath("//*[contains(@id, 'job-item')]"));
            var link = driver.FindElements(By.XPath("//*[contains(@href, '/jobs')]"));
            //var summary = driver.FindElements(By.ClassName("summary"));
            //var daysAgo = driver.FindElements(By.ClassName("jobsearch-SerpJobCard-footer"));
            //var link = driver.FindElements(By.TagName("a"));
            
            for (int i = 0; i < titles.Count; i++)
            {
                if (titles[i].Text.ToLower().Contains("junior"))
                {
                    Console.WriteLine("\n\n" + titles[i].Text);
                    sw.WriteLine("\n\n" + titles[i].Text);
                    for (int j = 0; j < link.Count; j++)
                    {
                        if (titles[i].Text.Contains(link[j].Text))
                        {
                            Console.WriteLine(link[j].Text + "\n" + link[j].GetAttribute("href"));
                            sw.WriteLine(link[j].Text + "\n" + link[j].GetAttribute("href"));
                        }
                    }
                }
            }

            try
            {
                //driver.FindElement(By.Id("Next")).Click();//title
                //*[@id="app-dynamicResultlist"]/div/div[1]/div/div[2]/div[3]/div[3]/a[2]

                if(pageCount <= 20)
                {
                    driver.FindElement(By.XPath("//*[contains(@title, 'Next')]")).Click();

                    Pnet(driver, pageCount, sw);
                }

                
            }catch(Exception e)
            {
                Console.WriteLine("\nNEXT BUTTON\n"+e);
            }
            
        }

        public static void Careerjunction(IWebDriver driver, StreamWriter sw)
        {
            var titles = driver.FindElements(By.ClassName("cardContentJob"));

            foreach (var item in titles)
            {
                
                Console.WriteLine("\n\n"+item.Text);
                Console.WriteLine(item.GetAttribute("href"));
                sw.WriteLine("\n\n" + item.Text+"\n"+ item.GetAttribute("href"));
            }
        }

        public static void Indeed(IWebDriver driver, StreamWriter sw)
        {
            var titles = driver.FindElements(By.ClassName("title"));
            var summary = driver.FindElements(By.ClassName("summary"));
            var daysAgo = driver.FindElements(By.ClassName("jobsearch-SerpJobCard-footer"));
            var link = driver.FindElements(By.TagName("a"));

            for (int i = 0; i < titles.Count; i++)
            {
                if (!daysAgo[i].Text.Contains("30"))//&& titles[i].Text.ToLower().Contains("junior")
                {
                    Console.WriteLine("\n\n" + titles[i].Text + "\n" + summary[i].Text + "\n" + daysAgo[i].Text);
                    sw.WriteLine("\n\n" + titles[i].Text + "\n" + summary[i].Text + "\n" + daysAgo[i].Text);
                    for (int j = 0; j < link.Count; j++)
                    {
                        if (link[j].Text == titles[i].Text)
                        {
                            Console.WriteLine(link[j].GetAttribute("href"));
                            sw.WriteLine(link[j].GetAttribute("href"));
                        }
                    }
                }
            }

            try
            {
                Console.WriteLine("POP!");
                //IWebElement element = driver.FindElement(By.XPath("//*[@id=\"popover - link - x\"]"));
                //element.Click();
                //driver.Refresh();
                IWebElement popup = driver.FindElement(By.Id("popover-email"));
                popup.SendKeys(Keys.Escape);
                //driver.SwitchTo().Alert().SendKeys(Keys.Escape);
                Console.WriteLine("POP!!");
                //if (element.Displayed && element.Enabled)
                //{
                //    Console.WriteLine("POP");
                //    element.Click();
                //    Console.WriteLine("POP BYE");
                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine("NO POP!");
            }
                Console.WriteLine("\nEND!");
                //Console.WriteLine(ex + "\n");
                try
                {

                    driver.FindElement(By.XPath("//*[@id=\"resultsCol\"]/nav/div/ul/li[7]/a")).Click();
                    Console.WriteLine("CLICK!");
                    Indeed(driver, sw);


                } catch (Exception exc) {
                    try
                    {
                        driver.FindElement(By.XPath("//*[@id=\"resultsCol\"]/nav/div/ul/li[6]/a")).Click();
                        Console.WriteLine("\nCLICK!!");
                        Indeed(driver, sw);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nEND!!");
                        //Console.WriteLine(e);
                    }

                }
            
            //}
            
            
        }
    }
}