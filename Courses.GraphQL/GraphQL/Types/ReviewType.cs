using Courses.GraphQL.Data.Models;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Types
{
    public class ReviewType:ObjectGraphType<Review>
    {
        public ReviewType()
        {
            // These is equivalent to defining the properties in a class
            Field(x => x.Id, type: typeof(IdGraphType)).Description(" Course Id Property");
            Field(x => x.Rate, type: typeof(IntGraphType)).Description("Rate");
            Field(x => x.Comment, type: typeof(StringGraphType)).Description("Comment");
                    
        }
    }
}
