using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchElement
{
    internal class Program
    {
        static void Main(string[] args)
        {

             string[] locations = { "Centennial", "Denver", "Greeley", "Lakewood", "Limerick" };

             var searchResult = Array.Find(locations, element => element.StartsWith("l".ToUpper()));

             Console.WriteLine(searchResult);
        }
    }
}

