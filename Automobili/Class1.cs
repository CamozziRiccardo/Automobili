using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili
{
    internal class Auto_Man
    {
        //da 0 a 100, 5 marce, valore 0 per la retro
        protected int _vel;

        //5 marce diverse
        protected int _marcia;

        //booleano per verificare l'accensione
        protected bool _acc;

        public Auto_Man() 
        {
            Vel = 0;
            Marcia = 1;
            Acc = false;
        }

        public bool Accensione()
        {
            if (_acc == true)
            {
                _acc = false;
            }
            else
            {
                _acc = true;
            }
            return _acc;
        }

        public int Vel
        {
            get { return _vel; }
            set { _vel = value; }
        }

        public int Marcia
        {
            get { return _marcia; }
            set { _marcia = value; }
        }

        public bool Acc
        {
            get { return _acc; }
            set { _acc = value; }
        }
    }
}
