using CSharpSelenium.Core;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharpSelenium.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var numbers = new List<int> { 1, 2, 4, 5, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            numbers.Distinct();
            var sorted = numbers.OrderBy(x => x);
            var SortedDesc = numbers.OrderByDescending(x => x);



            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            var input = "5 2 22 1";
            var sorted = input.Split(' ').Select(int.Parse).OrderBy(x => x).ToList();


            Assert.Pass();
        }
        [Test]
        public void Test3()
        {
            var data = "Value: 59; Value: 4; Value: 20";
            var sorted = data.Split(';').Select(s => int.Parse(Regex.Match(s, @"\d+").Value)).OrderBy(x => x).ToList();

            Assert.Pass();
        }
        [Test]
        public void Test4()
        {
            var uiPrices = new List<decimal> { 10.4m, 11.4m, 323.4m };
            var sorted = uiPrices.OrderBy(x => x).ToList();

            bool isTrue = uiPrices.SequenceEqual(sorted);
            Assert.Pass();
        }
        [Test]
        public void Test5()
        {
            var config = new ConfigReader();
            var browser = $"Browser: {config.Get("Browser")}";
            var baseURL = $"BaseURL: {config.Get("BaseURL")}";
            var timeout = $"Timeout: {config.GetInt("Timeout")}";
            var headless = $"Headless: {config.GetBool("Headless")}";
        }
    }
}