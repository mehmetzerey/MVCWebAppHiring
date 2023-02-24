namespace App.Application.ModelView.Product;

public class PutProductViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsNew { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
}
