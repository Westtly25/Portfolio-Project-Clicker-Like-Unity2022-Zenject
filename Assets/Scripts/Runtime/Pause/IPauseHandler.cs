namespace Assets.Code.Scripts.Runtime.Pause
{
    public interface IPauseHandler
    {
        bool IsPaused { get; }

        void CleanUp();
        void Register(IPauseListener listener);
        void SetPaused(bool isPaused);
        void UnRegister(IPauseListener listener);
    }
}