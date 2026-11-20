using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Nkust.InspectPlan.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class InspectPlanDbContextFactory : IDesignTimeDbContextFactory<InspectPlanDbContext>
{
    public InspectPlanDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        InspectPlanEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<InspectPlanDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));
        
        return new InspectPlanDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Nkust.InspectPlan.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables();

        return builder.Build();
    }
}
