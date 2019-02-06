namespace Hookah.Bar.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hookah")]
    public partial class Hookah
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Hookah_name { get; set; }

        [Key]
        [Column(Order = 2)]
        public double Price { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string Description { get; set; }
    }
}
