using Zenject;
using UnityEngine;
using Assets.Code.Scripts.Runtime.Save_System;

namespace Assets.Code.Scripts.Runtime.Utilities
{
    public class Logger : ILogger
    {
        private const string FILE = "log.txt";
        private readonly string path;

        [Header("Injected Data")]
        private readonly FileHandler fileHandler;

        [Inject]
        public Logger(FileHandler fileHandler)
        {
            path = Application.persistentDataPath + FILE;

            this.fileHandler = fileHandler;
        }

        public async void LogAsync(string msg) =>
            await fileHandler.WriteFileAsync(path, msg);
    }
}
