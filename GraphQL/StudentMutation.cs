using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPPractice.Data;
using ASPPractice.Repository;
using GraphQL;
using GraphQL.Types;

namespace ASPPractice.GraphQL
{
    public class StudentMutation :ObjectGraphType

    {
        public StudentMutation(StudentRepository studentRepository)
        {
          
            Field<StudentType>(
            "createStudent",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StudentInputType>> { Name = "name" }),
            resolve: context =>
            {
                var stu = context.GetArgument<Student>("name");
                return studentRepository.CreateStudent(stu);
            }
        );
        }
    }
}
//Iterate to ui/playground
//mutation addStudent($studentInput : studentInput!){
/*createStudent(name: $studentInput){
    name
  }
}
In query Variables-
    {
  "studentInput":{
    "name": "joe"
  }
}

*/