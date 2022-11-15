using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conto ciao = new Conto("5", "thomas", "sista", 0);
            

            Conto ciaoo = new Conto("55", "thomasss", "sistaaaa", 0);
            

            ciao.deposita(100);
            ciao.preleva(50);
            ciao.getSaldo();

            ciaoo.deposita(1000);
            ciaoo.preleva(2000);
            ciaoo.getSaldo();

            ciao.bonifico(ciaoo, 50);

            Carta carta = new Carta("6", "1234", ciao);
            Carta cartaa = new Carta("7", "3456", ciaoo);

            carta.deposita(ciao, 40);
            cartaa.preleva(ciaoo, 50);

        }
    }
}
