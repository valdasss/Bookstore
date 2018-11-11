namespace BookStore.EntityCore.Entity
{
    public class OrderItemEntity
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }

        public virtual OrderEntity Order { get; set; }
        public virtual BookEntity Book { get; set; }
    }
}
