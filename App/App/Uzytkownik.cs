using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    enum RodzajUzytkownika { nadawca, odbiorca };
    class Uzytkownik
    {
        private RodzajUzytkownika rodzaj;
        private bool odbior_; //czy uzytkownik ustawil sie w kolejce po odbior czy nie
        private Paczka pocket_; //paczka posiadana przez usera, albo przed wysłaniem, albo po odebraniu.
        private Paczkomat paczkomat_;
        private string nazwa_uzytkownika_;
        public string Nazwa_Uzytkownika
        {
            get
            {
                return this.nazwa_uzytkownika_;
            }
        }
        public Paczka Pocket
        {
            get
            {
                return this.pocket_;
            }
            set
            {
                this.pocket_ = value;
            }
        }
        public Paczkomat Paczkomat
        {
            get
            {
                return this.paczkomat_;
            }
        }
        public bool Odbior
        {
            get
            {
                return this.odbior_;
            }
        }
        public Uzytkownik(RodzajUzytkownika rodzaj, string nazwa, Paczkomat paczkomat)
        {
            this.rodzaj = rodzaj;
            this.nazwa_uzytkownika_ = nazwa;
            this.paczkomat_ = paczkomat;
            if (this.rodzaj == RodzajUzytkownika.odbiorca)
            {
                this.odbior_ = true; //jeżeli użytkownik ustawił się w kolejce po odbiór, to jest odbiorcą
            }
        }

    }
}
