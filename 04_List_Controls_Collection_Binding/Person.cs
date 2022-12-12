using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_List_Controls_Collection_Binding
{
    internal class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime Birth { get; set; }
        public string FullName => Name + " " + SurName;
        public override string ToString()
        {
            return $" {Name}  {SurName} - {Birth.ToLongDateString()}";
        }
    }
}
