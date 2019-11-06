namespace ScavengerHunt.Models
{
    public class QuestItem
    {
        public int QuestItemId { get; set; }
        public int QuestId { get; set; }
        public int ItemId { get; set; }
        public Quest Quest { get; set; }
        public Item Item { get; set; }

    }
}