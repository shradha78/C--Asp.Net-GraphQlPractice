using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace ASPPractice.GraphQL
{
    public class StudentSchema : Schema 
    {
        public StudentSchema(IServiceProvider resolver) : base(resolver) //IserviceProvider -> special service with method getService() -> pass class which contains query
        {
            Query = (IObjectGraphType)resolver.GetService(typeof(StudentQuery));
            Mutation = resolver.GetRequiredService<StudentMutation>();//standard syntax for using graph ql

        }
        
    }
}
//resolver is for resolving query
//get service -> get object of all the query in studentquery
