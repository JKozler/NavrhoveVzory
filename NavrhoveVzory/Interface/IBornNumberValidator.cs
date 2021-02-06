using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavrhoveVzory.Interface
{
    interface IBornNumberValidator
    {
        bool IsValid(string s, int year);
    }
}
