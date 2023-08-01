using UnityEngine;
using Zenject;

namespace Assets.Code.Scripts.Runtime.Save_System
{
    public class SaveHandler : ISaveHandler
    {
        private const string FILE_PATH = "";
        private readonly FileHandler fileHandler;
        private bool isLoaded = false;

        private SaveData saveData;

        public bool IsLoaded => isLoaded;

        [Inject]
        public SaveHandler(FileHandler fileHandler) =>
            this.fileHandler = fileHandler;

        public async void Save() =>
            await fileHandler.WriteFileAsync(FILE_PATH, ConvertToString());

        public async void Load()
        {
            isLoaded = false;

            string data = await fileHandler.ReadFileAsync(FILE_PATH);

            saveData = data != null ?
                ConvertFromJson(data) :
                NewSaveData();

            isLoaded = true;
        }

        private SaveData ConvertFromJson(string data) =>
            JsonUtility.FromJson<SaveData>(data);

        private SaveData NewSaveData() => new();

        private string ConvertToString()
            => JsonUtility.ToJson(saveData);
    }
}