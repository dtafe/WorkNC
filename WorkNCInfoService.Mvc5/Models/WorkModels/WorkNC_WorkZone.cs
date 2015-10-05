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
        [Display(Name = "WorkZone Name")]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        [StringLength(50)]
        [Display(Name = "Company")]
        public string CompanyName { get; set; }

        public int FactoryId { get; set; }

        [StringLength(50)]
        [Display(Name = "Factory")]
        public string FactoryName { get; set; }

        public int MachineId { get; set; }

        [StringLength(100)]
        public string WorkZonePath { get; set; }

        [StringLength(100)]
        [Display(Name = "Model Data Programer")]
        public string ModelDataProgramer { get; set; }

        [StringLength(100)]
        [Display(Name = "NC Data Programer")]
        public string NCDataProgramer { get; set; }

        [Display(Name = "Program date")]
        public DateTime? ProgramDate { get; set; }

        [StringLength(100)]
        [Display(Name = "Model name")]
        public string ModelName { get; set; }

        [StringLength(100)]
        [Display(Name = "Parts")]
        public string Parts { get; set; }

        [StringLength(100)]
        [Display(Name = "Parts Name")]
        public string PartName { get; set; }

        [StringLength(10)]
        [Display(Name = "Machining Time Total")]
        public string MachiningTimeTotal { get; set; }

        [StringLength(255)]
        [Display(Name = "Comment")]
        public string Comment { get; set; }

        [Display(Name = "Status")]
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
