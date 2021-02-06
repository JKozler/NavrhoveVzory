using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavrhoveVzory.Validators;

namespace NavrhoveVzory.Models
{
    public class People
    {
        NameValidator nameValidator = new NameValidator();
        BornNumberValidator bornNumber = new BornNumberValidator();
        AgeValidator ageValidator = new AgeValidator();

        private string jmeno;

        public string Jmeno
        {
            get { return jmeno; }
            set {
                if (nameValidator.IsValid(value))
                    jmeno = value;
                else
                    throw new ArgumentException("Name is in incorrect format.");
            }
        }

        private string prijmeni;

        public string Prijmeni
        {
            get { return prijmeni; }
            set
            {
                if (nameValidator.IsValid(value))
                    prijmeni = value;
                else
                    throw new ArgumentException("Second name is in incorrect format.");
            }
        }
        private DateTime datumNarozeni;

        public DateTime DatumNarozeni
        {
            get { return datumNarozeni; }
            set {
                if (ageValidator.IsValid(value))
                    datumNarozeni = value;
                else
                    throw new ArgumentException("Birth date is in incorrect format.");
            }
        }

        private string rodneCislo;

        public string RodneCislo
        {
            get { return rodneCislo; }
            set {
                if (bornNumber.IsValid(value, DatumNarozeni.Year))
                    rodneCislo = value;
                else
                    throw new ArgumentException("Personal ID number is in incorrect format.");
            }
        }

        public People(string jmeno, string prijmeni, DateTime datumNarozeni, string rodneCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            RodneCislo = rodneCislo;
        }
        public People(){}
    }
}
