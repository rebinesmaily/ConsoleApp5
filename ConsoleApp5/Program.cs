using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RestSharp;
using static System.Console;
namespace SeleniumSandbox
{
    internal class Program
    {
        private const string ChromeDriverContainer = @"G:\programs\chromedriver\";
        private const string SignUpForm = "https://www.instagram.com/accounts/emailsignup/";
        public static void Main()
        {

            //var webDriver = new ChromeDriver(ChromeDriverContainer);
            //webDriver.Navigate().GoToUrl(SignUpForm);
            //webDriver.FindElementByName("emailOrPhone").SendKeys(getText(10)+"@gmail.com");
            //webDriver.FindElementByName("fullName").SendKeys("Farhad SagDast");
            //webDriver.FindElementByName("username").SendKeys(getText(8));
            //webDriver.FindElementByName("password").SendKeys("M@aypas12345!#"); 
            //webDriver.FindElementByName("password").Submit();
            //Thread.Sleep(10000);
            //var findYear = webDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div[1]/div/div[4]/div/div/span/span[3]/select");
            //var yearSelect = new SelectElement(findYear);
            //var findMonth = webDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div[1]/div/div[4]/div/div/span/span[1]/select");
            //var monthSelect = new SelectElement(findMonth);
            //var findDay = webDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div[1]/div/div[4]/div/div/span/span[2]/select");
            //var daySelect = new SelectElement(findDay);
            //yearSelect.SelectByIndex(15);
            //monthSelect.SelectByIndex(5);
            //daySelect.SelectByIndex(14);
            //webDriver.FindElementByXPath("/html/body/div[1]/section/main/div/div/div[1]/div/div[6]").Click();
            ////*********Fake mail
            FakeMail();
            //webDriver.FindElementByClassName("sqdOP  L3NKy   y3zKF     ").Submit();
            ReadKey();
        }

        public static string getText(int length)
        {
            string[] Chars = { "A", "a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f", "G", "g", "H", "h", "I", "i", "J", "j", "K", "k", "L", "l", "M", "m", "N", "n", "O", "o", "P", "p", "Q", "q", "R", "r", "S", "s", "T", "t", "U", "u", "V", "v", "W", "w", "X", "x", "Y", "y", "Z", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            Random randomNumber = new Random();
            string Text = "";
            for (int i = 0; i < length; i++)
            {
                Text += Chars[randomNumber.Next(Chars.Length)];
            }

            return Text;
        }

        public static async void FakeMail()
        {
           
                    var client = new HttpClient();
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri("https://privatix-temp-mail-v1.p.rapidapi.com/request/mail/id/null/"),
                        Headers =
                   {
                    { "x-rapidapi-key", "17cb10e248mshee164ebe1495d1ep153d19jsn905917770794" },
                    { "x-rapidapi-host", "privatix-temp-mail-v1.p.rapidapi.com" },
                   },
                    };
                    using (var response = await client.SendAsync(request))
                    {
                       // response.EnsureSuccessStatusCode();
                        var body = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(body);
                    }
        }
    }
}