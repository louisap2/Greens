namespace Greens
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Purchases_details
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int purchase_id { get; set; }

        public int greens_id { get; set; }

        public int amount { get; set; }

        public int total_price { get; set; }
    }
}
