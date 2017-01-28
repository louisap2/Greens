namespace Greens
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Green
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string name { get; set; }

        [Required]
        [StringLength(40)]
        public string type { get; set; }

        public int price { get; set; }
    }
}
