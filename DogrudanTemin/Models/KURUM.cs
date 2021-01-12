namespace DogrudanTemin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KURUM")]
    public partial class KURUM
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string kurumadi { get; set; }

        [StringLength(50)]
        public string parola { get; set; }
    }
}
