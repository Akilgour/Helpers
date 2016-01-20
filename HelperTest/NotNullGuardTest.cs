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
   public class NotNullGuardTest
    {
        private string errorMessage = "{0} is null, this is not allowed.";

        [Test]
        public void CheckStringValue_Okay ()
        {
            //Arrange
            var value = "string value";

            //Act
            NotNullGuard.Check(value);

            //Assert
            Assert.True(true);
        }

        [Test]
        public void CheckIntValue_Okay()
        {
            //Arrange
            var value = 1;

            //Act
            NotNullGuard.Check(value);

            //Assert
            Assert.True(true);
        }

        [Test]
        public void CheckDateTimeValue_Okay()
        {
            //Arrange
            var value = DateTime.Now;

            //Act
            NotNullGuard.Check(value);

            //Assert
            Assert.True(true);
        }


        [Test]
        public void CheckNullableIntValue_Throw()
        {
            //Arrange
            int? value = null;

            //Act
            var ex = Assert.Catch<ArgumentNullException>(() => NotNullGuard.Check(value));

            //Assert
            StringAssert.Equals(string.Format(errorMessage, "value"), ex.Message);
        }

        [Test]
        public void CheckStringValue_Throw()
        {
            //Arrange
            string value = null;

            //Act
            var ex = Assert.Catch<ArgumentNullException>(() => NotNullGuard.Check(value));

            //Assert
            StringAssert.Equals(string.Format(errorMessage,"value"), ex.Message);
        }
    }
}
