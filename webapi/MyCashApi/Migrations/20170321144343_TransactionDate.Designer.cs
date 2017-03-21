using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyCashApi.Infrastructure;
using MyCashApi.Entities;

namespace MyCashApi.Migrations
{
    [DbContext(typeof(Ctx))]
    [Migration("20170321144343_TransactionDate")]
    partial class TransactionDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyCashApi.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountType");

                    b.Property<float>("IYR");

                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.Property<float>("PYR");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("MyCashApi.Entities.Budget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Budgets");
                });

            modelBuilder.Entity("MyCashApi.Entities.BudgetEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("ActualValue");

                    b.Property<int?>("BudgetId");

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Comment");

                    b.Property<float>("ExpectedValue");

                    b.Property<float>("Result");

                    b.HasKey("Id");

                    b.HasIndex("BudgetId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BudgetEntries");
                });

            modelBuilder.Entity("MyCashApi.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("VisibilityOrder");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MyCashApi.Entities.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AccountId");

                    b.Property<int?>("CategoryId");

                    b.Property<DateTime>("Deadline");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ReccurringPattern");

                    b.Property<bool>("Recurring");

                    b.Property<float>("Value");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("MyCashApi.Entities.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("MyCashApi.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AccountId");

                    b.Property<string>("Description");

                    b.Property<int?>("SubCategoryId");

                    b.Property<DateTime>("TransactionDate");

                    b.Property<int>("TransactionType");

                    b.Property<float>("Value");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("MyCashApi.Entities.BudgetEntry", b =>
                {
                    b.HasOne("MyCashApi.Entities.Budget")
                        .WithMany("BudgetEntries")
                        .HasForeignKey("BudgetId");

                    b.HasOne("MyCashApi.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("MyCashApi.Entities.Goal", b =>
                {
                    b.HasOne("MyCashApi.Entities.Category", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("MyCashApi.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("MyCashApi.Entities.SubCategory", b =>
                {
                    b.HasOne("MyCashApi.Entities.Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("MyCashApi.Entities.Transaction", b =>
                {
                    b.HasOne("MyCashApi.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("MyCashApi.Entities.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId");
                });
        }
    }
}
