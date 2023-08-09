using UnityEngine;
using Unity.Collections;

namespace Assets.Scripts.Runtime.Room_Decorations
{
    [CreateAssetMenu(fileName = "Decorations Container", menuName = "Clicker / Data / Decorations Container", order = 1)]
    public class DecorationsContainer
    {
        [SerializeField, ReadOnly]
        private DecorationObject[] DecorationObjects;
    }
}
