using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    class Mission : IMission
    {
        public string codeName { get; set ; }
        public string state { get; set; }
        public string[] possibleStates = new string[]{ "InProgress","Finished" };
        public Mission(string codeName,string state)
        {
            this.codeName = codeName;
            this.state = state;
        }
        public void CompleteMission()
        {
            this.state = "Finished";
        }
        public override string ToString()
        {
            return $"Code Name:{codeName} State:{state}";
        }

    }
}
