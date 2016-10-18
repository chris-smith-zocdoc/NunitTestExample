using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;

namespace TestProjectOne
{
    public class Class1
    {
        [TestCase(10)]
        [TestCase(100)]
        [TestCase(1000)]
        public void MyTestCase(int num)
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(num));
        }
    }

    public class Class2
    {
        [TestCase(10)]
        [TestCase(100)]
        [TestCase(1000)]
        public void MyTestCase(int num)
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(num));
        }
    }
}
