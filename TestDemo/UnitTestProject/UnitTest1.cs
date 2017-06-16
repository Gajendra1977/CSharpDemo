using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDemo;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RoundUpDateTest()
        {
            DoTest("2015-05-18 07:01", "2015-05-18 07:00");
            DoTest("2015-05-18 07:07", "2015-05-18 07:00");
            DoTest("2015-05-18 07:08", "2015-05-18 07:15");
            DoTest("2015-05-18 07:32", "2015-05-18 07:30");
            DoTest("2015-05-18 07:38", "2015-05-18 07:45");
            DoTest("2015-05-18 07:47", "2015-05-18 07:45");
            DoTest("2015-05-18 07:52", "2015-05-18 07:45");
            DoTest("2015-05-18 07:53", "2015-05-18 08:00");
        }


        public static void DoTest(string enteredValue, string expectedValue)
        {

            try
            {
                BusinessLogic clsBULogic = new BusinessLogic();
                string result = clsBULogic.RoundUpDate(enteredValue);

                Assert.AreEqual(result, expectedValue);
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed for values " + enteredValue);
            }
        }
    }
}
