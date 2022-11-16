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
        private string[] _carte_bloccate;

        public Sportello(string id, string indirizzo, string banca, string[] carte_bloccate)
        {
            ID = id;
            Indirizzo = indirizzo;
            Banca = banca;
            _carte_bloccate = carte_bloccate;
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
            for(int i = 0; i<_carte_bloccate.Length; i++)
            {
                if(carta.ID == _carte_bloccate[i])
                {
                    throw new Exception("Carta bloccata!");
                }
                
                    
            }
            return carta;

        }

        public Carta rimuovi(Carta carta)
        {
            return null;
        }

        


        public void deposita(Carta carta, float somma)
        {
            carta.deposita(carta._conto, 40);
        }

        public void preleva(Carta carta, float somma)
        {
            carta.preleva(carta._conto, 40);
        }
        

        
    }
}
