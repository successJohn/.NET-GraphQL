using Courses.GraphQL.Data.Repositories;
using Courses.GraphQL.GraphQL.Types;
using GraphQL.Types;
using System;

namespace Courses.GraphQL.GraphQL.Mutations
{
    //CourseInputType = DTO
    public class CourseMutation: ObjectGraphType
    {
        public CourseMutation(CoursesRepository repository)
        {
            Field<CourseType>(
                "addCourse", // similar to the endpoint name used in rest
                "Used to add a course",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CourseInputType>>
                    )
                )
        }
    }
}
