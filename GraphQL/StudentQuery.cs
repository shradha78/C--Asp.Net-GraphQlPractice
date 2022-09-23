using ASPPractice.Data;
using ASPPractice.Repository;
using GraphQL;
using GraphQL.Types;

namespace ASPPractice.GraphQL
{
    public class StudentQuery : ObjectGraphType
    {
        public StudentQuery(StudentRepository studentRepository)
        {
            Field<ListGraphType<StudentType>> ( //specify student type or listgraphtype
                "studentsQueryName", //query name
                resolve: context => studentRepository.GetStudents() //how to be resolved //resolve gets lambda expression context is parameter here
                ); //query is returning field of list of studenttype 
            //for query by studentType
            Field<StudentType>( //specify student type or listgraphtype
               "studentById", 
               arguments :new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "Id"}),
               resolve: context =>
               {
                   int id = context.GetArgument<int>("Id");
                   return studentRepository.GetStudentWithId(id);
               } //how to be resolved //resolve gets lambda expression context is parameter here
               );
        }
    }
}
//id string query boolean mutation studentObject(Custom)-> graphtype