using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace beep
{
    class Program
    {
        static void Main(string[] args)
        {

            Timer timer = new Timer();

            timer.Elapsed += new ElapsedEventHandler(OnTimeEvent);

            Console.WriteLine("Digite o tempo do seu timer em minutos");
            var tempo = Console.ReadLine();

            timer.Interval = int.Parse(tempo) * 10000;
            timer.Enabled = true;

            Console.WriteLine("Timer ajustado para " + tempo + " minutos.");
            Console.WriteLine("Feito por Tiago Potência. http://about.me/tiagomourabrandao\n\n");
            Console.WriteLine("Timer iniciado às " + DateTime.Now.Hour + "h" + DateTime.Now.Minute + "m");
            Console.ReadLine();

        }

        private static void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Disparado às " + DateTime.Now.Hour + "h" + DateTime.Now.Minute + "m");
            Console.Beep();
        }
    }
}
