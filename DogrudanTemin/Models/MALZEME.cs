namespace DogrudanTemin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MALZEME")]
    public partial class MALZEME
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MalzemeCinsi { get; set; }

        [StringLength(255)]
        public string MalzemeOzellikleri { get; set; }

        public int? Miktari { get; set; }

        [StringLength(50)]
        public string OlcuBirimi { get; set; }

        public double? KdvOrani { get; set; }
    }
}
