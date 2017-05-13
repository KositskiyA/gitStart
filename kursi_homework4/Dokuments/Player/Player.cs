using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Player:IPlayabl,IRecodable
    {

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Record()
        {
            Console.WriteLine("Record");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
   

    static void Main(string[] args)
    {
            Player player = new Player();
            player.Play();
            player.Record();

            Console.ReadKey();


    }


    }
}
