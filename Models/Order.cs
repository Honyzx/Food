namespace Models;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public List<MenuItem> MenuItems { get; set; }
    public string DeliveryStatus { get; set; } // Может быть "В обработке", "Доставка", "Доставлено"
}
