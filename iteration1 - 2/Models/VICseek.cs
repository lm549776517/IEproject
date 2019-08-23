namespace iteration1___2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VICseek")]
    public partial class VICseek
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string category { get; set; }

        [StringLength(200)]
        public string city { get; set; }

        [StringLength(200)]
        public string company_name { get; set; }

        [StringLength(20)]
        public string geo { get; set; }

        [StringLength(10)]
        public string iob_board { get; set; }

        [StringLength(200)]
        public string iob_title { get; set; }

        [StringLength(30)]
        public string iob_type { get; set; }

        [StringLength(200)]
        public string post_date { get; set; }

        [StringLength(200)]
        public string state_1 { get; set; }

        [StringLength(200)]
        public string url_1 { get; set; }
    }
}
