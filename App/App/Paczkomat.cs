using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace App
{
    enum NumeryPaczkomatow { zero, jeden, dwa, trzy };
    class Paczkomat
    {
        private int counter = 0;
        private NumeryPaczkomatow numer;
        private List<Paczka> lita_paczek_wys = new List<Paczka>(); //lista paczek oczekujących do wysyłki
        private Queue<Uzytkownik> kolejka_ = new Queue<Uzytkownik>(); //kolejka wszystkich uzytkownikow oczekujących na korzystanie z paczkomatu
        private Form1 form;
        public NumeryPaczkomatow Numer{
            get{
            return this.numer;
            }
        }
        public List<Paczka> ListWys
        {
            get
            {
                return this.lita_paczek_wys;
            }
            
        }
        public Queue<Uzytkownik> Kolejka
        {
            get
            {
                return this.kolejka_;
            }
        }

        public void kurier_job() //wysyłka paczek z jednego paczkomatu na drugi.
        {
                while (this.ListWys.Capacity != 0)
                {

                    if (this.ListWys.Count != 0)
                    {
                        for (int i = 0; i < ListWys.Count; i++)
                        {
                            if (this.ListWys[i].Odbiorca.Paczkomat.Numer != this.Numer)
                            {
                                this.ListWys[i].Odbiorca.Paczkomat.ListWys.Add(this.ListWys[i]);
                                this.ListWys.Remove(this.ListWys[i]);
                                Thread.Sleep(1000);
                                i--;
                            }

                        }
                    }

              }  
        }

        public void obsluga()
        {

                    if (Kolejka.ElementAt(0).Odbior == false)
                    {
                            Kolejka.Dequeue().Pocket.wyslij_paczke();
                    }
                    else
                    {
                            Kolejka.Dequeue().Pocket.odbierz_paczke();
                    }
        }

        public void update_list_wys()
        {

            if (this.ListWys.Count != 0)
            {
                if (this.Numer == NumeryPaczkomatow.jeden)
                {
                   
                    this.form.Paczkomat1.Invoke(new Action(delegate ()
                    {
                        this.form.Paczkomat1.Items.Clear();
                        for (int i = 0; i < this.ListWys.Count; i++)
                        {
                            this.form.Paczkomat1.Items.Add(this.ListWys[i].Nazwa);
                        }
                    }));
                    
                }
                else if (this.Numer == NumeryPaczkomatow.dwa)
                {
                   
                    this.form.Paczkomat2.Invoke(new Action(delegate ()
                    {
                        this.form.Paczkomat2.Items.Clear();
                        for (int i = 0; i < this.ListWys.Count; i++)
                        {
                            this.form.Paczkomat2.Items.Add(this.ListWys[i].Nazwa);
                        }
                    }));
                    
                }
                else if (this.Numer == NumeryPaczkomatow.trzy)
                {
                    
                    this.form.Paczkomat3.Invoke(new Action(delegate ()
                    {
                        this.form.Paczkomat3.Items.Clear();
                        for (int i = 0; i < this.ListWys.Count; i++)
                        {
                            this.form.Paczkomat3.Items.Add(this.ListWys[i].Nazwa);
                        }
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
        
        public Paczkomat(NumeryPaczkomatow numer, Form1 form)
        {
            this.numer = numer;
            this.form = form;
        }

    }
}
