using DataAccess.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistencia.Confi
{
   public class UserConfi: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entityUser)
        {
            entityUser.Property(x => x.Name)
                .IsRequired(true)
                .HasMaxLength(50);

        }
    }
}
