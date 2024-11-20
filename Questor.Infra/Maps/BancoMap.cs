using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questor.Domain.Entities;
using Questor.Infra.Maps.Base;

namespace Questor.Infra.Maps
{
    public class BancoMap : BaseDomainMap<Banco>
    {
        public BancoMap() : base("tb_banco") { }

        public override void Configure(EntityTypeBuilder<Banco> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            builder.Property(x => x.Codigo).HasColumnName("codigo").IsRequired();
            builder.Property(x => x.Juros).HasColumnName("juros").IsRequired();
        }

    }
}
