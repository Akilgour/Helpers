using Helper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperTest
{
    [TestFixture]
    public class SystemDateTimeTest
    {
        [Test]
        public void SystemTimeIsNow()
        {

            //Arrange
            var now = DateTime.Now;

            //Act
            var systemNow = SystemTime.Now;

            //Asset 
            Assert.AreEqual(now, systemNow);
        }

        [Test]
        public void SystemTimeShortDateIsNow()
        {

            //Arrange
            var now = DateTime.Now.ToShortDateString();

            //Act
            var systemNow = SystemTime.Now.ToShortDateString();

            //Asset 
            Assert.AreEqual(now, systemNow);
        }

        [Test]
        public void SystemTimeReset()
        {

            //Arrange
            var now = DateTime.Now;
            var notNow = new DateTime(2001, 1, 3, 3, 4, 5);

            //Act
            SystemTime.Set(notNow);
            SystemTime.Reset();
            var systemNow = SystemTime.Now;

            //Asset 
            Assert.AreEqual(now, systemNow);
        }

        [Test]
        public void SystemTimeSet()
        {

            //Arrange
            var now = DateTime.Now;
            var notNow = new DateTime(2001, 1, 3, 3, 4, 5);

            //Act
            SystemTime.Set(notNow);
            var systemNow = SystemTime.Now;

            //Asset 
            Assert.AreEqual(now, systemNow);
        }


    }
}
