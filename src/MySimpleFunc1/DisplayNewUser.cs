using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MySimpleFunc1
{
    public class DisplayNewUser
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(NewUser input, ILambdaContext context)
        {
            LambdaLogger.Log($"Calling function name: {context.FunctionName}\\n");              // Relays log to AWS CloudWatch if conditions met
            return $"Welcome: {input.FirstName.ToUpper()} {input.LastName.ToUpper()}";          // returning the upper-cased values of our NewUser model

        }
    }
}
