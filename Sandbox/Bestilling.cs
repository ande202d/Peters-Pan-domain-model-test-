using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Bestilling
    {
        private int _tidspunkt;
        private string _navn;
        private int _antalKunder;
        private int _dato;
        private int _bord;
        private bool _afbestilling = false;
        private int _bestillingsNummer;
        public Ordre _ordre;


        #region konstruktur

        public Bestilling(int bestillingNummer, int antalKunder, int dato, int tidspunkt)
        {
            _bestillingsNummer = bestillingNummer;
            //_navn = navn;
            _antalKunder = antalKunder;
            //_bord = bord;
            _dato = dato;
            _tidspunkt = tidspunkt;
        }

        #endregion

        #region properties

        public int OrdreNummer
        {
            get { return _bestillingsNummer; }
        }
        public string Navn
        {
            get { return _navn; }
        }
        public int AntalKunder
        {
            get { return _antalKunder; }
        }
        public int Bord
        {
            get { return _bord; }
        }
        public int Dato
        {
            get { return _dato; }
        }
        public int Tidspunkt
        {
            get { return _tidspunkt; }
        }

        #endregion

        #region metoder

        public void Afbestilling()
        {
            _afbestilling = true;
        }

        public void AddOrdre(Ordre o1)
        {
            _ordre = o1;
        }

        public void SeOrdre()
        {
            _ordre.ordreBeskrivelse();
        }

        #endregion
    }

}
