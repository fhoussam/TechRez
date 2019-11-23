﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using angularclient.Models;

namespace angularclient.Migrations
{
    [DbContext(typeof(TechRezDbContext))]
    partial class TechRezDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("angularclient.Models.Category", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Code");

                    b.ToTable("Category");

                    b.HasData(
                        new { Code = "1", Description = "Power Suply" },
                        new { Code = "2", Description = "Motherboard" },
                        new { Code = "3", Description = "Graphics Card" },
                        new { Code = "4", Description = "RAM" }
                    );
                });

            modelBuilder.Entity("angularclient.Models.Order", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("ProductCode");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<string>("TechRezUserId");

                    b.HasKey("Code");

                    b.HasIndex("ProductCode");

                    b.HasIndex("TechRezUserId");

                    b.ToTable("Order");

                    b.HasData(
                        new { Code = "1", OrderDate = new DateTime(2019, 11, 22, 8, 20, 7, 4, DateTimeKind.Local), ProductId = 15, Quantity = 1, TechRezUserId = "RandomDude_1" },
                        new { Code = "2", OrderDate = new DateTime(2019, 11, 18, 4, 24, 11, 6, DateTimeKind.Local), ProductId = 24, Quantity = 2, TechRezUserId = "RandomDude_2" }
                    );
                });

            modelBuilder.Entity("angularclient.Models.Product", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryCode");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("PhotoUrl");

                    b.Property<double>("Price");

                    b.Property<int>("Quantity");

                    b.HasKey("Code");

                    b.HasIndex("CategoryCode");

                    b.ToTable("Product");

                    b.HasData(
                        new { Code = "11", CategoryId = 1, Description = "Corsair RM850x", PhotoUrl = "PSU/Corsair_RM850x.jpg", Price = 139.0, Quantity = 52 },
                        new { Code = "12", CategoryId = 1, Description = "Cooler Master MasterWatt 750W", PhotoUrl = "PSU/Cooler_Master_MasterWatt_750W.jpg", Price = 187.0, Quantity = 87 },
                        new { Code = "13", CategoryId = 1, Description = "FSP Dagger 500W", PhotoUrl = "PSU/FSP_Dagger_500W.jpg", Price = 184.0, Quantity = 65 },
                        new { Code = "14", CategoryId = 1, Description = "Gamdias Astrape P1-750G", PhotoUrl = "PSU/Gamdias_Astrape_P1_750G.jpg", Price = 227.0, Quantity = 65 },
                        new { Code = "15", CategoryId = 1, Description = "NZXT E850", PhotoUrl = "PSU/NZXT_E850.jpg", Price = 89.0, Quantity = 86 },
                        new { Code = "16", CategoryId = 1, Description = "Seasonic Prime 1000 Titanium", PhotoUrl = "PSU/Seasonic_Prime_1000_Titanium.jpg", Price = 299.0, Quantity = 86 },
                        new { Code = "21", CategoryId = 2, Description = "Gigabyte Z390 Aorus Ultra", PhotoUrl = "MOB/Gigabyte_Z390_Aorus_Ultra.jpg", Price = 250.0, Quantity = 63 },
                        new { Code = "22", CategoryId = 2, Description = "ASUS ROG Maximus XI Hero Wi-Fi", PhotoUrl = "MOB/ASUS_ROG_Maximus_XI_Hero_Wi_Fi.jpg", Price = 178.0, Quantity = 41 },
                        new { Code = "23", CategoryId = 2, Description = "ASUS ROG Strix Z390-I Gaming", PhotoUrl = "MOB/ASUS_ROG_Strix_Z390_I_Gaming.jpg", Price = 233.0, Quantity = 85 },
                        new { Code = "24", CategoryId = 2, Description = "MSI MPG X570 Gaming Pro Carbon WiFi", PhotoUrl = "MOB/MSI_MPG_X570_Gaming_Pro_Carbon_WiFi.jpg", Price = 189.0, Quantity = 34 },
                        new { Code = "25", CategoryId = 2, Description = "Gigabyte X470 Aorus Gaming 5 Wi-Fi", PhotoUrl = "MOB/Gigabyte_X470_Aorus_Gaming_5_Wi_Fi.jpg", Price = 175.0, Quantity = 64 },
                        new { Code = "26", CategoryId = 2, Description = "ASUS TUF H370-Pro Gaming Wi-Fi", PhotoUrl = "MOB/ASUS_TUF_H370_Pro_Gaming_Wi_Fi.jpg", Price = 199.0, Quantity = 16 },
                        new { Code = "27", CategoryId = 2, Description = "Gigabyte Z390 UD", PhotoUrl = "MOB/Gigabyte_Z390_UD.jpg", Price = 245.0, Quantity = 52 },
                        new { Code = "30", CategoryId = 3, Description = "Nvidia GeForce RTX 2080 Ti", PhotoUrl = "GFX/Nvidia_GeForce_RTX_2080_Ti.jpg", Price = 1088.0, Quantity = 45 },
                        new { Code = "31", CategoryId = 3, Description = "AMD Radeon RX 570 4GB", PhotoUrl = "GFX/AMD_Radeon_RX_570_4GB.jpg", Price = 1072.0, Quantity = 88 },
                        new { Code = "32", CategoryId = 3, Description = "Nvidia GeForce RTX 2080 Super", PhotoUrl = "GFX/Nvidia_GeForce_RTX_2080_Super.jpg", Price = 860.0, Quantity = 32 },
                        new { Code = "33", CategoryId = 3, Description = "Nvidia GeForce RTX 2070 Super", PhotoUrl = "GFX/Nvidia_GeForce_RTX_2070_Super.jpg", Price = 890.0, Quantity = 56 },
                        new { Code = "34", CategoryId = 3, Description = "Nvidia GeForce RTX 2060 Super", PhotoUrl = "GFX/Nvidia_GeForce_RTX_2060_Super.jpg", Price = 699.0, Quantity = 73 },
                        new { Code = "35", CategoryId = 3, Description = "AMD Radeon RX 5700 XT", PhotoUrl = "GFX/AMD_Radeon_RX_5700_XT.jpg", Price = 599.0, Quantity = 81 },
                        new { Code = "36", CategoryId = 3, Description = "GeForce GTX 1660 Super 6GB", PhotoUrl = "GFX/GeForce_GTX_1660_Super_6GB.jpg", Price = 255.0, Quantity = 47 },
                        new { Code = "37", CategoryId = 3, Description = "AMD Radeon RX 590", PhotoUrl = "GFX/AMD_Radeon_RX_590.jpg", Price = 430.0, Quantity = 86 },
                        new { Code = "38", CategoryId = 3, Description = "AMD Radeon RX 5700", PhotoUrl = "GFX/AMD_Radeon_RX_5700.jpg", Price = 230.0, Quantity = 38 },
                        new { Code = "39", CategoryId = 3, Description = "Nvidia GeForce GTX 1660 Ti", PhotoUrl = "GFX/Nvidia_GeForce_GTX_1660_Ti.jpg", Price = 245.0, Quantity = 76 },
                        new { Code = "40", CategoryId = 4, Description = "Corsair Vengeance LED", PhotoUrl = "RAM/Corsair_Vengeance_LED.jpg", Price = 89.0, Quantity = 65 },
                        new { Code = "41", CategoryId = 4, Description = "G.Skill Trident Z RGB", PhotoUrl = "RAM/G_Skill_Trident_Z_RGB.jpg", Price = 99.0, Quantity = 65 },
                        new { Code = "42", CategoryId = 4, Description = "Kingston HyperX Predator", PhotoUrl = "RAM/Kingston_HyperX_Predator.jpg", Price = 199.0, Quantity = 71 },
                        new { Code = "43", CategoryId = 4, Description = "Kingston HyperX Fury ", PhotoUrl = "RAM/Kingston_HyperX_Fury .jpg", Price = 140.0, Quantity = 63 },
                        new { Code = "44", CategoryId = 4, Description = "Corsair Dominator Platinum RGB", PhotoUrl = "RAM/Corsair_Dominator_Platinum_RGB.jpg", Price = 175.0, Quantity = 85 },
                        new { Code = "45", CategoryId = 4, Description = "G.Skill Trident Z RGB DC", PhotoUrl = "RAM/G_Skill_Trident_Z_RGB_DC.jpg", Price = 146.0, Quantity = 27 },
                        new { Code = "46", CategoryId = 4, Description = "Adata Spectrix D80 ", PhotoUrl = "RAM/Adata_Spectrix_D80.jpg", Price = 99.0, Quantity = 19 },
                        new { Code = "47", CategoryId = 4, Description = "HyperX Fury RGB", PhotoUrl = "RAM/HyperX_Fury_RGB.jpg", Price = 187.0, Quantity = 36 },
                        new { Code = "48", CategoryId = 4, Description = "Corsair Vengeance LPX", PhotoUrl = "RAM/Corsair_Vengeance_LPX.jpg", Price = 163.0, Quantity = 85 },
                        new { Code = "49", CategoryId = 4, Description = "G.Skill Mac RAM", PhotoUrl = "RAM/G_Skill_Mac_RAM.jpg", Price = 165.0, Quantity = 26 }
                    );
                });

            modelBuilder.Entity("angularclient.Models.TechRezUser", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserName");

                    b.HasKey("Code");

                    b.ToTable("TechRezUser");

                    b.HasData(
                        new { Code = "RandomDude_1", UserName = "RandomDude One" },
                        new { Code = "RandomDude_2", UserName = "RandomDude Two" }
                    );
                });

            modelBuilder.Entity("angularclient.Models.Order", b =>
                {
                    b.HasOne("angularclient.Models.Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductCode");

                    b.HasOne("angularclient.Models.TechRezUser")
                        .WithMany("Orders")
                        .HasForeignKey("TechRezUserId");
                });

            modelBuilder.Entity("angularclient.Models.Product", b =>
                {
                    b.HasOne("angularclient.Models.Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryCode");
                });
#pragma warning restore 612, 618
        }
    }
}
