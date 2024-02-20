using GraphQL.Types;
using GraphQLDemo.GeaphQL.MyGraphQLQuery;

namespace GraphQLDemo.GeaphQL.MyGraphQLSchema
{
    public class IdentityGraphQLSchema : Schema
    {
        public IdentityGraphQLSchema(IServiceProvider serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<IdentityGraphQLQuery>();
        }
    }
}
