using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPIU
{
    internal class ClasaPersoana
    {

        private const char SEPARATOR_FISIER = ',';
        private const int ID = 0;
        public const int NUME = 1;
        public const int PRENUME = 2;
        public const int CNP = 3;
        private const int USERNAME = 4;
        private const int PASSWORD = 5;

        //proprietati
        private int idPersoana { set; get; }
        public string nume { set; get; }
        public string prenume { set; get; }
        public string cnp { set; get; }
        private string username { set; get; }
        private string password { set; get; }




    }
}
