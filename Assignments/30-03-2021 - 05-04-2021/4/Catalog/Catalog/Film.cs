namespace Catalog
{
    class Film : Item
    {
        public string Director, MainActor,MainActress;
        public Film(string Name, string Code, Category category, double Size, string Director,string MainActor,string MainActress) : base(Name, Code, category, Size)
        {
            this.Director = Director;
            this.MainActor = MainActor;
            this.MainActress = MainActress;
        }
        public void Play()
        {
            // TODO
        }
        public override string RetrieveInformation()
        {
            return $"{base.RetrieveInformation()}Director: {Director}\nMain Actor: {MainActor}\nMain Actress: {MainActress}";
        }
    }
}