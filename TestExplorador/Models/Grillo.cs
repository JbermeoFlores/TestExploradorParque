using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestExplorador.Models
{
    

    public class Grillo
    {

        public static String sonido1 = "cric-cric";
        public String getSonido1()
        {
            return sonido1;
        }

        public static String sonido2 = "trri-trri";

        public String getSonido2()
        {
            return sonido2;
        }

        public static String sonido3 = "bri-bri";

        public String getSonido3()
        {
            return sonido3;
        }

        public static Libelula l = new Libelula();
        public static Rana r = new Rana();

        public String melodia1()
        {
            return r.getSonido3();
        }

        public String melodia2()
        {
            return r.getSonido4();
        }

        public String melodia3()
        {
            return l.getSonido2()+" | "+ sonido1+" | "+r.getSonido3();
        }
    }
}