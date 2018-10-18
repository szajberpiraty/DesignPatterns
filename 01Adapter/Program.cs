using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Adapter
{
    class Program
    {
        /// <summary>
        /// Feladat:körüzenet küldése ügyfeleknek
        /// Ehhez majd lesz adatbázis, illetve valamilyen üzenetküldő szolgáltatás, de 
        /// egyelőre egyik sincsen meg, de  később illeszkedni kell hozzá
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            var example = new AdapterExample();
            example.Start();
        }
    }
}
