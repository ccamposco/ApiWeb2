using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiWeb2.Models;

namespace ApiWeb2.Data
{
    public class ApiWeb2Context : DbContext
    {
        public ApiWeb2Context (DbContextOptions<ApiWeb2Context> options)
            : base(options)
        {
        }

        public DbSet<Persona> Persona { get; set; }
    }
}
