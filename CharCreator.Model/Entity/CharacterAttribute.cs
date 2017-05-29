namespace CharCreator.Model.Entity
{
    public class CharacterAttribute
    {
        public short id { get; set; }
        public short system_id { get; set; }
        public short attribute_type_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public short value { get; set; }
        public short bonus { get; set; }
    }
}
