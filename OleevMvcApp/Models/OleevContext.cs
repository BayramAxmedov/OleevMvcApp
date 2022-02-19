

using Microsoft.EntityFrameworkCore;

namespace OleevMvcApp.Models
{
    public class OleevContext:DbContext
    {

        public OleevContext(DbContextOptions opt):base(opt)
        {

        }
        public DbSet<SectionOne> SectionOnes { get; set; }
        public DbSet<SectionTwo> SectionTwos { get; set; }
        public DbSet<SectionThree> SectionThrees { get; set; }
        public DbSet<SectionFour> SectionFours { get; set; }
        public DbSet<SectionFive> SectionFives { get; set; }
        public DbSet<SectionSix> SectionSixes { get; set; }
        public DbSet<SectionSeven> SectionSevens { get; set; }
        public DbSet<SectionEight> sectionEights { get; set; }
        public DbSet<SectionNine> sectionNines { get; set; }
        public DbSet<SectionTen> sectionTens { get; set; }
        public DbSet<SectionEleven> sectionElevens { get; set; }

    }
}
