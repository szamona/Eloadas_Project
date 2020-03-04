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

        public bool Lefoglal()
        {
            bool foglalas = false;
            for (int i = 0; i < this.foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j < this.foglalasok.GetLength(1); j++)
                {
                    if (this.foglalasok[i, j] == false)
                    {
                        this.foglalasok[i, j] = true;
                        foglalas = true;
                    }
                }
            }
            return foglalas;
        }

        public int SzabadHelyek
        {
            get
            {
                int szabadHelyek = 0;
                for (int i = 0; i < this.foglalasok.GetLength(0); i++)
                {
                    for (int j = 0; j < this.foglalasok.GetLength(1); j++)
                    {
                        if (this.foglalasok[i, j] == false)
                        {
                            szabadHelyek++;
                        }
                    }
                }
                return szabadHelyek;
            }
        }
        public bool Teli()
        {
            bool teliE=false;

            if( SzabadHelyek == 0 )
            {
                teliE = true;
            }
            return teliE;
        }
        public bool Foglalt(int sorSzam, int helySzam)
        {
            if (sorSzam < 1 || helySzam < 1)
            {
                throw new ArgumentException("A paramétereknek 0-nál nagyobbnak kell lenniük.");
            }
            return foglalasok[sorSzam - 1, helySzam - 1];
        }
    }
}

