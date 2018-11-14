using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Entities
{
    public class ApplicationDbContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }

        private static string GetConnectionString()
        {
            //const string serverName = "10.0.75.1,1433;";
            //const string databaseName = "sampleapidb";
            //const string databaseUser = "sa";
            //const string databasePass = "Mydev#333";

            const string serverName = "spottumuttuatosius.database.windows.net,1433;";
            const string databaseName = "sampleapidb";
            const string databaseUser = "sampleapiadmin";
            const string databasePass = "Mydev#333";

            return $"Server={serverName}" +
                   $"database={databaseName};" +
                   $"uid={databaseUser};" +
                   $"pwd={databasePass};" +
                   $"pooling=true;";
        }
    }
}
