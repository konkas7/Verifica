using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    internal class Carta
    {

        private string _ID;
        private string _PIN;
        private Conto _conto;

        public Carta(string id, string pin, Conto conto)
        {
            ID = id;
            PIN = pin;
            _conto = conto;
        }

        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        public string PIN
        {
            set { _PIN = value; }
            get { return _PIN; }
        }

        public float getSaldo()
        {
            return _conto._Saldo;
        }

        public void deposita(Conto conto, float somma)
        {
            if (somma > 0)
            {
                conto._Saldo = conto._Saldo + somma;
            }
            else
                throw new Exception("Il valore inserito non è corretto!");
        }

        public void preleva(Conto conto, float somma)
        {
            if (somma > 0 && somma < conto._Saldo)
            {
                conto._Saldo = conto._Saldo - somma;
            }
            else
                throw new Exception("Il valore inserito non è corretto!");
        }

    }
}
