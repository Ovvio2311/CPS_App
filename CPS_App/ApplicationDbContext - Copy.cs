//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using CPS_App.Models;
//using CCS_API.Data;

///*
// * nuggets necesarios
// Microsoft.EntityFrameworkCore.SqlServer
// Microsoft.Extensions.DependencyInjection;
// Microsoft.Extensions.Hosting; 
// FontAwesome.Sharp.Pro
// Microsoft.AspNetCore.Identity.EntityFrameworkCore

// */


//namespace CPS_App
//{
//    public class ApplicationDbContext : IdentityDbContext
//    {
//        public IConfiguration _configuration;
//        public AppConfig _appConfig;
//        public ApplicationDbContext(IConfiguration configuration, AppConfig appConfig)
//        {
//            _configuration = configuration;
//            _appConfig = configuration.Get<AppConfig>();
//        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            //ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["DefaultConnection"];
//            var builder = new ConfigurationBuilder()
//                                 .SetBasePath(Directory.GetCurrentDirectory())
//                                 .AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);

//            var config = _appConfig.MySQL.ConnectionString;
//            //string conn = builder.Build().GetConnectionString("DefaultConnection");

//            optionsBuilder.UseMySql(config, ServerVersion.AutoDetect(config))
//            .EnableSensitiveDataLogging(true);
//        }

//        //Fluent API - conventions
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            //base.OnModelCreating(modelBuilder);

//            modelBuilder
//                .HasAnnotation("ProductVersion", "7.0.2")
//                .HasAnnotation("Relational:MaxIdentifierLength", 64);

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
//            {
//                b.Property<string>("Id")
//                    .HasColumnType("varchar(255)");

//                b.Property<string>("ConcurrencyStamp")
//                    .IsConcurrencyToken()
//                    .HasColumnType("longtext");

//                b.Property<string>("Name")
//                    .HasMaxLength(256)
//                    .HasColumnType("varchar(256)");

//                b.Property<string>("NormalizedName")
//                    .HasMaxLength(256)
//                    .HasColumnType("varchar(256)");

//                b.HasKey("Id");

//                b.HasIndex("NormalizedName")
//                    .IsUnique()
//                    .HasDatabaseName("RoleNameIndex");

//                b.ToTable("roles", (string)null);
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
//            {
//                b.Property<int>("Id")
//                    .ValueGeneratedOnAdd()
//                    .HasColumnType("int");

//                b.Property<string>("ClaimType")
//                    .HasColumnType("longtext");

//                b.Property<string>("ClaimValue")
//                    .HasColumnType("longtext");

//                b.Property<string>("RoleId")
//                    .IsRequired()
//                    .HasColumnType("varchar(255)");

//                b.HasKey("Id");

//                b.HasIndex("RoleId");

//                b.ToTable("RoleClaims", (string)null);
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
//            {
//                b.Property<string>("Id")
//                    .HasColumnType("varchar(255)");

//                b.Property<int>("AccessFailedCount")
//                    .HasColumnType("int");

//                b.Property<string>("ConcurrencyStamp")
//                    .IsConcurrencyToken()
//                    .HasColumnType("longtext");

//                b.Property<string>("Discriminator")
//                    .IsRequired()
//                    .HasColumnType("longtext");

//                b.Property<string>("Email")
//                    .HasMaxLength(256)
//                    .HasColumnType("varchar(256)");

//                b.Property<bool>("EmailConfirmed")
//                    .HasColumnType("tinyint(1)");

//                b.Property<bool>("LockoutEnabled")
//                    .HasColumnType("tinyint(1)");

//                b.Property<DateTimeOffset?>("LockoutEnd")
//                    .HasColumnType("datetime(6)");

//                b.Property<string>("NormalizedEmail")
//                    .HasMaxLength(256)
//                    .HasColumnType("varchar(256)");

//                b.Property<string>("NormalizedUserName")
//                    .HasMaxLength(256)
//                    .HasColumnType("varchar(256)");

//                b.Property<string>("PasswordHash")
//                    .HasColumnType("longtext");

//                b.Property<string>("PhoneNumber")
//                    .HasColumnType("longtext");

//                b.Property<bool>("PhoneNumberConfirmed")
//                    .HasColumnType("tinyint(1)");

//                b.Property<string>("SecurityStamp")
//                    .HasColumnType("longtext");

//                b.Property<bool>("TwoFactorEnabled")
//                    .HasColumnType("tinyint(1)");

//                b.Property<string>("UserName")
//                    .HasMaxLength(256)
//                    .HasColumnType("varchar(256)");

//                b.HasKey("Id");

//                b.HasIndex("NormalizedEmail")
//                    .HasDatabaseName("EmailIndex");

//                b.HasIndex("NormalizedUserName")
//                    .IsUnique()
//                    .HasDatabaseName("UserNameIndex");

//                b.ToTable("users", (string)null);

//                b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

//                b.UseTphMappingStrategy();
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
//            {
//                b.Property<int>("Id")
//                    .ValueGeneratedOnAdd()
//                    .HasColumnType("int");

//                b.Property<string>("ClaimType")
//                    .HasColumnType("longtext");

//                b.Property<string>("ClaimValue")
//                    .HasColumnType("longtext");

//                b.Property<string>("UserId")
//                    .IsRequired()
//                    .HasColumnType("varchar(255)");

//                b.HasKey("Id");

//                b.HasIndex("UserId");

//                b.ToTable("UserClaims", (string)null);
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
//            {
//                b.Property<string>("LoginProvider")
//                    .HasMaxLength(128)
//                    .HasColumnType("varchar(128)");

//                b.Property<string>("ProviderKey")
//                    .HasMaxLength(128)
//                    .HasColumnType("varchar(128)");

//                b.Property<string>("ProviderDisplayName")
//                    .HasColumnType("longtext");

//                b.Property<string>("UserId")
//                    .IsRequired()
//                    .HasColumnType("varchar(255)");

//                b.HasKey("LoginProvider", "ProviderKey");

//                b.HasIndex("UserId");

//                b.ToTable("UserLogins", (string)null);
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
//            {
//                b.Property<string>("UserId")
//                    .HasColumnType("varchar(255)");

//                b.Property<string>("RoleId")
//                    .HasColumnType("varchar(255)");

//                b.HasKey("UserId", "RoleId");

//                b.HasIndex("RoleId");

//                b.ToTable("UserRoles", (string)null);
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
//            {
//                b.Property<string>("UserId")
//                    .HasColumnType("varchar(255)");

//                b.Property<string>("LoginProvider")
//                    .HasMaxLength(128)
//                    .HasColumnType("varchar(128)");

//                b.Property<string>("Name")
//                    .HasMaxLength(128)
//                    .HasColumnType("varchar(128)");

//                b.Property<string>("Value")
//                    .HasColumnType("longtext");

//                b.HasKey("UserId", "LoginProvider", "Name");

//                b.ToTable("UserTokens", (string)null);
//            });

//            modelBuilder.Entity("CPS_App.Models.AppUsers", b =>
//            {
//                b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

//                b.Property<DateTime?>("ActivationDate")
//                    .HasColumnType("datetime(6)");
                
//                b.Property<string>("UserName")
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .HasColumnType("varchar(100)");

//                b.Property<string>("staff_role")
//                    //.IsRequired()
//                    .HasMaxLength(100)
//                    .HasColumnType("varchar(100)");

//                b.Property<int>("staff_id")
//                    //.IsRequired()                    
//                    .HasColumnType("int");

//                b.Property<DateTime?>("Date")
//                    .HasColumnType("datetime(6)");

//                b.Property<string>("Email")
//                    .HasColumnType("Varchar(50)");

//                b.Property<string>("Logout")
//                    .HasColumnType("longtext");

//                b.Property<string>("Password")
//                    .IsRequired()
//                    .HasMaxLength(100)
//                    .HasColumnType("varchar(100)");             

//                b.Property<bool>("Valid")
//                    .HasColumnType("tinyint(1)");

//                b.HasDiscriminator().HasValue("AppUsers");
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
//            {
//                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
//                    .WithMany()
//                    .HasForeignKey("RoleId")
//                    .OnDelete(DeleteBehavior.Cascade)
//                    .IsRequired();
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
//            {
//                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
//                    .WithMany()
//                    .HasForeignKey("UserId")
//                    .OnDelete(DeleteBehavior.Cascade)
//                    .IsRequired();
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
//            {
//                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
//                    .WithMany()
//                    .HasForeignKey("UserId")
//                    .OnDelete(DeleteBehavior.Cascade)
//                    .IsRequired();
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
//            {
//                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
//                    .WithMany()
//                    .HasForeignKey("RoleId")
//                    .OnDelete(DeleteBehavior.Cascade)
//                    .IsRequired();

//                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
//                    .WithMany()
//                    .HasForeignKey("UserId")
//                    .OnDelete(DeleteBehavior.Cascade)
//                    .IsRequired();
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
//            {
//                b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
//                    .WithMany()
//                    .HasForeignKey("UserId")
//                    .OnDelete(DeleteBehavior.Cascade)
//                    .IsRequired();
//            });

//        }

//        public DbSet<AppUsers> AppUsers { get; set; }


//    }
//}
