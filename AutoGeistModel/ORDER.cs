namespace AutoGeistModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORDER")]
    public partial class ORDER
    {
        public int OrderId { get; set; }

        public int? CustId { get; set; }

        public int? CarId { get; set; }

        public virtual Car Car { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
