using Courses.GraphQL.Data.Models;
using Courses.GraphQL.Data.Repositories;
using Courses.GraphQL.GraphQL.Types;
using GraphQL;
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
                    new QueryArgument<NonNullGraphType<CourseInputType>> { Name = "course", Description = "Course input parameter" }
                    ),
                resolve: context =>
                {
                    var course = context.GetArgument<Course>("course");
                    return repository.AddCourse(course);
                });


            Field<CourseType>(
               "updateCourse", // similar to the endpoint name used in rest
               "Used to update an course",
               arguments: new QueryArguments(
                   new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id", Description = "Course id to be updated" },
                   new QueryArgument<NonNullGraphType<CourseInputType>> { Name = "course", Description = "updated course value" }
                   ),
               resolve: context =>
               {
                   var id = context.GetArgument<int>("id");
                   var course = context.GetArgument<Course>("course");
                   return repository.UpdateCourse(id, course);
               });


            Field<CourseType>(
                "DeleteCourse",
                "Used to delete a course",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id", Description = "Course Id to be deleted" }
                ),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                     repository.DeleteCourse(id);
                    return true;
                });
        }
    }
}
