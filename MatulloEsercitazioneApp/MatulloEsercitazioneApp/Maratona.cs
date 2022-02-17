using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatulloEsercitazioneApp
{
    class Maratona
    {
        public string NomeAtleta { get; set; }
        public string Società { get; set; }
        public int Tempo { get; set; }
        public string Città { get; set; }




        public int TrovaTempo(string Tempo )
        {

            int minuti = 0;

            int ore = int.Parse(Tempo.Substring(0, 1));
            int minutiParziali = int.Parse(Tempo.Substring(3, 2));
            minuti = (ore *60) + minutiParziali;

            return minuti;


        }
    }
}
