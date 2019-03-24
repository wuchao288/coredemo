using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
 public class MvcMovieContext:DbContext
 {
     public  MvcMovieContext(DbContextOptions<MvcMovieContext> options):base(){
 
     }
     public DbSet<MvcMovie.Models.Movie> Movies{get;set;}
 }
}