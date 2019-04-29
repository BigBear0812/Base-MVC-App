﻿// <auto-generated />
using DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabaseModels.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190429190614_ChangeObjectNames")]
    partial class ChangeObjectNames
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DatabaseModels.ToDoItem", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemName");

                    b.Property<int>("ListId");

                    b.Property<int>("Quantity");

                    b.HasKey("ItemId");

                    b.HasIndex("ListId");

                    b.ToTable("ToDoItems");
                });

            modelBuilder.Entity("DatabaseModels.ToDoList", b =>
                {
                    b.Property<int>("ListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ListName");

                    b.HasKey("ListId");

                    b.ToTable("ToDoLists");
                });

            modelBuilder.Entity("DatabaseModels.ToDoItem", b =>
                {
                    b.HasOne("DatabaseModels.ToDoList")
                        .WithMany("Items")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
