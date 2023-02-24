using App.Domain.Entities;

namespace App.Application.Repositories.Products;

public interface IReadProductRepository : IReadRepository<Product>
{
    List<GetProductViewModel> GetAll();
    Product GetById(int id);
}
