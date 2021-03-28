using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDNA
{
    class Person
    {
        public string name { get; set; }
        public int age;
        public string DNA { get; set; }
        public Person(string name,int age,string DNA)
        {
            this.name = name;
            this.age = age;
            this.DNA = DNA;
        }

    }
}
