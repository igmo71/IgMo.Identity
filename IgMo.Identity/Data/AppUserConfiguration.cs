using Microsoft.EntityFrameworkCore;
using IgMo.Identity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IgMo.Identity.Data
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
