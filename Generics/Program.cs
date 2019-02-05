using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        class Person //Przykładowa klasa nadrzędna
        {
            public Person()
            {

            }
            public Person(string name)
            {
                Name = name;
            }
            public string Name { get; set; }
        }
        class Joanna : Person //Przykladowa klasa pochodna
        {
            public string LastName { get; set; }
        }
        static void Main(string[] args)
        {
            var genericMethods = new GenericMethods();

            Joanna joanna = new Joanna
            {
                Name = "Aśka", //Właściwość klasy bazowej Person
                LastName = "Kowalska"
            };
        
            Person person = genericMethods.ReturnT<Person>();

            person = joanna as Person; //Konwersja typów za pomoca operatora as (możliwa jesli typ na który konwertujemy to typ nadrzędny)

            ShowType<string> str = new ShowType<string>(); //Instrancja klasy generycznej z typem string
            ShowType<int> intObject = new ShowType<int>(); //Instrancja klasy generycznej z typem int
            str.Show();
            intObject.Show();

            //Przyklad z dodawaniem.
            int a = 1;
            int b = 2;
            
            //int c = genericMethods.GetSum(a, b); // zapis uproszczony - kompilator wie jakiego typu jest T, dlatego że przekazujemy go jako parametry
            int c = genericMethods.GetSum<int>(a, b);
            Console.WriteLine(c);

            string aa = "1";
            string bb = "2";                   
            string cc = genericMethods.GetSum<string>(aa, bb);
            Console.WriteLine(cc);

            Console.Read();
        }
    }
}
