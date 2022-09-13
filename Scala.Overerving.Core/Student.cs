using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scala.Overerving.Core
{
    public class Student : Person
    {
        private List<string> courses = new List<string>();

        public List<string> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public Student(string name, int age) : base(name, age)
        {
            CanVote = false;
        }

        public override string ShowId()
        {
            return $"{Name} has id {id}";
        }

    }
}
