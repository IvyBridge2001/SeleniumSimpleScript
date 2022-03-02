// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


Console.WriteLine("Beginning Test");

new DriverManager().SetUpDriver(new ChromeConfig());


ChromeDriver driver = new ChromeDriver();
ChromeDriver driver2 = new ChromeDriver();
ChromeDriver driver3 = new ChromeDriver();

driver.Navigate().GoToUrl("https://www.google.com");
driver2.Navigate().GoToUrl("https://www.google.com");
driver3.Navigate().GoToUrl("https://www.google.com");

var searchBox = driver.FindElement(By.Name("q"));
var searchButton = driver.FindElement(By.Name("btnK"));

var searchBox2 = driver2.FindElement(By.Name("q"));
var searchButton2 = driver2.FindElement(By.Name("btnK"));

var searchBox3 = driver3.FindElement(By.Name("q"));
var searchButton3 = driver3.FindElement(By.Name("btnK"));

searchBox.SendKeys("Selenium");
searchBox2.SendKeys("Selenium");
searchBox3.SendKeys("Selenium");

searchButton.Click();
searchButton2.Click();
searchButton3.Click();

driver.Quit();
driver2.Quit();
driver3.Quit();

Console.WriteLine("Test successfull. Press any button to exit");
Console.ReadKey();


//ChromeOptions chromeOptions = new ChromeOptions();

////Set Chrome to work with incognito mode
//chromeOptions.AddArguments("incognito");
//another option is headless