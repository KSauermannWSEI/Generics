using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ShowType<T> //Klasa generyczna, przyjmuje typ podczas tworzenia instancji
    {
        public void Show()
        {
            Console.WriteLine(typeof(T));
        }
    }
}
