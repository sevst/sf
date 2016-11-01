namespace UnitTests
{
    [NUnit.Framework.TestFixture]
    public class Class1
    {
        [NUnit.Framework.Test]
        public void SomeTest()
        {
            NUnit.Framework.Assert.AreEqual(1,1);
        }

        [NUnit.Framework.Test]
        public void SomeOtherTest()
        {
            NUnit.Framework.Assert.AreEqual(1, 1);
        }
    }
}
