﻿namespace tskobic_zadaca_2.Modeli
{
    public class Vez
    {
        public int ID { get; set; }

        public int? IdMol { get; set; }

        public string Oznaka { get; set; }

        public string Vrsta { get; set; }

        public int CijenaPoSatu { get; set; }

        public int MaksDuljina { get; set; }

        public int MaksSirina { get; set; }

        public int MaksDubina { get; set; }

        public int Volumen
        {
            get
            {
                return MaksDuljina * MaksSirina * MaksDubina;
            }
        }

        public Vez(int id, string oznaka, string vrsta,
            int cijenaPoSatu, int maksDuljina, int maksSirina, int maksDubina)
        {
            ID = id;
            IdMol = null;
            Oznaka = oznaka;
            Vrsta = vrsta;
            CijenaPoSatu = cijenaPoSatu;
            MaksDuljina = maksDuljina;
            MaksSirina = maksSirina;
            MaksDubina = maksDubina;
        }
    }
}