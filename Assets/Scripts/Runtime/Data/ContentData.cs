using System;

namespace Assets.Scripts.Runtime.Data
{
    [Serializable]
    public class ContentData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float TimeToCreate { get; set; }
        public TopicType TopicType { get; set; }
    }
}