namespace OrderViewer.Web.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}