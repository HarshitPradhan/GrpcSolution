// <auto-generated />
using GrpcService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GrpcService.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GrpcService.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeProfile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            EmployeeEmail = "hp@gmail.com",
                            EmployeeName = "Harshit Prad",
                            EmployeeProfile = "Technician"
                        },
                        new
                        {
                            EmployeeId = 2,
                            EmployeeEmail = "dp@gmail.com",
                            EmployeeName = "Dev Prad",
                            EmployeeProfile = "Sales Manager"
                        },
                        new
                        {
                            EmployeeId = 3,
                            EmployeeEmail = "Dhp@gmail.com",
                            EmployeeName = "Dhruv Prad",
                            EmployeeProfile = "Business head"
                        },
                        new
                        {
                            EmployeeId = 4,
                            EmployeeEmail = "kp@gmail.com",
                            EmployeeName = "Kartik Prad",
                            EmployeeProfile = "software dev"
                        },
                        new
                        {
                            EmployeeId = 5,
                            EmployeeEmail = "Dep@gmail.com",
                            EmployeeName = "Deepu Prad",
                            EmployeeProfile = "software dev in test"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
