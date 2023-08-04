using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Runtime.Data
{
    public enum TopicType
    {
        Gameplay,
        Fun,
        Cats,
        Tech,
        Dogs,
        Sports,
        Music,
        Movies,
        Food,
        Travel,
        Book,
        Charity
    }

    [Serializable]
    public class ContentData
    {
        public TopicType topicType;
    }
}
