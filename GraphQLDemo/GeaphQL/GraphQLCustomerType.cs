using GraphQL.Types;
using GraphQLDemo.Models;

namespace GraphQLDemo.GeaphQL
{
    public class GraphQLCustomerType: ObjectGraphType<Customer>
    {
        public GraphQLCustomerType()
        {
            Field(x => x.CustomerId);
            Field(x => x.FirstName);
            Field(x => x.LastName);
            Field(x => x.Age);
            Field(x => x.City);
        }
    }
}
