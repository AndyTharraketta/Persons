using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    internal class Personen
    {
        // Selbstversuch
        //public string name;
        //public int age;
        //public string job;

        //public Personen(string _name,int _age,string _job)
        //{
        //    name = _name;
        //    age = _age;
        //    job = _job;
        //    Console.WriteLine($"Ein neuer User mit folgenden Daten wurde erstellt:\nName: {_name}\nAlter: {_age}\nBeruf: {_job}");

        //}

        //public string Welcome()
        //{
        //    string info = $"Hallo {name}! Du bist {age} Jahre alt/jung! Dein Beruf {job} ist sehr Interessant!";
        //    return info;
        //}

        // Korrektur

        public string Name;
        public int Alter;
        public string Beruf;

        public Personen(string wert1, int wert2, string wert3)
        {
            Name = wert1;
            Alter = wert2;
            Beruf = wert3;
        }

        public void Begruessung(string userName)
        {
            Console.WriteLine($"Hallo {userName} ich bin {Name}");
        }

        public void Infos()
        {
            Console.WriteLine($"Name: {Name}\nAlter: {Alter}\nBeruf: {Beruf}");
        }


    }
}
