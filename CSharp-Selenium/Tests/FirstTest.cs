

namespace CSharpSelenium.Tests
{
    public class FirstTest : Base.BaseTest
    {
        //attributes
        [TestCase("https://google.com", "Google")]
        [TestCase("https://bing.com", "Bing")]
        public void FirstTetst(string url, string title)
        {
            Driver.Navigate().GoToUrl(url);
            Assert.That(Driver.Title.Contains(title));
            //            MSTest NUnit аналог Пояснение
            //Assert.IsTrue(cond) Assert.That(cond, Is.True)  Проверка true
            //Assert.IsFalse(cond)    Assert.That(cond, Is.False) Проверка false
            //Assert.AreEqual(a, b)    Assert.That(a, Is.EqualTo(b))   Сравнение значений
            //Assert.AreNotEqual(a, b) Assert.That(a, Is.Not.EqualTo(b))   Не равны
            //Assert.Fail()   Assert.Fail()   Принудительный фейл
            //Assert.IsNull(obj)  Assert.That(obj, Is.Null)   null
            //Assert.IsNotNull(obj)   Assert.That(obj, Is.Not.Null)   Not null
            //Assert.IsInstanceOf<T>(obj) Assert.That(obj, Is.InstanceOf<T>())

            //            Matcher Пример  Назначение
            //Does.Contain()  Does.Contain("Google")  поиск строки
            //Does.StartWith()    Does.StartWith("Hello") начинается с
            //Does.Match(regex)   Does.Match(@"^\d{3}$")  Regex
            //Is.Empty Assert.That(list, Is.Empty) пустой
            //Is.Not.Empty Assert.That(list, Is.Not.Empty) не пуст
            //Is.GreaterThan()    Is.GreaterThan(5)   больше
            //Is.LessThan()   Is.LessThan(10) меньше

//            В NUnit они делятся на
//Категория   Примеры Значение
//Lifecycle[SetUp], [TearDown], [OneTimeSetUp] Управляют жизненным циклом теста
//Marks[Test], [TestCase], [Ignore] Помечают тесты
//Data[TestCase], [Values] Параметры тестов
//Class - level[TestFixture]   Помечают тестовый класс
        }
    }
}
