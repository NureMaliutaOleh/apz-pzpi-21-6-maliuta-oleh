﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartInlet.Server.Services.DB;

#nullable disable

namespace SmartInlet.Server.Services.DB.Migrations
{
    [DbContext(typeof(DbApp))]
    partial class DbAppModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SmartInlet.Server.Models.ActivationCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("ExpiresAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ActivationCodes");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.AirSensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccessCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Aqi")
                        .IsRequired()
                        .HasColumnType("smallint");

                    b.Property<short>("AqiLimitToClose")
                        .HasColumnType("smallint");

                    b.Property<short>("AqiLimitToOpen")
                        .HasColumnType("smallint");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int?>("InletDeviceId")
                        .HasColumnType("int");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("AirSensors");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("JoinOffersFromUsersAllowed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("OwnerId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.GroupMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("CanEditDevices")
                        .HasColumnType("bit");

                    b.Property<bool>("CanEditMembers")
                        .HasColumnType("bit");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("GroupMembers");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.InletDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccessCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AirSensorId")
                        .HasColumnType("int");

                    b.Property<string>("ControlType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOpened")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TempSensorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AirSensorId")
                        .IsUnique()
                        .HasFilter("[AirSensorId] IS NOT NULL");

                    b.HasIndex("GroupId");

                    b.HasIndex("TempSensorId")
                        .IsUnique()
                        .HasFilter("[TempSensorId] IS NOT NULL");

                    b.ToTable("InletDevices");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.JoinOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SentByGroup")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("JoinOffers");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.TempSensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccessCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int?>("InletDeviceId")
                        .HasColumnType("int");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<short>("KelvinLimitToClose")
                        .HasColumnType("smallint");

                    b.Property<short>("KelvinLimitToOpen")
                        .HasColumnType("smallint");

                    b.Property<short?>("Kelvins")
                        .IsRequired()
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("TempSensors");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("CanAdministrateDevices")
                        .HasColumnType("bit");

                    b.Property<bool>("CanAdministrateUsers")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CanAdministrateDevices = true,
                            CanAdministrateUsers = true,
                            Email = "1@gmail.com",
                            FirstName = "Artem",
                            IsActivated = true,
                            LastName = "Lavrinenko",
                            PasswordHash = "onGj5ihsCZ60LCjul2gTk3hfZBxhR74lkDfBtPwi4EWqN9GJ56cEZd5Go3DcdAV1luSxyxYu7pYwMQnuNKGzZkicYbGjsPKRzxLjfNpkeeJ5gj24uzAJzOePysa8Zysh+YKNppL/7o1UTU5qg83uQNn3QcXvxyQhvwApDK9y8SL00aD1wjeYlzP/YMuY3mLOZskup2QXs5OCslexhK3Z2G9KiihMYwjUONSUHnKcPjIu7YXzRfae+BIFRrfCApmhu2eVAQt2M0/JMNcc95yuRYJGp5X8TfOEKMFKwDwTsMl6X+o/pIRZ2ftneHs1qmECXm74M9SjOhN8rAOmwrbefXZ0EeNfzvIPVOr7nkcoxe1/M7ZYiUuZBdA3BwC1W7eeQ4AV/Hr70vr4TwKWjdu7DcWbFHVxxyDP4aAXPUcCipqILfRJjzGYQYwyVh3WDMVGYQcmBgGfwz+AtG/Liw4azrHvf1Qn/nMoLmoM6OzGHnSzRPGbXErT6a6IgZnbQRw1e7zfr+RKD7Q7TfO6m1ebY9jn5YwVQ2aEpcI1GABiL/+c5ZdXRPP024JLBJJR9Ue943gMvKP89PrMpQaQp1BnNPkfC6G8Z4aEpwWZ+AHkVOicPVlD8TGWi0Ri9q8WQnITzoKmquX2GFft/EbBBwSF5OW3LfjhwB4BMPwdmsQc0h8=",
                            RegisteredAt = new DateTime(2024, 6, 1, 14, 33, 9, 760, DateTimeKind.Utc).AddTicks(8920),
                            Username = "user1"
                        },
                        new
                        {
                            Id = 2,
                            CanAdministrateDevices = false,
                            CanAdministrateUsers = true,
                            Email = "2@gmail.com",
                            FirstName = "Artem",
                            IsActivated = true,
                            LastName = "Lavrinenko",
                            PasswordHash = "onGj5ihsCZ60LCjul2gTk3hfZBxhR74lkDfBtPwi4EWqN9GJ56cEZd5Go3DcdAV1luSxyxYu7pYwMQnuNKGzZkicYbGjsPKRzxLjfNpkeeJ5gj24uzAJzOePysa8Zysh+YKNppL/7o1UTU5qg83uQNn3QcXvxyQhvwApDK9y8SL00aD1wjeYlzP/YMuY3mLOZskup2QXs5OCslexhK3Z2G9KiihMYwjUONSUHnKcPjIu7YXzRfae+BIFRrfCApmhu2eVAQt2M0/JMNcc95yuRYJGp5X8TfOEKMFKwDwTsMl6X+o/pIRZ2ftneHs1qmECXm74M9SjOhN8rAOmwrbefXZ0EeNfzvIPVOr7nkcoxe1/M7ZYiUuZBdA3BwC1W7eeQ4AV/Hr70vr4TwKWjdu7DcWbFHVxxyDP4aAXPUcCipqILfRJjzGYQYwyVh3WDMVGYQcmBgGfwz+AtG/Liw4azrHvf1Qn/nMoLmoM6OzGHnSzRPGbXErT6a6IgZnbQRw1e7zfr+RKD7Q7TfO6m1ebY9jn5YwVQ2aEpcI1GABiL/+c5ZdXRPP024JLBJJR9Ue943gMvKP89PrMpQaQp1BnNPkfC6G8Z4aEpwWZ+AHkVOicPVlD8TGWi0Ri9q8WQnITzoKmquX2GFft/EbBBwSF5OW3LfjhwB4BMPwdmsQc0h8=",
                            RegisteredAt = new DateTime(2024, 6, 1, 14, 33, 9, 760, DateTimeKind.Utc).AddTicks(8925),
                            Username = "user2"
                        },
                        new
                        {
                            Id = 3,
                            CanAdministrateDevices = true,
                            CanAdministrateUsers = false,
                            Email = "3@gmail.com",
                            FirstName = "Artem",
                            IsActivated = true,
                            LastName = "Lavrinenko",
                            PasswordHash = "onGj5ihsCZ60LCjul2gTk3hfZBxhR74lkDfBtPwi4EWqN9GJ56cEZd5Go3DcdAV1luSxyxYu7pYwMQnuNKGzZkicYbGjsPKRzxLjfNpkeeJ5gj24uzAJzOePysa8Zysh+YKNppL/7o1UTU5qg83uQNn3QcXvxyQhvwApDK9y8SL00aD1wjeYlzP/YMuY3mLOZskup2QXs5OCslexhK3Z2G9KiihMYwjUONSUHnKcPjIu7YXzRfae+BIFRrfCApmhu2eVAQt2M0/JMNcc95yuRYJGp5X8TfOEKMFKwDwTsMl6X+o/pIRZ2ftneHs1qmECXm74M9SjOhN8rAOmwrbefXZ0EeNfzvIPVOr7nkcoxe1/M7ZYiUuZBdA3BwC1W7eeQ4AV/Hr70vr4TwKWjdu7DcWbFHVxxyDP4aAXPUcCipqILfRJjzGYQYwyVh3WDMVGYQcmBgGfwz+AtG/Liw4azrHvf1Qn/nMoLmoM6OzGHnSzRPGbXErT6a6IgZnbQRw1e7zfr+RKD7Q7TfO6m1ebY9jn5YwVQ2aEpcI1GABiL/+c5ZdXRPP024JLBJJR9Ue943gMvKP89PrMpQaQp1BnNPkfC6G8Z4aEpwWZ+AHkVOicPVlD8TGWi0Ri9q8WQnITzoKmquX2GFft/EbBBwSF5OW3LfjhwB4BMPwdmsQc0h8=",
                            RegisteredAt = new DateTime(2024, 6, 1, 14, 33, 9, 760, DateTimeKind.Utc).AddTicks(8927),
                            Username = "user3"
                        },
                        new
                        {
                            Id = 4,
                            CanAdministrateDevices = false,
                            CanAdministrateUsers = false,
                            Email = "4@gmail.com",
                            FirstName = "Artem",
                            IsActivated = true,
                            LastName = "Lavrinenko",
                            PasswordHash = "onGj5ihsCZ60LCjul2gTk3hfZBxhR74lkDfBtPwi4EWqN9GJ56cEZd5Go3DcdAV1luSxyxYu7pYwMQnuNKGzZkicYbGjsPKRzxLjfNpkeeJ5gj24uzAJzOePysa8Zysh+YKNppL/7o1UTU5qg83uQNn3QcXvxyQhvwApDK9y8SL00aD1wjeYlzP/YMuY3mLOZskup2QXs5OCslexhK3Z2G9KiihMYwjUONSUHnKcPjIu7YXzRfae+BIFRrfCApmhu2eVAQt2M0/JMNcc95yuRYJGp5X8TfOEKMFKwDwTsMl6X+o/pIRZ2ftneHs1qmECXm74M9SjOhN8rAOmwrbefXZ0EeNfzvIPVOr7nkcoxe1/M7ZYiUuZBdA3BwC1W7eeQ4AV/Hr70vr4TwKWjdu7DcWbFHVxxyDP4aAXPUcCipqILfRJjzGYQYwyVh3WDMVGYQcmBgGfwz+AtG/Liw4azrHvf1Qn/nMoLmoM6OzGHnSzRPGbXErT6a6IgZnbQRw1e7zfr+RKD7Q7TfO6m1ebY9jn5YwVQ2aEpcI1GABiL/+c5ZdXRPP024JLBJJR9Ue943gMvKP89PrMpQaQp1BnNPkfC6G8Z4aEpwWZ+AHkVOicPVlD8TGWi0Ri9q8WQnITzoKmquX2GFft/EbBBwSF5OW3LfjhwB4BMPwdmsQc0h8=",
                            RegisteredAt = new DateTime(2024, 6, 1, 14, 33, 9, 760, DateTimeKind.Utc).AddTicks(8930),
                            Username = "user4"
                        },
                        new
                        {
                            Id = 5,
                            CanAdministrateDevices = false,
                            CanAdministrateUsers = false,
                            Email = "5@gmail.com",
                            FirstName = "Artem",
                            IsActivated = true,
                            LastName = "Lavrinenko",
                            PasswordHash = "onGj5ihsCZ60LCjul2gTk3hfZBxhR74lkDfBtPwi4EWqN9GJ56cEZd5Go3DcdAV1luSxyxYu7pYwMQnuNKGzZkicYbGjsPKRzxLjfNpkeeJ5gj24uzAJzOePysa8Zysh+YKNppL/7o1UTU5qg83uQNn3QcXvxyQhvwApDK9y8SL00aD1wjeYlzP/YMuY3mLOZskup2QXs5OCslexhK3Z2G9KiihMYwjUONSUHnKcPjIu7YXzRfae+BIFRrfCApmhu2eVAQt2M0/JMNcc95yuRYJGp5X8TfOEKMFKwDwTsMl6X+o/pIRZ2ftneHs1qmECXm74M9SjOhN8rAOmwrbefXZ0EeNfzvIPVOr7nkcoxe1/M7ZYiUuZBdA3BwC1W7eeQ4AV/Hr70vr4TwKWjdu7DcWbFHVxxyDP4aAXPUcCipqILfRJjzGYQYwyVh3WDMVGYQcmBgGfwz+AtG/Liw4azrHvf1Qn/nMoLmoM6OzGHnSzRPGbXErT6a6IgZnbQRw1e7zfr+RKD7Q7TfO6m1ebY9jn5YwVQ2aEpcI1GABiL/+c5ZdXRPP024JLBJJR9Ue943gMvKP89PrMpQaQp1BnNPkfC6G8Z4aEpwWZ+AHkVOicPVlD8TGWi0Ri9q8WQnITzoKmquX2GFft/EbBBwSF5OW3LfjhwB4BMPwdmsQc0h8=",
                            RegisteredAt = new DateTime(2024, 6, 1, 14, 33, 9, 760, DateTimeKind.Utc).AddTicks(8932),
                            Username = "user5"
                        });
                });

            modelBuilder.Entity("SmartInlet.Server.Models.ActivationCode", b =>
                {
                    b.HasOne("SmartInlet.Server.Models.User", "User")
                        .WithMany("ActivationCodes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.AirSensor", b =>
                {
                    b.HasOne("SmartInlet.Server.Models.Group", "Group")
                        .WithMany("AirSensors")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Group");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.Group", b =>
                {
                    b.HasOne("SmartInlet.Server.Models.User", "Owner")
                        .WithMany("Groups")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.GroupMember", b =>
                {
                    b.HasOne("SmartInlet.Server.Models.Group", "Group")
                        .WithMany("GroupMembers")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartInlet.Server.Models.User", "User")
                        .WithMany("GroupMembers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.InletDevice", b =>
                {
                    b.HasOne("SmartInlet.Server.Models.AirSensor", "AirSensor")
                        .WithOne("InletDevice")
                        .HasForeignKey("SmartInlet.Server.Models.InletDevice", "AirSensorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SmartInlet.Server.Models.Group", "Group")
                        .WithMany("InletDevices")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SmartInlet.Server.Models.TempSensor", "TempSensor")
                        .WithOne("InletDevice")
                        .HasForeignKey("SmartInlet.Server.Models.InletDevice", "TempSensorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("AirSensor");

                    b.Navigation("Group");

                    b.Navigation("TempSensor");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.JoinOffer", b =>
                {
                    b.HasOne("SmartInlet.Server.Models.Group", "Group")
                        .WithMany("JoinOffers")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmartInlet.Server.Models.User", "User")
                        .WithMany("JoinOffers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.TempSensor", b =>
                {
                    b.HasOne("SmartInlet.Server.Models.Group", "Group")
                        .WithMany("TempSensors")
                        .HasForeignKey("GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.AirSensor", b =>
                {
                    b.Navigation("InletDevice");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.Group", b =>
                {
                    b.Navigation("AirSensors");

                    b.Navigation("GroupMembers");

                    b.Navigation("InletDevices");

                    b.Navigation("JoinOffers");

                    b.Navigation("TempSensors");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.TempSensor", b =>
                {
                    b.Navigation("InletDevice");
                });

            modelBuilder.Entity("SmartInlet.Server.Models.User", b =>
                {
                    b.Navigation("ActivationCodes");

                    b.Navigation("GroupMembers");

                    b.Navigation("Groups");

                    b.Navigation("JoinOffers");
                });
#pragma warning restore 612, 618
        }
    }
}
