using CinemaHelper.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaHelper.Server.Extensions
{
    public static class MigrationExtension
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();

            using AuthDataContext authContext = scope.ServiceProvider.GetRequiredService<AuthDataContext>();
            using DataContext context = scope.ServiceProvider.GetRequiredService<DataContext>();

            authContext.Database.Migrate();
            context.Database.Migrate();
        }
    }
}
