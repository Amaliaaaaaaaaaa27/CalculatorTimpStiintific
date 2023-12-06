using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;

namespace CalculatorTimpStiintific
{
    class CalculareaClaseiInTimp
    {
        public int Viteza { get; private set; } = 28440;
        public int Distanta { get; private set; } = 384400;
        public float Minut { get; private set; } = 60f; 
        public float Ora { get; private set; } = 60f;

        public float minute;
        public float ora;

        public CalculareaClaseiInTimp()
        {

        }
 
        public float CalculareVitezaOre()
        {
            ora =(Distanta * Viteza)/60;
            return ora;
        }
        public float ObtinereOraConcreta()
        {
            while (ora > 9)
            {
                ora = ora/ 10;
            }

            return ora;
        }
        public float CalculareInTimpMinute()
        {
            minute = (Distanta / Viteza) - ora * Minut;
            return minute;
        }
    }
}

///<summary> 
/// viteza = distanta / timp deci din asta extragem ca  viteza /1  = distanta/timp deci  v t = distanta => t = distanta/ viteza 
/// noi ora si minutele le avem ca sablon nu trb sa le egalam cu ecuatia asadar noi nu ptem spune ca 60 de minte poate sa fie egla cu distanta/vitwza 
/// deoarece ar fi 60 = 3884/2844
/// asadar eu cred ca trb sa creem o variabila iar aceasta variabila sa fie folosit ca un fel de caounter dupa sa inpartim la 60 ig 
/// 
/// </summary>
/// 


 