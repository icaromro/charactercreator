namespace CharCreator.Model.Entity
{
    public class Character3det
    {
        public long id { get; set; }
        public long character_id { get; set; }
        public Character character { get; set; }
        public int scale_id { get; set; }
        public int max_helth { get; set; }
        public int max_mana { get; set; }
        public int current_helth { get; set; }
        public int current_mana { get; set; }
    }
}
