using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestName() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Maximiliano", "4.364.951-6", "16/05/1991");
            string expected = "Maximiliano";
            Assert.AreEqual(expected, p.Name);
        }

        [Test]
        public void TestID() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Maximiliano", "4.364.951-6", "16/05/1991");
            string expected = "4.364.951-6";
            Assert.AreEqual(expected, p.ID);
        }

        [Test]
        public void TestBirthday() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Maximiliano", "4.364.951-6", "16/05/1991");
            string expected = "16/05/1991";
            Assert.AreEqual(expected, p.Birthday);
        }
    }
}