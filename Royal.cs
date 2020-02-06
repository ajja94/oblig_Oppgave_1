using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_1
{
    static class Royal
    {
        public static List<Person> Persons { get; set; } = new List<Person>();

        public static void AddDefaultRoyal()
        {
           Persons.Add(new Person(0,"Tidligere Konge","Olav", "VII",87, 1903, 1991));
           Persons.Add(new Person(1,"Tidligere Dronning", "Märtha", "Dronning av norge", 53, 1901, 1954));
           Persons.Add(new Person(2,"Konge", "Harald", "den Femte", 82, 1937));
           Persons.Add(new Person(3,"Dronning", "Sonja", "av Norge", 82, 1937));
           Persons.Add(new Person(4,"Prinsesse", "Märtha-Louise", "av Norge", 48, 1971)); 
           Persons.Add(new Person(5,"Kron prins", "Haakon", "den Femte", 46, 1973));
           Persons.Add(new Person(6,"Kron prinsesse", "Mette-Marit", "av Norge", 46, 1973 ));
           Persons.Add(new Person(7,"prins", "Sverre Magnus", "av Norge", 14, 2005 ));
           Persons.Add(new Person(8,"prinsesse", "Ingerid Alexandra", "av Norge", 15, 2004 ));
           Persons.Add(new Person(9,"", "Marius", "Borg Høiby", 23, 1997 ));

            Persons[3].Mother = Persons[1];
            Persons[3].Father = Persons[0];

            Persons[5].Mother = Persons[3];
            Persons[5].Father = Persons[2];

            Persons[7].Mother = Persons[6];
            Persons[7].Father = Persons[5];
            Persons[8].Mother = Persons[6];
            Persons[8].Father = Persons[5];
            Persons[9].Mother = Persons[6];
            Persons[9].Father = Persons[6];
        }
       
    }
}
