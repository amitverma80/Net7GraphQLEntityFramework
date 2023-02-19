# .Net 7-> GraphQL with EF 7

This application will use .Net 7, GraphQL, Entity Framework 7 with SQL Server.

1. Create ASP.Net Web API Project.
2. Create New folder "Models" inside this project.
3. Add entity class inside Models.
4. Since we will use dependency injection, add folder for Interfaces.
6. Add Interface class. Add methods for CRUD.
7. Add folder for Service. For interface created in Step 6, implementation is required. This will be done in Service Class.
8. Add Dependency Injection in Program.cs
9. Add new folder for Controllers.
10. Add Controller class and add Dependency in constructor.
11. integrate GraphQL
	a) Install Nuget Package GraphQL.Server.Transports.AspNetCore.SystemTextJson
	b) Install Nuget Package graphiql. This will enable browser to run graphql.

12. Add folder "Type". This will hold all types for Graphql.
13. Add folder Schema. Here will have all queries and mutation for grahql.
14. Add folder for Query. This will query the records for HttpGet.
15. Add folder for Mutation. This will be for HttpPost and HttpPut verbs.
16. Add a class inside Type folder for your entity class.
17. This type clas will extend ObjectGraphType. (Eg. YourClassType:ObjectGraphType<yourModelClass>)
18. This type will be used in browser. Graphql doesn't understand the models created in .Net. 
	Therefore Type are created. 
	In browser when ctrl+space is pressed all fields are shown. 
	This is only because of Types created in this step.
19. Add class for your entity in Query folder. This class will implement : ObjectGraphType
20. Add class for Schema.
21. Add dependency in Program.cs class
22. Add Type for input data (Ad/Update/Delete) in Types folder for your Entity.
23. Add NugetPackage for EntityFramework
	a) Install Nuget Package Microsoft.EntityFrameworkCore
	b) Install Nuget Package Microsoft.EntityFrameworkCore.SqlServer

24. Add folder Data. Add class for DBContext. This will inherit from DBContext.
25. Add DBSet Property for your Model class. This will create table in Database for this entity.
26. In the service class created in Step 7, add object for this DBContext class.
27. Change Program.cs for DBContext Class.
	
	
	TO DO
======================
	
	
28. Add Unity of Work Pattern
29. Add Businss layer
30. Add Transactions, if required.
31. Add async await	

#For creating and altering database
#Add below Nuget Packages
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design

#Open Package manager console and run below commands
Add-Migration "<migration_name>"
update-database
