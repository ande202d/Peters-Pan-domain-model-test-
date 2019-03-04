using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Ordre
    {
        private int _ordreNummer;
        private bool _allergener;
        private double _totalPris;
        public Mad _m1;
        public Mad _m2;
        public Mad _m3;

        public Ordre(int ordreNummer)
        {
            _ordreNummer = ordreNummer;
        }

        public int ordreNummer
        {
            get { return _ordreNummer; }
            set { _ordreNummer = value; }
        }
        public bool allergener
        {
            get
            {
                bool allergi = false;
                if (_m1 != null)
                {
                    if (!allergi) allergi = _m1.Allergener;
                }
                if (_m2 != null)
                {
                    if (!allergi) allergi = _m2.Allergener;
                }
                if (_m3 != null)
                {
                    if (!allergi) allergi = _m3.Allergener;
                }
                return allergi;
            }
        }

        public double TotalPris
        {
            get
            {
                double sum = 0;
                if (_m1 != null) sum += _m1.Pris;
                if (_m2 != null) sum += _m2.Pris;
                if (_m3 != null) sum += _m3.Pris;
                return sum;
            }
        }

        public string Navne
        {
            get
            {
                string navne = "";
                if (_m1 != null) navne += _m1.Navn;
                if (_m2 != null) navne += $"\n{_m2.Navn}";
                if (_m3 != null) navne += $"\n{_m3.Navn}";
                return navne;
            }
        }


        public void ordreBeskrivelse()
        {
            //Console.WriteLine($"Dit ordre nummer er {ordreNummer} og den koster {TotalPris} kroner, og den har allergener: {allergener}");
            Console.WriteLine($"Dit ordre nummer er {ordreNummer} og den indeholder: \n{Navne} \nDet koster {TotalPris} kroner \nAllergi: {allergener}");
        }

        public void AddRetTilOrdre(Mad m)
        {
            if (_m1 == null) _m1 = m;
            else if (_m2 == null) _m2 = m;
            else if (_m3 == null) _m3 = m;
        }

        //test ændring

    }

}
