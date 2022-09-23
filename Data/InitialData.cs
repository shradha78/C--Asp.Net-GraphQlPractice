using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPPractice.Data
{
    public static class InitialData
    {
        public static void Seed(this StudentContext dbContext)

        {
           
            if (!dbContext.Details.Any())
            {
                dbContext.Details.Add(new Student
                {
                   
                    Name = "Jim"
                });
                dbContext.Details.Add(new Student
                {
                    
                    Name = "Brian"
                });
                dbContext.SaveChanges();
            }
        }
    }
}
