namespace Assets.Code.Scripts.Runtime.Audio_System
{
    public interface IAudioService
    {
        void PlayOneShotSound(SoundType soundType);
        void PlayLoopSound(SoundType soundType);
    }
}
