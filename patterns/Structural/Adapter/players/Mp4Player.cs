using System;
using patterns.Structural.Adapter.playersInterface;

namespace patterns.Structural.Adapter.players
{
    public class Mp4Player : AdvancedMediaPlayer
    {
        public Mp4Player()
        {
        }

        public void PlayMp4(string fileName)
        {
            Console.WriteLine($"Playing mp4 file. Name: {fileName}");
        }

        public void PlayVlc(string fileName)
        {
        }
    }
}
