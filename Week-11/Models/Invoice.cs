namespace Week_11.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public String InvoiceNumber { get; set; }
        public float Total { get; set; }
    }
}
