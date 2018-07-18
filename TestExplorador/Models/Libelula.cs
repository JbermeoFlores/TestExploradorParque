using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestExplorador.Models
{
    public class Libelula
    {
        public static String sonido1 = "fiu";

        public String getSonido1()
        {
            return sonido1;
        }

        private static String sonido2 = "plop";

        public String getSonido2()
        {
            return sonido2;
        }

        private static String sonido3 = "pep";

        public String getSonido3()
        {
            return sonido3;
        }

        public static Grillo g = new Grillo();
        public static Rana r = new Rana();

        public String melodia1()
        {
            return g.getSonido1() + " | " + r.getSonido3();
        }

        public String melodia2()
        {
            return g.getSonido1() + " | " + r.getSonido3();
        }

        public String melodia3()
        {
            return r.getSonido2()+" | "+g.getSonido2()+" | "+r.getSonido4();
        }

    }
}