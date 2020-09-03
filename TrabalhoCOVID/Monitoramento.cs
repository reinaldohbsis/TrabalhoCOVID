using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrabalhoCOVID
{
    public class Monitoramento
    {
        public int _estados { get; private set; }

        public int _pessoas { get; private set; }

        public Monitoramento()
        {
            _estados = Estados();
            _pessoas = Pessoas();
         
        }


        public static int Estados()
        {
            Console.WriteLine("Digite o n de estados");
            string l = Console.ReadLine();
            bool trava = Regex.IsMatch(l, @"\d");

            if (trava) 
            {
                int v = Convert.ToInt32(l);
                    if (v < 27)
                    return  v; 
            }
            Console.WriteLine("Não seja um animal");
            Estados();
            return 0;
          
        }

        public static int Pessoas()
        {
            Console.WriteLine("Digite o n de pessoas");
            string l = Console.ReadLine();
            bool trava = Regex.IsMatch(l, @"\d");
            if (trava)
                    return Convert.ToInt32(l);
            Console.WriteLine("Não seja um animal, isso não é um número");
            Pessoas();
            return 0;


        }
    }
}
