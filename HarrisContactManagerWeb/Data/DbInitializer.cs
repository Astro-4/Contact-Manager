using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactManagerWeb.Data
{
    public class DbInitializer
    {
        public static void Initialize(HarrisDbContext context) {
            context.Database.EnsureCreated();
        }
    }
}
