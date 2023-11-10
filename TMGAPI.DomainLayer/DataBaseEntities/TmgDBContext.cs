using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TMGAPI.DomainLayer.DataBaseEntities;

public partial class TmgDBContext : DbContext
{
    public TmgDBContext(DbContextOptions<TmgDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblApplicantInfo> TblApplicantInfos { get; set; }

    public virtual DbSet<TblApplicantType> TblApplicantTypes { get; set; }

    public virtual DbSet<TblCreditScore> TblCreditScores { get; set; }

    public virtual DbSet<TblCreditSummary> TblCreditSummaries { get; set; }

    public virtual DbSet<TblExtraDeposit> TblExtraDeposits { get; set; }

    public virtual DbSet<TblIncomeCriterion> TblIncomeCriteria { get; set; }

    public virtual DbSet<TblIncomeVerification> TblIncomeVerifications { get; set; }

    public virtual DbSet<TblLandlordReferance> TblLandlordReferances { get; set; }

    public virtual DbSet<TblPet> TblPets { get; set; }

    public virtual DbSet<TblPointsSummary> TblPointsSummaries { get; set; }

    public virtual DbSet<TblPropertyType> TblPropertyTypes { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<TblTenantInfo> TblTenantInfos { get; set; }

    public virtual DbSet<TblTenantType> TblTenantTypes { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblApplicantInfo>(entity =>
        {
            entity.ToTable("tblApplicantInfo");

            entity.Property(e => e.ApplicantName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PetDeposit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Property)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Section8Rent)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardDepositProperty)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenantStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblApplicantInfoCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblApplicantInfo_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblApplicantInfoModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblApplicantInfo_tblUsers1");
        });

        modelBuilder.Entity<TblApplicantType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblApplicant_Type");

            entity.ToTable("tblApplicantType");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblApplicantTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblApplicantType_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblApplicantTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblApplicantType_tblUsers1");
        });

        modelBuilder.Entity<TblCreditScore>(entity =>
        {
            entity.ToTable("tblCreditScore");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblCreditScoreCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblCreditScore_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblCreditScoreModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblCreditScore_tblUsers1");

            entity.HasOne(d => d.PropertyType).WithMany(p => p.TblCreditScores)
                .HasForeignKey(d => d.PropertyTypeId)
                .HasConstraintName("FK_tblCreditScore_tblPropertyType");

            entity.HasOne(d => d.TenantType).WithMany(p => p.TblCreditScores)
                .HasForeignKey(d => d.TenantTypeId)
                .HasConstraintName("FK_tblCreditScore_tblTenantType");
        });

        modelBuilder.Entity<TblCreditSummary>(entity =>
        {
            entity.ToTable("tblCreditSummary");

            entity.Property(e => e.Class1Misdemeaners).HasColumnType("datetime");
            entity.Property(e => e.Class2Felonies).HasColumnType("datetime");
            entity.Property(e => e.Class2Misdemeaners).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EvectionHistory)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblCreditSummaryCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblCreditSummary_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblCreditSummaryModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblCreditSummary_tblUsers1");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TblCreditSummaries)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("FK_tblCreditSummary_tblTenantInfo");
        });

        modelBuilder.Entity<TblExtraDeposit>(entity =>
        {
            entity.ToTable("tblExtraDeposits");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblExtraDepositCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblExtraDeposits_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblExtraDepositModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblExtraDeposits_tblUsers1");

            entity.HasOne(d => d.PropertyType).WithMany(p => p.TblExtraDeposits)
                .HasForeignKey(d => d.PropertyTypeId)
                .HasConstraintName("FK_tblExtraDeposits_tblPropertyType");

            entity.HasOne(d => d.TenantType).WithMany(p => p.TblExtraDeposits)
                .HasForeignKey(d => d.TenantTypeId)
                .HasConstraintName("FK_tblExtraDeposits_tblTenantType");
        });

        modelBuilder.Entity<TblIncomeCriterion>(entity =>
        {
            entity.ToTable("tblIncomeCriteria");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.ApplicantType).WithMany(p => p.TblIncomeCriteria)
                .HasForeignKey(d => d.ApplicantTypeId)
                .HasConstraintName("FK_tblIncomeCriteria_tblApplicantType");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblIncomeCriterionCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblIncomeCriteria_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblIncomeCriterionModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblIncomeCriteria_tblUsers1");

            entity.HasOne(d => d.PropertyType).WithMany(p => p.TblIncomeCriteria)
                .HasForeignKey(d => d.PropertyTypeId)
                .HasConstraintName("FK_tblIncomeCriteria_tblPropertyType");
        });

        modelBuilder.Entity<TblIncomeVerification>(entity =>
        {
            entity.ToTable("tblIncomeVerification");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.XRent).HasColumnName("xRent");
            entity.Property(e => e.YtdEarnings).HasColumnName("YTD_Earnings");
            entity.Property(e => e._2ndPayStub).HasColumnName("2ndPayStub");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblIncomeVerificationCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblIncomeVerification_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblIncomeVerificationModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblIncomeVerification_tblUsers1");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TblIncomeVerifications)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("FK_tblIncomeVerification_tblTenantInfo");
        });

        modelBuilder.Entity<TblLandlordReferance>(entity =>
        {
            entity.ToTable("tblLandlordReferances");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Hoaviolations).HasColumnName("HOAViolations");
            entity.Property(e => e.HoaviolationsPoints).HasColumnName("HOAViolationsPoints");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Nsf).HasColumnName("NSF");
            entity.Property(e => e.Nsfpoints).HasColumnName("NSFPoints");
            entity.Property(e => e._10dayComplyNotice).HasColumnName("10dayComplyNotice");
            entity.Property(e => e._10dayComplyNoticePoints).HasColumnName("10dayComplyNoticePoints");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblLandlordReferanceCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblLandlordReferances_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblLandlordReferanceModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblLandlordReferances_tblUsers1");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TblLandlordReferances)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("FK_tblLandlordReferances_tblTenantInfo");
        });

        modelBuilder.Entity<TblPet>(entity =>
        {
            entity.ToTable("tblPets");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblPetCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblPets_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblPetModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblPets_tblUsers1");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TblPets)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("FK_tblPets_tblTenantInfo");
        });

        modelBuilder.Entity<TblPointsSummary>(entity =>
        {
            entity.ToTable("tblPointsSummary");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblPointsSummaryCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblPointsSummary_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblPointsSummaryModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblPointsSummary_tblUsers1");
        });

        modelBuilder.Entity<TblPropertyType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblProperty_Type");

            entity.ToTable("tblPropertyType");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblPropertyTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblPropertyType_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblPropertyTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblPropertyType_tblUsers1");
        });

        modelBuilder.Entity<TblRole>(entity =>
        {
            entity.ToTable("tblRoles");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblRoleCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblRoles_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblRoleModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblRoles_tblUsers1");
        });

        modelBuilder.Entity<TblTenantInfo>(entity =>
        {
            entity.ToTable("tblTenantInfo");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TenantSerialNumber).HasColumnName("Tenant_Serial_Number");

            entity.HasOne(d => d.Applicant).WithMany(p => p.TblTenantInfos)
                .HasForeignKey(d => d.ApplicantId)
                .HasConstraintName("FK_tblTenantInfo_tblApplicantInfo");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblTenantInfoCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblTenantInfo_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblTenantInfoModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblTenantInfo_tblUsers1");
        });

        modelBuilder.Entity<TblTenantType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblTenant_Type");

            entity.ToTable("tblTenantType");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblTenantTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblTenantType_tblUsers");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblTenantTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblTenantType_tblUsers1");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.ToTable("tblUsers");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Role).WithMany(p => p.TblUsers)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_tblUsers_tblRoles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
