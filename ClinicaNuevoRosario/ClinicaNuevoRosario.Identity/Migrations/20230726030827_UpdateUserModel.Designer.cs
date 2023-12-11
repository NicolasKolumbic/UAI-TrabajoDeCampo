﻿// <auto-generated />
using System;
using ClinicaNuevoRosario.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClinicaNuevoRosario.Identity.Migrations
{
    [DbContext(typeof(CNRIdentityDbContext))]
    [Migration("20230726030827_UpdateUserModel")]
    partial class UpdateUserModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClinicaNuevoRosario.Domain.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppointmentDurationDefault")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("IdentificationNumber")
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalLicense")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PhoneNumber")
                        .HasColumnType("float");

                    b.Property<string>("SystemEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("ClinicaNuevoRosario.Domain.DoctorSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AppointmentDuration")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("EndTime")
                        .HasColumnType("int");

                    b.Property<int>("StartTime")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("DoctorSchedule");
                });

            modelBuilder.Entity("ClinicaNuevoRosario.Domain.HealthInsurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HealthInsurance");
                });

            modelBuilder.Entity("ClinicaNuevoRosario.Domain.MedicalSpecialty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedicalSpecialty");
                });

            modelBuilder.Entity("ClinicaNuevoRosario.Domain.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HealthInsuranceId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HealthInsuranceId");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("ClinicaNuevoRosario.Identity.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3600fe5c-e3f3-4e0f-9bf4-e98d32eb5e12",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "69b8cb48-6495-41af-8e34-eeead0ba0baf",
                            Email = "nicolaskolumbic@hotmail.com",
                            EmailConfirmed = true,
                            LastName = "Kolumbic",
                            LockoutEnabled = false,
                            Name = "Nicolás",
                            NormalizedEmail = "nicolaskolumbic@hotmail.com",
                            NormalizedUserName = "NKOLUMBIC",
                            PasswordHash = "AQAAAAEAACcQAAAAEB9EyPLje2SXNrnGHQiPlity7Ool8ZvaAI4KXGLiTnkbhosA4zZ68JZDo2OK0RZ+ow==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e306e601-f9db-4844-a3a7-c833aa386efc",
                            TwoFactorEnabled = false,
                            UserName = "nkolumbic"
                        },
                        new
                        {
                            Id = "a3ec6212-26ef-4871-b13f-7e7c8d8c5101",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a0e779d7-068a-416a-9f10-f3bef11e6489",
                            Email = "gastonbarbero@hotmail.com",
                            EmailConfirmed = true,
                            LastName = "Barbero",
                            LockoutEnabled = false,
                            Name = "Gastón",
                            NormalizedEmail = "gastonbarbero@hotmail.com",
                            NormalizedUserName = "gbarbero",
                            PasswordHash = "AQAAAAEAACcQAAAAEGQz3PVs9iU57lI+52u/4DdvtMt2hlDIom+gScvg043rpEEWKmoenBQ/PA6utT36oA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8115df37-e5a3-4ff9-8960-4f274761bf82",
                            TwoFactorEnabled = false,
                            UserName = "gbarbero"
                        });
                });

            modelBuilder.Entity("DoctorMedicalSpecialty", b =>
                {
                    b.Property<int>("DoctorsId")
                        .HasColumnType("int");

                    b.Property<int>("MedicalSpecialtiesId")
                        .HasColumnType("int");

                    b.HasKey("DoctorsId", "MedicalSpecialtiesId");

                    b.HasIndex("MedicalSpecialtiesId");

                    b.ToTable("DoctorMedicalSpecialty");
                });

            modelBuilder.Entity("DoctorPlan", b =>
                {
                    b.Property<int>("DoctorsId")
                        .HasColumnType("int");

                    b.Property<int>("PlansId")
                        .HasColumnType("int");

                    b.HasKey("DoctorsId", "PlansId");

                    b.HasIndex("PlansId");

                    b.ToTable("DoctorPlan");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d2c01424-3245-4dff-abb4-51086fb6f897",
                            ConcurrencyStamp = "1ce00de6-f1d5-4623-a82e-808e6d14cf06",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "6f8b16d7-b2e4-420c-8c96-3ab021b11b78",
                            ConcurrencyStamp = "d13c6c62-f210-4494-add3-c8ef1686a8c6",
                            Name = "Administrativo",
                            NormalizedName = "ADMINISTRATIVO"
                        },
                        new
                        {
                            Id = "304ec0ad-f5dd-442f-ae18-ed26ef5feb27",
                            ConcurrencyStamp = "5d94e334-dfde-4e35-9d33-45ccbc1c8b14",
                            Name = "Medico",
                            NormalizedName = "MEDICO"
                        },
                        new
                        {
                            Id = "084136d8-c054-46d1-beb8-14ad1e647b2d",
                            ConcurrencyStamp = "002d281c-0edb-4c5d-878f-9228843899e1",
                            Name = "Visitante",
                            NormalizedName = "VISITANTE"
                        },
                        new
                        {
                            Id = "30a33a14-23a6-447d-ae41-fbcbb7815f61",
                            ConcurrencyStamp = "17016ffc-c20d-4aa2-a9a4-c82cd9d2192f",
                            Name = "Contable",
                            NormalizedName = "CONTABLE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "3600fe5c-e3f3-4e0f-9bf4-e98d32eb5e12",
                            RoleId = "d2c01424-3245-4dff-abb4-51086fb6f897"
                        },
                        new
                        {
                            UserId = "a3ec6212-26ef-4871-b13f-7e7c8d8c5101",
                            RoleId = "d2c01424-3245-4dff-abb4-51086fb6f897"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ClinicaNuevoRosario.Domain.DoctorSchedule", b =>
                {
                    b.HasOne("ClinicaNuevoRosario.Domain.Doctor", "Doctor")
                        .WithMany("DoctorSchedules")
                        .HasForeignKey("DoctorId");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("ClinicaNuevoRosario.Domain.Plan", b =>
                {
                    b.HasOne("ClinicaNuevoRosario.Domain.HealthInsurance", "HealthInsurance")
                        .WithMany()
                        .HasForeignKey("HealthInsuranceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HealthInsurance");
                });

            modelBuilder.Entity("ClinicaNuevoRosario.Identity.Models.ApplicationUser", b =>
                {
                    b.HasOne("ClinicaNuevoRosario.Domain.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorMedicalSpecialty", b =>
                {
                    b.HasOne("ClinicaNuevoRosario.Domain.Doctor", null)
                        .WithMany()
                        .HasForeignKey("DoctorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicaNuevoRosario.Domain.MedicalSpecialty", null)
                        .WithMany()
                        .HasForeignKey("MedicalSpecialtiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorPlan", b =>
                {
                    b.HasOne("ClinicaNuevoRosario.Domain.Doctor", null)
                        .WithMany()
                        .HasForeignKey("DoctorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicaNuevoRosario.Domain.Plan", null)
                        .WithMany()
                        .HasForeignKey("PlansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ClinicaNuevoRosario.Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ClinicaNuevoRosario.Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicaNuevoRosario.Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ClinicaNuevoRosario.Identity.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClinicaNuevoRosario.Domain.Doctor", b =>
                {
                    b.Navigation("DoctorSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}