using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavrhoveVzory.Models;
using GalaSoft.MvvmLight.Command;
using System.Diagnostics;
using System.Windows.Input;

namespace NavrhoveVzory.ViewModels
{
    public class PeopleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        #region Properities
        private string jmeno;

        public string Jmeno
        {
            get { return jmeno; }
            set {
                jmeno = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Jmeno)));
            }
        }

        private string prijmeni;

        public string Prijmeni
        {
            get { return prijmeni; }
            set
            {
                prijmeni = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Prijmeni)));
            }
        }

        private DateTime datumNarozeni;

        public DateTime DatumNarozeni
        {
            get { return datumNarozeni; }
            set
            {
                datumNarozeni = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DatumNarozeni)));
            }
        }

        private string rodneCislo;

        public string RodneCislo
        {
            get { return rodneCislo; }
            set
            {
                rodneCislo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RodneCislo)));
            }
        }

        private List<string> peopleItems;

        public List<string> PeopleItems
        {
            get { return peopleItems; }
            set { 
                peopleItems = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PeopleItems)));
            }
        }
        #endregion

        public PeopleViewModel()
        {
            DatumNarozeni = DateTime.Now;
            if (DBPeople.PeopleDatabase.dbPeople.Count == 0)
            {
                Jmeno = "";
            }
            else
            {
                Jmeno = DBPeople.PeopleDatabase.dbPeople[DBPeople.PeopleDatabase.dbPeople.Values.Last().RodneCislo].Jmeno;
            }
        }


        private static ICommand _sendCommand;

        public ICommand SendCommand
        {
            get
            {
                if (_sendCommand == null)
                {
                    _sendCommand = new RelayCommand(
                        () => {
                            // Tady je práce, která se má odmakat, když se spustí command
                            Debug.WriteLine(Jmeno);

                            // Uložení do modelu
                            PeopleItems = new List<string>();
                            People people = new People(Jmeno, Prijmeni, DatumNarozeni, RodneCislo);
                            DBPeople.PeopleDatabase.dbPeople.Add(RodneCislo, people);
                            foreach (var item in DBPeople.PeopleDatabase.dbPeople)
                            {
                                PeopleItems.Add(item.Value.Jmeno + " " + item.Value.Prijmeni + " - " + item.Value.RodneCislo);
                            }
                            Jmeno = "";
                            Prijmeni = "";
                            RodneCislo = "";
                            DatumNarozeni = DateTime.Now;
                        });
                }
                return _sendCommand;
            }
        }
    }
}
