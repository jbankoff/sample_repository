# sample_repository
part of class demo

## Blazor + SQL Server setup

This repository now includes a Blazor Web App in `/home/runner/work/sample_repository/sample_repository/SampleBlazorApp` configured with:

- Entity Framework Core
- SQL Server provider (`Microsoft.EntityFrameworkCore.SqlServer`)
- A sample `Customer` entity and `AppDbContext`
- A `/customers` page for listing and adding records

Update `ConnectionStrings:DefaultConnection` in:

- `/home/runner/work/sample_repository/sample_repository/SampleBlazorApp/appsettings.json`

Then run:

```bash
cd /home/runner/work/sample_repository/sample_repository/SampleBlazorApp
dotnet run
```
I have edited the readme file
