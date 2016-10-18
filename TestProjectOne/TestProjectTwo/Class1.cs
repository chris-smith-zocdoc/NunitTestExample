using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;

namespace TestProjectTwo
{
    public class Class1
    {
        [TestCase(20)]
        [TestCase(200)]
        [TestCase(2000)]
        public void AnotherTestCase(int num)
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(num));
        }
    }

    public class Class2
    {
        [TestCase(20)]
        [TestCase(200)]
        [TestCase(2000)]
        public void AnotherTestCase(int num)
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(num));
        }
    }
}
