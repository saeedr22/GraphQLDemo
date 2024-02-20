using GraphQL.Types;
using GraphQLDemo.Models;
using GraphQLParser.AST;

namespace GraphQLDemo.GeaphQL
{
    public class GraphQLCompanyType : ObjectGraphType<Company>
    {
        public GraphQLCompanyType()
        {
            Field(x => x.CompanyId);
            Field(x => x.Name);
            Field(x => x.Address);
        }
    }
}
