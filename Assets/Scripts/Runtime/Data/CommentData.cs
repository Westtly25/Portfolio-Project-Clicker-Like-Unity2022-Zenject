using System;

namespace Assets.Scripts.Runtime.Data
{
    [Serializable]
    public class CommentData
    {
        public int Id { get; }
        public string Text { get; }
        public bool IsPositive { get; }
    }
}