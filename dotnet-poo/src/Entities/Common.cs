namespace dotnet_poo.src.Entities
{
    public  class Common
    {
        public string? Name { get; set; }
        public int Level { get; set; }
        public string? Type { get; set; }

        public Common()
        {}
        public Common(string name, string heroType, int level)
        {
            Name = name;
            Type = heroType;
            Level = level;
        }

        public override string ToString()
        {
            return $@"
                Name: {Name},
                Type: {Type},
                Level: {Level}
            ";
        }

        public virtual string Talk()
        {
            return "";
        }
    }
}