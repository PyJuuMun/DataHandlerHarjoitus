using System;
using System.Collections.Generic;
using System.Text;

namespace DataHandlerHarjoitus
{
    public class DataHandler
    {
        public List<Person> people = new List<Person>();
        public int Counter;

        public void AddPersonToList(Person addedperson)
        {
            people.Add(addedperson);
            Console.WriteLine("Person added to the list.");
        }

        public void PrintNames()
        {
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}.  Age: {person.Age} years.");
            }
        }

        public Person CreatePerson()
        {
            Person newperson = new Person();
            Console.WriteLine("What is your name?");
            //yhdistää lisätyn nimen objectiin 'newperson'
            newperson.Name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            newperson.Age = Convert.ToInt32(Console.ReadLine());
            return newperson;
        }
    }
}
