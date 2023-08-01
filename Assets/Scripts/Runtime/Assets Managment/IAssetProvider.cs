using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.AddressableAssets;

namespace Assets.Code.Scripts.Runtime.Asset_Management
{
    public interface IAssetProvider
    {
        void Initialize();
        Task<GameObject> Instantiate(string path, Vector3 at);
        Task<GameObject> Instantiate(string path);
        Task<T> Load<T>(AssetReference monsterDataPrefabReference) where T : class;
        Task<T> Load<T>(string address) where T : class;
        void Cleanup();
    }
}