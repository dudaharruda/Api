using Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class MateriasMap : IEntityTypeConfiguration<MateriasModel>
    {
        public void Configure(EntityTypeBuilder<MateriasModel> builder)
        {
            builder.HasKey(x => x.MateriasId);
            builder.Property(x => x.MateriasName).IsRequired().HasMaxLength(255);
          
        }

    }
}
