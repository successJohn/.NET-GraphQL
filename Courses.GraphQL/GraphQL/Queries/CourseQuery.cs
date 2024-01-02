using Courses.GraphQL.Data.Repositories;
using Courses.GraphQL.GraphQL.Types;
using GraphQL;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Queries
{
    public class CourseQuery: ObjectGraphType
    {
        public CourseQuery(CoursesRepository repository)
        {
            // define the return 
            Field<ListGraphType<CourseType>>(
                "courses",
                "Returns list of courses ",
                resolve: context => repository.GetAllCourses()
                );

            Field<CourseType>(
                  "course",
                  "Returns a coursebyId ",
                   new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "CourserId" }),
                   resolve: context => repository.GetCourseById(context.GetArgument("id", int.MinValue))
                );
                
        }


      
    }
}
