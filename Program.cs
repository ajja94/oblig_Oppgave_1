using System;
using System.Collections.Generic;

namespace Obligatorisk_Oppgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Royal.AddDefaultRoyal();

            Console.WriteLine("welcome to the Royal familiy tree, explore the tree and search for members og the Royal familiy");
            while (true)
            {
                Console.WriteLine();
                Console.Write("Your input please: ");
               
                var input = Console.ReadLine().ToLower();
                Console.WriteLine();
                if (input == "add")
                {
                    Person royal = CreateNewRoyal();
                    if (royal != null) Royal.Persons.Add(royal);
                }
                else if (input == "count")
                {

                    PrintPersonsCount();
                }
                //else if (input.Contains("sibling"))
                //{
                //    var Id = input.Split(' ')[1];
                //    PrintPersonsSiblings(Id);
                //}
                else if (input.Contains("show "))
                {
                    var name = input.Split(' ')[1];
                    Person.ShowPerson(name);
                }
                else if (input.Contains("list"))
                {
                    Person.ShowPerson("");
                }
                else if (input.Contains("father " )|| input.Contains("mother "))
                {
                    try
                    {
                        int id = Convert.ToInt32(input.Split(' ')[1]);
                        ShowFather(id);
                    }
                    catch
                    {
                        Console.WriteLine("Id is not a number");
                    }
                }
                else if (input == "")
                {
                    break;
                }
                else
                {
                    PrintHelp();
                }

            }
        }

        private static void ShowFather(int Id)
        {
            var children = new List<Person>();
            foreach(var person in Royal.Persons)
            {
                if (person.Father == Royal.Persons[Id] || person.Mother == Royal.Persons[Id])
                {
                    children.Add(person);
                }
            }

            foreach (var child in children)
            {
                //child.PrintPerson();
                Console.WriteLine($"{child.Name} id: {Convert.ToString(child.Id)}");  
            }
        }

        private static void PrintHelp()
        {
            Console.WriteLine("type show and the name of the person you want to search");
            Console.WriteLine("type add to Add a new menber og the Royal familiy");
            Console.WriteLine("type count to get the Number of Royals you can search trough");
            Console.WriteLine("type List to show all royals");
            Console.WriteLine("type father and the id of the father to get his childrens name ");
            Console.WriteLine("type mother and the id of the mother to get his childrens name ");
            Console.WriteLine("type enter to end ");

        }

        private static void PrintPersonsCount()
        {
            var count = Royal.Persons.Count;
            Console.WriteLine($"it is {count} Royal(s) in the Familiy tree");
        }  
        //private static void PrintPersonsSiblings(string name)
        //{
        //    var foundPerson = new List<Person>();

        //    foreach (var person in Royal.Persons)
        //    {
        //        if (person.Name.ToLower().Contains(name))
        //        {
        //            Console.WriteLine();
        //            foundPerson.Add(person);
        //            person.PrintPerson();
        //        }
        //    }
        //}

        private static Person CreateNewRoyal()
        {
            string Title;
            string Name;
            string LastName;
            int Age;
            int DateOfBirth;
            int DeadYear;
            //int Id;
            //Person Mother;
            //Person Father;

           



            Console.Write("Enter the Royal title: ");
                Title = Console.ReadLine();
                if (Title == " ")
                {
                    
                }
                Console.Write("Enter the Name: ");
                Name = Console.ReadLine();
                if (Name == " ")
                {
                }
                Console.Write("Enter the LastName: ");
                LastName = Console.ReadLine();
                if (LastName == "")
                {
                }

            while (true)
            {
                Age = 0;
                Console.Write("Enter Age: ");
                string input = Console.ReadLine();
                if (input == "") break;
                try
                {
                    Age = Convert.ToInt32(input);
                }
                catch (Exception)
                {

                    continue;
                }

                if (Age < 1)
                {
                    continue;
                }

                break;

            }
            while (true)
            {
                DateOfBirth = 0;
                Console.Write("Enter Date of Birth: ");
                string input = Console.ReadLine();
                if (input == "") break;
                try
                {
                    DateOfBirth = Convert.ToInt32(input);
                }
                catch (Exception)
                {

                    continue;
                }

                if (DateOfBirth < 1)
                {
                    continue;
                }
                

                break;

            }
            while (true)
            {
                DeadYear = 0;
                Console.Write("Enter death year og skip: ");
                string input = Console.ReadLine();
                if (input == "") break;
                DeadYear = Convert.ToInt32(input);
               
                break;

            }
            while (true)
            {
                Console.Write("Enter Mothers Name: ");
            var inputMother = Console.ReadLine();


                if (inputMother == null)
                {
                    continue;
                }

                break;

            }
            while (true)
            {
                Console.Write("Enter Fathers: ");
                var inputFather = Console.ReadLine();
                if (inputFather == null)
                {
                    continue;
                }

                break;

            }
            if(Title== "" && Name== "" && LastName == "" && Age == 0 && DateOfBirth == 0 && DeadYear == 0)
            {
                return null;
            }
            return new Person(Royal.Persons.Count, Title, Name, LastName, Age, DateOfBirth, DeadYear/*, inputMother, inputFather*/);


        }
    }
}
