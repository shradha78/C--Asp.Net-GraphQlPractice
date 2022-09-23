using ASPPractice.Data;
using GraphQL.Types;

namespace ASPPractice.GraphQL
{
    public class StudentType : ObjectGraphType<Student>
    {
        public StudentType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
        }
    }
}