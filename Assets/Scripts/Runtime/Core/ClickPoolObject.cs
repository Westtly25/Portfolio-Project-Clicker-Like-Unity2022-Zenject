using UnityEngine;

namespace Assets.Scripts.Runtime.Core
{
    public class ClickPoolObject : MonoBehaviour
    {
        [SerializeField]
        private Transform cachedTransform;

        private void OnEnable() =>
            cachedTransform ??= transform;

        public void SetSpawnPosition(Vector3 to) =>
            cachedTransform.position = to;
    }
}