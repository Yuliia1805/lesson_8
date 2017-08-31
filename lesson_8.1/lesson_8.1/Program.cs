using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_8._1
{
    class Program
    {
        struct Human
        {
           public string name;
           public int age;
           public char sex;
        }
        static void Main(string[] args)
        {
            /* Human person;

             person.name = "Ivan";
             person.age = 20;
             person.sex = 'm';

             Console.WriteLine(person.name + " " + person.age + " " + person.sex);*/

            Human[] persons;
            persons = new Human[5];

            persons[0].name = "Ivan";
            persons[0].age = 15;
            persons[0].sex = 'm';
            persons[1].name = "Vasia";
            persons[1].age = 32;
            persons[1].sex = 'm';
            persons[2].name = "Sveta";
            persons[2].age = 18;
            persons[2].sex = 'f';
            persons[3].name = "Ivan";
            persons[3].age = 65;
            persons[3].sex = 'm';
            persons[4].name = "Kate";
            persons[4].age = 15;
            persons[4].sex = 'f';
            foreach (Human h in persons)
            {
                Console.WriteLine(h.name + " " + h.age + " " + h.sex);
            }
            Console.WriteLine("------------------------------------------");
            //sortig
            int minAge;
            int numberminAge;
            Human tmpHuman;

            for ( int i = 0; i < persons.Length; i++)
            {
                numberminAge = i;
                minAge = persons[i].age;
                //looking for new minimum
                for (int j = i; j < persons.Length; j++)
                {
                    if (minAge < persons[j].age)
                    {
                        minAge = persons[j].age;
                        numberminAge = j;
                    }
                }
                //exchanging
                tmpHuman = persons[i];
                persons[i] = persons[numberminAge];
                persons[numberminAge] = tmpHuman;
            }
            string name1 = "Ivan";
            int a = name1.Length;
            
                foreach(Human h in persons)
            {
                Console.WriteLine(h.name + " " + h.age + " " + h.sex);

            }





            Console.ReadLine();
        }
    }
}
