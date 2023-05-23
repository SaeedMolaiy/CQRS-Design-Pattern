using CqrsExample.Commands;
using CqrsExample.Models;
using CqrsExample.Repositories;

namespace CqrsExample.Handlers;

internal class ProductCommandHandler :
        ICommandHandler<RateProduct>
      , ICommandHandler<AddProductToInventory>
{
    private readonly ProductRepository _productRepository;

    public ProductCommandHandler(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void Handle(RateProduct command)
    {
        //Rate Product Using Repository
    }

    public void Handle(AddProductToInventory command)
    {
        //Add Product To Inventory Using Repository
    }
}