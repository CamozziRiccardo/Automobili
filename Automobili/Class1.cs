using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili
{
    internal class Auto_Man
    {
        //da 0 a 100, 6 marce, valorre 0 per la retro
        protected int _vel;

        //6 marce diverse
        protected int _marcia;

        //booleano per verificare l'accensione
        protected bool _acc;

        public Auto_Man() 
        {
            Vel = 0;
            Marcia = 1;
            Acc = false;
        }

        int Vel
        {
            get { return _vel; }
            set { _vel = value; }
        }

        int Marcia
        {
            get { return _marcia; }
            set { _marcia = value; }
        }

        bool Acc
        {
            get { return _acc; }
            set { _acc = value; }
        }
    }
}
