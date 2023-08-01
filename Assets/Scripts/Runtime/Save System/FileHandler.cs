using System;
using Zenject;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Assets.Code.Scripts.Runtime.Utilities;

namespace Assets.Code.Scripts.Runtime.Save_System
{
    public class FileHandler
    {
        private readonly Logger logger;

        [Inject]
        public FileHandler(Logger logger)
        {
            this.logger = logger;
        }

        public async Task<string> ReadFileAsync(string filePath)
        {
            try
            {
                using FileStream sourceStream = new(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 4096, useAsync: true);
                using StreamReader reader = new(sourceStream);
                StringBuilder sb = new();

                while (!reader.EndOfStream)
                {
                    string line = await reader.ReadLineAsync();
                    sb.AppendLine(line);
                }

                return sb.ToString();
            }
            catch (FileNotFoundException ex)
            {
                // Handle file not found exception
                logger.LogAsync(ex.Message);
                return null;
            }
            catch (IOException ex)
            {
                // Handle IO exception
                logger.LogAsync(ex.Message);
                return null;
            }
            catch (UnauthorizedAccessException ex)
            {
                // Handle unauthorized access exception
                logger.LogAsync(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                // Handle any other exception
                logger.LogAsync(ex.Message);
                return null;
            }
        }

        public async Task WriteFileAsync(string filePath, string text)
        {
            try
            {
                using FileStream destinationStream = new(filePath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true);
                using StreamWriter writer = new(destinationStream);
                await writer.WriteLineAsync(text);
            }
            catch (FileNotFoundException ex)
            {
                // Handle file not found exception
                logger.LogAsync(ex.Message);
            }
            catch (IOException ex)
            {
                // Handle IO exception
                logger.LogAsync(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                // Handle unauthorized access exception
                logger.LogAsync(ex.Message);
            }
            catch (Exception ex)
            {
                logger.LogAsync(ex.Message);
            }
        }
    }
}