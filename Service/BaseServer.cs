using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BaseServer<T> : DbContext where T : class, new()
    {
        public DbSet<T> GetDb()
        {

            return new DbSet<T>(Db);
        }
        public async Task<string> AddAsync(T parm)
        {
            try
            {
                var dbres = GetDb().Insert(parm);
               
            }
            catch (Exception ex)
            {

            }
            return await Task.Run(() => "OK");
        }
        public async Task<List<T>> GetModelAsync()
        {
            List<T> lsit = new List<T>();
            try
            {
                lsit = GetDb().GetList();
            }
            catch (Exception ex)
            {

            }
            return await Task.Run(() => lsit);
        }
    }
    public class MovieServer : BaseServer<Movie>
    {

    }
  }