using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2W5Assessment
{
    public class DataSeeder
    {
        public static void SeedData(ConcertContext context)
        {
            if (true)
            {
                Performers performer1 = new Performers { Name = "dave grohl", skill = "being a fucking bad ass" };
                Concert con1 = new Concert { Name = "woodstock", ShowDate = DateTime.Now.ToUniversalTime(), Performers = new List<Performers> { performer1 } };

                context.Add(con1);
                context.Add(performer1);

                context.SaveChanges();
            }
        }
    }
}
