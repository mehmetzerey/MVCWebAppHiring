namespace App.Application.Repositories.ProductCategories;

public interface IReadProductCategoryRepository : IReadRepository<ProductCategory>
{
    List<GetProductCategoryViewModel> GetAll();
    ProductCategoryViewModel GetById(int id);
}
