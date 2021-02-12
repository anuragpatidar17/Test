﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    class Program
    {
        public static void Main(string[] args)
        {
            var driver = new ChromeDriver();

            

                driver.Navigate().GoToUrl("http://www.google.com/");


                IWebElement query = driver.FindElement(By.Name("q"));


            Console.WriteLine(driver.Title + " Checking");


                query.Submit();



                driver.Quit();
            
        }
    }
}
