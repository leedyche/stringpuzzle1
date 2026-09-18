namespace StringTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void GivenTest()
        {

            string input = "nepo";

            string expected = "openerent";

            string actual = StringPuzzle.StringPuzzle.Solve(input);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void NullTest()
        {

            string input = null;

            string expected = "";

            string actual = StringPuzzle.StringPuzzle.Solve(input);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void BlankTest()
        {

            string input = "";

            string expected = "";

            string actual = StringPuzzle.StringPuzzle.Solve(input);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void RandomOddTest()
        {

            string input = "dsfhgsdu";

            //reverse it - udsghfsd
            //earliest is d
            //vowel count ({ 'a', 'e', 'i', 'o', 'u' };) is 1
            //udsghfsddopen

            string expected = "udsghfsddopen";

            string actual = StringPuzzle.StringPuzzle.Solve(input);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void RandomEvenTest()
        {

            string input = "dsfhgsau";

            //reverse it - udsghfsd
            //earliest is a
            //vowel count ({ 'a', 'e', 'i', 'o', 'u' };) is 2
            //uasghfsdarent

            string expected = "uasghfsdarent";

            string actual = StringPuzzle.StringPuzzle.Solve(input);

            Assert.AreEqual(expected, actual);

        }


    }
}
