using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    struct Person 
    {
		private int age;

		public int Age	
		{
			get { return age; }
			set
            {
                if (value >= 20 && value <= 50)
                {
                    age = value;
                }
            }
		}

		private string name;

        public Person(int age, string name) : this()
        {
            Age = age;
            Name = name;
        }

        public string Name
		{
			get { return name; }
			set
            {
                if (value is not null)
                    name = value;
            }
		}



		public override string ToString()
		=> $"Age = {Age} :: Name = {Name}";
        

	}
}
