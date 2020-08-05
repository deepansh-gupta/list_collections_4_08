using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace PersonLinked
{
    class Person
    {

        int age;
        string fname;
        string lname;
        string city;
       
        public Person()
        {

        }

        public Person(int age , string fname , string lname , string city)
        {
            this.age = age;
            this.fname = fname;
            this.lname = lname;
            this.city = city;
        }

        public void Display()
        {
            Console.WriteLine("age is: " + age + "fname is: " + fname + "lname is: " + lname + "city is: " + city);
        }
        

    }

    class PersonList
    {
        static void Main(string[] args)
        {
            List<Person> li = new List<Person>();
               new Person();
            //    new Person(10, "raju", " yadav", "indore");
            li.Add(new Person(10, "raju", " yadav", "indore"));
            li.Add(new Person(11, "ramu", " shadav", "bandore"));
            li.Add(new Person(12, "shaamu", " jadav", "chandigarh"));
            li.Add(new Person(13, "doremon", " agrawal", "bhandara"));
            li.Add(new Person(14, "nobita", " banerjee", "Nepal"));

            foreach (Person p in li)
            {
                p.Display();
            }
        }
    }
}
