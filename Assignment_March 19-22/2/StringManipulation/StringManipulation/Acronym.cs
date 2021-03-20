using System;

namespace StringManipulation
{
    class Acronym
    {
        string Sentence;

        public Acronym(string Sentence)
        {
            this.Sentence = Sentence;
        }

        public string RemoveSpecialCharacter()
        {
            int j = 0;
            string NormalSentence = "";
            for (int i = 0; i < Sentence.Length; i++)
            {
                if ((Sentence[i] >= 'A' && Sentence[i] <= 'Z') || (Sentence[i] >= 'a' && Sentence[i] <= 'z') || Sentence[i] == ' ')
                {
                    NormalSentence += Sentence[i];
                    j++;
                }
            }
            return NormalSentence;
        }
        public void FindAcronymUsingFor(string NormalSentence)
        {
            Console.WriteLine($"-------Using For---------");
            int i, j = 1;
            string AcronymOfString = "";
            AcronymOfString  += NormalSentence[0];
            for (i=1;i<NormalSentence.Length;i++)
            {
                if(NormalSentence[i] ==' ')
                {
                    
                    AcronymOfString += NormalSentence[i+1];
                    j++;
                }
            }
            GetAcronym(AcronymOfString);
          
        }
        public void FindAcronymUsingForEach(string NormalSentence)
        {
            Console.WriteLine($"-------Using ForEach---------");
            string AcronymOfString = "";
            bool isAcronymCharacter = true;
            foreach(var ch in NormalSentence)
            {
                if (isAcronymCharacter)
                {
                    AcronymOfString += ch;
                    isAcronymCharacter = false;
                }
                if(ch==' ')
                {
                    isAcronymCharacter = true;
                }

            }
            GetAcronym(AcronymOfString);

        }
        public void FindAcronymUsingWhile(string NormalSentence)
        {
            Console.WriteLine($"-------Using While---------");
            int i=1, j = 1;
            string AcronymOfString = "";
            AcronymOfString += NormalSentence[0];
            while(i < NormalSentence.Length)
            {
                if (NormalSentence[i] == ' ')
                {

                    AcronymOfString += NormalSentence[i + 1];
                    j++;
                }
                i++;
            }
            GetAcronym(AcronymOfString);

        }
        public void FindAcronymUsingDoWhile(string NormalSentence)
        {
            Console.WriteLine($"-------Using Do-While---------");
            int i=1, j = 1;
            string AcronymOfString = "";
            AcronymOfString += NormalSentence[0];
            do
            {
                if (NormalSentence[i] == ' ')
                {

                    AcronymOfString += NormalSentence[i + 1];
                    j++;
                }
                i++;
            }
            while (i < NormalSentence.Length);
            GetAcronym(AcronymOfString);

        }
        public void GetAcronym(string AcronmyOfString)
        {
            Console.WriteLine($"The Acronmy of the given Sentence is : {AcronmyOfString.ToUpper()}");
        }


        

    

    static void Main(string[] args)
        {
            Console.WriteLine("Enter the Sentence:");
            string Sentence = Console.ReadLine();
            Acronym obj = new Acronym(Sentence);
            string NormalSentence=obj.RemoveSpecialCharacter();
            obj.FindAcronymUsingFor(NormalSentence);
            obj.FindAcronymUsingForEach(NormalSentence);
            obj.FindAcronymUsingWhile(NormalSentence);
            obj.FindAcronymUsingDoWhile(NormalSentence);

        }
    }
}
