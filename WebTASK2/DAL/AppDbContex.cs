using Microsoft.EntityFrameworkCore;
using WebTASK2.Models;

namespace WebTASK2.DAL
{
    public class AppDbContex:DbContext
    {

        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options) 
        {
        
        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
