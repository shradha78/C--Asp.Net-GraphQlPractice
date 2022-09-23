using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
//for mutation input
namespace ASPPractice.GraphQL
{
    public class StudentInputType :InputObjectGraphType
    {
        public StudentInputType()
        {
            Name = "studentInput";
            base.Field<NonNullGraphType<StringGraphType>>("name");
        }
    }
}
