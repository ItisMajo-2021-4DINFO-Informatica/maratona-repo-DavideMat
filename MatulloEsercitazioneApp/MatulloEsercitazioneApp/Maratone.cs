﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MatulloEsercitazioneApp
{
    class Maratone
    {
        public List<Maratona> ElencoMaratone;


        public Maratone()
        {

            ElencoMaratone = new List<Maratona>();
        }

        public void Aggiungi(Maratona maratona)
        {
            ElencoMaratone.Add(maratona);
        }

        public void LeggiDati()
        {

            using (FileStream flussoDati = new FileStream("Maratone.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader lettoreDati = new StreamReader(flussoDati))
                {
                    while (!lettoreDati.EndOfStream)
                    {
                        
                        string linea = lettoreDati.ReadLine();
                        string[] campi = linea.Split('%');

                        Maratona maratona = new Maratona();
                        maratona.NomeAtleta = campi[0];
                        maratona.Società = campi[1];
                        maratona.Tempo = campi[2];
                        maratona.Città = campi[3];

                        Aggiungi(maratona);



                    }


                }
            }


        }

        public  string CercaTempo(string nome, string città)
        {
            string Tempo = "";
            foreach (var maratona in ElencoMaratone)
            {

                if (maratona.NomeAtleta == nome)
                {
                    Tempo = maratona.Tempo;
                }


            }


            return Tempo;
        }




        










    }
}
