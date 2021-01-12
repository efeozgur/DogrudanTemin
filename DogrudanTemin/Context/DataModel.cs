using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DogrudanTemin.Models
{
    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<ANTET> Antet { get; set; }
        public virtual DbSet<KANITLAYICI> Kanitlayici { get; set; }
        public virtual DbSet<KISILER> Kisiler { get; set; }
        public virtual DbSet<KURUM> Kurum { get; set; }
        public virtual DbSet<MALZEME> Malzeme { get; set; }

    }
}
