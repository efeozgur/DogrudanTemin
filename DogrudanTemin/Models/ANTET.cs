namespace DogrudanTemin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ANTET")]
    public partial class ANTET
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string SATIR1 { get; set; }

        [StringLength(100)]
        public string SATIR2 { get; set; }

        [StringLength(100)]
        public string SATIR3 { get; set; }
    }
}
