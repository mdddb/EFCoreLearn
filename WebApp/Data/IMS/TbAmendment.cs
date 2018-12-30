using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_Amendment")]
    public partial class TbAmendment
    {
        [Key]
        public int RefNo { get; set; }
        [Required]
        [StringLength(10)]
        public string BadgeNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime EffDate { get; set; }
        public int TypeCode { get; set; }
        [Required]
        [StringLength(100)]
        public string Remarks { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Expiry { get; set; }
        [StringLength(30)]
        public string ContrRef { get; set; }
        [Column("pFlag")]
        public bool? PFlag { get; set; }
        public short? OldPost { get; set; }
        public short? NewPost { get; set; }
        [Column("OldPRole")]
        [StringLength(8)]
        public string OldProle { get; set; }
        [Column("NewPRole")]
        [StringLength(8)]
        public string NewProle { get; set; }
        public double? OldSal { get; set; }
        public double? NewSal { get; set; }
        [Column("OldOT")]
        public double? OldOt { get; set; }
        [Column("NewOT")]
        public double? NewOt { get; set; }
        [Column("OldOTLump")]
        public double? OldOtlump { get; set; }
        [Column("NewOTLump")]
        public double? NewOtlump { get; set; }
        public double? BonusAmt { get; set; }
        [Column("OldCREA")]
        [StringLength(2)]
        public string OldCrea { get; set; }
        [Column("NewCREA")]
        [StringLength(2)]
        public string NewCrea { get; set; }
        public short? OldLevel { get; set; }
        public short? NewLevel { get; set; }
        public short? OldRotation { get; set; }
        public short? NewRotation { get; set; }
        public double? OldAnnualSal { get; set; }
        public double? NewAnnualSal { get; set; }
        [Column("OldAnnualOT")]
        public double? OldAnnualOt { get; set; }
        [Column("NewAnnualOT")]
        public double? NewAnnualOt { get; set; }
        public double? OldAnnualRotAllow { get; set; }
        public double? NewAnnualRotAllow { get; set; }
        public double? OldAnnualOverseasAllow { get; set; }
        public double? NewAnnualOverseasAllow { get; set; }
        [Column("IFFactor")]
        public double? Iffactor { get; set; }
        [Column("UserID")]
        [StringLength(10)]
        public string UserID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEntered { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }

        [ForeignKey("BadgeNo")]
        [InverseProperty("TbAmendments")]
        public virtual TbEmployee BadgeNoNavigation { get; set; }
        [ForeignKey("NewCrea")]
        [InverseProperty("TbAmendmentNewCreaNavigations")]
        public virtual TbCrea NewCreaNavigation { get; set; }
        [ForeignKey("NewLevel")]
        [InverseProperty("TbAmendmentNewLevelNavigations")]
        public virtual TbJobLevel NewLevelNavigation { get; set; }
        [ForeignKey("NewPost")]
        [InverseProperty("TbAmendmentNewPostNavigations")]
        public virtual TbPosition NewPostNavigation { get; set; }
        [ForeignKey("NewProle")]
        [InverseProperty("TbAmendmentNewProleNavigations")]
        public virtual TbProfRole NewProleNavigation { get; set; }
        [ForeignKey("NewRotation")]
        [InverseProperty("TbAmendmentNewRotationNavigations")]
        public virtual TbRotation NewRotationNavigation { get; set; }
        [ForeignKey("OldCrea")]
        [InverseProperty("TbAmendmentOldCreaNavigations")]
        public virtual TbCrea OldCreaNavigation { get; set; }
        [ForeignKey("OldLevel")]
        [InverseProperty("TbAmendmentOldLevelNavigations")]
        public virtual TbJobLevel OldLevelNavigation { get; set; }
        [ForeignKey("OldPost")]
        [InverseProperty("TbAmendmentOldPostNavigations")]
        public virtual TbPosition OldPostNavigation { get; set; }
        [ForeignKey("OldProle")]
        [InverseProperty("TbAmendmentOldProleNavigations")]
        public virtual TbProfRole OldProleNavigation { get; set; }
        [ForeignKey("OldRotation")]
        [InverseProperty("TbAmendmentOldRotationNavigations")]
        public virtual TbRotation OldRotationNavigation { get; set; }
        [ForeignKey("TypeCode")]
        [InverseProperty("TbAmendments")]
        public virtual TbAmendmentCode TypeCodeNavigation { get; set; }
    }
}
