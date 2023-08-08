using UnityEngine;
using Unity.Collections;
using Assets.Scripts.Runtime.Data;

namespace Assets.Scripts.Runtime.Scriptable_Objects_Data
{
    [CreateAssetMenu(fileName = "Comments Data Container", menuName = "Clicker / Data / Comments Data Container", order = 1)]
    public class CommentsDataContainer
    {
        [SerializeField, ReadOnly]
        public CommentData[] Comments;
    }
}