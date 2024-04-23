using System;

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

        // Enum pentru starea de închiriere a mașinii
        public enum StareInchiriere
        {
            Disponibil,
            Inchiriat
        }

        // Enum pentru marca mașinii
        public enum MarcaAuto
        {
            Ford,
            BMW,
            Audi,
            Mercedes,
            Toyota
        }

        //proprietati
        private int IdAuto { set; get; }
        private MarcaAuto Marca { set; get; }
        private string culoare { set; get; }
        private string an { set; get; }
        private string vin { set; get; }
        private StareInchiriere Inchiriat { set; get; }
    }
}
