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

        //Attributo che servirà a calcolare quanto l'auto deve accellerare per arrivare al limite massima imposto dalla marcia dalla velocità corrente usando l'accelleratore 3 volte
        protected int _limit;

        public Auto_Man() 
        {
            Vel = 0;
            Marcia = 0;
            Acc = false;
            Limit = 0;
        }

        public bool Accensione()
        {
            if (Acc == true && Vel == 0)
            {
                Acc = false;
            }
            else if (Vel == 0)
            {
                Acc = true;
            }
            return Acc;
        }

        public bool ControlloMarcia(int m)
        {
            //controllo che la macchina sia accesa
            if (!Acc) { return false; }

            //controllo che la velocità sia abbastanza bassa per poter diminuire la marcia
            if (Vel <= 100 && m > 4) { Limit = 100 - Vel;  return true; }
            else if (Vel <= 80 && m > 3) { Limit = 80 - Vel; return true; }
            else if (Vel <= 60 && m > 2) { Limit = 60 - Vel; return true; }
            else if (Vel <= 40 && m > 1) { Limit = 40 - Vel; return true; }
            else if (Vel <= 20 && m > 0) { Limit = 20 - Vel; return true; }

            //nel caso la velocità sia troppo elevata non posso cambiare marcia
            return false;
        }

        public void accellerazione()
        {
            if (!Acc)
            {
                return;
            }
            if (_marcia == 1)
            {
                 if (Vel < 20) { Vel += Limit / 3; if (Vel > 20) { Vel = 20; } }
                 else { Vel = 20; }
            }
            if (_marcia == 2)
            {
                if (Vel < 40) { Vel += Limit / 3; if (_vel > 40) { _vel = 40; } }
                else { Vel = 40; }
            }
            if (_marcia == 3)
            {
                if (Vel < 60) { Vel += Limit / 3; if (_vel > 60) { Vel = 60; } }
                else { Vel = 60; }
            }
            if (_marcia == 4)
            {
                if (Vel < 80) { _vel += Limit / 3; if (Vel > 80) { Vel = 80; } }
                else { Vel = 80; }
            }
            if (_marcia == 5)
            {
                if (Vel < 100) { _vel += Limit / 3; if (Vel > 100) { Vel = 100; } }
                else { Vel = 100; }
            }
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

        public int Limit
        {
            get { return _limit; }
            set { _limit = value; }
        }
    }
}
