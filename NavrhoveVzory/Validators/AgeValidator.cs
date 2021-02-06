using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavrhoveVzory.Interface;

namespace NavrhoveVzory.Validators
{
    public class AgeValidator : IDateValidator
    {
        public bool IsValid(DateTime s)
        {
            DateTime now = DateTime.Now;

            if (now.Year - s.Year <= 130)
                return true;

            return false;
        }
    }
}
