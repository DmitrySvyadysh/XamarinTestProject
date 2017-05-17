using NUnit.Framework;

namespace XamarinTestProject.TestConsole
{
    [TestFixture]
    public class MathHelperTest
    {
        [Test]
        public void Max_ShouldReturnirst()
        {
            var mathHelper = new MathHelper();
            int result = mathHelper.Max(2, 1);
            Assert.AreEqual(2, result);
        }
    }
}
