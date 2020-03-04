using System;

namespace EloadasProject
{
    public class Eloadas
    {
        private bool[,] foglalasok;
        public Eloadas(int sorokSzama, int helyekSzama)
        {
            if (!(sorokSzama > 0) || !(helyekSzama > 0))
            {
                throw new ArgumentException("A paramétereknek 0-nál nagyobbnak kell lenniük.");
            }
            foglalasok = new bool[sorokSzama, helyekSzama];
        }


    }