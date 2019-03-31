using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Service
{
    public class Config
    {
        public static string ConnectionString = "server=.;uid=sa;pwd=@jhl85661501;database=SqlSugar4XTest";
        public static string ConnectionString2 = "server=.;uid=sa;pwd=@jhl85661501;database=SQLSUGAR4XTEST";
        public static string ConnectionString3 = "server=.;uid=sa;pwd=@jhl85661501;database=sqlsugar4xtest";

        public DbType DbType { get; internal set; }
    }
}