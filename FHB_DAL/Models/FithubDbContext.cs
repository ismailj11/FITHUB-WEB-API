using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FHB_DAL.Models;

public partial class FithubDbContext : DbContext
{
    public FithubDbContext()
    {
    }

    public FithubDbContext(DbContextOptions<FithubDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Coach> Coaches { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<GymSub> GymSubs { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<PersonalTrainerSub> PersonalTrainerSubs { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Tenant> Tenants { get; set; }

    public virtual DbSet<TrainingRecord> TrainingRecords { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-4D5C2RR;Database=FithubDB;Trusted_Connection=True; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.CategoryId).HasColumnName("Category_ID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .HasColumnName("Category_Name");
        });

        modelBuilder.Entity<Coach>(entity =>
        {
            entity.HasKey(e => e.CoachId).HasName("PK__Coach__F411D9A1E0BBD008");

            entity.ToTable("Coach");

            entity.Property(e => e.CoachId)
                .ValueGeneratedNever()
                .HasColumnName("Coach_ID");
            entity.Property(e => e.CoachName).HasMaxLength(50);
            entity.Property(e => e.FkEmployeeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FK_Employee_ID");
            entity.Property(e => e.Specialization).HasMaxLength(50);

            entity.HasOne(d => d.FkEmployee).WithMany(p => p.Coaches)
                .HasForeignKey(d => d.FkEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Coach__FK_Employ__4D94879B");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF18CBE824D");

            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployeeName).HasMaxLength(50);
            entity.Property(e => e.FkUserId).HasColumnName("FK_UserID");
            entity.Property(e => e.Salary)
                .HasColumnType("money")
                .HasColumnName("salary");

            entity.HasOne(d => d.FkUser).WithMany(p => p.Employees)
                .HasForeignKey(d => d.FkUserId)
                .HasConstraintName("FK__Employees__FK_Us__4AB81AF0");
        });

        modelBuilder.Entity<GymSub>(entity =>
        {
            entity.HasKey(e => e.SubscriberId).HasName("PK__GymSub__7DFEB634DB54AC9B");

            entity.ToTable("GymSub");

            entity.Property(e => e.SubscriberId).HasColumnName("Subscriber_ID");
            entity.Property(e => e.FkMemberId).HasColumnName("FK_Member_ID");
            entity.Property(e => e.FkTenantId).HasColumnName("FK_TenantID");

            entity.HasOne(d => d.FkMember).WithMany(p => p.GymSubs)
                .HasForeignKey(d => d.FkMemberId)
                .HasConstraintName("FK__GymSub__FK_Membe__5EBF139D");

            entity.HasOne(d => d.FkTenant).WithMany(p => p.GymSubs)
                .HasForeignKey(d => d.FkTenantId)
                .HasConstraintName("fk_cenantID");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__members__B29A816CE857CFF2");

            entity.ToTable("members");

            entity.Property(e => e.MemberId).HasColumnName("member_ID");
            entity.Property(e => e.FkUserId).HasColumnName("FK_User_ID");
            entity.Property(e => e.MemberName).HasMaxLength(50);
            entity.Property(e => e.RegistrationDate).HasColumnName("Registration_Date");

            entity.HasOne(d => d.FkUser).WithMany(p => p.Members)
                .HasForeignKey(d => d.FkUserId)
                .HasConstraintName("FK__members__FK_User__3D5E1FD2");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payments__9B556A585653D624");

            entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("money")
                .HasColumnName("amount");
            entity.Property(e => e.CreatedAt).HasColumnName("CreatedAT");
            entity.Property(e => e.FkMemberId).HasColumnName("FK_member_ID");
            entity.Property(e => e.FkMethodId).HasColumnName("FK_method_ID");
            entity.Property(e => e.FkPersonalTrainerSubId).HasColumnName("FK_PersonalTrainerSub_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_product_ID");
            entity.Property(e => e.FkSubscriberId).HasColumnName("FK_Subscriber_ID");
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("Transaction_ID");
            entity.Property(e => e.UpdatedAt).HasColumnName("UpdatedAT");

            entity.HasOne(d => d.FkMember).WithMany(p => p.Payments)
                .HasForeignKey(d => d.FkMemberId)
                .HasConstraintName("FK__Payments__FK_mem__6383C8BA");

            entity.HasOne(d => d.FkMethod).WithMany(p => p.Payments)
                .HasForeignKey(d => d.FkMethodId)
                .HasConstraintName("FK__Payments__FK_met__6477ECF3");

            entity.HasOne(d => d.FkPersonalTrainerSub).WithMany(p => p.Payments)
                .HasForeignKey(d => d.FkPersonalTrainerSubId)
                .HasConstraintName("FK__Payments__FK_Per__6754599E");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.Payments)
                .HasForeignKey(d => d.FkProductId)
                .HasConstraintName("FK__Payments__FK_pro__656C112C");

            entity.HasOne(d => d.FkSubscriber).WithMany(p => p.Payments)
                .HasForeignKey(d => d.FkSubscriberId)
                .HasConstraintName("FK__Payments__FK_Sub__66603565");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.MethodId).HasName("PK__PaymentM__FC681FB15487A1F8");

            entity.ToTable("PaymentMethod");

            entity.Property(e => e.MethodId).HasColumnName("Method_ID");
            entity.Property(e => e.Method)
                .HasMaxLength(50)
                .HasColumnName("method");
        });

        modelBuilder.Entity<PersonalTrainerSub>(entity =>
        {
            entity.HasKey(e => e.SubId).HasName("PK__Personal__DFB18CAD608C6604");

            entity.ToTable("PersonalTrainerSub");

            entity.Property(e => e.SubId).HasColumnName("Sub_ID");
            entity.Property(e => e.FkMemberId).HasColumnName("FK_Member_ID");
            entity.Property(e => e.FkRecordId).HasColumnName("FK_Record_ID");

            entity.HasOne(d => d.FkMember).WithMany(p => p.PersonalTrainerSubs)
                .HasForeignKey(d => d.FkMemberId)
                .HasConstraintName("FK__PersonalT__FK_Me__5BE2A6F2");

            entity.HasOne(d => d.FkRecord).WithMany(p => p.PersonalTrainerSubs)
                .HasForeignKey(d => d.FkRecordId)
                .HasConstraintName("FK__PersonalT__FK_Re__5AEE82B9");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6EDDF7CA7CE");

            entity.Property(e => e.ProductId).HasColumnName("Product_ID");
            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.FkCategoryId).HasColumnName("FK_Category_ID");
            entity.Property(e => e.ProductName).HasMaxLength(50);
        });

        modelBuilder.Entity<Tenant>(entity =>
        {
            entity.HasKey(e => e.TenantId).HasName("PK__tenant__2E9B47814EFD5B23");

            entity.ToTable("tenant");

            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TenantName).HasMaxLength(50);
        });

        modelBuilder.Entity<TrainingRecord>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK__Training__FBDF78C9352D8E8D");

            entity.Property(e => e.RecordId).HasColumnName("Record_ID");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.FkCoachId).HasColumnName("FK_Coach_ID");
            entity.Property(e => e.Trainer).HasMaxLength(50);
            entity.Property(e => e.TrainingType).HasMaxLength(50);

            entity.HasOne(d => d.FkCoach).WithMany(p => p.TrainingRecords)
                .HasForeignKey(d => d.FkCoachId)
                .HasConstraintName("FK__TrainingR__FK_Co__5070F446");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC2F13E703");

            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
