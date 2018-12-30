using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Employee")]
    public partial class TbEmployee
    {
        public TbEmployee()
        {
            ApprovalMatricesToEmployees = new HashSet<ApprovalMatricesToEmployee>();
            EmployeesToRepresentativeEmployees = new HashSet<EmployeesToRepresentative>();
            EmployeesToRepresentativeRepresentativeEmployees = new HashSet<EmployeesToRepresentative>();
            GroupsFlexibleMembersLists = new HashSet<GroupsFlexibleMembersList>();
            GroupsSpecificationGroupCostControlB2bemployeeBadgeNumberNavigation = new HashSet<GroupsSpecification>();
            GroupsSpecificationGroupCostControlEmployeeBadgeNumberNavigations = new HashSet<GroupsSpecification>();
            GroupsSpecificationGroupHeadB2bemployeeBadgeNumberNavigation = new HashSet<GroupsSpecification>();
            GroupsSpecificationGroupHeadEmployeeBadgeNumberNavigations = new HashSet<GroupsSpecification>();
            GroupsSpecificationGroupSupervisorB2bemployeeBadgeNumberNavigation = new HashSet<GroupsSpecification>();
            GroupsSpecificationGroupSupervisorEmployeeBadgeNumberNavigations = new HashSet<GroupsSpecification>();
            GroupsSpecificationGroupTimeKeeperB2bemployeeBadgeNumberNavigation = new HashSet<GroupsSpecification>();
            GroupsSpecificationGroupTimeKeeperEmployeeBadgeNumberNavigations = new HashSet<GroupsSpecification>();
            GroupsSpecificationLastUpdatedByBadgeNavigations = new HashSet<GroupsSpecification>();
            InverseEmpIntSupvNavigation = new HashSet<TbEmployee>();
            InverseEmpSupvNavigation = new HashSet<TbEmployee>();
            Lpoauthorizers = new HashSet<Lpoauthorizer>();
            LpocontactPeople = new HashSet<LpocontactPerson>();
            LpoorderEmployees = new HashSet<Lpoorder>();
            LpoorderLastUpdateBies = new HashSet<Lpoorder>();
            TbAmendments = new HashSet<TbAmendment>();
            TbStaffMovements = new HashSet<TbStaffMovement>();
            TimeSheetDetails = new HashSet<TimeSheetDetail>();
            TimeSheets = new HashSet<TimeSheet>();
            TimeSheetsToEmployees = new HashSet<TimeSheetsToEmployee>();
            TmsapprovalApprovers = new HashSet<Tmsapproval>();
            TmsapprovalMatrices = new HashSet<TmsapprovalMatrix>();
            TmsapprovalMatricesToIntermediateSupervisors = new HashSet<TmsapprovalMatricesToIntermediateSupervisor>();
            TmsapprovalMatricesToSupervisors = new HashSet<TmsapprovalMatricesToSupervisor>();
            TmsapprovalMatrixStagesToApprovers = new HashSet<TmsapprovalMatrixStagesToApprover>();
            TmsapprovalOnBehalfOfApprovers = new HashSet<Tmsapproval>();
            TmsbatchRequestGroupsToEmployees = new HashSet<TmsbatchRequestGroupsToEmployee>();
            TmsrequestEmployees = new HashSet<Tmsrequest>();
            TmsrequestLastUpdatedByEmployees = new HashSet<Tmsrequest>();
            TmsrequestRepresentativeEmployees = new HashSet<Tmsrequest>();
        }

        [Key]
        [StringLength(10)]
        public string EmpBadge { get; set; }
        [Column("EmpGHRSID")]
        [StringLength(15)]
        public string EmpGhrsid { get; set; }
        [Required]
        [Column("EmpLName")]
        [StringLength(30)]
        public string EmpLname { get; set; }
        [Column("EmpFName")]
        [StringLength(30)]
        public string EmpFname { get; set; }
        [Column("EmpMName")]
        [StringLength(25)]
        public string EmpMname { get; set; }
        [StringLength(50)]
        public string EmpNameLoc { get; set; }
        public byte[] EmpPhoto { get; set; }
        [Column("EmpCPos")]
        public short EmpCpos { get; set; }
        [Column("EmpAPos")]
        public short EmpApos { get; set; }
        [StringLength(10)]
        public string EmpProj { get; set; }
        [StringLength(6)]
        public string EmpDept { get; set; }
        [StringLength(10)]
        public string EmpSupv { get; set; }
        [StringLength(10)]
        public string EmpIntSupv { get; set; }
        [StringLength(30)]
        public string EmpSect { get; set; }
        [StringLength(3)]
        public string EmpGroup { get; set; }
        [StringLength(6)]
        public string EmpBussUnit { get; set; }
        [StringLength(60)]
        public string EmpStreet { get; set; }
        [StringLength(60)]
        public string EmpTown { get; set; }
        [StringLength(60)]
        public string EmpCity { get; set; }
        [StringLength(3)]
        public string EmpCountry { get; set; }
        [StringLength(20)]
        public string EmpPostCode { get; set; }
        [StringLength(60)]
        public string EmpStreetLoc { get; set; }
        [StringLength(60)]
        public string EmpTownLoc { get; set; }
        [StringLength(60)]
        public string EmpCityLoc { get; set; }
        [StringLength(3)]
        public string EmpCountryLoc { get; set; }
        [StringLength(50)]
        public string EmpHomeTel { get; set; }
        [StringLength(50)]
        public string EmpWorkTel { get; set; }
        [StringLength(50)]
        public string EmpEmail { get; set; }
        [Required]
        [StringLength(1)]
        public string EmpCat { get; set; }
        [StringLength(3)]
        public string EmpNat { get; set; }
        public byte? EmpChild { get; set; }
        [StringLength(1)]
        public string EmpMarital { get; set; }
        [StringLength(20)]
        public string EmpReligion { get; set; }
        [Column("EmpBDate", TypeName = "date")]
        public DateTime? EmpBdate { get; set; }
        [Column("EmpBPlace")]
        [StringLength(50)]
        public string EmpBplace { get; set; }
        [Required]
        [StringLength(1)]
        public string EmpSex { get; set; }
        public short? EmpStat { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EmpRelDate { get; set; }
        public short? EmpRelReason { get; set; }
        [StringLength(20)]
        public string EmpPassNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EmpPassIss { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EmpPassExp { get; set; }
        [StringLength(60)]
        public string EmpPassLoc { get; set; }
        [StringLength(30)]
        public string EmpPassStat { get; set; }
        [Column("EmpWPNo")]
        [StringLength(20)]
        public string EmpWpno { get; set; }
        [Column("EmpWPLoc")]
        public short? EmpWploc { get; set; }
        [Column("EmpWPIss", TypeName = "date")]
        public DateTime? EmpWpiss { get; set; }
        [Column("EmpWPExp", TypeName = "date")]
        public DateTime? EmpWpexp { get; set; }
        [Column("EmpWPSDate", TypeName = "date")]
        public DateTime? EmpWpsdate { get; set; }
        [Column("EmpWPPos")]
        [StringLength(150)]
        public string EmpWppos { get; set; }
        [Column("EmpWPCat")]
        public byte? EmpWpcat { get; set; }
        [StringLength(20)]
        public string EmpVisaNo { get; set; }
        public short? EmpVisaType { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EmpVisaIss { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EmpVisaExp { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EmpPoliceReg { get; set; }
        [Column("EmpIIN")]
        [StringLength(20)]
        public string EmpIin { get; set; }
        [StringLength(25)]
        public string EmpPensionNo { get; set; }
        public double? EmpPensionPerc { get; set; }
        public short? EmpPensionGroup { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EmpMedExp { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EmpContrIni { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EmpProjDate { get; set; }
        [Column("EmpContrSDate", TypeName = "date")]
        public DateTime? EmpContrSdate { get; set; }
        [Column("EmpContrEDate", TypeName = "date")]
        public DateTime? EmpContrEdate { get; set; }
        [Column("EmpContrADate", TypeName = "date")]
        public DateTime? EmpContrAdate { get; set; }
        [Column("EmpLVacDate", TypeName = "date")]
        public DateTime? EmpLvacDate { get; set; }
        [Column("EmpMWHour")]
        public short? EmpMwhour { get; set; }
        public short? EmpRotation { get; set; }
        [StringLength(20)]
        public string EmpContractNo { get; set; }
        public short? EmpContrType { get; set; }
        [StringLength(3)]
        public string EmpCurr { get; set; }
        [Column("EmpHFundDay")]
        public double? EmpHfundDay { get; set; }
        [Column("EmpBFundDay")]
        public double? EmpBfundDay { get; set; }
        [StringLength(30)]
        public string EmpAccomm { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EmpCampIn { get; set; }
        public double? EmpBasicSal { get; set; }
        [Column("EmpOTRate")]
        public double? EmpOtrate { get; set; }
        [Column("EmpOTLump")]
        public double? EmpOtlump { get; set; }
        [Column("EmpOTWeekday")]
        public double? EmpOtweekday { get; set; }
        [Column("EmpOTWeekend")]
        public double? EmpOtweekend { get; set; }
        [Column("EmpMWHour2")]
        public short? EmpMwhour2 { get; set; }
        public short? EmpRotation2 { get; set; }
        public short? EmpContrType2 { get; set; }
        public double? EmpBasicSal2 { get; set; }
        [Column("EmpOTRate2")]
        public double? EmpOtrate2 { get; set; }
        public double? EmpSiteAllow { get; set; }
        public short? EmpSiteAllowType { get; set; }
        public double? EmpLivingAllow { get; set; }
        public short? EmpLivingAllowType { get; set; }
        public double? EmpVacDaysRate { get; set; }
        public double? EmpHardship { get; set; }
        public double? EmpQuay { get; set; }
        [StringLength(3)]
        public string EmpUnionName { get; set; }
        public bool? EmpInkindTax { get; set; }
        public bool? EmpTradeUnion { get; set; }
        public bool? EmpTaxExempt { get; set; }
        public bool? EmpPensionExempt { get; set; }
        [Column("EmpOPFC")]
        public bool? EmpOpfc { get; set; }
        [Column("EmpCSHIExempt")]
        public bool? EmpCshiexempt { get; set; }
        public double? EmpFoodAllow { get; set; }
        public double? EmpAccomAllow { get; set; }
        [Column("EmpOCC")]
        [StringLength(6)]
        public string EmpOcc { get; set; }
        [StringLength(2)]
        public string EmpGrade { get; set; }
        public short? EmpLevel { get; set; }
        public short? EmpQualifi { get; set; }
        public short EmpWorkLoc { get; set; }
        [StringLength(4)]
        public string EmpClass { get; set; }
        public short? EmpKeyRes { get; set; }
        public short? EmpNational { get; set; }
        public short? EmpEduLevel { get; set; }
        [StringLength(50)]
        public string EmpEduDegree { get; set; }
        [StringLength(50)]
        public string EmpEduMajor { get; set; }
        public bool? EmpEduGrad { get; set; }
        public short? EmpEduDate { get; set; }
        [StringLength(100)]
        public string EmpSchool { get; set; }
        [StringLength(100)]
        public string EmpSchoolAddr { get; set; }
        public short? EmpPayType { get; set; }
        [StringLength(50)]
        public string EmpPayee { get; set; }
        [StringLength(40)]
        public string EmpBankAccnt { get; set; }
        public short? EmpBankName { get; set; }
        [StringLength(150)]
        public string EmpBankAddr { get; set; }
        [Column("EmpBankSWIFT")]
        [StringLength(25)]
        public string EmpBankSwift { get; set; }
        [StringLength(50)]
        public string EmpPayeeLoc { get; set; }
        public string EmpBankNameLoc { get; set; }
        [Column("EmpBankIBANLoc")]
        [StringLength(25)]
        public string EmpBankIbanloc { get; set; }
        [Column("EmpVendorID")]
        [StringLength(8)]
        public string EmpVendorID { get; set; }
        [Column("EmpPRole")]
        [StringLength(8)]
        public string EmpProle { get; set; }
        [Column("EmpHOBUnit")]
        [StringLength(6)]
        public string EmpHobunit { get; set; }
        [Column("EmpBOCUnit")]
        [StringLength(6)]
        public string EmpBocunit { get; set; }
        [StringLength(50)]
        public string EmpKinName { get; set; }
        [StringLength(150)]
        public string EmpKinAddr { get; set; }
        [StringLength(50)]
        public string EmpKinTel { get; set; }
        public byte? EmpKinRel { get; set; }
        public double? EmpAccGrossSal { get; set; }
        public double? EmpAccGrossInc { get; set; }
        public double? EmpAccExempt { get; set; }
        [Column("EmpAccMCB")]
        public double? EmpAccMcb { get; set; }
        public double? EmpAccTax { get; set; }
        public double? EmpAccPension { get; set; }
        [Column("EmpYTDBonus")]
        public double? EmpYtdbonus { get; set; }
        [Column("EmpBFund")]
        public double? EmpBfund { get; set; }
        [Column("EmpYTDVac")]
        public double? EmpYtdvac { get; set; }
        [Column("EmpHFund")]
        public double? EmpHfund { get; set; }
        public double? EmpAccDays { get; set; }
        public double? EmpRotAllow { get; set; }
        [Column("EmpABasicSal")]
        public double? EmpAbasicSal { get; set; }
        [Column("EmpAOAllow")]
        public double? EmpAoallow { get; set; }
        [Column("EmpSF")]
        public short? EmpSf { get; set; }
        public byte? EmpDuration { get; set; }
        public double? EmpTravelLump { get; set; }
        public byte? EmpTicket { get; set; }
        public short? EmpDeathIns { get; set; }
        public short? EmpMedIns { get; set; }
        public short? EmpLifeIns { get; set; }
        public short? EmpIncProt { get; set; }
        [StringLength(5)]
        public string EmpProb { get; set; }
        public byte? EmpNotice { get; set; }
        public string EmpRemark { get; set; }
        [Column("_OtherEducationalBackgroundInfoJSON")]
        public string OtherEducationalBackgroundInfoJson { get; set; }
        [Column("_WorkExperienceInfoJSON")]
        public string WorkExperienceInfoJson { get; set; }
        public string LastUpdatedByBadge { get; set; }
        public string LastUpdatedByUsername { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdateTime { get; set; }
        public string PhoneExtensionNumber { get; set; }
        [Column("BlanksTypes_Code")]
        public short? BlanksTypesCode { get; set; }
        [StringLength(50)]
        public string EmpEmailCorporate { get; set; }

        [ForeignKey("BlanksTypesCode")]
        [InverseProperty("TbEmployees")]
        public virtual TbBlanksType BlanksTypesCodeNavigation { get; set; }
        [ForeignKey("EmpApos")]
        [InverseProperty("TbEmployeeEmpAposNavigations")]
        public virtual TbPosition EmpAposNavigation { get; set; }
        [ForeignKey("EmpBankName")]
        [InverseProperty("TbEmployees")]
        public virtual TbBank EmpBankNameNavigation { get; set; }
        [ForeignKey("EmpBocunit")]
        [InverseProperty("TbEmployees")]
        public virtual TbBocunit EmpBocunitNavigation { get; set; }
        [ForeignKey("EmpBussUnit")]
        [InverseProperty("TbEmployees")]
        public virtual TbBussUnit EmpBussUnitNavigation { get; set; }
        [ForeignKey("EmpClass")]
        [InverseProperty("TbEmployees")]
        public virtual TbEmpClass EmpClassNavigation { get; set; }
        [ForeignKey("EmpContrType2")]
        [InverseProperty("TbEmployeeEmpContrType2Navigation")]
        public virtual TbContractType EmpContrType2Navigation { get; set; }
        [ForeignKey("EmpContrType")]
        [InverseProperty("TbEmployeeEmpContrTypeNavigations")]
        public virtual TbContractType EmpContrTypeNavigation { get; set; }
        [ForeignKey("EmpCountryLoc")]
        [InverseProperty("TbEmployeeEmpCountryLocNavigations")]
        public virtual TbNationality EmpCountryLocNavigation { get; set; }
        [ForeignKey("EmpCountry")]
        [InverseProperty("TbEmployeeEmpCountryNavigations")]
        public virtual TbNationality EmpCountryNavigation { get; set; }
        [ForeignKey("EmpCpos")]
        [InverseProperty("TbEmployeeEmpCposNavigations")]
        public virtual TbPosition EmpCposNavigation { get; set; }
        [ForeignKey("EmpCurr")]
        [InverseProperty("TbEmployees")]
        public virtual TbCurrency EmpCurrNavigation { get; set; }
        [ForeignKey("EmpDeathIns")]
        [InverseProperty("TbEmployees")]
        public virtual TbDeathInsurance EmpDeathInsNavigation { get; set; }
        [ForeignKey("EmpDept")]
        [InverseProperty("TbEmployees")]
        public virtual TbDepartment EmpDeptNavigation { get; set; }
        [ForeignKey("EmpEduLevel")]
        [InverseProperty("TbEmployees")]
        public virtual TbEducationLevel EmpEduLevelNavigation { get; set; }
        [ForeignKey("EmpGrade")]
        [InverseProperty("TbEmployees")]
        public virtual TbCrea EmpGradeNavigation { get; set; }
        [ForeignKey("EmpGroup")]
        [InverseProperty("TbEmployees")]
        public virtual TbEmpGroup EmpGroupNavigation { get; set; }
        [ForeignKey("EmpHobunit")]
        [InverseProperty("TbEmployees")]
        public virtual TbHobunit EmpHobunitNavigation { get; set; }
        [ForeignKey("EmpIncProt")]
        [InverseProperty("TbEmployees")]
        public virtual TbIncProtection EmpIncProtNavigation { get; set; }
        [ForeignKey("EmpIntSupv")]
        [InverseProperty("InverseEmpIntSupvNavigation")]
        public virtual TbEmployee EmpIntSupvNavigation { get; set; }
        [ForeignKey("EmpKeyRes")]
        [InverseProperty("TbEmployees")]
        public virtual TbKeyResource EmpKeyResNavigation { get; set; }
        [ForeignKey("EmpKinRel")]
        [InverseProperty("TbEmployees")]
        public virtual TbRelationship EmpKinRelNavigation { get; set; }
        [ForeignKey("EmpLevel")]
        [InverseProperty("TbEmployees")]
        public virtual TbJobLevel EmpLevelNavigation { get; set; }
        [ForeignKey("EmpLifeIns")]
        [InverseProperty("TbEmployees")]
        public virtual TbLifeInsurance EmpLifeInsNavigation { get; set; }
        [ForeignKey("EmpMarital")]
        [InverseProperty("TbEmployees")]
        public virtual TbMarital EmpMaritalNavigation { get; set; }
        [ForeignKey("EmpMedIns")]
        [InverseProperty("TbEmployees")]
        public virtual TbMedInsurance EmpMedInsNavigation { get; set; }
        [ForeignKey("EmpNat")]
        [InverseProperty("TbEmployeeEmpNatNavigations")]
        public virtual TbNationality EmpNatNavigation { get; set; }
        [ForeignKey("EmpNational")]
        [InverseProperty("TbEmployees")]
        public virtual TbNationalization EmpNationalNavigation { get; set; }
        [ForeignKey("EmpOcc")]
        [InverseProperty("TbEmployees")]
        public virtual TbCostCenter EmpOccNavigation { get; set; }
        [ForeignKey("EmpPayType")]
        [InverseProperty("TbEmployees")]
        public virtual TbPayType EmpPayTypeNavigation { get; set; }
        [ForeignKey("EmpPensionGroup")]
        [InverseProperty("TbEmployees")]
        public virtual TbPensionGroup EmpPensionGroupNavigation { get; set; }
        [ForeignKey("EmpProj")]
        [InverseProperty("TbEmployees")]
        public virtual TbProject EmpProjNavigation { get; set; }
        [ForeignKey("EmpProle")]
        [InverseProperty("TbEmployees")]
        public virtual TbProfRole EmpProleNavigation { get; set; }
        [ForeignKey("EmpQualifi")]
        [InverseProperty("TbEmployees")]
        public virtual TbQualification EmpQualifiNavigation { get; set; }
        [ForeignKey("EmpRelReason")]
        [InverseProperty("TbEmployees")]
        public virtual TbEmpStatReason EmpRelReasonNavigation { get; set; }
        [ForeignKey("EmpRotation2")]
        [InverseProperty("TbEmployeeEmpRotation2Navigation")]
        public virtual TbRotation EmpRotation2Navigation { get; set; }
        [ForeignKey("EmpRotation")]
        [InverseProperty("TbEmployeeEmpRotationNavigations")]
        public virtual TbRotation EmpRotationNavigation { get; set; }
        [ForeignKey("EmpStat")]
        [InverseProperty("TbEmployees")]
        public virtual TbEmpStat EmpStatNavigation { get; set; }
        [ForeignKey("EmpSupv")]
        [InverseProperty("InverseEmpSupvNavigation")]
        public virtual TbEmployee EmpSupvNavigation { get; set; }
        [ForeignKey("EmpTicket")]
        [InverseProperty("TbEmployees")]
        public virtual TbTicketType EmpTicketNavigation { get; set; }
        [ForeignKey("EmpUnionName")]
        [InverseProperty("TbEmployees")]
        public virtual TbUnionGroup EmpUnionNameNavigation { get; set; }
        [ForeignKey("EmpVisaType")]
        [InverseProperty("TbEmployees")]
        public virtual TbVisaType EmpVisaTypeNavigation { get; set; }
        [ForeignKey("EmpWorkLoc")]
        [InverseProperty("TbEmployees")]
        public virtual TbWorkLocation EmpWorkLocNavigation { get; set; }
        [ForeignKey("EmpWpcat")]
        [InverseProperty("TbEmployees")]
        public virtual TbWpcategory EmpWpcatNavigation { get; set; }
        [ForeignKey("EmpWploc")]
        [InverseProperty("TbEmployees")]
        public virtual TbWplocation EmpWplocNavigation { get; set; }
        [InverseProperty("Employee")]
        public virtual ICollection<ApprovalMatricesToEmployee> ApprovalMatricesToEmployees { get; set; }
        [InverseProperty("Employee")]
        public virtual ICollection<EmployeesToRepresentative> EmployeesToRepresentativeEmployees { get; set; }
        [InverseProperty("RepresentativeEmployee")]
        public virtual ICollection<EmployeesToRepresentative> EmployeesToRepresentativeRepresentativeEmployees { get; set; }
        [InverseProperty("EmployeeBadgeNumberNavigation")]
        public virtual ICollection<GroupsFlexibleMembersList> GroupsFlexibleMembersLists { get; set; }
        [InverseProperty("GroupCostControlB2bemployeeBadgeNumberNavigation")]
        public virtual ICollection<GroupsSpecification> GroupsSpecificationGroupCostControlB2bemployeeBadgeNumberNavigation { get; set; }
        [InverseProperty("GroupCostControlEmployeeBadgeNumberNavigation")]
        public virtual ICollection<GroupsSpecification> GroupsSpecificationGroupCostControlEmployeeBadgeNumberNavigations { get; set; }
        [InverseProperty("GroupHeadB2bemployeeBadgeNumberNavigation")]
        public virtual ICollection<GroupsSpecification> GroupsSpecificationGroupHeadB2bemployeeBadgeNumberNavigation { get; set; }
        [InverseProperty("GroupHeadEmployeeBadgeNumberNavigation")]
        public virtual ICollection<GroupsSpecification> GroupsSpecificationGroupHeadEmployeeBadgeNumberNavigations { get; set; }
        [InverseProperty("GroupSupervisorB2bemployeeBadgeNumberNavigation")]
        public virtual ICollection<GroupsSpecification> GroupsSpecificationGroupSupervisorB2bemployeeBadgeNumberNavigation { get; set; }
        [InverseProperty("GroupSupervisorEmployeeBadgeNumberNavigation")]
        public virtual ICollection<GroupsSpecification> GroupsSpecificationGroupSupervisorEmployeeBadgeNumberNavigations { get; set; }
        [InverseProperty("GroupTimeKeeperB2bemployeeBadgeNumberNavigation")]
        public virtual ICollection<GroupsSpecification> GroupsSpecificationGroupTimeKeeperB2bemployeeBadgeNumberNavigation { get; set; }
        [InverseProperty("GroupTimeKeeperEmployeeBadgeNumberNavigation")]
        public virtual ICollection<GroupsSpecification> GroupsSpecificationGroupTimeKeeperEmployeeBadgeNumberNavigations { get; set; }
        [InverseProperty("LastUpdatedByBadgeNavigation")]
        public virtual ICollection<GroupsSpecification> GroupsSpecificationLastUpdatedByBadgeNavigations { get; set; }
        [InverseProperty("EmpIntSupvNavigation")]
        public virtual ICollection<TbEmployee> InverseEmpIntSupvNavigation { get; set; }
        [InverseProperty("EmpSupvNavigation")]
        public virtual ICollection<TbEmployee> InverseEmpSupvNavigation { get; set; }
        [InverseProperty("Employee")]
        public virtual ICollection<Lpoauthorizer> Lpoauthorizers { get; set; }
        [InverseProperty("Employee")]
        public virtual ICollection<LpocontactPerson> LpocontactPeople { get; set; }
        [InverseProperty("Employee")]
        public virtual ICollection<Lpoorder> LpoorderEmployees { get; set; }
        [InverseProperty("LastUpdateBy")]
        public virtual ICollection<Lpoorder> LpoorderLastUpdateBies { get; set; }
        [InverseProperty("BadgeNoNavigation")]
        public virtual ICollection<TbAmendment> TbAmendments { get; set; }
        [InverseProperty("BadgeNoNavigation")]
        public virtual ICollection<TbStaffMovement> TbStaffMovements { get; set; }
        [InverseProperty("LastUpdatedByBadgeNavigation")]
        public virtual ICollection<TimeSheetDetail> TimeSheetDetails { get; set; }
        [InverseProperty("LastUpdatedByBadgeNavigation")]
        public virtual ICollection<TimeSheet> TimeSheets { get; set; }
        [InverseProperty("EmployeeBadgeNumberNavigation")]
        public virtual ICollection<TimeSheetsToEmployee> TimeSheetsToEmployees { get; set; }
        [InverseProperty("Approver")]
        public virtual ICollection<Tmsapproval> TmsapprovalApprovers { get; set; }
        [InverseProperty("LastUpdatedByBadgeNavigation")]
        public virtual ICollection<TmsapprovalMatrix> TmsapprovalMatrices { get; set; }
        [InverseProperty("EmployeeBadgeNumberNavigation")]
        public virtual ICollection<TmsapprovalMatricesToIntermediateSupervisor> TmsapprovalMatricesToIntermediateSupervisors { get; set; }
        [InverseProperty("EmployeeBadgeNumberNavigation")]
        public virtual ICollection<TmsapprovalMatricesToSupervisor> TmsapprovalMatricesToSupervisors { get; set; }
        [InverseProperty("EmployeeBadgeNumberNavigation")]
        public virtual ICollection<TmsapprovalMatrixStagesToApprover> TmsapprovalMatrixStagesToApprovers { get; set; }
        [InverseProperty("OnBehalfOfApprover")]
        public virtual ICollection<Tmsapproval> TmsapprovalOnBehalfOfApprovers { get; set; }
        [InverseProperty("Employee")]
        public virtual ICollection<TmsbatchRequestGroupsToEmployee> TmsbatchRequestGroupsToEmployees { get; set; }
        [InverseProperty("Employee")]
        public virtual ICollection<Tmsrequest> TmsrequestEmployees { get; set; }
        [InverseProperty("LastUpdatedByEmployee")]
        public virtual ICollection<Tmsrequest> TmsrequestLastUpdatedByEmployees { get; set; }
        [InverseProperty("RepresentativeEmployee")]
        public virtual ICollection<Tmsrequest> TmsrequestRepresentativeEmployees { get; set; }
    }
}
