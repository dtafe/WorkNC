namespace WorkNCInfoService.Mvc5.Models.WorkModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Profile
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        [StringLength(4000)]
        public string PropertyNames { get; set; }

        [Required]
        [StringLength(4000)]
        public string PropertyValueStrings { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] PropertyValueBinary { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public virtual User User { get; set; }
    }
}
