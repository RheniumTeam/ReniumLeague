using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReniumLeague.Entity
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var db = new RheniumSportsEntities())
            {
                Console.WriteLine(db.Matches.FirstOrDefault());
            }
        }
    }
}
