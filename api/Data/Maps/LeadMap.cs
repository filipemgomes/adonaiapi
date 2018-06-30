using api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Data
{
    public class LeadMap : IEntityTypeConfiguration<Lead>
    {
        public void Configure(EntityTypeBuilder<Lead> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(150).HasColumnType("text");
            builder.Property(p => p.Email).IsRequired().HasMaxLength(100).HasColumnType("text");
            builder.Property(p => p.PhoneNumber).IsRequired().HasMaxLength(30).HasColumnType("text");
            builder.Property(p => p.Consorcio).IsRequired().HasMaxLength(30).HasColumnType("text");
        }
    }
}