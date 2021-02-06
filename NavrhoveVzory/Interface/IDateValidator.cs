using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavrhoveVzory.Interface
{
    interface IDateValidator
    {
        /// <summary>
        /// Check if date is Valid, if he/she can be alive
        /// </summary>
        /// <param name="s">DateTime of born</param>
        /// <returns>True/False</returns>
        bool IsValid(DateTime s);
    }
}
