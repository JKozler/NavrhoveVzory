using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavrhoveVzory.Interface;

namespace NavrhoveVzory.Validators
{
    public class NameValidator : IStringValidator
    {
        public bool IsValid(string s) { return s.Length > 1; }
    }
}
