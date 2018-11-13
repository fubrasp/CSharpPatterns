using System;
using patterns.Structural.Adapter.adaptator;
using patterns.Structural.Adapter.playersInterface;

namespace patterns.Structural.Adapter.adaptorManager
{
    /// <summary>
    /// Audio player is able to manage any type all players
    /// </summary>
    public class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            //inbuilt support to play mp3 music files
            if (string.Equals(audioType, "mp3"))
            {
                Console.WriteLine($"Playing mp3 file. Name: {fileName}");
            }
            //mediaAdapter is providing support to play other file formats
            else if (string.Equals(audioType, "vlc") || string.Equals(audioType, "mp4"))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine($"Invalid media. {audioType} format not supported");
            }
        }
    }
}
