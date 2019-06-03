using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace App
{
    class Paczka
    {
        private string nazwa_;
        private Uzytkownik nadawca_;
        private Uzytkownik odbiorca_;
        private Form1 form;
        public string Nazwa
        {
            get
            {
                return this.nazwa_;
            }
        }
        public Uzytkownik Nadawca
        {
            get
            {
                return this.nadawca_;
            }
        }
        public Uzytkownik Odbiorca
        {
            get
            {
                return this.odbiorca_;
            }
        }

        public void wyslij_paczke() //włożenie paczki do paczkomatu
        {

            if (this.nadawca_.Paczkomat.Numer == NumeryPaczkomatow.jeden)
            {
                
                this.form.ServedP1.Invoke(new Action(delegate ()
                {
                    this.form.ServedP1.Items.Add(this.nadawca_.Nazwa_Uzytkownika + " - korzystam");
                }));
                this.form.Queue1.Invoke(new Action(delegate ()
                {
                    this.form.Queue1.Items.RemoveAt(0);
                }));
               
            }
            else if (this.nadawca_.Paczkomat.Numer == NumeryPaczkomatow.dwa)
                {
                
                this.form.ServedP2.Invoke(new Action(delegate ()
                {
                    this.form.ServedP2.Items.Add(this.nadawca_.Nazwa_Uzytkownika + " - korzystam");
                }));
                this.form.Queue2.Invoke(new Action(delegate ()
                {
                    this.form.Queue2.Items.RemoveAt(0);
                }));
                
            }
            else if (this.nadawca_.Paczkomat.Numer == NumeryPaczkomatow.trzy)
                {
                
                this.form.ServedP3.Invoke(new Action(delegate ()
                {
                    this.form.ServedP3.Items.Add(this.nadawca_.Nazwa_Uzytkownika + " - korzystam");
                }));
                this.form.Queue3.Invoke(new Action(delegate ()
                {
                    this.form.Queue3.Items.RemoveAt(0);
                }));
                
            }
            Thread.Sleep(1000);
            Semafor.Semafor1.WaitOne();
            this.nadawca_.Paczkomat.ListWys.Add(this);
            Semafor.Semafor1.Release();
           
            if (this.nadawca_.Paczkomat.Numer == NumeryPaczkomatow.jeden)
            {
               
                this.form.ServedP1.Invoke(new Action(delegate ()
                {
                    this.form.ServedP1.Items.Clear();
                }));
               
            }
            else if (this.nadawca_.Paczkomat.Numer == NumeryPaczkomatow.dwa)
            {
               
                this.form.ServedP2.Invoke(new Action(delegate ()
                {
                    this.form.ServedP2.Items.Clear();
                }));
               
            }
            else if (this.nadawca_.Paczkomat.Numer == NumeryPaczkomatow.trzy)
            {
              
                this.form.ServedP3.Invoke(new Action(delegate ()
                {
                    this.form.ServedP3.Items.Clear();
                }));
                
            }

            wait();   
        }
        public void odbierz_paczke()
        {

            if (this.odbiorca_.Paczkomat.Numer == NumeryPaczkomatow.jeden)
            {
               
                this.form.ServedP1.Invoke(new Action(delegate ()
                    {
                        this.form.ServedP1.Items.Add(this.odbiorca_.Nazwa_Uzytkownika + " - korzystam");

                    }));
                    this.form.Queue1.Invoke(new Action(delegate ()
                    {
                        this.form.Queue1.Items.RemoveAt(0);
                    }));
               
            }
            else if (this.odbiorca_.Paczkomat.Numer == NumeryPaczkomatow.dwa)
            {
                
                this.form.ServedP2.Invoke(new Action(delegate ()
                    {
                        this.form.ServedP2.Items.Add(this.odbiorca_.Nazwa_Uzytkownika + " - korzystam");
                    }));
                    this.form.Queue2.Invoke(new Action(delegate ()
                    {
                        this.form.Queue2.Items.RemoveAt(0);
                    }));
               
            }
            else if (this.odbiorca_.Paczkomat.Numer == NumeryPaczkomatow.trzy)
            {
               
                this.form.ServedP3.Invoke(new Action(delegate ()
                    {
                        this.form.ServedP3.Items.Add(this.odbiorca_.Nazwa_Uzytkownika + " - korzystam");
                    }));
                    this.form.Queue3.Invoke(new Action(delegate ()
                    {
                        this.form.Queue3.Items.RemoveAt(0);
                    }));
                
            }
            wait();
            if (this.odbiorca_.Paczkomat.ListWys.Contains(this))
            {
                Thread.Sleep(1000);
                Semafor.Semafor1.WaitOne();
                    this.odbiorca_.Paczkomat.ListWys.Remove(this);
                Semafor.Semafor1.Release();
                
            }
            else
            {
                
                this.Odbiorca.Paczkomat.Kolejka.Enqueue(this.Odbiorca);
                if (this.odbiorca_.Paczkomat.Numer == NumeryPaczkomatow.jeden)
                {
                   
                    this.form.Queue1.Invoke(new Action(delegate ()
                    {
                        this.form.Queue1.Items.Add(this.odbiorca_.Nazwa_Uzytkownika);
                    }));
                   
                }
                else if (this.odbiorca_.Paczkomat.Numer == NumeryPaczkomatow.dwa)
                {
                   
                    this.form.Queue2.Invoke(new Action(delegate ()
                    {
                        this.form.Queue2.Items.Add(this.odbiorca_.Nazwa_Uzytkownika);
                    }));
                   
                }
                else if (this.odbiorca_.Paczkomat.Numer == NumeryPaczkomatow.trzy)
                {
                    
                    this.form.Queue3.Invoke(new Action(delegate ()
                    {
                        this.form.Queue3.Items.Add(this.odbiorca_.Nazwa_Uzytkownika);
                    }));
                   
                }
                
                }
            if (this.odbiorca_.Paczkomat.Numer == NumeryPaczkomatow.jeden)
            {
                
                this.form.ServedP1.Invoke(new Action(delegate ()
                {
                    this.form.ServedP1.Items.Clear();
                }));
                
            }
            else if (this.odbiorca_.Paczkomat.Numer == NumeryPaczkomatow.dwa)
            {
               
                this.form.ServedP2.Invoke(new Action(delegate ()
                {
                    this.form.ServedP2.Items.Clear();
                }));
                
            }
            else if (this.odbiorca_.Paczkomat.Numer == NumeryPaczkomatow.trzy)
            {
               
                this.form.ServedP3.Invoke(new Action(delegate ()
                {
                    this.form.ServedP3.Items.Clear();
                }));
               
            }


        }

        public void wejdz_do_kolejki(Uzytkownik uzytkownik)
        {
            
            if (uzytkownik.Odbior == false)
            {
                this.Nadawca.Pocket = this;
                this.Nadawca.Paczkomat.Kolejka.Enqueue(this.Nadawca);
                if (this.Nadawca.Paczkomat.Numer == NumeryPaczkomatow.jeden)
                {
                   
                    this.form.Queue1.Invoke(new Action(delegate ()
                    {
                        this.form.Queue1.Items.Add(this.Nadawca.Nazwa_Uzytkownika);
                    }));
                   
                }
                else if (this.Nadawca.Paczkomat.Numer == NumeryPaczkomatow.dwa)
                {
                    
                    this.form.Queue2.Invoke(new Action(delegate ()
                    {
                        this.form.Queue2.Items.Add(this.Nadawca.Nazwa_Uzytkownika);
                    }));
                   
                }
                else if (this.Nadawca.Paczkomat.Numer == NumeryPaczkomatow.trzy)
                {
                   
                    this.form.Queue3.Invoke(new Action(delegate ()
                    {
                        this.form.Queue3.Items.Add(this.Nadawca.Nazwa_Uzytkownika);
                    }));
                    
                }

            }
            else
            {
                this.Odbiorca.Pocket = this;
                this.Odbiorca.Paczkomat.Kolejka.Enqueue(this.Odbiorca);
                if (this.Odbiorca.Paczkomat.Numer == NumeryPaczkomatow.jeden)
                {
                    
                    this.form.Queue1.Invoke(new Action(delegate ()
                    {
                        this.form.Queue1.Items.Add(this.Odbiorca.Nazwa_Uzytkownika);
                    }));
                    
                }
                else if (this.Odbiorca.Paczkomat.Numer == NumeryPaczkomatow.dwa)
                {
                    
                    this.form.Queue2.Invoke(new Action(delegate ()
                    {
                        this.form.Queue2.Items.Add(this.Odbiorca.Nazwa_Uzytkownika);
                    }));
                    
                }
                else if (this.Odbiorca.Paczkomat.Numer == NumeryPaczkomatow.trzy)
                {
                    
                    this.form.Queue3.Invoke(new Action(delegate ()
                    {
                        this.form.Queue3.Items.Add(this.Odbiorca.Nazwa_Uzytkownika);
                    }));
                   
                }

            }
        }
        
        private void wait()
        {
            for (int i = 0; i < 1000000000; i++)
            {
                ;
            }
        }

        public Paczka(Uzytkownik n, Uzytkownik o, string nn, Form1 form)
        {
            this.nadawca_ = n;
            this.odbiorca_ = o;
            this.nazwa_ = nn;
            this.form = form;
        }
    }
}
