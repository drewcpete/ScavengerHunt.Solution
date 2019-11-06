using System.Collections.Generic;

namespace ScavengerHunt.Models
{
    public class Item

    {
        public Item()
        {
            this.Quests = new HashSet<QuestItem>();

        }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemRules { get; set; }
        public ICollection<QuestItem> Quests { get; }
    }
}