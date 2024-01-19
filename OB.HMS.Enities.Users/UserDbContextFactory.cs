using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OB.HMS.Enities.Users
{
    public class UserDbContextFactory : IDesignTimeDbContextFactory<UserDbContext>
    {
        public UserDbContext CreateDbContext(string[] args)
        {
            string connectionString = EnvironmentVariables.DbConnectionString;
            string MySqlVersion = EnvironmentVariables.MySqlVersion;

            var options = new DbContextOptionsBuilder<UserDbContext>();

            options.UseMySql(connectionString, new MySqlServerVersion(MySqlVersion));

            return new UserDbContext(options.Options);
        }
    }
}
