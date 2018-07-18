using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using TestExplorador.Models;

namespace TestExplorador.Models
{
    public class Rana
    {
        public static String sonido1 = "brr";

        public String getSonido1()
        {
            return sonido1;
        }

        public static String sonido2 = "birip";

        public String getSonido2()
        {
            return sonido2;
        }

        public static String sonido3 = "brrah";

        public String getSonido3()
        {
            return sonido3;
        }

        public static String sonido4 = "croac";

        public String getSonido4()
        {
            return sonido4;
        }


        public static Grillo g = new Grillo();
        public static Libelula l = new Libelula();

        public String melodia1()
        {
            return l.getSonido1()+" | "+g.getSonido1()+" | "+sonido3;
        }

        public String melodia2()
        {
            return g.getSonido2() + " | " + sonido4;
        }

        public String melodia3()
        {
            return "";
        }
        
        public String melodia4()
        {
            return "";
        }
    
    }


}