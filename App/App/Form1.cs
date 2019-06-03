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
    public partial class Form1 : Form
    {

        public ListBox Paczkomat1
        {
            get
            {
                return this.paczkomat1;
            }
        }
        public ListBox Paczkomat2
        {
            get
            {
                return this.paczkomat2;
            }
        }
        public ListBox Paczkomat3
        {
            get
            {
                return this.paczkomat3;
            }
        }

        public ListBox Queue1
        {
            get
            {
                return this.q1;
            }
        }
        public ListBox Queue2
        {
            get
            {
                return this.q2;
            }
        }
        public ListBox Queue3
        {
            get
            {
                return this.q3;
            }
        }
        public ListBox ServedP1
        {
            get
            {
                return this.servedP1;
            }
        }
        public ListBox ServedP2
        {
            get
            {
                return this.servedP2;
            }
        }
        public ListBox ServedP3
        {
            get
            {
                return this.servedP3;
            }
        }
        private Paczkomat paczkomat1_, paczkomat2_, paczkomat3_;
        private Uzytkownik u1, u2, u3, u4, u5, u6, u7, u8, u9, u10, u11, u12;

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.Paczkomat1.Items.Clear();
            this.Paczkomat2.Items.Clear();
            this.Paczkomat3.Items.Clear();
        }

        private Paczka p1_, p2_, p3_, p4_, p5_, p6_;
        private Thread t1, t2, t3, t4, t5, t6, t7, t8, t9, t10;
        


        public Form1()
        {
            InitializeComponent();
            object obj = new object();
            this.paczkomat1_ = new Paczkomat(NumeryPaczkomatow.jeden, this);
            this.paczkomat2_ = new Paczkomat(NumeryPaczkomatow.dwa, this);
            this.paczkomat3_ = new Paczkomat(NumeryPaczkomatow.trzy, this);
            //Paczkomat1
            this.u1 = new Uzytkownik(RodzajUzytkownika.nadawca, "Adam", paczkomat1_); //p1
            this.u2 = new Uzytkownik(RodzajUzytkownika.nadawca, "Artur", paczkomat1_); //p2
            this.u3 = new Uzytkownik(RodzajUzytkownika.odbiorca, "Andrzej", paczkomat1_);
            this.u4 = new Uzytkownik(RodzajUzytkownika.odbiorca, "Arkadiusz", paczkomat1_);
            //Paczkomat2
            this.u5 = new Uzytkownik(RodzajUzytkownika.nadawca, "Bartek", paczkomat2_); //p3
            this.u6 = new Uzytkownik(RodzajUzytkownika.nadawca, "Barbara", paczkomat2_); //p4
            this.u7 = new Uzytkownik(RodzajUzytkownika.odbiorca, "Bożena", paczkomat2_);
            this.u8 = new Uzytkownik(RodzajUzytkownika.odbiorca, "Bogan", paczkomat2_);
            //Paczkomat3
            this.u9 = new Uzytkownik(RodzajUzytkownika.nadawca, "Czarek", paczkomat3_); //p5
            this.u10 = new Uzytkownik(RodzajUzytkownika.nadawca, "Celina", paczkomat3_); //p6
            this.u11 = new Uzytkownik(RodzajUzytkownika.odbiorca, "Cezary", paczkomat3_);
            this.u12 = new Uzytkownik(RodzajUzytkownika.odbiorca, "Cecylia", paczkomat3_);

            this.p1_ = new Paczka(u1, u7, "Paczka 1", this); 
            this.p2_ = new Paczka(u2, u11, "Paczka 2", this);
            this.p3_ = new Paczka(u5, u3, "Paczka 3", this);
            this.p4_ = new Paczka(u6, u12, "Paczka 4", this);
            this.p5_ = new Paczka(u9, u4, "Paczka 5", this);
            this.p6_ = new Paczka(u10, u8, "Paczka 6", this);

            t1 = new Thread(() =>
            {
                this.p1_.wejdz_do_kolejki(u1);
                this.p2_.wejdz_do_kolejki(u2);
                this.p3_.wejdz_do_kolejki(u3);
                this.p5_.wejdz_do_kolejki(u4);
                
            });

            t2 = new Thread(() =>
            {
                this.p3_.wejdz_do_kolejki(u5);
                this.p4_.wejdz_do_kolejki(u6);
                this.p1_.wejdz_do_kolejki(u7);
                this.p6_.wejdz_do_kolejki(u8);
               
            });
            
            t3 = new Thread(() =>
            {
                this.p5_.wejdz_do_kolejki(u9);
                this.p6_.wejdz_do_kolejki(u10);
                this.p2_.wejdz_do_kolejki(u11);
                this.p4_.wejdz_do_kolejki(u12);
                
            });

            t4 = new Thread(() =>
            {
                while (true)
                {
                    this.paczkomat1_.update_list_wys();
                    this.paczkomat2_.update_list_wys();
                    this.paczkomat3_.update_list_wys();
                   
                }
            });
            t5 = new Thread(() =>
            {
                try
                {
                   Semafor.Semafor1.WaitOne();
                    for (int i = 0; i < 10; i++)
                    {
                        if (this.paczkomat1_.Kolejka.ElementAt(0) != null)
                        {
                            this.paczkomat1_.obsluga();
                        }
                    }

                }
                finally
                {
                  Semafor.Semafor1.Release();
                }
            });

            t6 = new Thread(() =>
            {
                try
                {
                    Semafor.Semafor2.WaitOne();
                    for (int i = 0; i < 10; i++)
                    {
                        if (this.paczkomat2_.Kolejka.ElementAt(0) != null)
                        {
                            this.paczkomat2_.obsluga();
                        }
                    }

                }
                finally
                {
                    Semafor.Semafor2.Release();
                }

            });

            t7 = new Thread(() =>
            {
                    try
                    {
                    Semafor.Semafor3.WaitOne();
                    for (int i=0; i<10; i++)
                    {
                        if (this.paczkomat3_.Kolejka.ElementAt(0) != null)
                        {
                            this.paczkomat3_.obsluga();
                        }
                    }  
                    }
                    finally
                    {
                    Semafor.Semafor3.Release();
                }
            });

            t8 = new Thread(() =>
            {
               
                    try
                    {
                        Semafor.Semafor1.WaitOne();
                        while (this.paczkomat1_.ListWys.Capacity != 0)
                        {
                            this.paczkomat1_.kurier_job();
                        }
                    }
                    finally
                    {
                        Semafor.Semafor1.Release();
                    }
               
                
                
            });

            t9 = new Thread(() =>
            {
              
                    try
                    {
                        Semafor.Semafor2.WaitOne();
                        while (this.paczkomat2_.ListWys.Capacity != 0)
                        {
                            this.paczkomat2_.kurier_job();
                        }
                    }
                    finally
                    {
                        Semafor.Semafor2.Release();
                    }
               
                
                
            });

            t10 = new Thread(() =>
            {
                
                    try
                    {
                        Semafor.Semafor3.WaitOne();
                        
                        while (this.paczkomat3_.ListWys.Capacity != 0)
                        {
                            this.paczkomat3_.kurier_job();
                        }
                    }
                    finally
                    {
                        Semafor.Semafor3.Release();
                    }
               
                
                
            });


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przygotował - Bartłomiej Pieróg, grupa: I7X3S1. \n" +
                "Programowanie Współbieżne.\n" +
                "Icon made by Smashicons from www.flaticon.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startBtn.Click -= startBtn_Click;
            startBtn.Click += thread_starter;
            stopBtn.Click += thread_stopper;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //this.p1_.jakas_funckja();
        }
        
        private void thread_starter(object sender, EventArgs e)
        {
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();
            t8.Start();
            t9.Start();
            t10.Start();
        }
        private void thread_stopper(object sender, EventArgs e)
        {
            t1.Abort();
            t2.Abort();
            t3.Abort();
            t4.Abort();
            t5.Abort();
            t6.Abort();
            t7.Abort();
            t8.Abort();
            t9.Abort();
            t10.Abort();
        }
    }
}
