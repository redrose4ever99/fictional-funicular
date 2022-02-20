using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace testproj.Models
{
    public partial class WakoodSitesContext : DbContext
    {
        public WakoodSitesContext()
        {
        }

        public WakoodSitesContext(DbContextOptions<WakoodSitesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivationStatus> ActivationStatuses { get; set; } = null!;
        public virtual DbSet<Card> Cards { get; set; } = null!;
        public virtual DbSet<CardsLogical> CardsLogicals { get; set; } = null!;
        public virtual DbSet<CardsTag> CardsTags { get; set; } = null!;
        public virtual DbSet<CardsVehicle> CardsVehicles { get; set; } = null!;
        public virtual DbSet<Cat> Cats { get; set; } = null!;
        public virtual DbSet<Decision> Decisions { get; set; } = null!;
        public virtual DbSet<DecisionsFuelTotalAmount> DecisionsFuelTotalAmounts { get; set; } = null!;
        public virtual DbSet<DecreasRatio> DecreasRatios { get; set; } = null!;
        public virtual DbSet<Division> Divisions { get; set; } = null!;
        public virtual DbSet<DivisionBurnRatio> DivisionBurnRatios { get; set; } = null!;
        public virtual DbSet<DivisionFreeRatio> DivisionFreeRatios { get; set; } = null!;
        public virtual DbSet<DivisionPlanCalcResult> DivisionPlanCalcResults { get; set; } = null!;
        public virtual DbSet<DivisionQuotum> DivisionQuota { get; set; } = null!;
        public virtual DbSet<DivisionYearCalcualationResult> DivisionYearCalcualationResults { get; set; } = null!;
        public virtual DbSet<DivisionsMaxQuotum> DivisionsMaxQuota { get; set; } = null!;
        public virtual DbSet<DivisionsStore> DivisionsStores { get; set; } = null!;
        public virtual DbSet<FillingCategory> FillingCategories { get; set; } = null!;
        public virtual DbSet<FreeVehicle> FreeVehicles { get; set; } = null!;
        public virtual DbSet<FuleType> FuleTypes { get; set; } = null!;
        public virtual DbSet<GetlastVinfo> GetlastVinfos { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<LogicalsSite> LogicalsSites { get; set; } = null!;
        public virtual DbSet<Nono> Nonos { get; set; } = null!;
        public virtual DbSet<Nono1> Nono1s { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<OilAdd> OilAdds { get; set; } = null!;
        public virtual DbSet<OilBill> OilBills { get; set; } = null!;
        public virtual DbSet<OilBillDetail> OilBillDetails { get; set; } = null!;
        public virtual DbSet<OilCard> OilCards { get; set; } = null!;
        public virtual DbSet<OilCardQuota> OilCardQuotas { get; set; } = null!;
        public virtual DbSet<OilChangeDate> OilChangeDates { get; set; } = null!;
        public virtual DbSet<OilCircuit> OilCircuits { get; set; } = null!;
        public virtual DbSet<OilCircuitCategory> OilCircuitCategories { get; set; } = null!;
        public virtual DbSet<OilDrum> OilDrums { get; set; } = null!;
        public virtual DbSet<OilException> OilExceptions { get; set; } = null!;
        public virtual DbSet<OilPlan> OilPlans { get; set; } = null!;
        public virtual DbSet<OilPlanDetail> OilPlanDetails { get; set; } = null!;
        public virtual DbSet<OilPlanTashkeelDetail> OilPlanTashkeelDetails { get; set; } = null!;
        public virtual DbSet<OilType> OilTypes { get; set; } = null!;
        public virtual DbSet<OilVehicleCircuit> OilVehicleCircuits { get; set; } = null!;
        public virtual DbSet<OriginalQuotaSpecial> OriginalQuotaSpecials { get; set; } = null!;
        public virtual DbSet<OriginalQuotum> OriginalQuota { get; set; } = null!;
        public virtual DbSet<PlanApproval> PlanApprovals { get; set; } = null!;
        public virtual DbSet<PlanCalculationDatum> PlanCalculationData { get; set; } = null!;
        public virtual DbSet<PlanStoppedVehilce> PlanStoppedVehilces { get; set; } = null!;
        public virtual DbSet<PlannedDistance> PlannedDistances { get; set; } = null!;
        public virtual DbSet<PlannedHour> PlannedHours { get; set; } = null!;
        public virtual DbSet<QuotaAddition> QuotaAdditions { get; set; } = null!;
        public virtual DbSet<Report22> Report22s { get; set; } = null!;
        public virtual DbSet<Report3> Report3s { get; set; } = null!;
        public virtual DbSet<Report41StationsSale> Report41StationsSales { get; set; } = null!;
        public virtual DbSet<Report47> Report47s { get; set; } = null!;
        public virtual DbSet<Report47QuarterSpecial> Report47QuarterSpecials { get; set; } = null!;
        public virtual DbSet<Report47VehiclesQuarterSale> Report47VehiclesQuarterSales { get; set; } = null!;
        public virtual DbSet<SalesQ> SalesQs { get; set; } = null!;
        public virtual DbSet<SalesView> SalesViews { get; set; } = null!;
        public virtual DbSet<SiteV> SiteVs { get; set; } = null!;
        public virtual DbSet<SpecialAlertsAction> SpecialAlertsActions { get; set; } = null!;
        public virtual DbSet<StoreLogicalCard> StoreLogicalCards { get; set; } = null!;
        public virtual DbSet<SyncOilBill> SyncOilBills { get; set; } = null!;
        public virtual DbSet<SyncOilBillDetail> SyncOilBillDetails { get; set; } = null!;
        public virtual DbSet<SyncOilCard> SyncOilCards { get; set; } = null!;
        public virtual DbSet<SyncOilCardQuota> SyncOilCardQuotas { get; set; } = null!;
        public virtual DbSet<SyncOilDemandDetail> SyncOilDemandDetails { get; set; } = null!;
        public virtual DbSet<SyncOilException> SyncOilExceptions { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;
        public virtual DbSet<Tagging> Taggings { get; set; } = null!;
        public virtual DbSet<UnApprovedDivisionFuel> UnApprovedDivisionFuels { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;
        public virtual DbSet<UsageType> UsageTypes { get; set; } = null!;
        public virtual DbSet<UsersLogin> UsersLogins { get; set; } = null!;
        public virtual DbSet<VNQ> VNQs { get; set; } = null!;
        public virtual DbSet<VNQ1> VNQs1 { get; set; } = null!;
        public virtual DbSet<VNQO> VNQOs { get; set; } = null!;
        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;
        public virtual DbSet<VehicleCategory> VehicleCategories { get; set; } = null!;
        public virtual DbSet<VehicleGroup> VehicleGroups { get; set; } = null!;
        public virtual DbSet<VehicleRepair> VehicleRepairs { get; set; } = null!;
        public virtual DbSet<VehicleType> VehicleTypes { get; set; } = null!;
        public virtual DbSet<VehiclesDeleted> VehiclesDeleteds { get; set; } = null!;
        public virtual DbSet<VehiclesDivision> VehiclesDivisions { get; set; } = null!;
        public virtual DbSet<VehiclesMotorGroup> VehiclesMotorGroups { get; set; } = null!;
        public virtual DbSet<VehiclesNonAutomatedQuotum> VehiclesNonAutomatedQuota { get; set; } = null!;
        public virtual DbSet<VehiclesSubDivision> VehiclesSubDivisions { get; set; } = null!;
        public virtual DbSet<VehiclesUnit> VehiclesUnits { get; set; } = null!;
        public virtual DbSet<VehiclesUsageType> VehiclesUsageTypes { get; set; } = null!;
        public virtual DbSet<VwAllDivisionQuotum> VwAllDivisionQuota { get; set; } = null!;
        public virtual DbSet<VwAllVehiclesPlanDatum> VwAllVehiclesPlanData { get; set; } = null!;
        public virtual DbSet<VwAllVehiclesWithAllDatum> VwAllVehiclesWithAllData { get; set; } = null!;
        public virtual DbSet<VwCardsTwoTag> VwCardsTwoTags { get; set; } = null!;
        public virtual DbSet<VwCardsVehiclesToSend> VwCardsVehiclesToSends { get; set; } = null!;
        public virtual DbSet<VwDivisionCardsCount> VwDivisionCardsCounts { get; set; } = null!;
        public virtual DbSet<VwGetDivisionsFreeVehicle> VwGetDivisionsFreeVehicles { get; set; } = null!;
        public virtual DbSet<VwLastSiteInfoDate> VwLastSiteInfoDates { get; set; } = null!;
        public virtual DbSet<VwMawqef> VwMawqefs { get; set; } = null!;
        public virtual DbSet<VwModifiedVehiclesGroupedDivision> VwModifiedVehiclesGroupedDivisions { get; set; } = null!;
        public virtual DbSet<VwNoneAutomatedCalculationDatum> VwNoneAutomatedCalculationData { get; set; } = null!;
        public virtual DbSet<VwOneTagVehicle> VwOneTagVehicles { get; set; } = null!;
        public virtual DbSet<VwPlanCalculationDatum> VwPlanCalculationData { get; set; } = null!;
        public virtual DbSet<VwPlanSpecialCalculationDataNa> VwPlanSpecialCalculationDataNas { get; set; } = null!;
        public virtual DbSet<VwPlanSpecialCalculationDatum> VwPlanSpecialCalculationData { get; set; } = null!;
        public virtual DbSet<VwSpecialQuotaForUpdatedVehicle> VwSpecialQuotaForUpdatedVehicles { get; set; } = null!;
        public virtual DbSet<VwStartUpPlan> VwStartUpPlans { get; set; } = null!;
        public virtual DbSet<VwSubDivTagCount> VwSubDivTagCounts { get; set; } = null!;
        public virtual DbSet<VwTwoTagVehicle> VwTwoTagVehicles { get; set; } = null!;
        public virtual DbSet<VwUnSentDivisionQuotum> VwUnSentDivisionQuota { get; set; } = null!;
        public virtual DbSet<VwUnUpdatedVehicle> VwUnUpdatedVehicles { get; set; } = null!;
        public virtual DbSet<VwUpdatedOriginalQuotum> VwUpdatedOriginalQuota { get; set; } = null!;
        public virtual DbSet<VwVehicleInfo> VwVehicleInfos { get; set; } = null!;
        public virtual DbSet<VwVehicleLookUp> VwVehicleLookUps { get; set; } = null!;
        public virtual DbSet<VwVehiclesReport> VwVehiclesReports { get; set; } = null!;
        public virtual DbSet<VwVehiclesTagsCount> VwVehiclesTagsCounts { get; set; } = null!;
        public virtual DbSet<WarActivationCard> WarActivationCards { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=NON;Database=WakoodSites;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivationStatus>(entity =>
            {
                entity.ToTable("ActivationStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .HasColumnName("NOTE");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasIndex(e => e.CardNumber, "IX_Cards")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardNumber).HasColumnType("decimal(11, 0)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("(1)");

                entity.Property(e => e.IsUpdated).HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(0)");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<CardsLogical>(entity =>
            {
                entity.ToTable("Cards_Logicals");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogicalId).HasColumnName("LogicalID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardsTag>(entity =>
            {
                entity.ToTable("Cards_Tags");

                entity.HasIndex(e => e.TagId, "IX_Cards_Tags_TagID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.CardsTags)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cards_Tags_Cards");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.CardsTag)
                    .HasForeignKey<CardsTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cards_Tags_Tags");
            });

            modelBuilder.Entity<CardsVehicle>(entity =>
            {
                entity.ToTable("Cards_Vehicles");

                entity.HasIndex(e => e.CardId, "IX_Cards_Vehicles_CID")
                    .IsUnique();

                entity.HasIndex(e => e.VehicleId, "IX_Cards_Vehicles_VID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Card)
                    .WithOne(p => p.CardsVehicle)
                    .HasForeignKey<CardsVehicle>(d => d.CardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cards_Vehicles_Cards");

                entity.HasOne(d => d.Vehicle)
                    .WithOne(p => p.CardsVehicle)
                    .HasForeignKey<CardsVehicle>(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cards_Vehicles_Vehicles");
            });

            modelBuilder.Entity<Cat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cat");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Decision>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.ApproveUserId).HasColumnName("ApproveUserID");

                entity.Property(e => e.Cancled).HasDefaultValueSql("((0))");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DecisionDate).HasColumnType("datetime");

                entity.Property(e => e.DecisionNumber).HasMaxLength(50);

                entity.Property(e => e.IssuerDivisionId).HasColumnName("IssuerDivisionID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RelatedDivisionId).HasColumnName("RelatedDivisionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.IssuerDivision)
                    .WithMany(p => p.DecisionIssuerDivisions)
                    .HasForeignKey(d => d.IssuerDivisionId)
                    .HasConstraintName("FK_Decisions_Divisions");

                entity.HasOne(d => d.RelatedDivision)
                    .WithMany(p => p.DecisionRelatedDivisions)
                    .HasForeignKey(d => d.RelatedDivisionId)
                    .HasConstraintName("FK_Decisions_Divisions1");
            });

            modelBuilder.Entity<DecisionsFuelTotalAmount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DecisionsFuelTotalAmount");

                entity.Property(e => e.CatId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CatID")
                    .IsFixedLength();

                entity.Property(e => e.DecisionNumber).HasMaxLength(50);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<DecreasRatio>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DecisionNumber).HasMaxLength(50);

                entity.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Notes).HasMaxLength(50);
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasIndex(e => e.SortId, "IX_Divisions");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SortId).HasColumnName("SortID");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.TmpId).HasColumnName("tmpID");
            });

            modelBuilder.Entity<DivisionBurnRatio>(entity =>
            {
                entity.ToTable("DivisionBurnRatio");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BurnRatio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<DivisionFreeRatio>(entity =>
            {
                entity.ToTable("DivisionFreeRatio");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.DivisionFreeRatios)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_DivisionFreeRatio_Divisions");
            });

            modelBuilder.Entity<DivisionPlanCalcResult>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<DivisionQuotum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DecisionId).HasColumnName("DecisionID");

                entity.Property(e => e.LastUpdateDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogicalId).HasColumnName("LogicalID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.DivisionQuota)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK_DivisionQuota_FillingCategories");

                entity.HasOne(d => d.Decision)
                    .WithMany(p => p.DivisionQuota)
                    .HasForeignKey(d => d.DecisionId)
                    .HasConstraintName("FK_DivisionQuota_Decisions");

                entity.HasOne(d => d.Logical)
                    .WithMany(p => p.DivisionQuota)
                    .HasForeignKey(d => d.LogicalId)
                    .HasConstraintName("FK_DivisionQuota_StoreLogicalCards");
            });

            modelBuilder.Entity<DivisionYearCalcualationResult>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AutomatedQuota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Fixed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fixed1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fixed2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fixed3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fixed5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fixed6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fixed7).HasDefaultValueSql("((0))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NonAuotomatedQuota).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DivisionsMaxQuotum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DecisionNumber).HasMaxLength(50);

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Maxquota)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MAXQuota");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Notes).HasMaxLength(50);
            });

            modelBuilder.Entity<DivisionsStore>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<FillingCategory>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryDifinitionId).HasColumnName("CategoryDifinitionID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<FreeVehicle>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<FuleType>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FuelTypeName).HasMaxLength(100);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TypeColor).HasColumnType("text");
            });

            modelBuilder.Entity<GetlastVinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetlastVinfo");

                entity.Property(e => e.Distanceconsumptionaverage).HasColumnName("DISTANCECONSUMPTIONAVERAGE");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Timeconsumptionaverage).HasColumnName("TIMECONSUMPTIONAVERAGE");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.VehicleDesciption).HasMaxLength(50);

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);

                entity.Property(e => e.VehicleQuota).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.TableName).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<LogicalsSite>(entity =>
            {
                entity.ToTable("Logicals_Sites");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LogicalId).HasColumnName("LogicalID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Logical)
                    .WithMany(p => p.LogicalsSites)
                    .HasForeignKey(d => d.LogicalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Logicals_Sites_StoreLogicalCards");
            });

            modelBuilder.Entity<Nono>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nono");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Numm)
                    .HasMaxLength(10)
                    .HasColumnName("numm")
                    .IsFixedLength();

                entity.Property(e => e.Palacer)
                    .HasMaxLength(50)
                    .HasColumnName("palacer");

                entity.Property(e => e.Tash)
                    .HasMaxLength(50)
                    .HasColumnName("tash");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Nono1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nono1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Numm)
                    .HasMaxLength(10)
                    .HasColumnName("numm")
                    .IsFixedLength();

                entity.Property(e => e.Palacer)
                    .HasMaxLength(50)
                    .HasColumnName("palacer");

                entity.Property(e => e.Tash)
                    .HasMaxLength(50)
                    .HasColumnName("tash");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ended).HasColumnType("datetime");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.ToUserId).HasColumnName("ToUserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<OilAdd>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TashkeelId).HasColumnName("TashkeelID");
            });

            modelBuilder.Entity<OilBill>(entity =>
            {
                entity.HasKey(e => e.BillId)
                    .HasName("PK__OilBill__11F2FC4A426DB909");

                entity.ToTable("OilBill");

                entity.Property(e => e.BillId)
                    .ValueGeneratedNever()
                    .HasColumnName("BillID");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.DriverName).HasMaxLength(300);

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Note).HasMaxLength(300);

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.RepresenterName).HasMaxLength(50);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.TankerPlateNo).HasMaxLength(300);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<OilBillDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillId).HasColumnName("BillID");

                entity.Property(e => e.DummyDate).HasColumnType("datetime");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OilDrumId).HasColumnName("OilDrumID");
            });

            modelBuilder.Entity<OilCard>(entity =>
            {
                entity.HasKey(e => e.CardLogicalNo)
                    .HasName("PK__OilCards__2EB0D91F");

                entity.Property(e => e.CardLogicalNo).ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CardPhysicalNumber)
                    .HasColumnType("decimal(12, 0)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.TashkeelId).HasColumnName("TashkeelID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<OilCardQuota>(entity =>
            {
                entity.HasKey(e => e.SyncId);

                entity.Property(e => e.SyncId).HasColumnName("SyncID");

                entity.Property(e => e.AssignedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OilDrumId).HasColumnName("OilDrumID");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.HasOne(d => d.CardLogicalNoNavigation)
                    .WithMany(p => p.OilCardQuota)
                    .HasForeignKey(d => d.CardLogicalNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OilCardQu__CardL__61FB72FB");

                entity.HasOne(d => d.OilDrum)
                    .WithMany(p => p.OilCardQuota)
                    .HasForeignKey(d => d.OilDrumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OilCardQu__OilDr__61074EC2");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.OilCardQuota)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OilCardQu__PlanI__62EF9734");
            });

            modelBuilder.Entity<OilChangeDate>(entity =>
            {
                entity.ToTable("OilChangeDate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NextChangeDate).HasColumnType("datetime");

                entity.Property(e => e.OilCategoryId).HasColumnName("OilCategoryID");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.TashkeelId).HasColumnName("TashkeelID");

                entity.HasOne(d => d.OilCategory)
                    .WithMany(p => p.OilChangeDates)
                    .HasForeignKey(d => d.OilCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OilChange__OilCa__3A228BCB");
            });

            modelBuilder.Entity<OilCircuit>(entity =>
            {
                entity.ToTable("OilCircuit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Label).HasMaxLength(64);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OilCategoryId).HasColumnName("OilCategoryID");

                entity.HasOne(d => d.OilCategory)
                    .WithMany(p => p.OilCircuits)
                    .HasForeignKey(d => d.OilCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OilCircui__OilCa__3B16B004");
            });

            modelBuilder.Entity<OilCircuitCategory>(entity =>
            {
                entity.ToTable("OilCircuitCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Label).HasMaxLength(32);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<OilDrum>(entity =>
            {
                entity.ToTable("OilDrum");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Capacity).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.Label).HasMaxLength(64);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.OilTypeNavigation)
                    .WithMany(p => p.OilDrums)
                    .HasForeignKey(d => d.OilType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OilDrum__OilType__2D87AABC");
            });

            modelBuilder.Entity<OilException>(entity =>
            {
                entity.ToTable("OilException");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExEnd).HasColumnType("datetime");

                entity.Property(e => e.ExStart).HasColumnType("datetime");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UserID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<OilPlan>(entity =>
            {
                entity.ToTable("OilPlan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<OilPlanDetail>(entity =>
            {
                entity.HasKey(e => e.Pk);

                entity.Property(e => e.Pk)
                    .HasColumnName("PK")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ChangeQuota2).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.FuelCategoryId).HasColumnName("FuelCategoryID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.ReplaceQuota2).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.TashkeelId).HasColumnName("TashkeelID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<OilPlanTashkeelDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BurnRatio).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.ChangeQuota).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.ChangeRoundup).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.ReplaceQuota).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.ReplaceRoundup).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.TashkeelId).HasColumnName("TashkeelID");
            });

            modelBuilder.Entity<OilType>(entity =>
            {
                entity.ToTable("OilType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BurnRatio).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Label).HasMaxLength(32);

                entity.Property(e => e.MainCat).HasMaxLength(50);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SubCat).HasMaxLength(50);
            });

            modelBuilder.Entity<OilVehicleCircuit>(entity =>
            {
                entity.HasKey(e => e.Pk);

                entity.Property(e => e.Pk)
                    .HasColumnName("PK")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Capacity).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.ChangeDistance).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.ChangeHours).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ChangeRatio).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OilCircuitId).HasColumnName("OilCircuitID");

                entity.Property(e => e.ReplaceRatio).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.VehicleGroupId).HasColumnName("VehicleGroupID");
            });

            modelBuilder.Entity<OriginalQuotaSpecial>(entity =>
            {
                entity.ToTable("OriginalQuotaSpecial");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DecisionId).HasColumnName("DecisionID");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Quota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<OriginalQuotum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUpdated).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Quota).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PlanApproval>(entity =>
            {
                entity.HasIndex(e => e.DivisionId, "IX_PlanApprovals");

                entity.HasIndex(e => e.ActivationYear, "IX_PlanApprovals_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Creation1Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creation2Date).HasColumnType("datetime");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Quota01).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota010).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota010Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota010NA");

                entity.Property(e => e.Quota011).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota011Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota011NA");

                entity.Property(e => e.Quota012).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota012Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota012NA");

                entity.Property(e => e.Quota01Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota01NA");

                entity.Property(e => e.Quota02).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota02Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota02NA");

                entity.Property(e => e.Quota03).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota03Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota03NA");

                entity.Property(e => e.Quota04).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota04Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota04NA");

                entity.Property(e => e.Quota05).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota05Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota05NA");

                entity.Property(e => e.Quota06).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota06Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota06NA");

                entity.Property(e => e.Quota07).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota07Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota07NA");

                entity.Property(e => e.Quota08).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota08Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota08NA");

                entity.Property(e => e.Quota09).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota09Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota09NA");

                entity.Property(e => e.Quota11).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota110).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota110Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota110NA");

                entity.Property(e => e.Quota111).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota111Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota111NA");

                entity.Property(e => e.Quota112).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota112Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota112NA");

                entity.Property(e => e.Quota11Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota11NA");

                entity.Property(e => e.Quota12).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota12Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota12NA");

                entity.Property(e => e.Quota13).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota13Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota13NA");

                entity.Property(e => e.Quota14).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota14Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota14NA");

                entity.Property(e => e.Quota15).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota15Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota15NA");

                entity.Property(e => e.Quota16).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota16Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota16NA");

                entity.Property(e => e.Quota17).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota17Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota17NA");

                entity.Property(e => e.Quota18).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota18Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota18NA");

                entity.Property(e => e.Quota19).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota19Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota19NA");

                entity.Property(e => e.Quota21).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota210).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota210Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota210NA");

                entity.Property(e => e.Quota211).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota211Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota211NA");

                entity.Property(e => e.Quota212).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota212Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota212NA");

                entity.Property(e => e.Quota21Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota21NA");

                entity.Property(e => e.Quota22).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota22Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota22NA");

                entity.Property(e => e.Quota23).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota23Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota23NA");

                entity.Property(e => e.Quota24).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota24Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota24NA");

                entity.Property(e => e.Quota25).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota25Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota25NA");

                entity.Property(e => e.Quota26).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota26Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota26NA");

                entity.Property(e => e.Quota27).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota27Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota27NA");

                entity.Property(e => e.Quota28).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota28Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota28NA");

                entity.Property(e => e.Quota29).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota29Na)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quota29NA");

                entity.Property(e => e.User1Id).HasColumnName("User1ID");

                entity.Property(e => e.User2Id).HasColumnName("User2ID");
            });

            modelBuilder.Entity<PlanCalculationDatum>(entity =>
            {
                entity.HasIndex(e => new { e.VehicleId, e.ActivationYear }, "IX_PlanCalculationData")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Distanceconsumptionaverage).HasColumnName("DISTANCECONSUMPTIONAVERAGE");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OriginalQuotaId).HasColumnName("OriginalQuotaID");

                entity.Property(e => e.Timeconsumptionaverage).HasColumnName("TIMECONSUMPTIONAVERAGE");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.VehicleDesciption).HasMaxLength(50);

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);

                entity.Property(e => e.VehicleQuota).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.PlanCalculationData)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanCalculationData_Vehicles");
            });

            modelBuilder.Entity<PlanStoppedVehilce>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<PlannedDistance>(entity =>
            {
                entity.HasIndex(e => e.VehicleId, "IX_PlannedDistances_VID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.PlannedDistances)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_PlannedDistances_Vehicles");
            });

            modelBuilder.Entity<PlannedHour>(entity =>
            {
                entity.HasIndex(e => e.VehicleId, "IX_PlannedHours_VID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.PlannedHours)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_PlannedHours_Vehicles");
            });

            modelBuilder.Entity<QuotaAddition>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DecisionId).HasColumnName("DecisionID");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Quota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Decision)
                    .WithMany(p => p.QuotaAdditions)
                    .HasForeignKey(d => d.DecisionId)
                    .HasConstraintName("FK_QuotaAdditions_Decisions");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.QuotaAdditions)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_QuotaAdditions_Vehicles");
            });

            modelBuilder.Entity<Report22>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Report22");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.SaleTs).HasColumnName("SaleTS");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<Report3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Report3");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.SaleTs).HasColumnName("SaleTS");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<Report41StationsSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Report41StationsSales");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.SaleTs).HasColumnName("SaleTS");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<Report47>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Report47");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Hours).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Quota).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.VehicleDescription).HasMaxLength(100);

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.VehicleModel).HasMaxLength(255);

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);
            });

            modelBuilder.Entity<Report47QuarterSpecial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Report47QuarterSpecials");

                entity.Property(e => e.SpecialHours).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.SpecialQuota).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<Report47VehiclesQuarterSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Report47VehiclesQuarterSales");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<SalesQ>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("sales_Q");

                entity.Property(e => e.CardId).HasColumnName("CardID");
            });

            modelBuilder.Entity<SalesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("sales_view");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.OriginalSaleId).HasColumnName("OriginalSaleID");

                entity.Property(e => e.PumpId).HasColumnName("PumpID");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.TagId).HasColumnName("TagID");
            });

            modelBuilder.Entity<SiteV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("site_V");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SiteName).HasMaxLength(80);
            });

            modelBuilder.Entity<SpecialAlertsAction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AlertId).HasColumnName("AlertID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.TableName).HasMaxLength(50);

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<StoreLogicalCard>(entity =>
            {
                entity.HasIndex(e => e.CardNo, "UQ__StoreLogicalCard__05AEC38C")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardNumber).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CardType).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChildDivId).HasColumnName("ChildDivID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.LastUpdateDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SubDivId).HasColumnName("SubDivID");
            });

            modelBuilder.Entity<SyncOilBill>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("syncOilBill");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillId).HasColumnName("BillID");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(300)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(300)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.RepresenterName).HasMaxLength(50);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.TankerPlateNo)
                    .HasMaxLength(300)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SyncOilBillDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("syncOilBillDetails");

                entity.Property(e => e.BillId).HasColumnName("BillID");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.OilDrumId).HasColumnName("OilDrumID");
            });

            modelBuilder.Entity<SyncOilCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("syncOilCards");

                entity.Property(e => e.CardPhysicalNumber).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.DivisionTitle).HasMaxLength(255);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.TashkeelTitle).HasMaxLength(255);

                entity.Property(e => e.UnitTitle).HasMaxLength(255);
            });

            modelBuilder.Entity<SyncOilCardQuota>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("syncOilCardQuotas");

                entity.Property(e => e.AssignedDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.OilDrumId).HasColumnName("OilDrumID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<SyncOilDemandDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("syncOilDemandDetails");

                entity.Property(e => e.BillId).HasColumnName("BillID");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.NeededAmount).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SyncOilException>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("syncOilException");

                entity.Property(e => e.ExEnd).HasColumnType("datetime");

                entity.Property(e => e.ExStart).HasColumnType("datetime");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UserID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasIndex(e => e.TagNumber, "IX_Tags")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TagNumber).HasColumnType("decimal(11, 0)");
            });

            modelBuilder.Entity<Tagging>(entity =>
            {
                entity.ToTable("Tagging");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CardNumber).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TagNumber).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<UnApprovedDivisionFuel>(entity =>
            {
                entity.ToTable("UnApprovedDivisionFuel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.UnApprovedDivisionFuels)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnApprovedDivisionFuel_Divisions");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Units_Divisions");
            });

            modelBuilder.Entity<UsageType>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UsageName).HasColumnType("text");
            });

            modelBuilder.Entity<UsersLogin>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LogInDate).HasColumnType("datetime");

                entity.Property(e => e.LogOutDate).HasColumnType("datetime");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Pcname)
                    .HasMaxLength(50)
                    .HasColumnName("PCName");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<VNQ>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_N_Q");

                entity.Property(e => e.DivisionIdo).HasColumnName("DivisionIDO");

                entity.Property(e => e.DivisionIds).HasColumnName("DivisionIDS");

                entity.Property(e => e.Mo).HasColumnName("MO");

                entity.Property(e => e.Ms).HasColumnName("MS");

                entity.Property(e => e.QuotaO).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QuotaS).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<VNQ1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_N_Q_S");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Quota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<VNQO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_N_Q_O");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Mo).HasColumnName("MO");

                entity.Property(e => e.Quota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_Vehicles_PlateNo")
                    .IsUnique();

                entity.HasIndex(e => e.CardNo, "UQ__Vehicles__1CDC41A7")
                    .IsUnique();

                entity.HasIndex(e => e.VehiclePlateNo, "UQ__Vehicles__1DD065E0")
                    .HasFillFactor(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OriginalQuotaId).HasColumnName("OriginalQuotaID");

                entity.Property(e => e.PlanApproveDivId).HasColumnName("PlanApproveDivID");

                entity.Property(e => e.VehicleDesciption).HasMaxLength(200);

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);

                entity.HasOne(d => d.FuelTypeNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.FuelType)
                    .HasConstraintName("FK_Vehicles_FuleTypes");
            });

            modelBuilder.Entity<VehicleCategory>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryName).HasMaxLength(255);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<VehicleGroup>(entity =>
            {
                entity.HasIndex(e => e.GroupName, "IX_VehicleGroups")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackBridgeCapacity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BackBridgeTypeId).HasColumnName("BackBridgeTypeID");

                entity.Property(e => e.BrakeCapacity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BraketypeId).HasColumnName("BraketypeID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CoolingcircuitCapacity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CoolingcircuittypeId).HasColumnName("CoolingcircuittypeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Distanceconsumptionaverage).HasColumnName("DISTANCECONSUMPTIONAVERAGE");

                entity.Property(e => e.EnginFuelCapacity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EngineTypeId).HasColumnName("EngineTypeID");

                entity.Property(e => e.FlipflopcircuitCapacity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FlipflopcircuittypeId).HasColumnName("FlipflopcircuittypeID");

                entity.Property(e => e.FrontbridgeCapacity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FrontbridgeTypeId).HasColumnName("FrontbridgeTypeID");

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.HasTwoTags).HasDefaultValueSql("((0))");

                entity.Property(e => e.HidroliccircCacacity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HidroliccirctypeId).HasColumnName("HidroliccirctypeID");

                entity.Property(e => e.Maingearcapacity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaingeartypeId).HasColumnName("MaingeartypeID");

                entity.Property(e => e.MidlebridgeCapacity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MidlebridgetypId).HasColumnName("MidlebridgetypID");

                entity.Property(e => e.MilfafCapacity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SecondGearCapacity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SecondGearTypeId).HasColumnName("SecondGearTypeID");

                entity.Property(e => e.SteringwheelCapacity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SteringwheeltypId).HasColumnName("SteringwheeltypID");

                entity.Property(e => e.Timeconsumptionaverage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TIMECONSUMPTIONAVERAGE");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.VehicleGroups)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleGroups_VehicleTypes");
            });

            modelBuilder.Entity<VehicleRepair>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivatorId).HasColumnName("ActivatorID");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionIdin).HasColumnName("DivisionIDIN");

                entity.Property(e => e.DivisionIdout).HasColumnName("DivisionIDOUT");

                entity.Property(e => e.EndActivatorId).HasColumnName("EndActivatorID");

                entity.Property(e => e.EndUserId).HasColumnName("EndUserID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RepairEndDate).HasColumnType("datetime");

                entity.Property(e => e.RepairStartDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.DivisionIdinNavigation)
                    .WithMany(p => p.VehicleRepairDivisionIdinNavigations)
                    .HasForeignKey(d => d.DivisionIdin)
                    .HasConstraintName("FK_VehicleRepairs_Divisions");

                entity.HasOne(d => d.DivisionIdoutNavigation)
                    .WithMany(p => p.VehicleRepairDivisionIdoutNavigations)
                    .HasForeignKey(d => d.DivisionIdout)
                    .HasConstraintName("FK_VehicleRepairs_Divisions1");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehicleRepairs)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleRepairs_Vehicles");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeName).HasMaxLength(255);
            });

            modelBuilder.Entity<VehiclesDeleted>(entity =>
            {
                entity.ToTable("Vehicles_deleted");

                entity.HasIndex(e => e.CardNo, "UQ__Vehicles_deleted__1CDC41A7")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OriginalQuotaId).HasColumnName("OriginalQuotaID");

                entity.Property(e => e.PlanApproveDivId).HasColumnName("PlanApproveDivID");

                entity.Property(e => e.VehicleDesciption).HasMaxLength(200);

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);

                entity.HasOne(d => d.FuelTypeNavigation)
                    .WithMany(p => p.VehiclesDeleteds)
                    .HasForeignKey(d => d.FuelType)
                    .HasConstraintName("FK_Vehicles_deleted_FuleTypes");
            });

            modelBuilder.Entity<VehiclesDivision>(entity =>
            {
                entity.ToTable("Vehicles_Divisions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.VehiclesDivisions)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_Vehicles_Divisions_Divisions");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehiclesDivisions)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_Vehicles_Divisions_Vehicles");
            });

            modelBuilder.Entity<VehiclesMotorGroup>(entity =>
            {
                entity.ToTable("Vehicles_MotorGroups");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MotorGroupId).HasColumnName("MotorGroupID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.MotorGroup)
                    .WithMany(p => p.VehiclesMotorGroups)
                    .HasForeignKey(d => d.MotorGroupId)
                    .HasConstraintName("FK_Vehicles_MotorGroups_VehicleGroups");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehiclesMotorGroups)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_Vehicles_MotorGroups_Vehicles");
            });

            modelBuilder.Entity<VehiclesNonAutomatedQuotum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Quota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehiclesNonAutomatedQuota)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_VehiclesNonAutomatedQuota_Vehicles");
            });

            modelBuilder.Entity<VehiclesSubDivision>(entity =>
            {
                entity.ToTable("Vehicles_SubDivisions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SubDivisionId).HasColumnName("SubDivisionID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.SubDivision)
                    .WithMany(p => p.VehiclesSubDivisions)
                    .HasForeignKey(d => d.SubDivisionId)
                    .HasConstraintName("FK_Vehicles_SubDivisions_Divisions");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehiclesSubDivisions)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_Vehicles_SubDivisions_Vehicles");
            });

            modelBuilder.Entity<VehiclesUnit>(entity =>
            {
                entity.ToTable("Vehicles_Units");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.VehiclesUnits)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_Vehicles_Units_Units");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehiclesUnits)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_Vehicles_Units_Vehicles");
            });

            modelBuilder.Entity<VehiclesUsageType>(entity =>
            {
                entity.ToTable("Vehicles_UsageTypes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UsageTypeId).HasColumnName("UsageTypeID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.UsageType)
                    .WithMany(p => p.VehiclesUsageTypes)
                    .HasForeignKey(d => d.UsageTypeId)
                    .HasConstraintName("FK_Vehicles_UsageTypes_UsageTypes");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehiclesUsageTypes)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_Vehicles_UsageTypes_Vehicles");
            });

            modelBuilder.Entity<VwAllDivisionQuotum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAllDivisionQuota");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.FuelTypeName).HasMaxLength(100);

                entity.Property(e => e.Quota).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<VwAllVehiclesPlanDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAllVehiclesPlanData");

                entity.Property(e => e.Distanceconsumptionaverage).HasColumnName("DISTANCECONSUMPTIONAVERAGE");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.FuelTypeName).HasMaxLength(100);

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NonAutomatedQuota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalQuotaId).HasColumnName("OriginalQuotaID");

                entity.Property(e => e.Quota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Timeconsumptionaverage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TIMECONSUMPTIONAVERAGE");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.VehicleDesciption).HasMaxLength(200);

                entity.Property(e => e.VehicleGroup).HasMaxLength(100);

                entity.Property(e => e.VehicleGroupId).HasColumnName("VehicleGroupID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.VehicleModelId).HasColumnName("VehicleModelID");

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);
            });

            modelBuilder.Entity<VwAllVehiclesWithAllDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAllVehiclesWithAllData");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber).HasColumnType("decimal(11, 0)");

                entity.Property(e => e.Distanceconsumptionaverage).HasColumnName("DISTANCECONSUMPTIONAVERAGE");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.FuelTypeName).HasMaxLength(100);

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalQuotaId).HasColumnName("OriginalQuotaID");

                entity.Property(e => e.Quota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubDivTitle).HasMaxLength(255);

                entity.Property(e => e.Timeconsumptionaverage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TIMECONSUMPTIONAVERAGE");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitName).HasMaxLength(255);

                entity.Property(e => e.UsageType).HasColumnType("text");

                entity.Property(e => e.UsageTypeId).HasColumnName("UsageTypeID");

                entity.Property(e => e.VehicleDesciption).HasMaxLength(100);

                entity.Property(e => e.VehicleGroup).HasMaxLength(100);

                entity.Property(e => e.VehicleGroupId).HasColumnName("VehicleGroupID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.VehicleModel).HasMaxLength(255);

                entity.Property(e => e.VehicleModelId).HasColumnName("VehicleModelID");

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);
            });

            modelBuilder.Entity<VwCardsTwoTag>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCardsTwoTags");

                entity.Property(e => e.CardNumber).HasColumnType("decimal(11, 0)");

                entity.Property(e => e.TagNumber1).HasColumnType("decimal(11, 0)");

                entity.Property(e => e.TagNumber2).HasColumnType("decimal(11, 0)");
            });

            modelBuilder.Entity<VwCardsVehiclesToSend>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCardsVehiclesToSend");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber).HasColumnType("decimal(11, 0)");

                entity.Property(e => e.OriginalQuotaId).HasColumnName("OriginalQuotaID");

                entity.Property(e => e.Quota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VehicleCardLinkId).HasColumnName("VehicleCardLinkID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<VwDivisionCardsCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwDivisionCardsCount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<VwGetDivisionsFreeVehicle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetDivisionsFreeVehicles");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<VwLastSiteInfoDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLastSiteInfoDate");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<VwMawqef>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMawqef");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<VwModifiedVehiclesGroupedDivision>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwModifiedVehiclesGroupedDivisions");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate1)
                    .HasColumnType("datetime")
                    .HasColumnName("CreationDate_1");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.DivisionId1).HasColumnName("DivisionID_1");
            });

            modelBuilder.Entity<VwNoneAutomatedCalculationDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwNoneAutomatedCalculationData");

                entity.Property(e => e.Distanceconsumptionaverage).HasColumnName("DISTANCECONSUMPTIONAVERAGE");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalQuotaId).HasColumnName("OriginalQuotaID");

                entity.Property(e => e.Timeconsumptionaverage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TIMECONSUMPTIONAVERAGE");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.VehicleDesciption).HasMaxLength(100);

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);
            });

            modelBuilder.Entity<VwOneTagVehicle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwOneTagVehicles");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<VwPlanCalculationDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPlanCalculationData");

                entity.Property(e => e.Distanceconsumptionaverage).HasColumnName("DISTANCECONSUMPTIONAVERAGE");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalQuotaId).HasColumnName("OriginalQuotaID");

                entity.Property(e => e.Timeconsumptionaverage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TIMECONSUMPTIONAVERAGE");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.VehicleDesciption).HasMaxLength(100);

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);
            });

            modelBuilder.Entity<VwPlanSpecialCalculationDataNa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPlanSpecialCalculationDataNA");

                entity.Property(e => e.Distanceconsumptionaverage).HasColumnName("DISTANCECONSUMPTIONAVERAGE");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalQuotaId).HasColumnName("OriginalQuotaID");

                entity.Property(e => e.Timeconsumptionaverage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TIMECONSUMPTIONAVERAGE");

                entity.Property(e => e.VehicleDesciption).HasMaxLength(200);

                entity.Property(e => e.VehicleId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("VehicleID");

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);
            });

            modelBuilder.Entity<VwPlanSpecialCalculationDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPlanSpecialCalculationData");

                entity.Property(e => e.Distanceconsumptionaverage).HasColumnName("DISTANCECONSUMPTIONAVERAGE");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalQuotaId).HasColumnName("OriginalQuotaID");

                entity.Property(e => e.Timeconsumptionaverage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TIMECONSUMPTIONAVERAGE");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.VehicleDesciption).HasMaxLength(200);

                entity.Property(e => e.VehicleId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("VehicleID");

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);
            });

            modelBuilder.Entity<VwSpecialQuotaForUpdatedVehicle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSpecialQuotaForUpdatedVehicles");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Quota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<VwStartUpPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwStartUpPlan");

                entity.Property(e => e.Distanceconsumptionaverage).HasColumnName("DISTANCECONSUMPTIONAVERAGE");

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalQuotaId).HasColumnName("OriginalQuotaID");

                entity.Property(e => e.Timeconsumptionaverage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TIMECONSUMPTIONAVERAGE");

                entity.Property(e => e.VehicleDesciption).HasMaxLength(100);

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);
            });

            modelBuilder.Entity<VwSubDivTagCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSubDivTagCount");

                entity.Property(e => e.SortId).HasColumnName("SortID");

                entity.Property(e => e.التشكيل).HasMaxLength(255);

                entity.Property(e => e.العربة).HasMaxLength(100);

                entity.Property(e => e.المادة).HasMaxLength(50);

                entity.Property(e => e.الوحدة).HasMaxLength(255);

                entity.Property(e => e.رقمالبطاقة).HasColumnName("رقم البطاقة");

                entity.Property(e => e.طرازالعربة)
                    .HasMaxLength(100)
                    .HasColumnName("طراز العربة");

                entity.Property(e => e.عددالحساسات).HasColumnName("عدد الحساسات");
            });

            modelBuilder.Entity<VwTwoTagVehicle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTwoTagVehicles");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<VwUnSentDivisionQuotum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwUnSentDivisionQuota");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DecisionId).HasColumnName("DecisionID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LogicalId).HasColumnName("LogicalID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<VwUnUpdatedVehicle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwUnUpdatedVehicles");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.OriginalQuotaId).HasColumnName("OriginalQuotaID");

                entity.Property(e => e.VehicleDesciption).HasMaxLength(200);

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);
            });

            modelBuilder.Entity<VwUpdatedOriginalQuotum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwUpdatedOriginalQuota");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OldQuota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);
            });

            modelBuilder.Entity<VwVehicleInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwVehicleInfos");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber).HasColumnType("decimal(11, 0)");

                entity.Property(e => e.Distanceconsumptionaverage).HasColumnName("DISTANCECONSUMPTIONAVERAGE");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.FuelTypeName).HasMaxLength(100);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.Quota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.VehicleDesciption).HasMaxLength(100);

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);
            });

            modelBuilder.Entity<VwVehicleLookUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwVehicleLookUp");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CfuelT).HasColumnName("CFuelT");

                entity.Property(e => e.CfuelTypeName)
                    .HasMaxLength(100)
                    .HasColumnName("CFuelTypeName");

                entity.Property(e => e.Distanceconsumptionaverage).HasColumnName("DISTANCECONSUMPTIONAVERAGE");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.OriginalQuotaId).HasColumnName("OriginalQuotaID");

                entity.Property(e => e.Quota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitName).HasMaxLength(255);

                entity.Property(e => e.UsageType).HasColumnType("text");

                entity.Property(e => e.UsageTypeId).HasColumnName("UsageTypeID");

                entity.Property(e => e.VehicleDesciption).HasMaxLength(100);

                entity.Property(e => e.VehicleGroup).HasMaxLength(100);

                entity.Property(e => e.VehicleGroupId).HasColumnName("VehicleGroupID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.VehicleModel).HasMaxLength(255);

                entity.Property(e => e.VehicleModelId).HasColumnName("VehicleModelID");

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);

                entity.Property(e => e.VfuelTypeName)
                    .HasMaxLength(100)
                    .HasColumnName("VFuelTypeName");
            });

            modelBuilder.Entity<VwVehiclesReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwVehiclesReport");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.التشكيل).HasMaxLength(255);

                entity.Property(e => e.الساعاتالمقررة)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("الساعات المقررة");

                entity.Property(e => e.الطراز).HasMaxLength(255);

                entity.Property(e => e.المسافةالمقررة).HasColumnName("المسافة المقررة");

                entity.Property(e => e.النوع).HasMaxLength(100);

                entity.Property(e => e.تتبعللمجموعة)
                    .HasMaxLength(255)
                    .HasColumnName("تتبع للمجموعة");

                entity.Property(e => e.رقمالعربة)
                    .HasMaxLength(100)
                    .HasColumnName("رقم العربة");

                entity.Property(e => e.مجموعةالمركبة)
                    .HasMaxLength(402)
                    .HasColumnName("مجموعة المركبة");

                entity.Property(e => e.نسبةالأتمتة).HasColumnName("نسبة الأتمتة");

                entity.Property(e => e.نوعالاستخدام)
                    .HasColumnType("text")
                    .HasColumnName("نوع الاستخدام");

                entity.Property(e => e.نوعالوقود)
                    .HasMaxLength(100)
                    .HasColumnName("نوع الوقود");
            });

            modelBuilder.Entity<VwVehiclesTagsCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwVehiclesTagsCount");

                entity.Property(e => e.SortId).HasColumnName("SortID");

                entity.Property(e => e.SubDivTitle).HasMaxLength(255);

                entity.Property(e => e.Tagcount).HasColumnName("TAGCount");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.VehiclePlateNo).HasMaxLength(100);
            });

            modelBuilder.Entity<WarActivationCard>(entity =>
            {
                entity.HasKey(e => e.CardNo)
                    .HasName("PK__WarActiv__55FF25F12E66C05C");

                entity.Property(e => e.CardNo).ValueGeneratedNever();

                entity.Property(e => e.CardNumber).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
