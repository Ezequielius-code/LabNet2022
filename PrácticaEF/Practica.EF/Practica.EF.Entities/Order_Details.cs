using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica.EF.Entities
{
    [Table("Order Details")]
    public partial class Order_Details
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }
    }
}
