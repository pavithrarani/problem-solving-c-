using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving;


namespace TEST
{
    [TestClass]
    public class FindPointTest
    {
        [TestMethod]
        public void ShouldReturnTrueIfPointLiesInsideTriangle()
        {
            var fp = new FindPoint();
            var p1 = new FindPoint.Point(0, 0);
            var p2 = new FindPoint.Point(0, 4);
            var p3 = new FindPoint.Point(5, 0);


            FindPoint.Point[] triangle = { p1, p2, p3 };
            var newp = new FindPoint.Point(2, 1);


            var res = fp.compute(new[] { p1, p2, p3 }, newp);
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void ShouldReturnFalseIfPointLiesOutsideTriangle()
        {
            var fp = new FindPoint();
            var p1 = new FindPoint.Point(0, 0);
            var p2 = new FindPoint.Point(0, 4);
            var p3 = new FindPoint.Point(5, 0);


            FindPoint.Point[] triangle = { p1, p2, p3 };
            var newp = new FindPoint.Point(3, 3);


            var res = fp.compute(new[] { p1, p2, p3 }, newp);
            Assert.AreEqual(false, res);
        }
    }
}
