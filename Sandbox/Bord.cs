using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Bord
    {
        private bool _ledig;
        private int _antal;
        private int _bordnr;

        public Bord(int bordnr, int antal)
        {
            _antal = antal;
            _bordnr = bordnr;
        }


        public int Antal
        {
            get { return _antal; }
            set { _antal = value; }
        }

        public int Bordnr
        {
            get { return _bordnr; }
            set { _bordnr = value; }
        }

        public bool Ledig
        {
            get { return _ledig; }
            set { _ledig = value; }
        }

        
    }

}
