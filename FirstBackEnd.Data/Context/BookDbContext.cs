using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstBackEnd.Data.Context
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
