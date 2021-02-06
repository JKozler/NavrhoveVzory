using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NavrhoveVzory.Interface;
namespace NavrhoveVzory.Validators
{
    public class BornNumberValidator : IBornNumberValidator
    {
        public bool IsValid(string s, int year)
        {
            if (year >= 1954)
            {
                string pattern = @"\d{6}.\d{4}";
                Match m = Regex.Match(s, pattern, RegexOptions.IgnoreCase);
                if (m.Success && s.Length == 11)
                    return true;
                else
                    return false;
                
            }
            string pattern2 = @"\d{6}.\d{3}";
            Match m2 = Regex.Match(s, pattern2, RegexOptions.IgnoreCase);
            if (m2.Success && s.Length == 10)
                return true;


            return false;
        }
    }
}
