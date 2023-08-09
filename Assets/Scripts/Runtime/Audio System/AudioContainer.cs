using UnityEngine;
using Unity.Collections;

namespace Assets.Code.Scripts.Runtime.Audio_System
{
    [CreateAssetMenu(menuName = "Match3 / Audio Container", fileName = "Audio Container", order = 1)]
    public class AudioContainer : ScriptableObject
    {
        [SerializeField, ReadOnly]
        private AudioItem[] AudioItems; 
    }
}