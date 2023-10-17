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
            Marcia = 0;
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

        public bool ControlloMarcia(int m)
        {
            //controllo che la macchina sia accesa
            if (!_acc) { return false; }
            //controllo che la velocità sia abbastanza bassa per poter diminuire la marcia
            if (_vel < 20 && m > 0) { return true; }
            else if (_vel <= 40 && m > 1) { return true; }
            else if (_vel <= 60 && m > 2) { return true; }
            else if (_vel <= 80 && m > 3) { return true; }
            else if (_vel <= 100 && m > 4) { return true; }

            //nel caso la velocità sia troppo elevata non posso cambiare marcia
            return false;
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
