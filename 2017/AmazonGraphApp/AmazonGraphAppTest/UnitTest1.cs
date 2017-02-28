using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AmazonGraphAppLib;

namespace AmazonGraphAppTest
{
    [TestClass]
    public class when_group_count_2
    {
        [TestMethod]
        public void should_return_2()
        {
            var ar = new int[][] {  new int[]{1, 1, 0, 0, 0},
                                    new int[]{0, 0, 0, 0, 1},
                                    new int[]{1, 0, 0, 1, 1},
                                    new int[]{1, 1, 1, 0, 1},
                                    new int[]{1, 0, 1, 0, 1} };

            var grouper = new BitmapGrouper();
            var cnt = grouper.GetGroupCountFromBitmap(ar);

            Assert.AreEqual<int>(2, cnt);
        }
    }

    [TestClass]
    public class when_group_count_3
    {
        [TestMethod]
        public void should_return_3()
        {
            var ar = new int[][] {  new int[]{0, 0, 1, 0, 0, 1},
                                    new int[]{1, 0, 1, 0, 1, 1},
                                    new int[]{1, 1, 1, 0, 0, 1},
                                    new int[]{0, 0, 0, 1, 0, 0},
                                    new int[]{0, 0, 0, 0, 0, 1} };

            var grouper = new BitmapGrouper();
            var cnt = grouper.GetGroupCountFromBitmap(ar);

            Assert.AreEqual<int>(3, cnt);
        }
    }

    [TestClass]
    public class when_group_count_1
    {
        [TestMethod]
        public void should_return_1()
        {
            var ar = new int[][] {  new int[]{0, 0, 1, 0, 0, 1},
                                    new int[]{1, 0, 1, 0, 1, 1},
                                    new int[]{1, 1, 1, 1, 0, 1},
                                    new int[]{0, 0, 0, 1, 0, 0},
                                    new int[]{0, 0, 0, 0, 1, 1} };

            var grouper = new BitmapGrouper();
            var cnt = grouper.GetGroupCountFromBitmap(ar);

            Assert.AreEqual<int>(1, cnt);
        }
    }

    [TestClass]
    public class when_group_count_4
    {
        [TestMethod]
        public void should_return_4()
        {
            var ar = new int[][] {  new int[]{0, 0, 1, 0, 0, 1},
                                    new int[]{1, 0, 1, 0, 0, 0},
                                    new int[]{1, 0, 1, 1, 0, 1},
                                    new int[]{0, 0, 0, 1, 0, 0},
                                    new int[]{0, 0, 0, 0, 1, 1} };

            var grouper = new BitmapGrouper();
            var cnt = grouper.GetGroupCountFromBitmap(ar);

            Assert.AreEqual<int>(4, cnt);
        }
    }


    [TestClass]
    public class when_group_count_5
    {
        [TestMethod]
        public void should_return_5()
        {
            var ar = new int[][] {  new int[]{0, 0, 1, 0, 0, 1, 0, 0},
                                    new int[]{1, 0, 1, 0, 0, 1, 0, 0},
                                    new int[]{1, 0, 1, 1, 0, 1, 0, 1},
                                    new int[]{0, 0, 0, 1, 0, 0, 0, 0},
                                    new int[]{0, 0, 0, 1, 0, 1, 1, 1},
                                    new int[]{0, 0, 0, 1, 0, 0, 0, 1},
                                    new int[]{0, 0, 0, 0, 1, 1, 0, 1} };

            var grouper = new BitmapGrouper();
            var cnt = grouper.GetGroupCountFromBitmap(ar);

            Assert.AreEqual<int>(5, cnt);
        }
    }

}
