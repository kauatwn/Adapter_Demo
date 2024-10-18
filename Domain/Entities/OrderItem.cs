namespace Domain.Entities;

public class OrderItem(int id, string productName, int quantity, double price)
{
    public int Id { get; set; } = id;
    public string ProductName { get; set; } = productName;
    public int Quantity { get; set; } = quantity;
    public double Price { get; set; } = price;
}