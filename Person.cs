using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_1
{
    class Person
    {
        public string Title { get; private set; }
        public string Name { get;  set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int DateOfBirth { get; private set; }
        public int DeadYear { get; private set; }
       public Person Mother { get; set; }
        public Person Father { get;  set; }
        public int Id { get; private set; }

        public Person(int Id, string Title, string Name, string LastName, int Age, int DateOfBirth, int DeadYear/*, Person Mother, Person Father*//*, int Id*/)
        {
            this.Title = Title;
            this.Name = Name;
            this.LastName = LastName;
            this.Age = Age;
            this.DateOfBirth = DateOfBirth;
            this.DeadYear = DeadYear;
            this.Mother = Mother;
            this.Father = Father;
            this.Id = Id;
        }

        internal void PrintPerson()
        {
            if (Title != "") Console.WriteLine($"Title: {Title}");
            if (Name != "") Console.WriteLine($"Name: {Name}");
            if (LastName != "") Console.WriteLine($"LastName: {LastName}");
            if (Age != 0) Console.WriteLine($"Age: {Age}");
            if (DateOfBirth != 0) Console.WriteLine($"Date Of Birth: {DateOfBirth}");
            if (DeadYear !=0) Console.WriteLine($"Dead: {DeadYear}");
            if (Mother != null)Console.WriteLine($"Mother: {Mother.Name}");
            if (Father != null)Console.WriteLine($"Father: {Father.Name}");
            Console.WriteLine($"Id: {Id}");
        }

        public static void ShowPerson(string name)
        {
            var foundPerson = new List<Person>();

            foreach (var person in Royal.Persons)
            {
                if (person.Name.ToLower().Contains(name))
                {
                    Console.WriteLine();
                    foundPerson.Add(person);
                    person.PrintPerson();
                }
            }
            if (foundPerson.Count == 0)
            {
                Console.WriteLine("no Royal by this name is found, please try again");
            }

            // library.Find(b => b.Title.Contains(inputTitle));
        }
    }
}
