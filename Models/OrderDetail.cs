namespace DemoDeploy.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        // Foreign keys
        public int UserId { get; set; }
        public int OrderId { get; set; }

        // Navigation properties
        public ApplicationUser User { get; set; }
        public Order Order { get; set; }

    }
}
