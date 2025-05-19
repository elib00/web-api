using Microsoft.EntityFrameworkCore;
using web_api.Models;

namespace web_api
{
    public class BackendDBContext : DbContext
    {
        public BackendDBContext(DbContextOptions<BackendDBContext> options): base(options) {}


        //register models here
        public  DbSet<User> Users { get; set; }
    }
}
