
using System.Collections.Generic;

namespace ScavengerHunt.Models
{
    public class Quest
    {
        public Quest()
        {
    
            this.Item = new HashSet<QuestItem>();
        }

        public int QuestId { get; set; }
        public string Name { get; set; }
        public string Rules { get; set; }
        public ICollection<QuestItem> Item { get; }

    }
}