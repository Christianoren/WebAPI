using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class CurriculumDBcontext : DbContext
    {
        public CurriculumDBcontext(DbContextOptions<CurriculumDBcontext> options) : base (options)
        {

        }

        public DbSet<CCandidate> CCandidates { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
    }

}
