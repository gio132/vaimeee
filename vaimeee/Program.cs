using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatia
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    namespace Inheritance
    {

        internal class Country
        {
            public string Name { get; set; }
            public string City { get; set; }

            public int Residents { get; set; }




            public static Country Parse(string s)
            {

                string[] data = s.Split(',');

               

                int idx = 0;

                Country newCountry = new Country
                {
                    Name = data[idx++],
                    City = data[idx++],

                    Residents = int.Parse(data[idx]),
                }

                return newCountry;
            }

            private static void Main()
            {
                string[] data = File.ReadAllLines(@"C:\Users\User\source\repos\vaimeee\vaimeee\\countryes.csv");

                Country[] countryes = Array.ConvertAll(data, Country.Parse);

                Country[] GEORGIAs = Array.FindAll(countryes, MatchGeorgia);

                Console.ReadLine();
            }
            private static bool MatchGeorgia(Country obj)
            {
                return obj.Name.Contains("Georgia");
            }

        }
    }
}