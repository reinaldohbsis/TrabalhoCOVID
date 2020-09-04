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

        public Calculo()
        {
            Ret(base._estados, base._pessoas);
        }

        public static int Rnd(int limite)
        {
            Random rnd = new Random();
            return Convert.ToInt32(rnd.Next(0,limite));
        }

        public static void Ret(int estados, int pessoas)
        {
            int linha = 0;
            int e;
            int contador = 0;
            bool titi = true;
            string[] pes = new string[estados];
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
                 e = Rnd(estados);                 
                    if (!titi)
                    {
                    pes[e] = Infectar(pes[e], pessoas, e,contador, out titi, out linha, out contador);
                    }

                for (var i = 0; i < estados; i++)
                {
                    if (i == linha)
                        Console.ForegroundColor = ConsoleColor.Red;                  
                    Console.WriteLine(pes[i]);
                    Console.ResetColor();
                }

                Console.WriteLine("\n\n\n Runtime: " + tempo + "s");
                Thread.Sleep(1000);
                tempo++;
                titi = false;
                
                Console.Clear();
            }
            Console.WriteLine("TEMPO DE ANALISE FINALIZADO");
            Console.WriteLine("Pessoas infectadas: " + contador);
        }

       public static string Infectar(string pessoas, int pessoa,int estado, int cotad, out bool titis, out int linhas, out int contador)
        {
            
            StringBuilder pess = new StringBuilder(pessoas);
            int ale = Rnd(pessoa);
            if (pess[ale] == '-')
            {
                Linha(estado, out linhas);
                pess[ale] = '*';
                titis = true;
                contador = cotad + 1;
                return pess.ToString();              
            }
            contador = cotad + 0;
            titis = false;
            linhas = estado+1;
            return pessoas;
        }

        public static void Linha(int estado, out int linha)
        {
            linha = estado;
        }



    }
}
