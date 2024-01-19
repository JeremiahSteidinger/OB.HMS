using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OB.HMS.Enities.Users
{
    public static class EnvironmentVariables
    {
        public static string DbConnectionString => Environment.GetEnvironmentVariable("ConnectionString");
        public static string MySqlVersion =>  Environment.GetEnvironmentVariable("MySqlVersion");
    }
}
