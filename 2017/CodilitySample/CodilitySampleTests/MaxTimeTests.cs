using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodilitySample;

namespace CodilitySampleTests
{
    [TestClass]
    public class when_getting_max_time_of_1_2_3_4
    {
        [TestMethod]
        public void should_return_23_41()
        {
            var maxTime = new MaxTime();
            var max = maxTime.Get(1, 2, 3, 4);

            Assert.AreEqual<string>("23:41", max);
        }
    }

    [TestClass]
    public class when_getting_max_time_of_9_9_1_1
    {
        [TestMethod]
        public void should_return_19_19()
        {
            var maxTime = new MaxTime();
            var max = maxTime.Get(9,9,1,1);

            Assert.AreEqual<string>("19:19", max);
        }
    }

    [TestClass]
    public class when_getting_max_time_of_5_0_1_0
    {
        [TestMethod]
        public void should_return_15_00()
        {
            var maxTime = new MaxTime();
            var max = maxTime.Get(5,0,1,0);

            Assert.AreEqual<string>("15:00", max);
        }
    }

    [TestClass]
    public class when_getting_max_time_of_2_4_4_5
    {
        [TestMethod]
        public void should_return_NOT_POSSIBLE()
        {
            var maxTime = new MaxTime();
            var max = maxTime.Get(2,4,4,5);

            Assert.AreEqual<string>("NOT POSSIBLE", max);
        }
    }

    [TestClass]
    public class when_getting_max_time_of_10_10_10_10
    {
        [TestMethod]
        public void should_return_NOT_POSSIBLE()
        {
            var maxTime = new MaxTime();
            var max = maxTime.Get(10,10,10,10);

            Assert.AreEqual<string>("NOT POSSIBLE", max);
        }
    }

    [TestClass]
    public class when_getting_max_time_of_0_0_0_0
    {
        [TestMethod]
        public void should_return_NOT_POSSIBLE()
        {
            var maxTime = new MaxTime();
            var max = maxTime.Get(0,0,0,0);

            Assert.AreEqual<string>("00:00", max);
        }
    }
}
