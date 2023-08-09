using UnityEngine;
using Unity.Collections;

namespace Assets.Code.Scripts.Runtime.Audio_System
{
    [CreateAssetMenu(fileName = "Audio Container", menuName = "Clicker / Data / Audio Container", order = 1)]
    public class AudioContainer : ScriptableObject
    {
        [SerializeField, ReadOnly]
        private AudioItem[] AudioItems; 
    }
}