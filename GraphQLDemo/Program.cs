using GraphQL.Types;
using GraphQLDemo.GeaphQL.MyGraphQLQuery;
using GraphQLDemo.GeaphQL;
using GraphQLDemo.GeaphQL.MyGraphQLSchema;
using GraphQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ISchema, IdentityGraphQLSchema>();
builder.Services.AddSingleton<IdentityGraphQLQuery>();
builder.Services.AddSingleton<GraphQLCustomerType>();
builder.Services.AddSingleton<GraphQLCompanyType>();
builder.Services.AddGraphQL(b => b
    .AddAutoSchema<IdentityGraphQLQuery>()  // schema
    .AddSystemTextJson());   // serializer

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseGraphQL<ISchema>("/graphql");            // url to host GraphQL endpoint
app.UseGraphQLPlayground(
    "/",                               // url to host Playground at
    new GraphQL.Server.Ui.Playground.PlaygroundOptions
    {
        GraphQLEndPoint = "/graphql",         // url of GraphQL endpoint
        SubscriptionsEndPoint = "/graphql",   // url of GraphQL endpoint
    });
app.Run();
