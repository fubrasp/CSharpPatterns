using System;
using patterns.Structural.Adapter.players;
using patterns.Structural.Adapter.playersInterface;

namespace patterns.Structural.Adapter.adaptator
{
    /// <summary>
    /// MediaAdapter is the adaptor part
    /// </summary>
    public class MediaAdapter : MediaPlayer
    {
        // It adapts an AdvancedMediaPlayer which is adapted
        AdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            switch (audioType)
            {
                case "vlc":
                    advancedMediaPlayer = new VlcPlayer();
                    break;
                case "mp4":
                    advancedMediaPlayer = new Mp4Player();
                    break;
            }
        }

        public void Play(string audioType, string fileName)
        {
            switch (audioType)
            {
                case "vlc":
                    advancedMediaPlayer.PlayVlc(fileName);
                    break;
                case "mp4":
                    advancedMediaPlayer.PlayMp4(fileName);
                    break;
            }
        }
    }
}
