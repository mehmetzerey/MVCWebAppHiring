namespace App.Application.Repositories.ProductCategories;

public interface IWriteProductCategoryRepository : IWriteRepository<ProductCategory>
{
    Task<ServiceResponse> Create(CreateProductCategoryViewModel model);
    Task<ServiceResponse> UpdateProduct(CreateProductCategoryViewModel model);
    Task<ServiceResponse> DeleteProduct(CreateProductCategoryViewModel model);
}
