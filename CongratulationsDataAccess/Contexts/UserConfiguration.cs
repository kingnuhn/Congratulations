using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CongratulationsDataAccess.Contexts
{
    public class UserConfiguration
    {
        public void ConfigureUser(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(32);
            builder.Property(x =>x.Email).HasMaxLength(32);
            // TODO: Доделать
            //builder.Property(x => x.Birthday).HasConversion(s => s, s => DateTime.SpecifyKind(s, DateTime.UtcNow);

        }
    }
}
