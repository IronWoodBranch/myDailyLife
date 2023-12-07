using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Youshow.Ace.Data;
using Youshow.Ace.EntityFrameworkCore;

namespace dotnet.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class dotnetDbContext : AceDbContext<dotnetDbContext>
    {
        public dotnetDbContext(DbContextOptions<dotnetDbContext> options) : base(options)
        {
        }
    }
}
