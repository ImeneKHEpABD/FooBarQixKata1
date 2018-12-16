using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQixToolkit
{
    public class FooBarQixRuleContains: FooBarQixAbstractRules
    {
        #region Attributes
        
        public Dictionary<int, string> DicContainsRules = new Dictionary<int, string>
        {
            [3] = "Foo",
            [5] = "Bar",
            [7] = "Qix",
            [0] = "*"
        };
        #endregion
        #region Constructor
        public FooBarQixRuleContains()
        {
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the string that corresponds to the digit included in the contains rules.
        /// </summary>
        /// <param name="number">The digit to be replaced by the correspondant string from the DicContainsRules if possible</param>
        /// <returns>The string returned after applying the contains rules</returns>
        public override string ApplyRule(string number)
        {
            var result = string.Empty;
            int key;
            try
            {
                key = Int16.Parse(number);
                if (DicContainsRules.ContainsKey(key))
                    result += DicContainsRules[key];
            }
            catch (Exception ex)
            {
               
            }
            return result;

        }
        #endregion
    }
}
