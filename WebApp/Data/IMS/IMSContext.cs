using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApp.Data.IMS
{
    public partial class IMSContext : DbContext
    {
        public virtual DbSet<ApprovalMatricesToEmployee> ApprovalMatricesToEmployees { get; set; }
        public virtual DbSet<EmployeesToRepresentative> EmployeesToRepresentatives { get; set; }
        public virtual DbSet<GroupsFlexibleMembersList> GroupsFlexibleMembersLists { get; set; }
        public virtual DbSet<GroupsSpecification> GroupsSpecifications { get; set; }
        public virtual DbSet<LpoaccountsToCharge> LpoaccountsToCharges { get; set; }
        public virtual DbSet<LpoadditionalService> LpoadditionalServices { get; set; }
        public virtual DbSet<LpoadditionalServiceType> LpoadditionalServiceTypes { get; set; }
        public virtual DbSet<Lpoagency> Lpoagencies { get; set; }
        public virtual DbSet<Lpoauthorizer> Lpoauthorizers { get; set; }
        public virtual DbSet<LpocontactPerson> LpocontactPersons { get; set; }
        public virtual DbSet<LpodependantPassengerType> LpodependantPassengerTypes { get; set; }
        public virtual DbSet<LpoflightTicket> LpoflightTickets { get; set; }
        public virtual DbSet<LpoflightTicketClass> LpoflightTicketClasses { get; set; }
        public virtual DbSet<Lpoorder> Lpoorders { get; set; }
        public virtual DbSet<LpoorderType> LpoorderTypes { get; set; }
        public virtual DbSet<Lpopassenger> Lpopassengers { get; set; }
        public virtual DbSet<Lpopurpos> Lpopurposes { get; set; }
        public virtual DbSet<LpoticketArea> LpoticketAreas { get; set; }
        public virtual DbSet<TbAmendment> TbAmendments { get; set; }
        public virtual DbSet<TbAmendmentCode> TbAmendmentCodes { get; set; }
        public virtual DbSet<TbBank> TbBanks { get; set; }
        public virtual DbSet<TbBlanksType> TbBlanksTypes { get; set; }
        public virtual DbSet<TbBocunit> TbBocunits { get; set; }
        public virtual DbSet<TbBussUnit> TbBussUnits { get; set; }
        public virtual DbSet<TbContractType> TbContractTypes { get; set; }
        public virtual DbSet<TbCostCenter> TbCostCenters { get; set; }
        public virtual DbSet<TbCrea> TbCreas { get; set; }
        public virtual DbSet<TbCurrency> TbCurrencies { get; set; }
        public virtual DbSet<TbDeathInsurance> TbDeathInsurances { get; set; }
        public virtual DbSet<TbDepartment> TbDepartments { get; set; }
        public virtual DbSet<TbEducationLevel> TbEducationLevels { get; set; }
        public virtual DbSet<TbEmpClass> TbEmpClasses { get; set; }
        public virtual DbSet<TbEmpGroup> TbEmpGroups { get; set; }
        public virtual DbSet<TbEmployee> TbEmployees { get; set; }
        public virtual DbSet<TbEmpStat> TbEmpStats { get; set; }
        public virtual DbSet<TbEmpStatReason> TbEmpStatReasons { get; set; }
        public virtual DbSet<TbGhrsimportedFile> TbGhrsimportedFiles { get; set; }
        public virtual DbSet<TbHobunit> TbHobunits { get; set; }
        public virtual DbSet<TbIncProtection> TbIncProtections { get; set; }
        public virtual DbSet<TbJobCode> TbJobCodes { get; set; }
        public virtual DbSet<TbJobLevel> TbJobLevels { get; set; }
        public virtual DbSet<TbKeyResource> TbKeyResources { get; set; }
        public virtual DbSet<TbLifeInsurance> TbLifeInsurances { get; set; }
        public virtual DbSet<TbMarital> TbMaritals { get; set; }
        public virtual DbSet<TbMedInsurance> TbMedInsurances { get; set; }
        public virtual DbSet<TbMilitary> TbMilitaries { get; set; }
        public virtual DbSet<TbNatGroup> TbNatGroups { get; set; }
        public virtual DbSet<TbNationality> TbNationalities { get; set; }
        public virtual DbSet<TbNationalization> TbNationalizations { get; set; }
        public virtual DbSet<TbPayrollCode> TbPayrollCodes { get; set; }
        public virtual DbSet<TbPayType> TbPayTypes { get; set; }
        public virtual DbSet<TbPensionGroup> TbPensionGroups { get; set; }
        public virtual DbSet<TbPosClass> TbPosClasses { get; set; }
        public virtual DbSet<TbPosition> TbPositions { get; set; }
        public virtual DbSet<TbProfRole> TbProfRoles { get; set; }
        public virtual DbSet<TbProfRoleArea> TbProfRoleAreas { get; set; }
        public virtual DbSet<TbProject> TbProjects { get; set; }
        public virtual DbSet<TbProjectType> TbProjectTypes { get; set; }
        public virtual DbSet<TbQualification> TbQualifications { get; set; }
        public virtual DbSet<TbRelationship> TbRelationships { get; set; }
        public virtual DbSet<TbReligion> TbReligions { get; set; }
        public virtual DbSet<TbRoleFamily> TbRoleFamilies { get; set; }
        public virtual DbSet<TbRotation> TbRotations { get; set; }
        public virtual DbSet<TbStaffMovement> TbStaffMovements { get; set; }
        public virtual DbSet<TbTicketType> TbTicketTypes { get; set; }
        public virtual DbSet<TbTrc> TbTrcs { get; set; }
        public virtual DbSet<TbUnionGroup> TbUnionGroups { get; set; }
        public virtual DbSet<TbVacationDetail> TbVacationDetails { get; set; }
        public virtual DbSet<TbVacationType> TbVacationTypes { get; set; }
        public virtual DbSet<TbVisaType> TbVisaTypes { get; set; }
        public virtual DbSet<TbWb> TbWbs { get; set; }
        public virtual DbSet<TbWorkLocation> TbWorkLocations { get; set; }
        public virtual DbSet<TbWpcategory> TbWpcategories { get; set; }
        public virtual DbSet<TbWplocation> TbWplocations { get; set; }
        public virtual DbSet<TimeSheet> TimeSheets { get; set; }
        public virtual DbSet<TimeSheetDetail> TimeSheetDetails { get; set; }
        public virtual DbSet<TimeSheetStatusesDictionary> TimeSheetStatusesDictionaries { get; set; }
        public virtual DbSet<TimeSheetsToEmployee> TimeSheetsToEmployees { get; set; }
        public virtual DbSet<Tmsapproval> Tmsapprovals { get; set; }
        public virtual DbSet<TmsapprovalMatricesStage> TmsapprovalMatricesStages { get; set; }
        public virtual DbSet<TmsapprovalMatricesStagesToSkip> TmsapprovalMatricesStagesToSkips { get; set; }
        public virtual DbSet<TmsapprovalMatricesToBusinessUnit> TmsapprovalMatricesToBusinessUnits { get; set; }
        public virtual DbSet<TmsapprovalMatricesToDepartment> TmsapprovalMatricesToDepartments { get; set; }
        public virtual DbSet<TmsapprovalMatricesToIntermediateSupervisor> TmsapprovalMatricesToIntermediateSupervisors { get; set; }
        public virtual DbSet<TmsapprovalMatricesToRequestType> TmsapprovalMatricesToRequestTypes { get; set; }
        public virtual DbSet<TmsapprovalMatricesToSupervisor> TmsapprovalMatricesToSupervisors { get; set; }
        public virtual DbSet<TmsapprovalMatricesToWorkLocation> TmsapprovalMatricesToWorkLocations { get; set; }
        public virtual DbSet<TmsapprovalMatrix> TmsapprovalMatrices { get; set; }
        public virtual DbSet<TmsapprovalMatrixStagesToApprover> TmsapprovalMatrixStagesToApprovers { get; set; }
        public virtual DbSet<TmsbatchRequestGroup> TmsbatchRequestGroups { get; set; }
        public virtual DbSet<TmsbatchRequestGroupsToEmployee> TmsbatchRequestGroupsToEmployees { get; set; }
        public virtual DbSet<TmsleaveRequestsAddData> TmsleaveRequestsAddData { get; set; }
        public virtual DbSet<TmsmissionRequestsAddData> TmsmissionRequestsAddData { get; set; }
        public virtual DbSet<Tmsrequest> Tmsrequests { get; set; }
        public virtual DbSet<TmsrequestType> TmsrequestTypes { get; set; }
        public virtual DbSet<TsemployeeDate> TsemployeeDates { get; set; }
        public virtual DbSet<TsworkedHour> TsworkedHours { get; set; }

        public IMSContext(DbContextOptions<IMSContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApprovalMatricesToEmployee>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeID, e.MatrixID });

                entity.HasIndex(e => e.EmployeeID)
                    .HasName("IX_EmployeeID");

                entity.HasIndex(e => e.MatrixID)
                    .HasName("IX_MatrixID");

                entity.Property(e => e.EmployeeID).IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ApprovalMatricesToEmployees)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_dbo.ApprovalMatricesToEmployees_dbo.tb_Employee_EmployeeID");

                entity.HasOne(d => d.Matrix)
                    .WithMany(p => p.ApprovalMatricesToEmployees)
                    .HasForeignKey(d => d.MatrixID)
                    .HasConstraintName("FK_dbo.ApprovalMatricesToEmployees_dbo.TMSApprovalMatrices_MatrixID");
            });

            modelBuilder.Entity<EmployeesToRepresentative>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeID, e.RepresentativeEmployeeID });

                entity.HasIndex(e => e.EmployeeID)
                    .HasName("IX_EmployeeID");

                entity.HasIndex(e => e.RepresentativeEmployeeID)
                    .HasName("IX_RepresentativeEmployeeID");

                entity.Property(e => e.EmployeeID).IsUnicode(false);

                entity.Property(e => e.RepresentativeEmployeeID).IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeesToRepresentativeEmployees)
                    .HasForeignKey(d => d.EmployeeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.EmployeesToRepresentatives_dbo.tb_Employee_EmployeeID");

                entity.HasOne(d => d.RepresentativeEmployee)
                    .WithMany(p => p.EmployeesToRepresentativeRepresentativeEmployees)
                    .HasForeignKey(d => d.RepresentativeEmployeeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.EmployeesToRepresentatives_dbo.tb_Employee_RepresentativeEmployeeID");
            });

            modelBuilder.Entity<GroupsFlexibleMembersList>(entity =>
            {
                entity.HasKey(e => new { e.GroupsSpecificationsUid, e.EmployeeBadgeNumber });

                entity.HasIndex(e => e.EmployeeBadgeNumber)
                    .HasName("IX_EmployeeBadgeNumber");

                entity.HasIndex(e => e.GroupsSpecificationsUid)
                    .HasName("IX_GroupsSpecificationsUID");

                entity.Property(e => e.EmployeeBadgeNumber).IsUnicode(false);

                entity.HasOne(d => d.EmployeeBadgeNumberNavigation)
                    .WithMany(p => p.GroupsFlexibleMembersLists)
                    .HasForeignKey(d => d.EmployeeBadgeNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GroupsFlexibleMembersList_dbo.tb_Employee_EmployeeBadgeNumber");

                entity.HasOne(d => d.GroupsSpecificationsU)
                    .WithMany(p => p.GroupsFlexibleMembersLists)
                    .HasForeignKey(d => d.GroupsSpecificationsUid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GroupsFlexibleMembersList_dbo.GroupsSpecifications_GroupsSpecificationsUID");
            });

            modelBuilder.Entity<GroupsSpecification>(entity =>
            {
                entity.HasIndex(e => e.GroupCostControlB2bemployeeBadgeNumber)
                    .HasName("IX_GroupCostControlB2BEmployeeBadgeNumber");

                entity.HasIndex(e => e.GroupCostControlEmployeeBadgeNumber)
                    .HasName("IX_GroupCostControlEmployeeBadgeNumber");

                entity.HasIndex(e => e.GroupDefaultJobCodeID)
                    .HasName("IX_GroupDefaultJobCodeID");

                entity.HasIndex(e => e.GroupDefaultTrcid)
                    .HasName("IX_GroupDefaultTRCID");

                entity.HasIndex(e => e.GroupDefaultWbsid)
                    .HasName("IX_GroupDefaultWBSID");

                entity.HasIndex(e => e.GroupHeadB2bemployeeBadgeNumber)
                    .HasName("IX_GroupHeadB2BEmployeeBadgeNumber");

                entity.HasIndex(e => e.GroupHeadEmployeeBadgeNumber)
                    .HasName("IX_GroupHeadEmployeeBadgeNumber");

                entity.HasIndex(e => e.GroupSupervisorB2bemployeeBadgeNumber)
                    .HasName("IX_GroupSupervisorB2BEmployeeBadgeNumber");

                entity.HasIndex(e => e.GroupSupervisorEmployeeBadgeNumber)
                    .HasName("IX_GroupSupervisorEmployeeBadgeNumber");

                entity.HasIndex(e => e.GroupTimeKeeperB2bemployeeBadgeNumber)
                    .HasName("IX_GroupTimeKeeperB2BEmployeeBadgeNumber");

                entity.HasIndex(e => e.GroupTimeKeeperEmployeeBadgeNumber)
                    .HasName("IX_GroupTimeKeeperEmployeeBadgeNumber");

                entity.HasIndex(e => e.LastUpdatedByBadge)
                    .HasName("IX_LastUpdatedByBadge");

                entity.Property(e => e.GroupUid).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.GroupCostControlB2bemployeeBadgeNumber).IsUnicode(false);

                entity.Property(e => e.GroupCostControlEmployeeBadgeNumber).IsUnicode(false);

                entity.Property(e => e.GroupHeadB2bemployeeBadgeNumber).IsUnicode(false);

                entity.Property(e => e.GroupHeadEmployeeBadgeNumber).IsUnicode(false);

                entity.Property(e => e.GroupSupervisorB2bemployeeBadgeNumber).IsUnicode(false);

                entity.Property(e => e.GroupSupervisorEmployeeBadgeNumber).IsUnicode(false);

                entity.Property(e => e.GroupTimeKeeperB2bemployeeBadgeNumber).IsUnicode(false);

                entity.Property(e => e.GroupTimeKeeperEmployeeBadgeNumber).IsUnicode(false);

                entity.Property(e => e.LastUpdatedByBadge).IsUnicode(false);

                entity.HasOne(d => d.GroupCostControlB2bemployeeBadgeNumberNavigation)
                    .WithMany(p => p.GroupsSpecificationGroupCostControlB2bemployeeBadgeNumberNavigation)
                    .HasForeignKey(d => d.GroupCostControlB2bemployeeBadgeNumber)
                    .HasConstraintName("FK_dbo.GroupsSpecifications_dbo.tb_Employee_GroupCostControlB2BEmployeeBadgeNumber");

                entity.HasOne(d => d.GroupCostControlEmployeeBadgeNumberNavigation)
                    .WithMany(p => p.GroupsSpecificationGroupCostControlEmployeeBadgeNumberNavigations)
                    .HasForeignKey(d => d.GroupCostControlEmployeeBadgeNumber)
                    .HasConstraintName("FK_dbo.GroupsSpecifications_dbo.tb_Employee_GroupCostControlEmployeeBadgeNumber");

                entity.HasOne(d => d.GroupDefaultJobCode)
                    .WithMany(p => p.GroupsSpecifications)
                    .HasForeignKey(d => d.GroupDefaultJobCodeID)
                    .HasConstraintName("FK_dbo.GroupsSpecifications_dbo.tb_JobCode_GroupDefaultJobCodeID");

                entity.HasOne(d => d.GroupDefaultTrc)
                    .WithMany(p => p.GroupsSpecifications)
                    .HasForeignKey(d => d.GroupDefaultTrcid)
                    .HasConstraintName("FK_dbo.GroupsSpecifications_dbo.tb_TRC_GroupDefaultTRCID");

                entity.HasOne(d => d.GroupDefaultWbs)
                    .WithMany(p => p.GroupsSpecifications)
                    .HasForeignKey(d => d.GroupDefaultWbsid)
                    .HasConstraintName("FK_dbo.GroupsSpecifications_dbo.tb_WBS_GroupDefaultWBSID");

                entity.HasOne(d => d.GroupHeadB2bemployeeBadgeNumberNavigation)
                    .WithMany(p => p.GroupsSpecificationGroupHeadB2bemployeeBadgeNumberNavigation)
                    .HasForeignKey(d => d.GroupHeadB2bemployeeBadgeNumber)
                    .HasConstraintName("FK_dbo.GroupsSpecifications_dbo.tb_Employee_GroupHeadB2BEmployeeBadgeNumber");

                entity.HasOne(d => d.GroupHeadEmployeeBadgeNumberNavigation)
                    .WithMany(p => p.GroupsSpecificationGroupHeadEmployeeBadgeNumberNavigations)
                    .HasForeignKey(d => d.GroupHeadEmployeeBadgeNumber)
                    .HasConstraintName("FK_dbo.GroupsSpecifications_dbo.tb_Employee_GroupHeadEmployeeBadgeNumber");

                entity.HasOne(d => d.GroupSupervisorB2bemployeeBadgeNumberNavigation)
                    .WithMany(p => p.GroupsSpecificationGroupSupervisorB2bemployeeBadgeNumberNavigation)
                    .HasForeignKey(d => d.GroupSupervisorB2bemployeeBadgeNumber)
                    .HasConstraintName("FK_dbo.GroupsSpecifications_dbo.tb_Employee_GroupSupervisorB2BEmployeeBadgeNumber");

                entity.HasOne(d => d.GroupSupervisorEmployeeBadgeNumberNavigation)
                    .WithMany(p => p.GroupsSpecificationGroupSupervisorEmployeeBadgeNumberNavigations)
                    .HasForeignKey(d => d.GroupSupervisorEmployeeBadgeNumber)
                    .HasConstraintName("FK_dbo.GroupsSpecifications_dbo.tb_Employee_GroupSupervisorEmployeeBadgeNumber");

                entity.HasOne(d => d.GroupTimeKeeperB2bemployeeBadgeNumberNavigation)
                    .WithMany(p => p.GroupsSpecificationGroupTimeKeeperB2bemployeeBadgeNumberNavigation)
                    .HasForeignKey(d => d.GroupTimeKeeperB2bemployeeBadgeNumber)
                    .HasConstraintName("FK_dbo.GroupsSpecifications_dbo.tb_Employee_GroupTimeKeeperB2BEmployeeBadgeNumber");

                entity.HasOne(d => d.GroupTimeKeeperEmployeeBadgeNumberNavigation)
                    .WithMany(p => p.GroupsSpecificationGroupTimeKeeperEmployeeBadgeNumberNavigations)
                    .HasForeignKey(d => d.GroupTimeKeeperEmployeeBadgeNumber)
                    .HasConstraintName("FK_dbo.GroupsSpecifications_dbo.tb_Employee_GroupTimeKeeperEmployeeBadgeNumber");

                entity.HasOne(d => d.LastUpdatedByBadgeNavigation)
                    .WithMany(p => p.GroupsSpecificationLastUpdatedByBadgeNavigations)
                    .HasForeignKey(d => d.LastUpdatedByBadge)
                    .HasConstraintName("FK_dbo.GroupsSpecifications_dbo.tb_Employee_LastUpdatedByBadge");
            });

            modelBuilder.Entity<LpoaccountsToCharge>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();
            });

            modelBuilder.Entity<LpoadditionalService>(entity =>
            {
                entity.HasIndex(e => e.CurrencyID)
                    .HasName("IX_CurrencyID");

                entity.HasIndex(e => e.OrderID)
                    .HasName("IX_OrderID");

                entity.HasIndex(e => e.TypeID)
                    .HasName("IX_TypeID");

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CurrencyID).IsUnicode(false);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.LpoadditionalServices)
                    .HasForeignKey(d => d.CurrencyID)
                    .HasConstraintName("FK_dbo.LPOAdditionalServices_dbo.tb_Currency_CurrencyID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.LpoadditionalServices)
                    .HasForeignKey(d => d.OrderID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LPOAdditionalServices_dbo.LPOOrders_OrderID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.LpoadditionalServices)
                    .HasForeignKey(d => d.TypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LPOAdditionalServices_dbo.LPOAdditionalServiceTypes_TypeID");
            });

            modelBuilder.Entity<Lpoagency>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();
            });

            modelBuilder.Entity<Lpoauthorizer>(entity =>
            {
                entity.HasIndex(e => e.EmployeeID)
                    .HasName("IX_EmployeeID");

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.EmployeeID).IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Lpoauthorizers)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_dbo.LPOAuthorizers_dbo.tb_Employee_Employee_BadgeNumber");
            });

            modelBuilder.Entity<LpocontactPerson>(entity =>
            {
                entity.HasIndex(e => e.EmployeeID)
                    .HasName("IX_EmployeeID");

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.EmployeeID).IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LpocontactPeople)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_dbo.LPOContactPersons_dbo.tb_Employee_Employee_BadgeNumber");
            });

            modelBuilder.Entity<LpodependantPassengerType>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();
            });

            modelBuilder.Entity<LpoflightTicket>(entity =>
            {
                entity.HasIndex(e => e.ClassID)
                    .HasName("IX_ClassID");

                entity.HasIndex(e => e.CurrencyID)
                    .HasName("IX_CurrencyID");

                entity.HasIndex(e => e.OrderID)
                    .HasName("IX_OrderID");

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CurrencyID).IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.LpoflightTickets)
                    .HasForeignKey(d => d.ClassID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LPOFlightTickets_dbo.LPOFlightTicketClasses_ClassID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.LpoflightTickets)
                    .HasForeignKey(d => d.CurrencyID)
                    .HasConstraintName("FK_dbo.LPOFlightTickets_dbo.tb_Currency_CurrencyID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.LpoflightTickets)
                    .HasForeignKey(d => d.OrderID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LPOFlightTickets_dbo.LPOOrders_OrderID");
            });

            modelBuilder.Entity<LpoflightTicketClass>(entity =>
            {
                entity.HasIndex(e => e.HrmsticketTypeID)
                    .HasName("IX_HRMSTicketTypeID");

                entity.HasOne(d => d.HrmsticketType)
                    .WithMany(p => p.LpoflightTicketClasses)
                    .HasForeignKey(d => d.HrmsticketTypeID)
                    .HasConstraintName("FK_dbo.LPOFlightTicketClasses_dbo.tb_TicketType_HRMSTicketTypeID");
            });

            modelBuilder.Entity<Lpoorder>(entity =>
            {
                entity.HasIndex(e => e.AccountToChargeID)
                    .HasName("IX_AccountToChargeID");

                entity.HasIndex(e => e.AgencyID)
                    .HasName("IX_AgencyID");

                entity.HasIndex(e => e.AreaID)
                    .HasName("IX_AreaID");

                entity.HasIndex(e => e.AuthorizerID)
                    .HasName("IX_AuthorizerID");

                entity.HasIndex(e => e.ContactPersonID)
                    .HasName("IX_ContactPersonID");

                entity.HasIndex(e => e.CurrencyID)
                    .HasName("IX_CurrencyID");

                entity.HasIndex(e => e.Date)
                    .HasName("IX_Date");

                entity.HasIndex(e => e.EmployeeID)
                    .HasName("IX_EmployeeID");

                entity.HasIndex(e => e.LastUpdateByID)
                    .HasName("IX_LastUpdateByID");

                entity.HasIndex(e => e.Number)
                    .HasName("IX_Number");

                entity.HasIndex(e => e.PurposeID)
                    .HasName("IX_PurposeID");

                entity.HasIndex(e => e.TmsrequestID)
                    .HasName("IX_TMSRequestID");

                entity.HasIndex(e => e.TypeID)
                    .HasName("IX_TypeID");

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CostCenterOrJobCodeToCharge).HasDefaultValueSql("('')");

                entity.Property(e => e.CurrencyID).IsUnicode(false);

                entity.Property(e => e.EmployeeID).IsUnicode(false);

                entity.Property(e => e.LastUpdateByID).IsUnicode(false);

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AccountToCharge)
                    .WithMany(p => p.Lpoorders)
                    .HasForeignKey(d => d.AccountToChargeID)
                    .HasConstraintName("FK_dbo.LPOOrders_dbo.LPOAccountsToCharge_AccountToChargeID");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.Lpoorders)
                    .HasForeignKey(d => d.AgencyID)
                    .HasConstraintName("FK_dbo.LPOOrders_dbo.LPOAgencies_AgencyID");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Lpoorders)
                    .HasForeignKey(d => d.AreaID)
                    .HasConstraintName("FK_dbo.LPOOrders_dbo.LPOTicketAreas_AreaID");

                entity.HasOne(d => d.Authorizer)
                    .WithMany(p => p.Lpoorders)
                    .HasForeignKey(d => d.AuthorizerID)
                    .HasConstraintName("FK_dbo.LPOOrders_dbo.LPOAuthorizers_AuthorizerID");

                entity.HasOne(d => d.ContactPerson)
                    .WithMany(p => p.Lpoorders)
                    .HasForeignKey(d => d.ContactPersonID)
                    .HasConstraintName("FK_dbo.LPOOrders_dbo.LPOContactPersons_ContactPersonID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Lpoorders)
                    .HasForeignKey(d => d.CurrencyID)
                    .HasConstraintName("FK_dbo.LPOOrders_dbo.tb_Currency_CurrencyID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LpoorderEmployees)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_dbo.LPOOrders_dbo.tb_Employee_EmployeeID");

                entity.HasOne(d => d.LastUpdateBy)
                    .WithMany(p => p.LpoorderLastUpdateBies)
                    .HasForeignKey(d => d.LastUpdateByID)
                    .HasConstraintName("FK_dbo.LPOOrders_dbo.tb_Employee_LastUpdateByID");

                entity.HasOne(d => d.Purpose)
                    .WithMany(p => p.Lpoorders)
                    .HasForeignKey(d => d.PurposeID)
                    .HasConstraintName("FK_dbo.LPOOrders_dbo.LPOPurposes_PurposeID");

                entity.HasOne(d => d.Tmsrequest)
                    .WithMany(p => p.Lpoorders)
                    .HasForeignKey(d => d.TmsrequestID)
                    .HasConstraintName("FK_dbo.LPOOrders_dbo.TMSRequests_TMSRequestID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Lpoorders)
                    .HasForeignKey(d => d.TypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LPOOrders_dbo.LPOOrderTypes_TypeID");
            });

            modelBuilder.Entity<LpoorderType>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();
            });

            modelBuilder.Entity<Lpopassenger>(entity =>
            {
                entity.HasIndex(e => e.DependantPassengerTypeID)
                    .HasName("IX_DependantPassengerTypeID");

                entity.HasIndex(e => e.FullName)
                    .HasName("IX_FullName");

                entity.HasIndex(e => e.TicketsPurchaseOrderID)
                    .HasName("IX_TicketsPurchaseOrderID");

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.DependantPassengerType)
                    .WithMany(p => p.Lpopassengers)
                    .HasForeignKey(d => d.DependantPassengerTypeID)
                    .HasConstraintName("FK_dbo.LPOPassengers_dbo.LPODependantPassengerTypes_DependantPassengerTypeID");

                entity.HasOne(d => d.TicketsPurchaseOrder)
                    .WithMany(p => p.Lpopassengers)
                    .HasForeignKey(d => d.TicketsPurchaseOrderID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LPOPassengers_dbo.LPOOrders_TicketsPurchaseOrderID");
            });

            modelBuilder.Entity<Lpopurpos>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();
            });

            modelBuilder.Entity<LpoticketArea>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();
            });

            modelBuilder.Entity<TbAmendment>(entity =>
            {
                entity.HasIndex(e => e.BadgeNo)
                    .HasName("IX_tb_AmendmentBadgeNo");

                entity.HasIndex(e => e.TypeCode)
                    .HasName("IX_tb_AmendmentCode");

                entity.Property(e => e.RefNo).ValueGeneratedNever();

                entity.Property(e => e.BadgeNo).IsUnicode(false);

                entity.Property(e => e.ContrRef).IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewCrea).IsUnicode(false);

                entity.Property(e => e.NewProle).IsUnicode(false);

                entity.Property(e => e.OldCrea).IsUnicode(false);

                entity.Property(e => e.OldProle).IsUnicode(false);

                entity.Property(e => e.UserID).IsUnicode(false);

                entity.HasOne(d => d.BadgeNoNavigation)
                    .WithMany(p => p.TbAmendments)
                    .HasForeignKey(d => d.BadgeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_Employee");

                entity.HasOne(d => d.NewCreaNavigation)
                    .WithMany(p => p.TbAmendmentNewCreaNavigations)
                    .HasForeignKey(d => d.NewCrea)
                    .HasConstraintName("fk_tb_NewCREA");

                entity.HasOne(d => d.NewLevelNavigation)
                    .WithMany(p => p.TbAmendmentNewLevelNavigations)
                    .HasForeignKey(d => d.NewLevel)
                    .HasConstraintName("fk_tb_NewLevel");

                entity.HasOne(d => d.NewPostNavigation)
                    .WithMany(p => p.TbAmendmentNewPostNavigations)
                    .HasForeignKey(d => d.NewPost)
                    .HasConstraintName("fk_tb_NewPost");

                entity.HasOne(d => d.NewProleNavigation)
                    .WithMany(p => p.TbAmendmentNewProleNavigations)
                    .HasForeignKey(d => d.NewProle)
                    .HasConstraintName("fk_tb_NewRole");

                entity.HasOne(d => d.NewRotationNavigation)
                    .WithMany(p => p.TbAmendmentNewRotationNavigations)
                    .HasForeignKey(d => d.NewRotation)
                    .HasConstraintName("fk_tb_NewRot");

                entity.HasOne(d => d.OldCreaNavigation)
                    .WithMany(p => p.TbAmendmentOldCreaNavigations)
                    .HasForeignKey(d => d.OldCrea)
                    .HasConstraintName("fk_tb_OldCREA");

                entity.HasOne(d => d.OldLevelNavigation)
                    .WithMany(p => p.TbAmendmentOldLevelNavigations)
                    .HasForeignKey(d => d.OldLevel)
                    .HasConstraintName("fk_tb_OldLevel");

                entity.HasOne(d => d.OldPostNavigation)
                    .WithMany(p => p.TbAmendmentOldPostNavigations)
                    .HasForeignKey(d => d.OldPost)
                    .HasConstraintName("fk_tb_OldPost");

                entity.HasOne(d => d.OldProleNavigation)
                    .WithMany(p => p.TbAmendmentOldProleNavigations)
                    .HasForeignKey(d => d.OldProle)
                    .HasConstraintName("fk_tb_OldRole");

                entity.HasOne(d => d.OldRotationNavigation)
                    .WithMany(p => p.TbAmendmentOldRotationNavigations)
                    .HasForeignKey(d => d.OldRotation)
                    .HasConstraintName("fk_tb_OldRot");

                entity.HasOne(d => d.TypeCodeNavigation)
                    .WithMany(p => p.TbAmendments)
                    .HasForeignKey(d => d.TypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_AmendmentCode");
            });

            modelBuilder.Entity<TbAmendmentCode>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<TbBank>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.BankCode).IsUnicode(false);

                entity.Property(e => e.BranchCode).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Swift).IsUnicode(false);
            });

            modelBuilder.Entity<TbBlanksType>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<TbBocunit>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbBussUnit>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbContractType>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbCostCenter>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Referer).IsUnicode(false);
            });

            modelBuilder.Entity<TbCrea>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbCurrency>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbDeathInsurance>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<TbDepartment>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Hod).IsUnicode(false);
            });

            modelBuilder.Entity<TbEducationLevel>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbEmpClass>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Level).IsUnicode(false);
            });

            modelBuilder.Entity<TbEmpGroup>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Sidac).IsUnicode(false);
            });

            modelBuilder.Entity<TbEmployee>(entity =>
            {
                entity.HasIndex(e => e.BlanksTypesCode)
                    .HasName("IX_BlanksTypes_Code");

                entity.HasIndex(e => e.EmpBussUnit);

                entity.HasIndex(e => e.EmpClass);

                entity.HasIndex(e => e.EmpCountry);

                entity.HasIndex(e => e.EmpCpos);

                entity.HasIndex(e => e.EmpDept);

                entity.HasIndex(e => e.EmpGroup);

                entity.HasIndex(e => e.EmpIntSupv)
                    .HasName("IX_EmpIntSupv");

                entity.HasIndex(e => e.EmpNat);

                entity.HasIndex(e => e.EmpProj);

                entity.HasIndex(e => e.EmpRelReason);

                entity.HasIndex(e => e.EmpRotation);

                entity.HasIndex(e => e.EmpStat);

                entity.HasIndex(e => e.EmpWorkLoc);

                entity.Property(e => e.EmpBadge)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpAccomm).IsUnicode(false);

                entity.Property(e => e.EmpBankAccnt).IsUnicode(false);

                entity.Property(e => e.EmpBankIbanloc).IsUnicode(false);

                entity.Property(e => e.EmpBankSwift).IsUnicode(false);

                entity.Property(e => e.EmpBocunit).IsUnicode(false);

                entity.Property(e => e.EmpBplace).IsUnicode(false);

                entity.Property(e => e.EmpBussUnit).IsUnicode(false);

                entity.Property(e => e.EmpCat).IsUnicode(false);

                entity.Property(e => e.EmpCity).IsUnicode(false);

                entity.Property(e => e.EmpClass).IsUnicode(false);

                entity.Property(e => e.EmpContractNo).IsUnicode(false);

                entity.Property(e => e.EmpCountry).IsUnicode(false);

                entity.Property(e => e.EmpCountryLoc).IsUnicode(false);

                entity.Property(e => e.EmpCurr).IsUnicode(false);

                entity.Property(e => e.EmpDept).IsUnicode(false);

                entity.Property(e => e.EmpEduDegree).IsUnicode(false);

                entity.Property(e => e.EmpEduMajor).IsUnicode(false);

                entity.Property(e => e.EmpFname).IsUnicode(false);

                entity.Property(e => e.EmpGhrsid).IsUnicode(false);

                entity.Property(e => e.EmpGrade).IsUnicode(false);

                entity.Property(e => e.EmpGroup).IsUnicode(false);

                entity.Property(e => e.EmpHobunit).IsUnicode(false);

                entity.Property(e => e.EmpHomeTel).IsUnicode(false);

                entity.Property(e => e.EmpIin).IsUnicode(false);

                entity.Property(e => e.EmpIntSupv).IsUnicode(false);

                entity.Property(e => e.EmpKinName).IsUnicode(false);

                entity.Property(e => e.EmpKinTel).IsUnicode(false);

                entity.Property(e => e.EmpLname).IsUnicode(false);

                entity.Property(e => e.EmpMarital).IsUnicode(false);

                entity.Property(e => e.EmpMname).IsUnicode(false);

                entity.Property(e => e.EmpNat).IsUnicode(false);

                entity.Property(e => e.EmpOcc).IsUnicode(false);

                entity.Property(e => e.EmpPassLoc).IsUnicode(false);

                entity.Property(e => e.EmpPassNo).IsUnicode(false);

                entity.Property(e => e.EmpPassStat).IsUnicode(false);

                entity.Property(e => e.EmpPensionNo).IsUnicode(false);

                entity.Property(e => e.EmpPostCode).IsUnicode(false);

                entity.Property(e => e.EmpProb).IsUnicode(false);

                entity.Property(e => e.EmpProj).IsUnicode(false);

                entity.Property(e => e.EmpProle).IsUnicode(false);

                entity.Property(e => e.EmpReligion).IsUnicode(false);

                entity.Property(e => e.EmpRemark).IsUnicode(false);

                entity.Property(e => e.EmpSchool).IsUnicode(false);

                entity.Property(e => e.EmpSchoolAddr).IsUnicode(false);

                entity.Property(e => e.EmpSect).IsUnicode(false);

                entity.Property(e => e.EmpSex).IsUnicode(false);

                entity.Property(e => e.EmpStreet).IsUnicode(false);

                entity.Property(e => e.EmpSupv).IsUnicode(false);

                entity.Property(e => e.EmpTown).IsUnicode(false);

                entity.Property(e => e.EmpUnionName).IsUnicode(false);

                entity.Property(e => e.EmpVendorID).IsUnicode(false);

                entity.Property(e => e.EmpVisaNo).IsUnicode(false);

                entity.Property(e => e.EmpWorkTel).IsUnicode(false);

                entity.Property(e => e.EmpWpno).IsUnicode(false);

                entity.HasOne(d => d.BlanksTypesCodeNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.BlanksTypesCode)
                    .HasConstraintName("FK_dbo.tb_Employee_dbo.tb_BlanksTypes_BlanksTypes_Code");

                entity.HasOne(d => d.EmpAposNavigation)
                    .WithMany(p => p.TbEmployeeEmpAposNavigations)
                    .HasForeignKey(d => d.EmpApos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_PositionA");

                entity.HasOne(d => d.EmpBankNameNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpBankName)
                    .HasConstraintName("fk_tb_Bank");

                entity.HasOne(d => d.EmpBocunitNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpBocunit)
                    .HasConstraintName("fk_tb_BOCUnit");

                entity.HasOne(d => d.EmpBussUnitNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpBussUnit)
                    .HasConstraintName("fk_tb_BussUnit2");

                entity.HasOne(d => d.EmpClassNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpClass)
                    .HasConstraintName("fk_tb_EmpClass");

                entity.HasOne(d => d.EmpContrTypeNavigation)
                    .WithMany(p => p.TbEmployeeEmpContrTypeNavigations)
                    .HasForeignKey(d => d.EmpContrType)
                    .HasConstraintName("fk_tb_ContractType");

                entity.HasOne(d => d.EmpContrType2Navigation)
                    .WithMany(p => p.TbEmployeeEmpContrType2Navigation)
                    .HasForeignKey(d => d.EmpContrType2)
                    .HasConstraintName("fk_tb_ContractType2");

                entity.HasOne(d => d.EmpCountryNavigation)
                    .WithMany(p => p.TbEmployeeEmpCountryNavigations)
                    .HasForeignKey(d => d.EmpCountry)
                    .HasConstraintName("fk_tb_Country");

                entity.HasOne(d => d.EmpCountryLocNavigation)
                    .WithMany(p => p.TbEmployeeEmpCountryLocNavigations)
                    .HasForeignKey(d => d.EmpCountryLoc)
                    .HasConstraintName("fk_tb_CountryLoc");

                entity.HasOne(d => d.EmpCposNavigation)
                    .WithMany(p => p.TbEmployeeEmpCposNavigations)
                    .HasForeignKey(d => d.EmpCpos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_PositionC");

                entity.HasOne(d => d.EmpCurrNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpCurr)
                    .HasConstraintName("fk_tb_Currency");

                entity.HasOne(d => d.EmpDeathInsNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpDeathIns)
                    .HasConstraintName("fk_tb_DeathInsurance");

                entity.HasOne(d => d.EmpDeptNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpDept)
                    .HasConstraintName("fk_tb_Department");

                entity.HasOne(d => d.EmpEduLevelNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpEduLevel)
                    .HasConstraintName("fk_tb_EducationLevel");

                entity.HasOne(d => d.EmpGradeNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpGrade)
                    .HasConstraintName("fk_tb_CREA2");

                entity.HasOne(d => d.EmpGroupNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpGroup)
                    .HasConstraintName("fk_tb_EmpGroup");

                entity.HasOne(d => d.EmpHobunitNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpHobunit)
                    .HasConstraintName("fk_tb_HOBUnit");

                entity.HasOne(d => d.EmpIncProtNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpIncProt)
                    .HasConstraintName("fk_tb_IncProtection");

                entity.HasOne(d => d.EmpKeyResNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpKeyRes)
                    .HasConstraintName("fk_tb_KeyResource");

                entity.HasOne(d => d.EmpKinRelNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpKinRel)
                    .HasConstraintName("fk_tb_Relationship");

                entity.HasOne(d => d.EmpLevelNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpLevel)
                    .HasConstraintName("fk_tb_JobLevel");

                entity.HasOne(d => d.EmpLifeInsNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpLifeIns)
                    .HasConstraintName("fk_tb_LifeInsurance");

                entity.HasOne(d => d.EmpMaritalNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpMarital)
                    .HasConstraintName("fk_tb_Marital");

                entity.HasOne(d => d.EmpMedInsNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpMedIns)
                    .HasConstraintName("fk_tb_MedInsurance");

                entity.HasOne(d => d.EmpNatNavigation)
                    .WithMany(p => p.TbEmployeeEmpNatNavigations)
                    .HasForeignKey(d => d.EmpNat)
                    .HasConstraintName("fk_tb_Nationality");

                entity.HasOne(d => d.EmpNationalNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpNational)
                    .HasConstraintName("fk_tb_Nationalization");

                entity.HasOne(d => d.EmpOccNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpOcc)
                    .HasConstraintName("fk_tb_CostCenter");

                entity.HasOne(d => d.EmpPayTypeNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpPayType)
                    .HasConstraintName("fk_tb_PayType");

                entity.HasOne(d => d.EmpPensionGroupNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpPensionGroup)
                    .HasConstraintName("fk_tb_PensionGroup");

                entity.HasOne(d => d.EmpProjNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpProj)
                    .HasConstraintName("fk_tb_Project");

                entity.HasOne(d => d.EmpProleNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpProle)
                    .HasConstraintName("fk_tb_ProfRole");

                entity.HasOne(d => d.EmpQualifiNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpQualifi)
                    .HasConstraintName("fk_tb_Qualification");

                entity.HasOne(d => d.EmpRelReasonNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpRelReason)
                    .HasConstraintName("fk_tb_EmpStatReason");

                entity.HasOne(d => d.EmpRotationNavigation)
                    .WithMany(p => p.TbEmployeeEmpRotationNavigations)
                    .HasForeignKey(d => d.EmpRotation)
                    .HasConstraintName("fk_tb_Rotation");

                entity.HasOne(d => d.EmpRotation2Navigation)
                    .WithMany(p => p.TbEmployeeEmpRotation2Navigation)
                    .HasForeignKey(d => d.EmpRotation2)
                    .HasConstraintName("fk_tb_Rotation2");

                entity.HasOne(d => d.EmpStatNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpStat)
                    .HasConstraintName("fk_tb_EmpStat");

                entity.HasOne(d => d.EmpSupvNavigation)
                    .WithMany(p => p.InverseEmpSupvNavigation)
                    .HasForeignKey(d => d.EmpSupv)
                    .HasConstraintName("FK_tb_Employee_Supervisor");

                entity.HasOne(d => d.EmpTicketNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpTicket)
                    .HasConstraintName("fk_tb_TicketType2");

                entity.HasOne(d => d.EmpUnionNameNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpUnionName)
                    .HasConstraintName("fk_tb_UnionGroup");

                entity.HasOne(d => d.EmpVisaTypeNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpVisaType)
                    .HasConstraintName("fk_tb_VisaType");

                entity.HasOne(d => d.EmpWorkLocNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpWorkLoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_WorkLocation");

                entity.HasOne(d => d.EmpWpcatNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpWpcat)
                    .HasConstraintName("fk_tb_WPCategory");

                entity.HasOne(d => d.EmpWplocNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.EmpWploc)
                    .HasConstraintName("fk_tb_WPLocation");
            });

            modelBuilder.Entity<TbEmpStat>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Sidac).IsUnicode(false);
            });

            modelBuilder.Entity<TbEmpStatReason>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbHobunit>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbIncProtection>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbJobCode>(entity =>
            {
                entity.Property(e => e.JobCodeID).ValueGeneratedNever();
            });

            modelBuilder.Entity<TbJobLevel>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Level).IsUnicode(false);
            });

            modelBuilder.Entity<TbKeyResource>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbLifeInsurance>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<TbMarital>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbMedInsurance>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<TbMilitary>(entity =>
            {
                entity.Property(e => e.EmpBadge)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TbNatGroup>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbNationality>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Alias).IsUnicode(false);

                entity.Property(e => e.Bcclass).IsUnicode(false);

                entity.Property(e => e.Bfclass).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Mmclass).IsUnicode(false);

                entity.Property(e => e.Sidac).IsUnicode(false);

                entity.Property(e => e.Wcclass).IsUnicode(false);

                entity.HasOne(d => d.NatGroupNavigation)
                    .WithMany(p => p.TbNationalities)
                    .HasForeignKey(d => d.NatGroup)
                    .HasConstraintName("fk_tb_NatGroup");
            });

            modelBuilder.Entity<TbNationalization>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbPayrollCode>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<TbPayType>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbPensionGroup>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbPosClass>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TbPosition>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.Crea).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.TbPositions)
                    .HasForeignKey(d => d.Class)
                    .HasConstraintName("fk_tb_PosClass");

                entity.HasOne(d => d.CreaNavigation)
                    .WithMany(p => p.TbPositions)
                    .HasForeignKey(d => d.Crea)
                    .HasConstraintName("fk_tb_CREA");
            });

            modelBuilder.Entity<TbProfRole>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Family).IsUnicode(false);

                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p.TbProfRoles)
                    .HasForeignKey(d => d.Area)
                    .HasConstraintName("fk_tb_ProfRoleArea");

                entity.HasOne(d => d.FamilyNavigation)
                    .WithMany(p => p.TbProfRoles)
                    .HasForeignKey(d => d.Family)
                    .HasConstraintName("fk_tb_RoleFamily");
            });

            modelBuilder.Entity<TbProfRoleArea>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbProject>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BussUnit).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Manager).IsUnicode(false);

                entity.HasOne(d => d.BussUnitNavigation)
                    .WithMany(p => p.TbProjects)
                    .HasForeignKey(d => d.BussUnit)
                    .HasConstraintName("fk_tb_BussUnit");
            });

            modelBuilder.Entity<TbProjectType>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbQualification>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbRelationship>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbReligion>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbRoleFamily>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbRotation>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbStaffMovement>(entity =>
            {
                entity.HasIndex(e => e.BadgeNo)
                    .HasName("IX_BadgeNo");

                entity.HasIndex(e => e.NewBu)
                    .HasName("IX_NewBU");

                entity.HasIndex(e => e.NewOcc)
                    .HasName("IX_NewOCC");

                entity.HasIndex(e => e.NewPost)
                    .HasName("IX_NewPost");

                entity.HasIndex(e => e.NewProle)
                    .HasName("IX_NewPRole");

                entity.HasIndex(e => e.NewRotation)
                    .HasName("IX_NewRotation");

                entity.HasIndex(e => e.NewWorkLoc)
                    .HasName("IX_NewWorkLoc");

                entity.HasIndex(e => e.OldBu)
                    .HasName("IX_OldBU");

                entity.HasIndex(e => e.OldOcc)
                    .HasName("IX_OldOCC");

                entity.HasIndex(e => e.OldPost)
                    .HasName("IX_OldPost");

                entity.HasIndex(e => e.OldProle)
                    .HasName("IX_OldPRole");

                entity.HasIndex(e => e.OldRotation)
                    .HasName("IX_OldRotation");

                entity.HasIndex(e => e.OldWorkLoc)
                    .HasName("IX_OldWorkLoc");

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.BadgeNo).IsUnicode(false);

                entity.Property(e => e.NewBu).IsUnicode(false);

                entity.Property(e => e.NewOcc).IsUnicode(false);

                entity.Property(e => e.NewProle).IsUnicode(false);

                entity.Property(e => e.OldBu).IsUnicode(false);

                entity.Property(e => e.OldOcc).IsUnicode(false);

                entity.Property(e => e.OldProle).IsUnicode(false);

                entity.HasOne(d => d.BadgeNoNavigation)
                    .WithMany(p => p.TbStaffMovements)
                    .HasForeignKey(d => d.BadgeNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tb_StaffMovement_dbo.tb_Employee_BadgeNo");

                entity.HasOne(d => d.NewBuNavigation)
                    .WithMany(p => p.TbStaffMovementNewBuNavigations)
                    .HasForeignKey(d => d.NewBu)
                    .HasConstraintName("FK_dbo.tb_StaffMovement_dbo.tb_BussUnit_NewBU");

                entity.HasOne(d => d.NewOccNavigation)
                    .WithMany(p => p.TbStaffMovementNewOccNavigations)
                    .HasForeignKey(d => d.NewOcc)
                    .HasConstraintName("FK_dbo.tb_StaffMovement_dbo.tb_CostCenter_NewOCC");

                entity.HasOne(d => d.NewPostNavigation)
                    .WithMany(p => p.TbStaffMovementNewPostNavigations)
                    .HasForeignKey(d => d.NewPost)
                    .HasConstraintName("FK_dbo.tb_StaffMovement_dbo.tb_Position_NewPost");

                entity.HasOne(d => d.NewProleNavigation)
                    .WithMany(p => p.TbStaffMovementNewProleNavigations)
                    .HasForeignKey(d => d.NewProle)
                    .HasConstraintName("FK_dbo.tb_StaffMovement_dbo.tb_ProfRole_NewPRole");

                entity.HasOne(d => d.NewRotationNavigation)
                    .WithMany(p => p.TbStaffMovementNewRotationNavigations)
                    .HasForeignKey(d => d.NewRotation)
                    .HasConstraintName("FK_dbo.tb_StaffMovement_dbo.tb_Rotation_NewRotation");

                entity.HasOne(d => d.NewWorkLocNavigation)
                    .WithMany(p => p.TbStaffMovementNewWorkLocNavigations)
                    .HasForeignKey(d => d.NewWorkLoc)
                    .HasConstraintName("FK_dbo.tb_StaffMovement_dbo.tb_WorkLocation_OldWorkLoc");

                entity.HasOne(d => d.OldBuNavigation)
                    .WithMany(p => p.TbStaffMovementOldBuNavigations)
                    .HasForeignKey(d => d.OldBu)
                    .HasConstraintName("FK_dbo.tb_StaffMovement_dbo.tb_BussUnit_OldBU");

                entity.HasOne(d => d.OldOccNavigation)
                    .WithMany(p => p.TbStaffMovementOldOccNavigations)
                    .HasForeignKey(d => d.OldOcc)
                    .HasConstraintName("FK_dbo.tb_StaffMovement_dbo.tb_CostCenter_OldOCC");

                entity.HasOne(d => d.OldPostNavigation)
                    .WithMany(p => p.TbStaffMovementOldPostNavigations)
                    .HasForeignKey(d => d.OldPost)
                    .HasConstraintName("FK_dbo.tb_StaffMovement_dbo.tb_Position_OldPost");

                entity.HasOne(d => d.OldProleNavigation)
                    .WithMany(p => p.TbStaffMovementOldProleNavigations)
                    .HasForeignKey(d => d.OldProle)
                    .HasConstraintName("FK_dbo.tb_StaffMovement_dbo.tb_ProfRole_OldPRole");

                entity.HasOne(d => d.OldRotationNavigation)
                    .WithMany(p => p.TbStaffMovementOldRotationNavigations)
                    .HasForeignKey(d => d.OldRotation)
                    .HasConstraintName("FK_dbo.tb_StaffMovement_dbo.tb_Rotation_OldRotation");

                entity.HasOne(d => d.OldWorkLocNavigation)
                    .WithMany(p => p.TbStaffMovementOldWorkLocNavigations)
                    .HasForeignKey(d => d.OldWorkLoc)
                    .HasConstraintName("FK_dbo.tb_StaffMovement_dbo.tb_WorkLocation_NewWorkLoc");
            });

            modelBuilder.Entity<TbTicketType>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbTrc>(entity =>
            {
                entity.Property(e => e.Trccode).ValueGeneratedNever();
            });

            modelBuilder.Entity<TbUnionGroup>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbVacationDetail>(entity =>
            {
                entity.HasIndex(e => e.EmpBadge)
                    .HasName("IX_EmpBadge");

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmpBadge).IsUnicode(false);
            });

            modelBuilder.Entity<TbVacationType>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbVisaType>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbWb>(entity =>
            {
                entity.HasIndex(e => e.JobCodeID)
                    .HasName("IX_JobCodeID");

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.JobCode)
                    .WithMany(p => p.TbWbs)
                    .HasForeignKey(d => d.JobCodeID)
                    .HasConstraintName("FK_dbo.tb_WBS_dbo.tb_JobCode_JobCodeID");
            });

            modelBuilder.Entity<TbWorkLocation>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Sidac).IsUnicode(false);

                entity.Property(e => e.Warea).IsUnicode(false);

                entity.HasOne(d => d.ProjTypeNavigation)
                    .WithMany(p => p.TbWorkLocations)
                    .HasForeignKey(d => d.ProjType)
                    .HasConstraintName("fk_tb_ProjectType");
            });

            modelBuilder.Entity<TbWpcategory>(entity =>
            {
                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TbWplocation>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Descr).IsUnicode(false);
            });

            modelBuilder.Entity<TimeSheet>(entity =>
            {
                entity.HasIndex(e => e.LastUpdatedByBadge)
                    .HasName("IX_LastUpdatedByBadge");

                entity.HasIndex(e => e.TsStatusID)
                    .HasName("IX_TS_Status_ID");

                entity.Property(e => e.TimeSheetUid).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.LastUpdatedByBadge).IsUnicode(false);

                entity.HasOne(d => d.LastUpdatedByBadgeNavigation)
                    .WithMany(p => p.TimeSheets)
                    .HasForeignKey(d => d.LastUpdatedByBadge)
                    .HasConstraintName("FK_dbo.TimeSheet_dbo.tb_Employee_LastUpdatedByBadge");

                entity.HasOne(d => d.TsStatus)
                    .WithMany(p => p.TimeSheets)
                    .HasForeignKey(d => d.TsStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TimeSheet_dbo.TimeSheetStatusesDictionary_TS_Status_ID");
            });

            modelBuilder.Entity<TimeSheetDetail>(entity =>
            {
                entity.HasIndex(e => e.LastUpdatedByBadge)
                    .HasName("IX_LastUpdatedByBadge");

                entity.HasIndex(e => e.TimeSheetUid)
                    .HasName("IX_TimeSheetUID");

                entity.Property(e => e.TimeSheetUid).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedByBadge).IsUnicode(false);

                entity.HasOne(d => d.LastUpdatedByBadgeNavigation)
                    .WithMany(p => p.TimeSheetDetails)
                    .HasForeignKey(d => d.LastUpdatedByBadge)
                    .HasConstraintName("FK_dbo.TimeSheetDetails_dbo.tb_Employee_LastUpdatedByBadge");

                entity.HasOne(d => d.TimeSheetU)
                    .WithOne(p => p.TimeSheetDetail)
                    .HasForeignKey<TimeSheetDetail>(d => d.TimeSheetUid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TimeSheetDetails_dbo.TimeSheet_TimeSheetUID");
            });

            modelBuilder.Entity<TimeSheetStatusesDictionary>(entity =>
            {
                entity.Property(e => e.StatusID).ValueGeneratedNever();
            });

            modelBuilder.Entity<TimeSheetsToEmployee>(entity =>
            {
                entity.HasIndex(e => e.EmployeeBadgeNumber)
                    .HasName("IX_EmployeeBadgeNumber");

                entity.HasIndex(e => e.GroupUid)
                    .HasName("IX_GroupUID");

                entity.HasIndex(e => e.TimeSheetUid)
                    .HasName("IX_TimeSheetUID");

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmployeeBadgeNumber).IsUnicode(false);

                entity.HasOne(d => d.EmployeeBadgeNumberNavigation)
                    .WithMany(p => p.TimeSheetsToEmployees)
                    .HasForeignKey(d => d.EmployeeBadgeNumber)
                    .HasConstraintName("FK_dbo.TimeSheetsToEmployees_dbo.tb_Employee_EmployeeBadgeNumber");

                entity.HasOne(d => d.GroupU)
                    .WithMany(p => p.TimeSheetsToEmployees)
                    .HasForeignKey(d => d.GroupUid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TimeSheetsToEmployees_dbo.GroupsSpecifications_GroupUID");

                entity.HasOne(d => d.TimeSheetU)
                    .WithMany(p => p.TimeSheetsToEmployees)
                    .HasForeignKey(d => d.TimeSheetUid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TimeSheetsToEmployees_dbo.TimeSheet_TimeSheet_TimeSheetUID");
            });

            modelBuilder.Entity<Tmsapproval>(entity =>
            {
                entity.HasKey(e => new { e.RequestID, e.Level });

                entity.HasIndex(e => e.ApproverID)
                    .HasName("IX_ApproverID");

                entity.HasIndex(e => e.MatrixStageID)
                    .HasName("IX_MatrixStageID");

                entity.HasIndex(e => e.OnBehalfOfApproverID)
                    .HasName("IX_OnBehalfOfApproverID");

                entity.HasIndex(e => e.RequestID)
                    .HasName("IX_RequestID");

                entity.Property(e => e.ApproverID).IsUnicode(false);

                entity.Property(e => e.OnBehalfOfApproverID).IsUnicode(false);

                entity.HasOne(d => d.Approver)
                    .WithMany(p => p.TmsapprovalApprovers)
                    .HasForeignKey(d => d.ApproverID)
                    .HasConstraintName("FK_dbo.TMSApprovals_dbo.tb_Employee_ApproverID");

                entity.HasOne(d => d.MatrixStage)
                    .WithMany(p => p.Tmsapprovals)
                    .HasForeignKey(d => d.MatrixStageID)
                    .HasConstraintName("FK_dbo.TMSApprovals_dbo.TMSApprovalMatricesStages_MatrixStageID");

                entity.HasOne(d => d.OnBehalfOfApprover)
                    .WithMany(p => p.TmsapprovalOnBehalfOfApprovers)
                    .HasForeignKey(d => d.OnBehalfOfApproverID)
                    .HasConstraintName("FK_dbo.TMSApprovals_dbo.tb_Employee_OnBehalfOfApproverID");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Tmsapprovals)
                    .HasForeignKey(d => d.RequestID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TMSApprovals_dbo.TMSRequests_RequestID");
            });

            modelBuilder.Entity<TmsapprovalMatricesStage>(entity =>
            {
                entity.HasIndex(e => e.MatrixID)
                    .HasName("IX_MatrixID");

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Matrix)
                    .WithMany(p => p.TmsapprovalMatricesStages)
                    .HasForeignKey(d => d.MatrixID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesStages_dbo.TMSApprovalMatrices_MatrixID");
            });

            modelBuilder.Entity<TmsapprovalMatricesStagesToSkip>(entity =>
            {
                entity.HasKey(e => new { e.StageID, e.RequestTypeID });

                entity.HasIndex(e => e.RequestTypeID)
                    .HasName("IX_RequestTypeID");

                entity.HasIndex(e => e.StageID)
                    .HasName("IX_StageID");

                entity.HasOne(d => d.RequestType)
                    .WithMany(p => p.TmsapprovalMatricesStagesToSkips)
                    .HasForeignKey(d => d.RequestTypeID)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesStagesToSkip_dbo.TMSRequestTypes_RequestTypeID");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.TmsapprovalMatricesStagesToSkips)
                    .HasForeignKey(d => d.StageID)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesStagesToSkip_dbo.TMSApprovalMatricesStages_StageID");
            });

            modelBuilder.Entity<TmsapprovalMatricesToBusinessUnit>(entity =>
            {
                entity.HasKey(e => new { e.ApprovalMatrixID, e.BusinessUnitCode });

                entity.HasIndex(e => e.ApprovalMatrixID)
                    .HasName("IX_ApprovalMatrix_ID");

                entity.HasIndex(e => e.BusinessUnitCode)
                    .HasName("IX_BusinessUnit_Code");

                entity.Property(e => e.BusinessUnitCode).IsUnicode(false);

                entity.HasOne(d => d.ApprovalMatrix)
                    .WithMany(p => p.TmsapprovalMatricesToBusinessUnits)
                    .HasForeignKey(d => d.ApprovalMatrixID)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesToBusinessUnits_dbo.TMSApprovalMatrices_ApprovalMatrix_ID");

                entity.HasOne(d => d.BusinessUnitCodeNavigation)
                    .WithMany(p => p.TmsapprovalMatricesToBusinessUnits)
                    .HasForeignKey(d => d.BusinessUnitCode)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesToBusinessUnits_dbo.tb_BussUnit_BusinessUnit_Code");
            });

            modelBuilder.Entity<TmsapprovalMatricesToDepartment>(entity =>
            {
                entity.HasKey(e => new { e.ApprovalMatrixID, e.DepartmentCode });

                entity.HasIndex(e => e.ApprovalMatrixID)
                    .HasName("IX_ApprovalMatrix_ID");

                entity.HasIndex(e => e.DepartmentCode)
                    .HasName("IX_Department_Code");

                entity.Property(e => e.DepartmentCode).IsUnicode(false);

                entity.HasOne(d => d.ApprovalMatrix)
                    .WithMany(p => p.TmsapprovalMatricesToDepartments)
                    .HasForeignKey(d => d.ApprovalMatrixID)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesToDepartments_dbo.TMSApprovalMatrices_ApprovalMatrix_ID");

                entity.HasOne(d => d.DepartmentCodeNavigation)
                    .WithMany(p => p.TmsapprovalMatricesToDepartments)
                    .HasForeignKey(d => d.DepartmentCode)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesToDepartments_dbo.tb_Department_Department_Code");
            });

            modelBuilder.Entity<TmsapprovalMatricesToIntermediateSupervisor>(entity =>
            {
                entity.HasKey(e => new { e.ApprovalMatrixID, e.EmployeeBadgeNumber });

                entity.HasIndex(e => e.ApprovalMatrixID)
                    .HasName("IX_ApprovalMatrix_ID");

                entity.HasIndex(e => e.EmployeeBadgeNumber)
                    .HasName("IX_Employee_BadgeNumber");

                entity.Property(e => e.EmployeeBadgeNumber).IsUnicode(false);

                entity.HasOne(d => d.ApprovalMatrix)
                    .WithMany(p => p.TmsapprovalMatricesToIntermediateSupervisors)
                    .HasForeignKey(d => d.ApprovalMatrixID)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesToIntermediateSupervisors_dbo.TMSApprovalMatrices_ApprovalMatrix_ID");

                entity.HasOne(d => d.EmployeeBadgeNumberNavigation)
                    .WithMany(p => p.TmsapprovalMatricesToIntermediateSupervisors)
                    .HasForeignKey(d => d.EmployeeBadgeNumber)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesToIntermediateSupervisors_dbo.tb_Employee_Employee_BadgeNumber");
            });

            modelBuilder.Entity<TmsapprovalMatricesToRequestType>(entity =>
            {
                entity.HasKey(e => new { e.ApprovalMatrixID, e.TmsrequestTypeID });

                entity.HasIndex(e => e.ApprovalMatrixID)
                    .HasName("IX_ApprovalMatrix_ID");

                entity.HasIndex(e => e.TmsrequestTypeID)
                    .HasName("IX_TMSRequestType_ID");

                entity.HasOne(d => d.ApprovalMatrix)
                    .WithMany(p => p.TmsapprovalMatricesToRequestTypes)
                    .HasForeignKey(d => d.ApprovalMatrixID)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesToRequestTypes_dbo.TMSApprovalMatrices_ApprovalMatrix_ID");

                entity.HasOne(d => d.TmsrequestType)
                    .WithMany(p => p.TmsapprovalMatricesToRequestTypes)
                    .HasForeignKey(d => d.TmsrequestTypeID)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesToRequestTypes_dbo.TMSRequestTypes_TMSRequestType_ID");
            });

            modelBuilder.Entity<TmsapprovalMatricesToSupervisor>(entity =>
            {
                entity.HasKey(e => new { e.ApprovalMatrixID, e.EmployeeBadgeNumber });

                entity.HasIndex(e => e.ApprovalMatrixID)
                    .HasName("IX_ApprovalMatrix_ID");

                entity.HasIndex(e => e.EmployeeBadgeNumber)
                    .HasName("IX_Employee_BadgeNumber");

                entity.Property(e => e.EmployeeBadgeNumber).IsUnicode(false);

                entity.HasOne(d => d.ApprovalMatrix)
                    .WithMany(p => p.TmsapprovalMatricesToSupervisors)
                    .HasForeignKey(d => d.ApprovalMatrixID)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesToSupervisors_dbo.TMSApprovalMatrices_ApprovalMatrix_ID");

                entity.HasOne(d => d.EmployeeBadgeNumberNavigation)
                    .WithMany(p => p.TmsapprovalMatricesToSupervisors)
                    .HasForeignKey(d => d.EmployeeBadgeNumber)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesToSupervisors_dbo.tb_Employee_Employee_BadgeNumber");
            });

            modelBuilder.Entity<TmsapprovalMatricesToWorkLocation>(entity =>
            {
                entity.HasKey(e => new { e.ApprovalMatrixID, e.WorkLocationCode });

                entity.HasIndex(e => e.ApprovalMatrixID)
                    .HasName("IX_ApprovalMatrix_ID");

                entity.HasIndex(e => e.WorkLocationCode)
                    .HasName("IX_WorkLocation_Code");

                entity.HasOne(d => d.ApprovalMatrix)
                    .WithMany(p => p.TmsapprovalMatricesToWorkLocations)
                    .HasForeignKey(d => d.ApprovalMatrixID)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesToWorkLocations_dbo.TMSApprovalMatrices_ApprovalMatrix_ID");

                entity.HasOne(d => d.WorkLocationCodeNavigation)
                    .WithMany(p => p.TmsapprovalMatricesToWorkLocations)
                    .HasForeignKey(d => d.WorkLocationCode)
                    .HasConstraintName("FK_dbo.TMSApprovalMatricesToWorkLocations_dbo.tb_WorkLocation_WorkLocation_Code");
            });

            modelBuilder.Entity<TmsapprovalMatrix>(entity =>
            {
                entity.HasIndex(e => e.LastUpdatedByBadge)
                    .HasName("IX_LastUpdatedByBadge");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.LastUpdatedByBadge).IsUnicode(false);

                entity.HasOne(d => d.LastUpdatedByBadgeNavigation)
                    .WithMany(p => p.TmsapprovalMatrices)
                    .HasForeignKey(d => d.LastUpdatedByBadge)
                    .HasConstraintName("FK_dbo.TMSApprovalMatrices_dbo.tb_Employee_LastUpdatedByBadge");
            });

            modelBuilder.Entity<TmsapprovalMatrixStagesToApprover>(entity =>
            {
                entity.HasKey(e => new { e.ApprovalMatrixStageID, e.EmployeeBadgeNumber });

                entity.HasIndex(e => e.ApprovalMatrixStageID)
                    .HasName("IX_ApprovalMatrixStage_ID");

                entity.HasIndex(e => e.EmployeeBadgeNumber)
                    .HasName("IX_Employee_BadgeNumber");

                entity.Property(e => e.EmployeeBadgeNumber).IsUnicode(false);

                entity.HasOne(d => d.ApprovalMatrixStage)
                    .WithMany(p => p.TmsapprovalMatrixStagesToApprovers)
                    .HasForeignKey(d => d.ApprovalMatrixStageID)
                    .HasConstraintName("FK_dbo.TMSApprovalMatrixStagesToApprovers_dbo.TMSApprovalMatricesStages_ApprovalMatrixStage_ID");

                entity.HasOne(d => d.EmployeeBadgeNumberNavigation)
                    .WithMany(p => p.TmsapprovalMatrixStagesToApprovers)
                    .HasForeignKey(d => d.EmployeeBadgeNumber)
                    .HasConstraintName("FK_dbo.TMSApprovalMatrixStagesToApprovers_dbo.tb_Employee_Employee_BadgeNumber");
            });

            modelBuilder.Entity<TmsbatchRequestGroup>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<TmsbatchRequestGroupsToEmployee>(entity =>
            {
                entity.HasKey(e => new { e.GroupID, e.EmployeeID });

                entity.HasIndex(e => e.EmployeeID)
                    .HasName("IX_EmployeeID");

                entity.HasIndex(e => e.GroupID)
                    .HasName("IX_GroupID");

                entity.Property(e => e.EmployeeID).IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TmsbatchRequestGroupsToEmployees)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_dbo.TMSBatchRequestGroupsToEmployees_dbo.tb_Employee_EmployeeID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TmsbatchRequestGroupsToEmployees)
                    .HasForeignKey(d => d.GroupID)
                    .HasConstraintName("FK_dbo.TMSBatchRequestGroupsToEmployees_dbo.TMSBatchRequestGroups_GroupID");
            });

            modelBuilder.Entity<TmsleaveRequestsAddData>(entity =>
            {
                entity.HasIndex(e => e.ID)
                    .HasName("IX_ID");

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.TmsleaveRequestsAddData)
                    .HasForeignKey<TmsleaveRequestsAddData>(d => d.ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TMSLeaveRequestsAddData_dbo.TMSRequests_ID");
            });

            modelBuilder.Entity<TmsmissionRequestsAddData>(entity =>
            {
                entity.HasIndex(e => e.ID)
                    .HasName("IX_ID");

                entity.HasIndex(e => e.ProjectToChargeID)
                    .HasName("IX_ProjectToChargeID");

                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.ProjectToChargeID).IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.TmsmissionRequestsAddData)
                    .HasForeignKey<TmsmissionRequestsAddData>(d => d.ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TMSMissionRequestsAddData_dbo.TMSRequests_ID");

                entity.HasOne(d => d.ProjectToCharge)
                    .WithMany(p => p.TmsmissionRequestsAddData)
                    .HasForeignKey(d => d.ProjectToChargeID)
                    .HasConstraintName("FK_dbo.TMSMissionRequestsAddData_dbo.tb_Project_ProjectToChargeID");
            });

            modelBuilder.Entity<Tmsrequest>(entity =>
            {
                entity.HasIndex(e => e.CurrentMatrixStageID)
                    .HasName("IX_CurrentMatrixStageID");

                entity.HasIndex(e => e.EmployeeID)
                    .HasName("IX_EmployeeID");

                entity.HasIndex(e => e.From)
                    .HasName("IX_From");

                entity.HasIndex(e => e.LastUpdateTime)
                    .HasName("IX_LastUpdateTime");

                entity.HasIndex(e => e.LastUpdatedByEmployeeID)
                    .HasName("IX_LastUpdatedByEmployeeID");

                entity.HasIndex(e => e.MatrixID)
                    .HasName("IX_MatrixID");

                entity.HasIndex(e => e.RefNumber)
                    .HasName("IX_RefNumber");

                entity.HasIndex(e => e.RepresentativeEmployeeID)
                    .HasName("IX_RepresentativeEmployeeID");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.TypeID)
                    .HasName("IX_TypeID");

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmployeeID).IsUnicode(false);

                entity.Property(e => e.LastUpdatedByEmployeeID).IsUnicode(false);

                entity.Property(e => e.RepresentativeEmployeeID).IsUnicode(false);

                entity.HasOne(d => d.CurrentMatrixStage)
                    .WithMany(p => p.Tmsrequests)
                    .HasForeignKey(d => d.CurrentMatrixStageID)
                    .HasConstraintName("FK_dbo.TMSRequests_dbo.TMSApprovalMatricesStages_CurrentMatrixStageID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TmsrequestEmployees)
                    .HasForeignKey(d => d.EmployeeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TMSRequests_dbo.tb_Employee_EmployeeID");

                entity.HasOne(d => d.LastUpdatedByEmployee)
                    .WithMany(p => p.TmsrequestLastUpdatedByEmployees)
                    .HasForeignKey(d => d.LastUpdatedByEmployeeID)
                    .HasConstraintName("FK_dbo.TMSRequests_dbo.tb_Employee_LastUpdatedByEmployeeID");

                entity.HasOne(d => d.Matrix)
                    .WithMany(p => p.Tmsrequests)
                    .HasForeignKey(d => d.MatrixID)
                    .HasConstraintName("FK_dbo.TMSRequests_dbo.TMSApprovalMatrices_MatrixID");

                entity.HasOne(d => d.RepresentativeEmployee)
                    .WithMany(p => p.TmsrequestRepresentativeEmployees)
                    .HasForeignKey(d => d.RepresentativeEmployeeID)
                    .HasConstraintName("FK_dbo.TMSRequests_dbo.tb_Employee_RepresentativeEmployeeID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Tmsrequests)
                    .HasForeignKey(d => d.TypeID)
                    .HasConstraintName("FK_dbo.TMSRequests_dbo.TMSRequestTypes_TypeID");
            });

            modelBuilder.Entity<TmsrequestType>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();
            });

            modelBuilder.Entity<TsemployeeDate>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.TsemployeeID });

                entity.HasIndex(e => e.StatusID)
                    .HasName("IX_StatusID");

                entity.HasIndex(e => e.TsemployeeID)
                    .HasName("IX_TSEmployeeID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TsemployeeDates)
                    .HasForeignKey(d => d.StatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TSEmployeeDates_dbo.TimeSheetStatusesDictionary_StatusID");

                entity.HasOne(d => d.Tsemployee)
                    .WithMany(p => p.TsemployeeDates)
                    .HasForeignKey(d => d.TsemployeeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TSEmployeeDates_dbo.TimeSheetsToEmployees_TSEmployeeID");
            });

            modelBuilder.Entity<TsworkedHour>(entity =>
            {
                entity.HasIndex(e => e.StatusID)
                    .HasName("IX_StatusID");

                entity.HasIndex(e => e.TimeSheetJobCodeID)
                    .HasName("IX_TimeSheetJobCodeID");

                entity.HasIndex(e => e.TimeSheetTrcid)
                    .HasName("IX_TimeSheetTRCID");

                entity.HasIndex(e => e.TimeSheetWbsid)
                    .HasName("IX_TimeSheetWBSID");

                entity.HasIndex(e => new { e.Date, e.TsemployeeID })
                    .HasName("IX_Date_TSEmployeeID");

                entity.Property(e => e.ID).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TsworkedHours)
                    .HasForeignKey(d => d.StatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TSWorkedHours_dbo.TimeSheetStatusesDictionary_StatusID");

                entity.HasOne(d => d.TimeSheetJobCode)
                    .WithMany(p => p.TsworkedHours)
                    .HasForeignKey(d => d.TimeSheetJobCodeID)
                    .HasConstraintName("FK_dbo.TSWorkedHours_dbo.tb_JobCode_TimeSheetJobCodeID");

                entity.HasOne(d => d.TimeSheetTrc)
                    .WithMany(p => p.TsworkedHours)
                    .HasForeignKey(d => d.TimeSheetTrcid)
                    .HasConstraintName("FK_dbo.TSWorkedHours_dbo.tb_TRC_TimeSheetTRCID");

                entity.HasOne(d => d.TimeSheetWbs)
                    .WithMany(p => p.TsworkedHours)
                    .HasForeignKey(d => d.TimeSheetWbsid)
                    .HasConstraintName("FK_dbo.TSWorkedHours_dbo.tb_WBS_TimeSheetWBSID");

                entity.HasOne(d => d.Tsemployee)
                    .WithMany(p => p.TsworkedHours)
                    .HasForeignKey(d => d.TsemployeeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TSWorkedHours_dbo.TimeSheetsToEmployees_TSEmployeeID");

                entity.HasOne(d => d.TsemployeeDate)
                    .WithMany(p => p.TsworkedHours)
                    .HasForeignKey(d => new { d.Date, d.TsemployeeID })
                    .HasConstraintName("FK_dbo.TSWorkedHours_dbo.TSEmployeeDates_Date_TSEmployeeID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
