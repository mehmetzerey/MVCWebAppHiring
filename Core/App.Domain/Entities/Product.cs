namespace App.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; private set; } = string.Empty;

    public bool IsNew { get; private set; }
    public decimal Price { get; private set; }
}
