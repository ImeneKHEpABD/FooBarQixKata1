using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQixToolkit
{
    public class FooBarQix
    {
        private FooBarQixOperations foobarqixoperations;

        public FooBarQix(FooBarQixOperations opM)
        {
            
            foobarqixoperations = opM;
        }

        /// <summary>
        /// Evaluate the string using the division and contains rules.
        /// </summary>
        /// <param name="number">The  string number to be evaluated</param>
        /// <returns>The string returned after applying the division and the container rules</returns>
        public string Compute(string number)
        {
            try
            {
                return foobarqixoperations.EvaluateRules(number);
            }
            catch (Exception ex)
            {
                
                return string.Empty;
            }

        }
    }
}
