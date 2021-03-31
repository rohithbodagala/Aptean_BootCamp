using System;
namespace Catalog
{
    class Music : Item
    {
        public string Singer;
        public int Length;
        public Music(string Name, string Code, Category category, double Size,string Singer,int Length) : base(Name,Code,category,Size) 
        {
            this.Singer = Singer;
            this.Length = Length;
        }
        public void Play()
        {
            // TODO
        }
        public override string RetrieveInformation()
        {
            return $"{base.RetrieveInformation()}Singer:{Singer}\nLength:{Length} s";
        }

    }
}