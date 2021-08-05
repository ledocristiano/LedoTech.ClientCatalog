using LedoTech.ClientCatalog.Domain.CourseContext.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LedoTech.ClientCatalog.Infra.Data.Context.Mappings
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");
            builder
                .HasKey(x => x.Codigo);
            builder.Property(x => x.Codigo)
                .ValueGeneratedOnAdd();
            builder
                .Property(x => x.RazaoSocial)
                .HasMaxLength(200)
                .IsRequired();
            builder
                .Property(x => x.CNPJ)
                .HasMaxLength(15)
                .IsRequired();
            builder
                .Property(x => x.DataCadastro)
                .IsRequired();
        }
    }
}
