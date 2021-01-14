using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DogrudanTemin.Models
{
    [Table("OlcuBirimleri")]
    public class OLCUBIRIMLERI
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(30), Required]
        public string OlcuBirimAdi { get; set; }

    }
}