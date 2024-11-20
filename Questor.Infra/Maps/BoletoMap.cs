using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questor.Domain.Entities;
using Questor.Infra.Maps.Base;

namespace Questor.Infra.Maps
{
    public class BoletoMap : BaseDomainMap<Boleto>
    {
        public BoletoMap() : base("tb_boleto") { }

        public override void Configure(EntityTypeBuilder<Boleto> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            builder.Property(x => x.CPF).HasColumnName("cpf").IsRequired();
            builder.Property(x => x.NomeBeneficiario).HasColumnName("nome_beneficiario").IsRequired();
            builder.Property(x => x.CPFBeneficiario).HasColumnName("cpf_beneficiario").IsRequired();
            builder.Property(x => x.Valor).HasColumnName("valor").IsRequired();
            builder.Property(x => x.DataVencimento).HasColumnName("vencimento").IsRequired();            
        }
    }
}