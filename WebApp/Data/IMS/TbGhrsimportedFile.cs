using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.IMS
{
[Table("tb_GHRSImportedFiles")]
    public partial class TbGhrsimportedFile
    {
        [Column("id")]
        public int ID { get; set; }
        [Column("File_name")]
        [StringLength(50)]
        public string FileName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ImportDate { get; set; }
        [Column("Status_ID")]
        public int? StatusID { get; set; }
        [Column("Error_Message")]
        [StringLength(500)]
        public string ErrorMessage { get; set; }
    }
}
