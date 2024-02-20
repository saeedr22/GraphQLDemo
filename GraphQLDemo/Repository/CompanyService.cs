using GraphQLDemo.Models;

namespace GraphQLDemo.Repository
{
    public class CompanyService
    {
        List<Company> companies = new List<Company>();
        public CompanyService()
        {
            companies.Add(new Company() { CompanyId=1,Name="Microsoft",Address= " Evert van de Beekstraat 354, 1118 CZ Schiphol" });
            companies.Add(new Company() { CompanyId=2,Name="Ibm",Address= "Johan Huizingalaan 765, 1066 VH Amsterdam" });
        }

        public List<Company> GetCompanyList() => companies;
    }
}
