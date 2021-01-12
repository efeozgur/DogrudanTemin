namespace DogrudanTemin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KISILER")]
    public partial class KISILER
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string kisiAdi { get; set; }

        [StringLength(50)]
        public string unvani { get; set; }
    }
}
