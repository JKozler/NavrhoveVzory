using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavrhoveVzory.Interface
{
    interface IStringValidator
    {
        /// <summary>
        /// Check if string format is allright (fisrt name and last name)
        /// </summary>
        /// <param name="s">First Name or Last name</param>
        /// <returns>Tru/False</returns>
       bool IsValid(string s);
    }
}
