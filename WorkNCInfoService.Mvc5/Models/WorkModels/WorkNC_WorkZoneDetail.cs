namespace WorkNCInfoService.Mvc5.Models.WorkModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkNC_WorkZoneDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkZoneId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkZoneDetailId { get; set; }

        [StringLength(50)]
        public string No { get; set; }

        [StringLength(100)]
        public string PathType { get; set; }

        public double? ToolLenth { get; set; }

        public double? Tno { get; set; }

        public double? StockAllowance { get; set; }

        public double? Tolerance { get; set; }

        [StringLength(100)]
        public string NCFileName { get; set; }

        [StringLength(10)]
        public string MachineTime { get; set; }

        public double? MachineDistance { get; set; }

        [StringLength(255)]
        public string ToolShape { get; set; }

        public double? ToolDia { get; set; }

        public double? ToolConerR { get; set; }

        [StringLength(255)]
        public string HolderName { get; set; }

        public double? Spindle { get; set; }

        public double? CuttingFeedRate { get; set; }

        public double? ApproachFeedRate { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        public int Status { get; set; }

        [StringLength(250)]
        public string ImageFile { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateAccount { get; set; }

        public DateTime ModifiedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ModifiedAccount { get; set; }
    }
}
