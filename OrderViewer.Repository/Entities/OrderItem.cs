using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderViewer.Repository.Entities
{
    [Table("OrderItem", Schema = "dbo")]
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int ParentOrder { get; set; }
        [ForeignKey("ParentOrder")]
        public Order Order { get; set; }
    }
}
