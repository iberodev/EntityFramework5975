# EntityFramework5975

This is a Sample project created with ASP.NET Core 1.0.0 and EF Core 1.0.0
to show the issue with [the filtering problem] (https://github.com/aspnet/EntityFramework/issues/5975)

# Instructions to reproduce
* Clone this repository 
```
git clone https://github.com/iberodev/EntityFramework5975.git
```
* Restore all the dependencies
```
cd EntityFramework5975
dotnet restore
```
* Create the MSSQLLocalDB database by running the following
```
dotnet ef database update
```
* Run the application. The database will automatically be seeded with sample data.
* Trigger the sample by sending a GET request to:

```
GET localhost: http://localhost:57092/api/memory/NZ will return a list of ports whose code starts with "NZ". The filter happens in memory and it is correct.
```
```
GET localhost: http://localhost:57092/api/db/NZ will return a list of ports whose code starts with "NZ". The filter happens in database and it is inccorect since instead applying "NZ", the SQL applies a "?"
```
The sample will show that EF Core 1.0.0 does not handle properly filtering on fields of type char. This was working fine in EF Core RC2
