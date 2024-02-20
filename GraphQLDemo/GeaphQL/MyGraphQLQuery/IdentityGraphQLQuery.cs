using GraphQL.Types;
using GraphQLDemo.Repository;

namespace GraphQLDemo.GeaphQL.MyGraphQLQuery
{
    public class IdentityGraphQLQuery : ObjectGraphType
    {
        public IdentityGraphQLQuery()
        {
            CustomerService customerSerice = new CustomerService();
            Field<ListGraphType<GraphQLCustomerType>>(name:"Customers",resolve:context=> customerSerice.GetCustomerList());
            CompanyService companyService = new CompanyService();
            Field<ListGraphType<GraphQLCompanyType>>(name: "Companies", resolve: context => companyService.GetCompanyList());
        }
    }
}
