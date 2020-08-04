﻿// <auto-generated />
using System;
using HotelRooms.Data.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelRooms.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelRooms.Data.Entities.AssignedRoom", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BigTowels")
                        .HasColumnType("int");

                    b.Property<long>("ChambermaidId")
                        .HasColumnType("bigint");

                    b.Property<long>("CleaningStatusId")
                        .HasColumnType("bigint");

                    b.Property<long>("CleaningTypeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoubleDuvetCovers")
                        .HasColumnType("int");

                    b.Property<int>("DoubleSheets")
                        .HasColumnType("int");

                    b.Property<int>("FootTowels")
                        .HasColumnType("int");

                    b.Property<int>("Pillowcases")
                        .HasColumnType("int");

                    b.Property<long>("ReservedRoomId")
                        .HasColumnType("bigint");

                    b.Property<int>("SingleDuvetCovers")
                        .HasColumnType("int");

                    b.Property<int>("SingleSheets")
                        .HasColumnType("int");

                    b.Property<int>("SmallTowels")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChambermaidId");

                    b.HasIndex("CleaningStatusId");

                    b.HasIndex("CleaningTypeId");

                    b.HasIndex("ReservedRoomId");

                    b.ToTable("AssignedRooms");
                });

            modelBuilder.Entity("HotelRooms.Data.Entities.Chambermaid", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Chambermaids");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 127, DateTimeKind.Local).AddTicks(5605),
                            LastName = "Ivić",
                            Name = "Ivana"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 127, DateTimeKind.Local).AddTicks(6815),
                            LastName = "Matić",
                            Name = "Matea"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 127, DateTimeKind.Local).AddTicks(6868),
                            LastName = "Lorić",
                            Name = "Lara"
                        });
                });

            modelBuilder.Entity("HotelRooms.Data.Entities.CleaningStatus", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CleaningStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 128, DateTimeKind.Local).AddTicks(293),
                            Status = "Nespremljena"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 128, DateTimeKind.Local).AddTicks(883),
                            Status = "Trenutno se sprema"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 128, DateTimeKind.Local).AddTicks(932),
                            Status = "Zavrsena"
                        });
                });

            modelBuilder.Entity("HotelRooms.Data.Entities.CleaningType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CleaningTypes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 119, DateTimeKind.Local).AddTicks(5714),
                            Type = "Generalna"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 125, DateTimeKind.Local).AddTicks(2342),
                            Type = "Gostinjska"
                        });
                });

            modelBuilder.Entity("HotelRooms.Data.Entities.Guest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Guests");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 128, DateTimeKind.Local).AddTicks(9805),
                            Email = "morgan@mailinator.com",
                            LastName = "Adams",
                            Name = "Morgan"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1696),
                            Email = "petar@mailinator.com",
                            LastName = "Tuker",
                            Name = "Petar"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1776),
                            Email = "simona@mailinator.com",
                            LastName = "Horvat",
                            Name = "Simona"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1784),
                            Email = "ivanalton@mailinator.com",
                            LastName = "Alton",
                            Name = "Ivan"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1788),
                            Email = "morgan@mailinator.com",
                            LastName = "Adams",
                            Name = "Morgan"
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1792),
                            Email = "claudia@mailinator.com",
                            LastName = "Hebert",
                            Name = "Claudia"
                        },
                        new
                        {
                            Id = 7L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1795),
                            Email = "salvatore@mailinator.com",
                            LastName = "Singh",
                            Name = "Salvatore"
                        },
                        new
                        {
                            Id = 8L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1799),
                            Email = "misty@mailinator.com",
                            LastName = "Porter",
                            Name = "Misty"
                        },
                        new
                        {
                            Id = 9L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1803),
                            Email = "mendoza@mailinator.com",
                            LastName = "Mendoza",
                            Name = "Brett"
                        },
                        new
                        {
                            Id = 10L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1811),
                            Email = "abel@mailinator.com",
                            LastName = "Abel",
                            Name = "Wilfred"
                        });
                });

            modelBuilder.Entity("HotelRooms.Data.Entities.ReservedRoom", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("GuestId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoomId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("ReservedRooms");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ArrivalDate = new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(6649),
                            DepartureDate = new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 1L,
                            RoomId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            ArrivalDate = new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9168),
                            DepartureDate = new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 2L,
                            RoomId = 2L
                        },
                        new
                        {
                            Id = 3L,
                            ArrivalDate = new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9274),
                            DepartureDate = new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 3L,
                            RoomId = 3L
                        },
                        new
                        {
                            Id = 4L,
                            ArrivalDate = new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9282),
                            DepartureDate = new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 4L,
                            RoomId = 4L
                        },
                        new
                        {
                            Id = 5L,
                            ArrivalDate = new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9289),
                            DepartureDate = new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 5L,
                            RoomId = 5L
                        },
                        new
                        {
                            Id = 6L,
                            ArrivalDate = new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9293),
                            DepartureDate = new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 6L,
                            RoomId = 6L
                        },
                        new
                        {
                            Id = 7L,
                            ArrivalDate = new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9297),
                            DepartureDate = new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 7L,
                            RoomId = 7L
                        },
                        new
                        {
                            Id = 8L,
                            ArrivalDate = new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9305),
                            DepartureDate = new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 8L,
                            RoomId = 8L
                        },
                        new
                        {
                            Id = 9L,
                            ArrivalDate = new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9308),
                            DepartureDate = new DateTime(2020, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 9L,
                            RoomId = 9L
                        });
                });

            modelBuilder.Entity("HotelRooms.Data.Entities.Room", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("RoomTypeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(3735),
                            RoomTypeId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4667),
                            RoomTypeId = 2L
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4755),
                            RoomTypeId = 2L
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4801),
                            RoomTypeId = 3L
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4808),
                            RoomTypeId = 4L
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4816),
                            RoomTypeId = 1L
                        },
                        new
                        {
                            Id = 7L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4823),
                            RoomTypeId = 2L
                        },
                        new
                        {
                            Id = 8L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4831),
                            RoomTypeId = 2L
                        },
                        new
                        {
                            Id = 9L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4842),
                            RoomTypeId = 3L
                        },
                        new
                        {
                            Id = 10L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4846),
                            RoomTypeId = 5L
                        },
                        new
                        {
                            Id = 11L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4850),
                            RoomTypeId = 1L
                        },
                        new
                        {
                            Id = 12L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4858),
                            RoomTypeId = 2L
                        },
                        new
                        {
                            Id = 13L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4861),
                            RoomTypeId = 3L
                        },
                        new
                        {
                            Id = 14L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4865),
                            RoomTypeId = 3L
                        },
                        new
                        {
                            Id = 15L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4869),
                            RoomTypeId = 4L
                        });
                });

            modelBuilder.Entity("HotelRooms.Data.Entities.RoomType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(6536),
                            Type = "1SB"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(7145),
                            Type = "2SB"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(7179),
                            Type = "1DB"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(7186),
                            Type = "3SB"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(7190),
                            Type = "1DB1SB"
                        });
                });

            modelBuilder.Entity("HotelRooms.Data.Entities.AssignedRoom", b =>
                {
                    b.HasOne("HotelRooms.Data.Entities.Chambermaid", "Chambermaid")
                        .WithMany()
                        .HasForeignKey("ChambermaidId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelRooms.Data.Entities.CleaningStatus", "CleaningStatus")
                        .WithMany()
                        .HasForeignKey("CleaningStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelRooms.Data.Entities.CleaningType", "CleaningType")
                        .WithMany()
                        .HasForeignKey("CleaningTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelRooms.Data.Entities.ReservedRoom", "ReservedRoom")
                        .WithMany()
                        .HasForeignKey("ReservedRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelRooms.Data.Entities.ReservedRoom", b =>
                {
                    b.HasOne("HotelRooms.Data.Entities.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelRooms.Data.Entities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelRooms.Data.Entities.Room", b =>
                {
                    b.HasOne("HotelRooms.Data.Entities.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
