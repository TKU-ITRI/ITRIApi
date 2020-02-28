using ITRI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ITRI.Models.Helper
{
    public partial class ContextExt : ITRIContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
