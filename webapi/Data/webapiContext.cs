#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapi;

namespace webapi.Data
{
    public class webapiContext : DbContext
    {
        public webapiContext()
        {
        }

        public webapiContext (DbContextOptions<webapiContext> options)
            : base(options)
        {
        }

        public DbSet<webapi.Book> Book { get; set; }
    }
}
