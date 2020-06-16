using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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

            //demo start
            //npm install selenium-webdriver
            //npm install chromedriver

            //var chromeDriver = new ChromeDriver();
            //chromeDriver.Navigate().GoToUrl("https://reddit.com");

            //chromeDriver.FindElementByXPath("/html/body/div[1]/div/div[2]/div[1]/header/div/div[1]/div[2]/div/form/input").Click();
            //chromeDriver.Keyboard.SendKeys("Test");
            //chromeDriver.Keyboard.SendKeys(Keys.Enter);
            //*[@id=\"search\"]input[1]
            //demo end

            string location = "Johannesburg, Gauteng";
            string jobTitleOne = "junior developer";
            string jobTitleTwo = "junior software";
            string extraKeyword = "junior";
            Console.WriteLine($"DEFAULTS\nLoacation: {location}\nJob title one: {jobTitleOne}\nJob title two: {jobTitleTwo}\nExtra keyword: {extraKeyword}\nChange defaults y/n");
            string changeDefaults = Console.ReadLine();
            if (changeDefaults.ToLower().Equals("y"))
            {
                Console.WriteLine("Enter Location: ");
                location = Console.ReadLine();
                Console.WriteLine("Enter Job Title One: ");
                jobTitleOne = Console.ReadLine();
                Console.WriteLine("Enter Job Title Two: ");
                jobTitleTwo = Console.ReadLine();
                Console.WriteLine("Enter Extra Keyword: ");
                extraKeyword = Console.ReadLine();
            }



            string file = @"F:\Google Drive\Visual Studio Projects\Coding Problems\Coding Problems\bin\Debug\netcoreapp3.0\jobs.txt";
            File.Create(file).Close();

            StreamWriter sw = new StreamWriter(file, true);

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-popup-blocking");
            options.AddArguments("test-type");


            //start Indeed 1
            IWebDriver driverIndeed = new ChromeDriver(options);
            driverIndeed.Url = "https://za.indeed.com/";
            IWebElement elementWhatIndeed = driverIndeed.FindElement(By.Id("text-input-what"));
            elementWhatIndeed.SendKeys(jobTitleTwo);
            IWebElement elementWhereIndeed = driverIndeed.FindElement(By.Id("text-input-where"));
            elementWhereIndeed.SendKeys(location);
            elementWhereIndeed.SendKeys(Keys.Enter);
            Indeed(driverIndeed, sw, extraKeyword);
            driverIndeed.Close();

            //start Indeed 2
            IWebDriver driverIndeed2 = new ChromeDriver(options);
            driverIndeed2.Url = "https://za.indeed.com/";
            IWebElement elementWhatIndeed2 = driverIndeed2.FindElement(By.Id("text-input-what"));
            elementWhatIndeed2.SendKeys(jobTitleOne);
            IWebElement elementWhereIndeed2 = driverIndeed2.FindElement(By.Id("text-input-where"));
            elementWhereIndeed2.SendKeys(location);
            elementWhereIndeed2.SendKeys(Keys.Enter);
            Indeed(driverIndeed2, sw, extraKeyword);
            driverIndeed2.Close();

            //start Careerjunction
            IWebDriver driverCareerjunction = new ChromeDriver(options);
            //js dropdown issue
            //driverCareerjunction.Url = "https://www.careerjunction.co.za/jobs/results?jobtitle=&companies=&job_ref=&keywords=junior+developer&location%5B%5D=2747";

            driverCareerjunction.Url = "https://www.careerjunction.co.za";

            //js dropdown issue
            //driverCareerjunction.FindElement(By.XPath("//*[@id=\"location\"]/option")).Click();
            IWebElement elementWheredriverCareerjunction = driverCareerjunction.FindElement(By.Id("location"));
            //elementWheredriverCareerjunction.Click();
            SelectElement oSelect = new SelectElement(elementWheredriverCareerjunction);
            IList<IWebElement> elementCount = oSelect.Options;
            Console.Write(elementCount.Count);
            int iSize = elementCount.Count;
            for (int i = 0; i > iSize; i++)
            {
                String sValue = elementCount.ElementAt(i).Text;
                Console.WriteLine(sValue);
            }


            IWebElement elementWhatdriverCareerjunction = driverCareerjunction.FindElement(By.XPath("//*[@id=\"form1_anykeywords_input\"]"));
            elementWhatdriverCareerjunction.SendKeys(jobTitleOne);
            elementWhatdriverCareerjunction.SendKeys(Keys.Enter);
            driverCareerjunction.FindElement(By.Id("form1_submit")).Click();

            Careerjunction(driverCareerjunction, sw);
            driverCareerjunction.Close();

            //start Pnet
            IWebDriver driverPnet = new ChromeDriver(options);
            driverPnet.Url = "https://www.pnet.co.za/";
            IWebElement elementWhatPnet = driverPnet.FindElement(By.XPath("//*[@id=\"collapseSearch\"]/div/div/div/div/form/div[1]/div[1]/div/span[2]/input[2]"));
            elementWhatPnet.SendKeys(jobTitleOne);
            IWebElement elementWherePnet = driverPnet.FindElement(By.XPath("//*[@id=\"collapseSearch\"]/div/div/div/div/form/div[1]/div[2]/div/div/span[2]/input[2]"));
            elementWherePnet.SendKeys(location);
            elementWhatPnet.SendKeys(Keys.Enter);
            int pageCount = 0;
            Pnet(driverPnet, pageCount, sw, extraKeyword);
            driverPnet.Close();

            //start CareerJet
            IWebDriver driverCareerJet = new ChromeDriver(options);
            driverCareerJet.Url = "https://www.careerjet.co.za/";
            IWebElement elementWhatCareerjet = driverCareerJet.FindElement(By.Id("s"));
            elementWhatCareerjet.SendKeys(jobTitleOne);
            IWebElement elementWhereCareerjet = driverCareerJet.FindElement(By.Id("l"));
            elementWhereCareerjet.SendKeys(location);
            elementWhereCareerjet.SendKeys(Keys.Enter);
            Careerjet(driverCareerJet, sw, extraKeyword);
            driverCareerJet.Close();

            //start Careers24
            IWebDriver driverCareers24 = new ChromeDriver(options);

            driverCareers24.Url = "https://www.careers24.com/";
            IWebElement elementWhatCareers24 = driverCareers24.FindElement(By.Id("inSearch"));
            elementWhatCareers24.SendKeys(jobTitleOne);
            //todo menu select
            //driverCareers24.FindElement(By.XPath("//*[@id=\"rootItem\"]")).Click();
            //driverCareers24.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_contentHeaderPlaceHolder_c24basicjobsearch1_inLocation_locationContent\"]")).Click();
            ////driverCareers24.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_contentHeaderPlaceHolder_c24basicjobsearch1_inLocation_locationSelect_mn_active\"]/span")).Click();

            //IWebElement elementWheredriverCareers24 = driverCareers24.FindElement(By.XPath("//*[@id=\"rootItem\"]"));
            //elementWheredriverCareers24.Click();
            //SelectElement oSelect = new SelectElement(elementWheredriverCareers24);
            //IList<IWebElement> elementCount = oSelect.Options;
            //Console.Write(elementCount.Count);
            //int iSize = elementCount.Count;
            //for (int i = 0; i > iSize; i++)
            //{
            //    String sValue = elementCount.ElementAt(i).Text;
            //    Console.WriteLine(sValue);
            //}

            //driverCareers24.Url = "https://www.careers24.com/jobs/lc-johannesburg/kw-junior-developer/m-true/";


            driverCareers24.FindElement(By.XPath("//*[@id=\"ctl00_ctl00_contentHeaderPlaceHolder_c24basicjobsearch1_btnSearch\"]")).Click();
            Careers24(driverCareers24, sw);
            driverCareers24.Close();

            //end bit
            sw.Close();
            Process.Start("notepad.exe", file);//todo notepad++

            //Console.Close();

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
                sw.WriteLine("\n\n" + item.Text+"\n"+ item.GetAttribute("href"));
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

        public static void Careerjet(IWebDriver driver, StreamWriter sw, string extraKeyword)
        {

            for (int i = 0; i < 6; i++)
            {
                
                driver.FindElement(By.Id("more-jobs")).Click();
                Thread.Sleep(3000);
                
            }
            
            var titles = driver.FindElements(By.XPath("//*[contains(@class, 'job clicky')]"));

            foreach (var item in titles)
            {
                if (item.Text.ToLower().Contains(extraKeyword)) 
                {
                    Console.WriteLine("\n\n" + item.Text);
                    Console.WriteLine("https://www.careerjet.co.za/" + item.GetAttribute("data-url"));
                    sw.WriteLine("\n\n" + item.Text + "\n" + "https://www.careerjet.co.za/" + item.GetAttribute("data-url"));

                }

            }

            

            
        }

        public static void Pnet(IWebDriver driver, int pageCount, StreamWriter sw, string extraKeyword)
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

            var titles = driver.FindElements(By.XPath("//*[contains(@id, 'job-item')]"));
            var link = driver.FindElements(By.XPath("//*[contains(@href, '/jobs')]"));
            
            for (int i = 0; i < titles.Count; i++)
            {
                if (titles[i].Text.ToLower().Contains(extraKeyword))
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

                if(pageCount <= 20)
                {
                    driver.FindElement(By.XPath("//*[contains(@title, 'Next')]")).Click();

                    Pnet(driver, pageCount, sw, extraKeyword);
                }

                
            }catch(Exception e)
            {
                Console.WriteLine("\nNEXT BUTTON\n"+e);
            }
            
        }

        public static void Careerjunction(IWebDriver driver, StreamWriter sw)
        {
            Thread.Sleep(3500);
            
            var titles = driver.FindElements(By.XPath("//*[contains(@class, 'noUnderline jobTitle')]"));

            foreach (var item in titles)
            {
                Console.WriteLine("\n\n"+item.Text);
                Console.WriteLine(item.GetAttribute("href"));
                sw.WriteLine("\n\n" + item.Text+"\n"+ item.GetAttribute("href"));
            }

            try
            {
                
                driver.FindElement(By.ClassName("paginationNext")).Click();
                
                Careerjunction(driver, sw);
            }
            catch (Exception e)
            {
                Console.WriteLine("No Next Page!");
            }
        }

        public static void Indeed(IWebDriver driver, StreamWriter sw, string extraKeyword)
        {
            var titles = driver.FindElements(By.ClassName("title"));
            var summary = driver.FindElements(By.ClassName("summary"));
            var daysAgo = driver.FindElements(By.ClassName("jobsearch-SerpJobCard-footer"));
            var link = driver.FindElements(By.TagName("a"));

            for (int i = 0; i < titles.Count; i++)
            {
                if (!daysAgo[i].Text.Contains("30"))//&& titles[i].Text.ToLower().Contains(extraKeyword)
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
                IWebElement popup = driver.FindElement(By.Id("popover-email"));
                popup.SendKeys(Keys.Escape);
                Console.WriteLine("POP!!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("NO POP!");
            }
                Console.WriteLine("\nEND!");
                try
                {

                    driver.FindElement(By.XPath("//*[@id=\"resultsCol\"]/nav/div/ul/li[7]/a")).Click();
                    Console.WriteLine("CLICK!");
                    Indeed(driver, sw, extraKeyword);


                } catch (Exception exc) {
                    try
                    {
                        driver.FindElement(By.XPath("//*[@id=\"resultsCol\"]/nav/div/ul/li[6]/a")).Click();
                        Console.WriteLine("\nCLICK!!");
                        Indeed(driver, sw, extraKeyword);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nEND!!");
                    }

                }
        }
    }
}