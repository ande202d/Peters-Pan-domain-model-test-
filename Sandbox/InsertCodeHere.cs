using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Mad ret1 = new Mad(1, "Kyllingebryst", 100, false);
            Mad ret2 = new Mad(2, "Kamsteg", 250, false);
            Mad ret3 = new Mad(3, "Nødemix", 20, true);
            
            Bord bord1 = new Bord(1, 2);
            Bord bord2 = new Bord(2, 3);
            Bord bord3 = new Bord(3, 4);

            Ordre o1 = new Ordre(1);
            o1.AddRetTilOrdre(ret2);
            o1.AddRetTilOrdre(ret3);
            o1.AddRetTilOrdre(ret1);
            
            Bestilling b1 = new Bestilling(1,6,2502,1900);
            b1.AddOrdre(o1);
            b1.SeOrdre();
            
            


            // The LAST line of code should be ABOVE this line
        }
    }
}