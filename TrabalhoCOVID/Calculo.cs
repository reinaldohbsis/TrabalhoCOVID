using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace TrabalhoCOVID
{
    public class Calculo : Monitoramento
    {
        public int _total { get; set; }
        //public int _tempo { get; set; }

        public Calculo()
        {
            //_total = Total(base._estados, base._pessoas);
            Ret(base._estados, base._pessoas);
           // _tempo = 0;

        }

        public static int Total(int estados, int pessoas)
        {
            return estados * pessoas;
        }

        public static int Rnd(int limite)
        {
            Random rnd = new Random();
            return Convert.ToInt32(rnd.Next(0,limite));
        }

        public static void Ret(int estados, int pessoas)
        {
            int total = Total(estados, pessoas);
            Random rnd = new Random();
            int ale = 0;
            int linha = 0;
            int e = 0;
            int contador = 0;
            bool titi = true;
            string[] pes = new string[estados];
            int[] infectados = new int[estados];
            int tempo = 0;
            Console.Clear();
            for (int es = 0; es < estados; es++)
            {

                for (int p = 0; p < pessoas; p++)
                {
                    pes[es] += "-";
                }
            }
            while (tempo < 60)
            {
                 e = rnd.Next(estados);
                //for(int e = 0; e < estados; e++)
                //{
                    
                    for(int p = 0; p < pessoas; p++)
                    {
                        
                        //pess[e] = Regex.Replace(pes[e], @"-" , "*");

                    }
                    if (!titi)
                    {
                        StringBuilder pess = new StringBuilder(pes[e]);
                        ale = rnd.Next(pessoas);
                        if (pess[ale] == '-')
                        {
                            linha = e;
                            pess[ale] = '*';
                            pes[e] = pess.ToString();
                            contador++;
                            titi = true;
                        }
                    }

                for (var i = 0; i < estados; i++)
                {
                    if (i == linha)
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(pes[i]);
                    Console.ResetColor();
                }
               // }
                
                Thread.Sleep(1000);
                infectados[rnd.Next(estados)]++;
                tempo++;
                titi = false;
                Console.Clear();
            }
            Console.WriteLine("TEMPO DE ANALISE FINALIZADO");
            Console.WriteLine("Pessoas infectadas: " + contador);
        }




    }
}
