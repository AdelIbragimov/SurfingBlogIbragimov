using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestIbragimov.Models;

namespace TestIbragimov.DAL
{
    public class DataContextInitializer
    { 
        public static void Initialize(DataContext context)

    { 
         if (!context.Users.Any())
            {
            var user = new User();
             user.Name = "system";
        context.Users.Add(user);
            context.SaveChanges();
            }
    }
}
}
