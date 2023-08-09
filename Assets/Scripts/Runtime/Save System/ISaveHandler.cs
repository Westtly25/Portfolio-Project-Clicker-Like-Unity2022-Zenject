namespace Assets.Code.Scripts.Runtime.Save_System
{
    public interface ISaveHandler
    {
        void LoadAsync();
        void SaveAsync();
    }
}