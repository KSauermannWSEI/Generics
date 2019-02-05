using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericMethods
    {
        public T GetSum<T>(T first, T second) //Sumuje dwa obiekty tego samego typu
        {
            try
            {
                dynamic f = first;
                dynamic s = second;
                return f + s;
            }
            catch
            {
                throw new Exception($"Nieprawidłowy typ: {typeof(T)}, nie mozna dodać przekazanego typu"); //Przykładowy wyjątek dla programisty
            }

        }
        public T ReturnT<T>() where T : new() //Zwraca nowy obiekt danego typu
        {
            return new T();
        }
    }
}
