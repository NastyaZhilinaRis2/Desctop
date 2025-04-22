using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace Лабиринт
{
    static public class music
    {
        static public SoundPlayer music_osnova = new SoundPlayer(Properties.Resources.osnova);
        
        static public bool music_live = false;

        public static void music_on()
        {
            music_live = true;
        }
        public static void music_off()
        {
            music_live = false;
        }
        public static void music_play()
        {
            if (music_live)
            {
                music_osnova.Play();
            }
            else
            {
                music_osnova.Stop();
            }
            
        }

    }
}
