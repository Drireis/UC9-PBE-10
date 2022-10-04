using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA2_EncRemoto2.Classes
{
    static class Utils
    {
        public static void BarraCarregar(String texto, int tempo,int quantidade){
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write(texto);
            
            for (var i = 0; i < quantidade; i++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }
            Console.ResetColor();
        }
    }
}