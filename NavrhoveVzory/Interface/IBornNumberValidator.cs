using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavrhoveVzory.Interface
{
    interface IBornNumberValidator
    {
        /// <summary>
        /// Check if born number is allright
        /// </summary>
        /// <param name="s">Born Number</param>
        /// <param name="year">Year</param>
        /// <returns>True/False</returns>
        bool IsValid(string s, int year);
    }
}
