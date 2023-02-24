using App.Application.ModelView.Product;

namespace App.Application.ModelView.ProductCategory;

public class GetProductCategoryViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<GetProductViewModel> Product { get; set; }
}
