using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using MySimpleFunc1;

namespace MySimpleFunc1.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {

            // Invoke the lambda function and confirm the string was upper cased.
            var function = new DisplayNewUser();
            var context = new TestLambdaContext();
            var newUser = new NewUser();
            newUser.FirstName = "Marianne";
            newUser.LastName = "Zaricor";
            var upperCase = function.FunctionHandler(newUser, context);

            Assert.Equal("Marianne Zaricor", upperCase);
        }
    }
}
