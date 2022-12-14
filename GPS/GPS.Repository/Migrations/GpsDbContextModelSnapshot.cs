// <auto-generated />
using GPS.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GPS.Repository.Migrations
{
    [DbContext(typeof(GpsDbContext))]
    partial class GpsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GPS.Domain.VO.AtividadePrincipalVO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("atividade_principais");
                });

            modelBuilder.Entity("GPS.Domain.VO.AtividadesSecundariasVO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("atividades_secundarias");
                });

            modelBuilder.Entity("GPS.Domain.VO.BillingVO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<bool>("database")
                        .HasColumnType("bit");

                    b.Property<bool>("free")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("EmpresaId")
                        .IsUnique();

                    b.ToTable("billing");
                });

            modelBuilder.Entity("GPS.Domain.VO.EmpresaVO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("abertura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("capital_social")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("data_situacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("data_situacao_especial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("efr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fantasia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("motivo_situacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("natureza_juridica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("situacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("situacao_especial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("GPS.Domain.VO.QsaVO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome_rep_legal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais_origem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qual")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qual_rep_legal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("qsas");
                });

            modelBuilder.Entity("GPS.Domain.VO.AtividadePrincipalVO", b =>
                {
                    b.HasOne("GPS.Domain.VO.EmpresaVO", "Empresa")
                        .WithMany("atividade_principais")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("GPS.Domain.VO.AtividadesSecundariasVO", b =>
                {
                    b.HasOne("GPS.Domain.VO.EmpresaVO", "Empresa")
                        .WithMany("atividades_secundarias")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("GPS.Domain.VO.BillingVO", b =>
                {
                    b.HasOne("GPS.Domain.VO.EmpresaVO", "Empresa")
                        .WithOne("billing")
                        .HasForeignKey("GPS.Domain.VO.BillingVO", "EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("GPS.Domain.VO.QsaVO", b =>
                {
                    b.HasOne("GPS.Domain.VO.EmpresaVO", "Empresa")
                        .WithMany("qsas")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("GPS.Domain.VO.EmpresaVO", b =>
                {
                    b.Navigation("atividade_principais");

                    b.Navigation("atividades_secundarias");

                    b.Navigation("billing")
                        .IsRequired();

                    b.Navigation("qsas");
                });
#pragma warning restore 612, 618
        }
    }
}
