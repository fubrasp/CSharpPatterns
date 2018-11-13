using System;
using patterns.Structural.Adapter.playersInterface;

namespace patterns.Structural.Adapter.players
{
    public class VlcPlayer : AdvancedMediaPlayer
    {
        public VlcPlayer()
        {
        }

        public void PlayMp4(string fileName)
        {
        }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine($"Playing vlc file. Name: {fileName}");
        }
    }
}
