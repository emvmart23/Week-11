namespace Week_11.Models
{
    public class Detail
    {
        public int DetailId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Invoice Invoices { get; set; } 
        public int Amount { get; set; }
        public float Price { get; set; }
        public float Subtotal { get; set; }
       
    }
}
