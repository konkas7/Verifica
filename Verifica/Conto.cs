using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    internal class Conto
    {
        private string _ID;
        private string _Cliente;
        private string _Banca;
        public float _Saldo;


        public Conto(string iD, string cliente, string banca, float saldo)
        {
            ID = iD;
            Cliente = cliente;
            Banca = banca;
            _Saldo = saldo;
        }

        

        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        public string Cliente
        {
            set { _Cliente = value; }
            get { return _Cliente; }
        }

        public string Banca
        {
            set { _Banca = value; }
            get { return _Banca; }
        }

        public float getSaldo()
        {
            return _Saldo;
        }



        public void deposita(float somma)
        {
            if (somma > 0)
            {
                _Saldo = _Saldo + somma;
            }
            else
                throw new Exception("Il valore inserito non è corretto!");
        }

        public void preleva(float somma)
        {
            if (somma > 0 && somma < _Saldo)
            {
                _Saldo = _Saldo - somma;
            }
            else
                throw new Exception("Il valore inserito non è corretto!");
        }

        public void bonifico(Conto destinazione, float somma)
        {
            preleva(somma);
            destinazione._Saldo = destinazione._Saldo + somma;
        }

        
    }
}
