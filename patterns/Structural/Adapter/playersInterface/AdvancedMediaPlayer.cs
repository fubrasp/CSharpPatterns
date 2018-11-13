using System;
namespace patterns.Structural.Adapter.playersInterface
{
    public interface AdvancedMediaPlayer
    {
        void PlayVlc(string fileName);
        void PlayMp4(string fileName);
    }
}
