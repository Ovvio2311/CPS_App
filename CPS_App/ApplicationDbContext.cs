using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CPS_App.Models;
using CCS_API.Data;
using Microsoft.AspNetCore.Identity;

/*
 * nuggets necesarios
 Microsoft.EntityFrameworkCore.SqlServer
 Microsoft.Extensions.DependencyInjection;
 Microsoft.Extensions.Hosting; 
 FontAwesome.Sharp.Pro
 Microsoft.AspNetCore.Identity.EntityFrameworkCore

 */


namespace CPS_App
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public IConfiguration _configuration;
        public AppConfig _appConfig;
        public ApplicationDbContext(IConfiguration configuration, AppConfig appConfig)
        {
            _configuration = configuration;
            _appConfig = configuration.Get<AppConfig>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            var builder = new ConfigurationBuilder()
                                 .SetBasePath(Directory.GetCurrentDirectory())
                                 .AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);

            var config = _appConfig.MySQL.ConnectionString;
            //string conn = builder.Build().GetConnectionString("DefaultConnection");

            optionsBuilder.UseMySql(config, ServerVersion.AutoDetect(config))
            .EnableSensitiveDataLogging(true);
        }

        //Fluent API - conventions
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .Ignore<IdentityUserToken<string>>()
                .Ignore<IdentityUserLogin<string>>();
                //.Ignore<IdentityUserClaim<string>>()
                //.Ignore<IdentityRoleClaim<string>>();

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vc_role_id");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("longtext")
                    .HasColumnName("lt_concurrency_stamp");


                b.Property<string>("Name")
                    .HasMaxLength(256)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("vc_role_name");

                b.Property<string>("NormalizedName")
                    .HasMaxLength(256)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("vc_nor_name");

                b.HasKey("Id");

                b.HasIndex("NormalizedName")
                    .IsUnique()
                    .HasDatabaseName("RoleNameIndex");

                b.ToTable("tb_roles", (string)null);
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("i_claim_id");

                b.Property<string>("ClaimType")
                    .HasColumnType("longtext")
                .HasColumnName("vc_claim_type");

                b.Property<string>("ClaimValue")
                    .HasColumnType("longtext")
                    .HasColumnName("vc_claim_value");

                b.Property<string>("RoleId")
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vc_role_id");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.ToTable("tb_role_claim", (string)null);
            });

            modelBuilder.Entity<IdentityUser>(/*"Microsoft.AspNetCore.Identity.IdentityUser",*/ b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vc_user_id");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("int")
                    .HasColumnName("i_access_failed_count");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("longtext")
                    .HasColumnName("lt_concurrency_stamp");

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("lt_discriminator");

                b.Property<string>("Email")
                    .HasMaxLength(256)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("vc_email");

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("tinyint(1)")
                    .HasColumnName("ti_email_confirmed");

                b.Property<bool>("LockoutEnabled")
                    .HasColumnType("tinyint(1)")
                    .HasColumnName("ti_lockout_enabled");

                b.Property<string>("PhoneNumber")
                       .HasColumnType("longtext")
                       .HasColumnName("lt_phone_number");

                b.Property<DateTimeOffset?>("LockoutEnd")
                   .HasColumnType("datetime(6)")
                   .HasColumnName("dt_lockout_end");
                   //.HasConversion(x => x.HasValue ? x.Value.DateTime : (DateTime?)null,
                   //x => DateTimeOffset.Parse(x.ToString()));


                b.Property<string>("NormalizedEmail")
                    .HasMaxLength(256)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("vc_normalized_email");

                b.Property<string>("NormalizedUserName")
                    .HasMaxLength(256)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("vc_normalized_user_name");

                b.Property<string>("PasswordHash")
                    .HasColumnType("longtext")
                    .HasColumnName("lt_password_hash");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("longtext");

                b.Property<bool>("PhoneNumberConfirmed")
                    .HasColumnType("tinyint(1)")
                    .HasColumnName("ti_PhoneNumberConfirmed");

                b.Property<string>("SecurityStamp")
                    .HasColumnType("longtext")
                    .HasColumnName("lt_security_stamp");

                b.Property<bool>("TwoFactorEnabled")
                    .HasColumnType("tinyint(1)")
                    .HasColumnName("ti_TwoFactorEnabled");

                b.Property<string>("UserName")
                    .HasMaxLength(256)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("vc_user_name");

                b.HasKey("Id");

                b.HasIndex("NormalizedEmail")
                    .HasDatabaseName("EmailIndex");

                b.HasIndex("NormalizedUserName")
                    .IsUnique()
                    .HasDatabaseName("UserNameIndex");

                b.ToTable("tb_users", (string)null);

                b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                b.UseTphMappingStrategy();
            });

            modelBuilder.Entity<IdentityUser>()
                                                
                                                .Ignore(u => u.TwoFactorEnabled)
                                                .Ignore(u => u.PhoneNumberConfirmed)
                                                .Ignore(u => u.PhoneNumber);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("i_claim_id");

                b.Property<string>("ClaimType")
                    .HasColumnType("longtext")
                    .HasColumnName("vc_claim_type");

                b.Property<string>("ClaimValue")
                    .HasColumnType("longtext")
                    .HasColumnName("vc_claim_value");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vc_user_id");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("tb_user_claim", (string)null);
            });

            //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            //{
            //    b.Property<string>("LoginProvider")
            //        .HasMaxLength(128)
            //        .HasColumnType("varchar(128)");

            //    b.Property<string>("ProviderKey")
            //        .HasMaxLength(128)
            //        .HasColumnType("varchar(128)");

            //    b.Property<string>("ProviderDisplayName")
            //        .HasColumnType("longtext");

            //    b.Property<string>("UserId")
            //        .IsRequired()
            //        .HasColumnType("varchar(255)");

            //    b.HasKey("LoginProvider", "ProviderKey");

            //    b.HasIndex("UserId");

            //    b.ToTable("UserLogins", (string)null);
            //});

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vc_user_id");

                b.Property<string>("RoleId")
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vc_role_id");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("tb_user_roles", (string)null);
            });

            //modelBuilder.Entity<IdentityUserToken<string>>(/*"Microsoft.AspNetCore.Identity.IdentityUserToken<string>"*/ b =>
            //{
            //    b.Property<string>("UserId")
            //        .HasColumnType("varchar(255)");

            //    b.Property<string>("LoginProvider")
            //        .HasMaxLength(128)
            //        .HasColumnType("varchar(128)");

            //    b.Property<string>("Name")
            //        .HasMaxLength(128)
            //        .HasColumnType("varchar(128)");

            //    b.Property<string>("Value")
            //        .HasColumnType("longtext");

            //    b.HasKey("UserId", "LoginProvider", "Name");

            //    b.ToTable("UserTokens", (string)null);
            //});

            modelBuilder.Entity("CPS_App.Models.AppUsers", b =>
            {
                b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                //b.Property<DateTime?>("ActivationDate")
                //    .HasColumnType("datetime(6)");
                
                b.Property<string>("UserName")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("vc_user_name");                

                //b.Property<DateTime?>("Date")
                //    .HasColumnType("datetime(6)");

                b.Property<string>("Email")
                    .HasColumnType("Varchar(50)")
                    .HasColumnName("vc_email");

                //b.Property<string>("Logout")
                //    .HasColumnType("longtext");

                //b.Property<string>("Password")
                //    .IsRequired()
                //    .HasMaxLength(100)
                //    .HasColumnType("varchar(100)");             

                //b.Property<bool>("Valid")
                //    .HasColumnType("tinyint(1)");

                b.HasDiscriminator().HasValue("AppUsers");
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
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            //{
            //    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
            //        .WithMany()
            //        .HasForeignKey("UserId")
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .IsRequired();
            //});

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            //modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            //{
            //    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
            //        .WithMany()
            //        .HasForeignKey("UserId")
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .IsRequired();
            //});

        }

        public DbSet<AppUsers> AppUsers { get; set; }


    }
}
