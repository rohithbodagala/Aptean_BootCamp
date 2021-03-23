using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    class Commando : SpecialisedSoldier, ICommando
    {
        

        public List<Mission> missions { get ; set ; }
        public Commando(string id, string FirstName, string LastName, double salary, string corps,List<Mission> missions) : base(id, FirstName, LastName, salary,corps)
        {
            this.missions = missions;
        }
        public override string ToString()
        {
            string m = "";
            m += $"{base.ToString()}\nMissions:\n";
            foreach (var mission in missions)
            {
                m +=$"{mission.ToString()}\n";
            }
            return m;
        }
    }
}
