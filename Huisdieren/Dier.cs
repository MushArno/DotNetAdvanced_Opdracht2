using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1 //<!> Dier in project Huisdieren <!>
{
    public abstract class Dier
    {
        public int Gewicht { get; set; }
        protected string Geluid { get; set; }
        protected string Uitspraak { get; set; }


        public Dier()
        {
            Gewicht = 0;
            Uitspraak = "Unknown";

        }

        public string Zegt()
        {
            return Uitspraak;
        }

        public int getGewicht()
        {
            return Gewicht;
        }

        public string getGeluid()
        {
            return Geluid;
        }
        public string getAllData()
        {
            return $"Gewicht: {Gewicht}\nGeluid: {Geluid}\nUitspraak: {Uitspraak}";
        }
    }
   

    class Koe : Dier {
       

        public Koe() {
            Gewicht = 100;
            Geluid = "C:\\Users\\laiar\\source\\repos\\.NET\\Huiswerk\\Opdracht2\\DotNetAdvanced_Opdracht2\\sounds\\koe.wav";
            Uitspraak = "Moo";
            
        }
    }
    class Slang : Dier {

        public Slang() {
            Gewicht = 10;
            Geluid = "C:\\Users\\laiar\\source\\repos\\.NET\\Huiswerk\\Opdracht2\\DotNetAdvanced_Opdracht2\\sounds\\slang.wav";
            Uitspraak = "Sss";
        }
    }
    class Varken : Dier {
      
        public Varken() {
            Gewicht = 10;
            Geluid = "C:\\Users\\laiar\\source\\repos\\.NET\\Huiswerk\\Opdracht2\\DotNetAdvanced_Opdracht2\\sounds\\varken.wav";
            Uitspraak = "Oink";
        }
    }
    
}
