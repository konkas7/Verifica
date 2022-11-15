using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    internal class Sportello
    {
        private string _ID;
        private string _Indirizzo;
        private string _Banca;
        private Carta carta;

        public Sportello(string id, string indirizzo, string banca)
        {
            ID = id;
            Indirizzo = indirizzo;
            Banca = banca;
        }

        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        public string Indirizzo
        {
            set { _Indirizzo = value; }
            get { return _Indirizzo; }
        }

        public string Banca
        {
            set { _Banca = value; }
            get { return _Banca; }
        }

        public Carta inserisci(Carta carta)
        {
            return carta;
        }


        

        
    }
}
