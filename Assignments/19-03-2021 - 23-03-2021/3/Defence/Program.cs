using System;
using System.Collections.Generic;
using System.Linq;

namespace Defence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            Dictionary<string,Private> PersonDetails = new Dictionary<string, Private>();
            string[] corps = { "Airforces", "Army", "Navy" };
           
            var line = Console.ReadLine();
            while (!line.Equals("End"))
            {
                lines.Add(line);
                line = Console.ReadLine();
            }
            foreach(var i in lines)
            {
                try
                {
                    var input = i.Split(' ');

                    if (input[0].Equals(typeof(Private).Name))
                    {

                        Private p = new Private(input[1], input[2], input[3], double.Parse(input[4]));
                        PersonDetails.Add(input[1], p);
                        Console.WriteLine(p.ToString());



                    }
                    else if (input[0].Equals(typeof(Commando).Name))
                    {

                        if (corps.Contains(input[5]))
                        {
                            string[] states = { "inProgress", "finished" };
                            List<Mission> missions = new List<Mission>();
                            for (int t = 6, k = 7; t < input.Length && k < input.Length; t = t + 2, k = k + 2)
                            {

                                if (states.Contains(input[k]))
                                {
                                    missions.Add(new Mission(input[t], input[k]));
                                }


                            }
                            Private c = new Commando(input[1], input[2], input[3], double.Parse(input[4]), input[5], missions);
                            PersonDetails.Add(input[1], c);
                            Console.WriteLine(c.ToString());


                        }
                        else
                        {
                            Console.WriteLine("Invalid Corps!");
                        }

                    }
                    else if (input[0].Equals(typeof(LeutenantGeneral).Name))
                    {
                        List<Private> privates = new List<Private>();
                        for (var t = 5; t < input.Length; t++)
                        {
                            Private p;
                            if (PersonDetails.TryGetValue(input[t], out p))
                            {
                                privates.Add(p);
                            }



                        }
                        Private l = new LeutenantGeneral(input[1], input[2], input[3], double.Parse(input[4]), privates);
                        PersonDetails.Add(input[1], l);
                        Console.WriteLine(l.ToString());
                    }
                    else if (input[0].Equals(typeof(Engineer).Name))
                    {
                        List<Repair> repairs = new List<Repair>();
                        for (int t = 6, k = 7; t < input.Length && k < input.Length; t = t + 2, k = k + 2)
                        {
                            repairs.Add(new Repair(input[t], int.Parse(input[k])));
                        }
                        Private e = new Engineer(input[1], input[2], input[3], double.Parse(input[4]), input[5], repairs);
                        PersonDetails.Add(input[1], e);
                        Console.WriteLine(e.ToString());
                    }


                }
                catch (Exception)
                {
                    Console.WriteLine("Invald Input!");
                }
                

            }
            
        }
    }
}
