﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejexValidationTest
{
    public class UnitTest
    {
        [Test]
        public void InputInString_Test_FirstNameOfUser()
        {
            Validation input = new Validation();
            bool result = input.Validate_FirstName("Manasi");
            Assert.IsTrue(result);
        }
          public void InputInString_Test_LastNameOfUser()
        {
            Validation input = new Validation();
            bool result = input.Validate_FirstName("Saner");
            Assert.IsTrue(result);
        }
    }
}
