using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    abstract class Soldier : ISoldier
    {
        public string FirstName { get ; set; }
        public string id { get; set; }
        public string LastName { get; set; }
        public Soldier(string id,string FirstName,string LastName)
        {
            this.id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
