using Microsoft.VisualStudio.TestTools.UnitTesting;
using problems;
namespace TEST
{
    [TestClass]
    public class SafeUnsafeTest
    {
        [TestMethod]
        public void ShouldReturnTrueIfSafe()
        {
            var obj = new SafeUnsafe();
            string[] pattern =
            {
                "SSUSS", "SSUSSUSS", "SSUSSUSUUUS", "SSSSSSS", "SSUSUUSUUS", "SSUSSUSUUSUUUSUUUUS"
            };
            var jump = 1;

            int i;
            for (i = 0; i < pattern.Length; i++)
            {
                var res = obj.split(pattern[i], jump);
                Assert.AreEqual(true, res);
            }
        }

        [TestMethod]
        public void ShouldReturnFailIfUnsafe()
        {
            var obj = new SafeUnsafe();
            string[] pattern =
            {
                "SSU", "SSUSSUSUUUSS", "U", "SSUSSUSUUUUSUUUS", "SSUSSUSUUUSS"
            };
            var jump = 1;
            var start = jump;
            int i;
            for (i = 0; i < pattern.Length; i++)
            {
                var res = obj.split(pattern[i], jump);
                Assert.AreEqual(false, res);
            }
        }
    }
}
