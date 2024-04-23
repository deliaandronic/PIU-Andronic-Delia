using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPIU
{
    internal class Auto
    {

        //constante
        private const char SEPARATOR_FISIER = ',';
        private const int ID = 0;
        private const int MARCA = 1;
        private const int CULOARE = 2;
        private const int AN = 3;
        private const int VIN = 4;
        private const int INCHIRIAT = 5;

        //proprietati
        private int IdAuto { set; get; }
        private string marca { set; get; }
        private string culoare { set; get; }
        private string an { set; get; }
        private string vin { set; get; }
        private string inchiriat { set; get; }

    }
}
