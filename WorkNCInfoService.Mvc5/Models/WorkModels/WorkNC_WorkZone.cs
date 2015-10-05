namespace WorkNCInfoService.Mvc5.Models.WorkModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkNC_WorkZone
    {
        [Key]
        public int WorkZoneId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        public int FactoryId { get; set; }

        [StringLength(50)]
        public string FactoryName { get; set; }

        public int MachineId { get; set; }

        [StringLength(100)]
        public string WorkZonePath { get; set; }

        [StringLength(100)]
        public string ModelDataProgramer { get; set; }

        [StringLength(100)]
        public string NCDataProgramer { get; set; }

        public DateTime? ProgramDate { get; set; }

        [StringLength(100)]
        public string ModelName { get; set; }

        [StringLength(100)]
        public string Parts { get; set; }

        [StringLength(100)]
        public string PartName { get; set; }

        [StringLength(10)]
        public string MachiningTimeTotal { get; set; }

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
