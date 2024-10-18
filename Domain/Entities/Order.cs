namespace Domain.Entities;

public class Order(int id, string customerName, List<OrderItem> items)
{
    public int Id { get; set; } = id;
    public string CustomerName { get; set; } = customerName;
    public List<OrderItem> Items { get; set; } = items;

    public double Total => Items.Sum(item => item.Price * item.Quantity);
}