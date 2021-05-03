using System;

namespace AllenamentoEfficace
{
    public class Gestione
    {
        public static string btmMaxMin(int battiti,int eta)
        {
            int freqMax = 220 - eta;
            double freqMinAll = (freqMax * 70) / 100;
            double freqMaxAll= (freqMax * 90) / 100;
            return ($"{freqMaxAll} {freqMinAll}");
        }
        public static string LetturafileMediaGiornaliera()
        {
            
        }
    }
}
