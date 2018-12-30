using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_StaffMovement")]
    public partial class TbStaffMovement
    {
        [Column("ID")]
        public int ID { get; set; }
        public int RefNo { get; set; }
        [Required]
        [StringLength(10)]
        public string BadgeNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime EffDate { get; set; }
        [Column("OldBU")]
        [StringLength(6)]
        public string OldBu { get; set; }
        [Column("NewBU")]
        [StringLength(6)]
        public string NewBu { get; set; }
        public short? NewWorkLoc { get; set; }
        public short? OldWorkLoc { get; set; }
        public short? OldPost { get; set; }
        public short? NewPost { get; set; }
        [StringLength(50)]
        public string OldDept { get; set; }
        [StringLength(50)]
        public string NewDept { get; set; }
        [Column("OldOCC")]
        [StringLength(6)]
        public string OldOcc { get; set; }
        [Column("NewOCC")]
        [StringLength(6)]
        public string NewOcc { get; set; }
        [StringLength(10)]
        public string OldProj { get; set; }
        [StringLength(10)]
        public string NewProj { get; set; }
        [StringLength(50)]
        public string OldSection { get; set; }
        [StringLength(50)]
        public string NewSection { get; set; }
        [Column("OldPRole")]
        [StringLength(8)]
        public string OldProle { get; set; }
        [Column("NewPRole")]
        [StringLength(8)]
        public string NewProle { get; set; }
        public short? OldRotation { get; set; }
        public short? NewRotation { get; set; }
        [StringLength(100)]
        public string Remarks { get; set; }
        public bool? Posted { get; set; }
        [Column("UserID")]
        [StringLength(10)]
        public string UserID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEntered { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }

        [ForeignKey("BadgeNo")]
        [InverseProperty("TbStaffMovements")]
        public virtual TbEmployee BadgeNoNavigation { get; set; }
        [ForeignKey("NewBu")]
        [InverseProperty("TbStaffMovementNewBuNavigations")]
        public virtual TbBussUnit NewBuNavigation { get; set; }
        [ForeignKey("NewOcc")]
        [InverseProperty("TbStaffMovementNewOccNavigations")]
        public virtual TbCostCenter NewOccNavigation { get; set; }
        [ForeignKey("NewPost")]
        [InverseProperty("TbStaffMovementNewPostNavigations")]
        public virtual TbPosition NewPostNavigation { get; set; }
        [ForeignKey("NewProle")]
        [InverseProperty("TbStaffMovementNewProleNavigations")]
        public virtual TbProfRole NewProleNavigation { get; set; }
        [ForeignKey("NewRotation")]
        [InverseProperty("TbStaffMovementNewRotationNavigations")]
        public virtual TbRotation NewRotationNavigation { get; set; }
        [ForeignKey("NewWorkLoc")]
        [InverseProperty("TbStaffMovementNewWorkLocNavigations")]
        public virtual TbWorkLocation NewWorkLocNavigation { get; set; }
        [ForeignKey("OldBu")]
        [InverseProperty("TbStaffMovementOldBuNavigations")]
        public virtual TbBussUnit OldBuNavigation { get; set; }
        [ForeignKey("OldOcc")]
        [InverseProperty("TbStaffMovementOldOccNavigations")]
        public virtual TbCostCenter OldOccNavigation { get; set; }
        [ForeignKey("OldPost")]
        [InverseProperty("TbStaffMovementOldPostNavigations")]
        public virtual TbPosition OldPostNavigation { get; set; }
        [ForeignKey("OldProle")]
        [InverseProperty("TbStaffMovementOldProleNavigations")]
        public virtual TbProfRole OldProleNavigation { get; set; }
        [ForeignKey("OldRotation")]
        [InverseProperty("TbStaffMovementOldRotationNavigations")]
        public virtual TbRotation OldRotationNavigation { get; set; }
        [ForeignKey("OldWorkLoc")]
        [InverseProperty("TbStaffMovementOldWorkLocNavigations")]
        public virtual TbWorkLocation OldWorkLocNavigation { get; set; }
    }
}
