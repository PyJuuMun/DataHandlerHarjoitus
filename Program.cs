using System;

namespace DataHandlerHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.Name = "";
            //person.Age = ;
            //person.Employment = true/false;
            //person.Hobbies.Add("");

            Person person1 = new Person();
            person1.Name = "Tommi";
            person1.Age = 44;
            person1.Employment = true;
            person1.Hobbies.Add("Kalastus");
            person1.Hobbies.Add("Lenkkeily");

            Person person2 = new Person();
            person2.Name = "Marika";
            person2.Age = 67;
            person2.Employment = false;
            person2.Hobbies.Add("Uinti");
            person2.Hobbies.Add("Lenkkeily");
            person2.Hobbies.Add("Kudonta");

            Person person3 = new Person();
            person3.Name = "Matias";
            person3.Age = 19;
            person3.Employment = false;
            person3.Hobbies.Add("Tietokonepelit");
            person3.Hobbies.Add("Kitaran soitto");

            Person person4 = new Person();
            person4.Name = "Aleksi";
            person4.Age = 32;
            person4.Employment = true;
            person4.Hobbies.Add("Videopelit");

            Person person5 = new Person();
            person5.Name = "Julia";
            person5.Age = 26;
            person5.Employment = true;
            person5.Hobbies.Add("Laulaminen");
            person5.Hobbies.Add("Tanssiminen");

            //person objectit lisätty dataHandler objectiin/listaan
            DataHandler dataHandler = new DataHandler();
            dataHandler.AddPersonToList(person1);
            dataHandler.AddPersonToList(person2);
            dataHandler.AddPersonToList(person3);
            dataHandler.AddPersonToList(person4);
            dataHandler.AddPersonToList(person5);

            //kutsuu PrintNames metodin DataHandler classista ja käy objectissa olevat nimet/iät läpi
            dataHandler.PrintNames();

            dataHandler.CreatePerson();
        }
    }
}
