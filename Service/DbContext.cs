
using Model;
using SqlSugar;
using System.Collections.Generic;

namespace Service
{
    public class DbSet<T> : SimpleClient<T> where T : class, new()
    {
        public DbSet(SqlSugarClient context) : base(context)
        {

        }
        //SimpleClient中的方法满足不了你，你可以扩展自已的方法
        public List<T> GetByIds(dynamic[] ids)
        {
            return Context.Queryable<T>().In(ids).ToList(); ;
        }
    }

    public class DbContext
    {
        public DbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = Config.ConnectionString2,
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,//开启自动释放模式和EF原理一样我就不多解释了
                           //InitKey默认SystemTable
            });
        }
        public SqlSugarClient Db;//用来处理事务多表查询和复杂的操作
        public DbSet<Movie> MovieDb { get { return new DbSet<Movie>(Db); } }//用来处理Student表的常用操作

       
    }
}