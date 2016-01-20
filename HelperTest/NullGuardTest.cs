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
   public class NullGuardTest
    {
        private string errorMessage = "Object reference not set to an instance of an object.";

        [Test]
        public void CheckStringValue_Okay ()
        {
            //Arrange
            var value = "string value";

            //Act
            NullGuard.Check(value);

            //Assert
            Assert.True(true);
        }

        [Test]
        public void CheckIntValue_Okay()
        {
            //Arrange
            var value = 1;

            //Act
            NullGuard.Check(value);

            //Assert
            Assert.True(true);
        }

        [Test]
        public void CheckDateTimeValue_Okay()
        {
            //Arrange
            var value = DateTime.Now;

            //Act
            NullGuard.Check(value);

            //Assert
            Assert.True(true);
        }


        [Test]
        public void CheckNullableIntValue_Throw()
        {
            //Arrange
            int? value = null;

            //Act
            var ex = Assert.Catch<ArgumentNullException>(() => NullGuard.Check(value));

            //Assert
            Assert.AreEqual(errorMessage, ex.ParamName);
        }

        [Test]
        public void CheckStringValue_Throw()
        {
            //Arrange
            string value = null;

            //Act
            var ex = Assert.Catch<ArgumentNullException>(() => NullGuard.Check(value));

            //Assert
            Assert.AreEqual(errorMessage, ex.ParamName);
        }
    }
}
