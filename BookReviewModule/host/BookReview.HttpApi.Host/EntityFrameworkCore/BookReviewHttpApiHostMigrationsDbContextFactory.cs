using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BookReview.EntityFrameworkCore;

public class BookReviewHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<BookReviewHttpApiHostMigrationsDbContext>
{
    public BookReviewHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BookReviewHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("BookReview"));

        return new BookReviewHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
