using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace App
{
    class Semafor
    {
        static Semaphore semafor1 = new Semaphore(4, 8);
        static Semaphore semafor2 = new Semaphore(4, 8);
        static Semaphore semafor3 = new Semaphore(4, 8);

        static public Semaphore Semafor1
        {
            get
            {
                return semafor1;
            }
        }
        static public Semaphore Semafor2
        {
            get
            {
                return semafor2;
            }
        }
        static public Semaphore Semafor3
        {
            get
            {
                return semafor3;
            }
        }
   
    }
}
