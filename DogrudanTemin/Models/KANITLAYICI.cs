namespace DogrudanTemin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KANITLAYICI")]
    public partial class KANITLAYICI
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string KanitlayiciBelgeAdi { get; set; }
    }
}
