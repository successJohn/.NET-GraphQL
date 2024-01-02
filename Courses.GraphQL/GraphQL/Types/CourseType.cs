using Courses.GraphQL.Data.Models;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Types
{
    //In order to create an object type of graphql, we need to inherit from the
    //base class object graph type and pass as a parameter the model name 

    public class CourseType:ObjectGraphType<Course>
    {
        public CourseType()
        {
            // These is equivalent to defining the properties in a class
            Field(x => x.Id, type: typeof(IdGraphType)).Description(" Course Id Property");
            Field(x => x.Description, type: typeof(StringGraphType)).Description(" Course Description");
            Field(x => x.Name, type: typeof(StringGraphType)).Description(" Course Name");
            Field(x => x.Review, type: typeof(IntGraphType)).Description(" Course Review");
            Field(x => x.DateAdded, type: typeof(DateTimeGraphType)).Description(" Course Description");
            Field(x => x.DateUpdated, type: typeof(DateTimeGraphType)).Description(" Course Description");
        }
    }
}
