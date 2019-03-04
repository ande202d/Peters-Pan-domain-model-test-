using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Mad
    {
        private int _id;
        private string _navn; //alle ordrer navnene på nye linjer
        private double _pris; //total prisen
        private bool _allergener; //er der nogle allergener

        public Mad(int id, string navn, double pris, bool allergener)
        {
            _id = id;
            _navn = navn;
            _pris = pris;
            _allergener = allergener;
        }

        public void Info()
        {
            Console.WriteLine($"ID: {Id}, Navn: {Navn}, Pris: {Pris}, Allergener: {Allergener}");
            Console.WriteLine();
        }

        #region properties
        public int Id
        {
            get { return _id; }
        }

        public string Navn
        {
            get
            {
                return _navn;
            }
        }

        public double Pris
        {
            get
            {
                return _pris;
            }
        }

        public bool Allergener
        {
            get
            {
                return _allergener;
            }
        }
#endregion

    }
}
