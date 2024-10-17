using car_shop.domain.Entities;
using car_shop.domain.DTOs;
using car_shop.infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace car_shop.api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ProductController : ControllerBase
{
    private readonly AppDbContext _db;

    public ProductController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAll()
    {
        var products = await _db.Products.ToListAsync();
        return Ok(products);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<Product>> GetById([FromRoute] int id)
    {
        var product = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
        return Ok(product);
    }

    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct([FromBody] ProductDto productDto)
    {
        var product = new Product
        {
            Make = productDto.Make,
            Model = productDto.Model,
            Price = productDto.Price,
            Stock = productDto.Stock
        };
        
        await _db.Products.AddAsync(product);
        await _db.SaveChangesAsync();
        return Ok();
    }

    [HttpPut]
    public async Task<ActionResult<Product>> UpdateProduct([FromBody] Product product)
    {
        var productToUpdate = await _db.Products.FirstOrDefaultAsync(x => x.Id == product.Id);

        if (productToUpdate == null) return NotFound();
        
        productToUpdate.Make = product.Make;
        productToUpdate.Model = product.Model;
        productToUpdate.Price = product.Price;
        productToUpdate.Stock = product.Stock;

        _db.Products.Update(productToUpdate);
        await _db.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteProduct([FromRoute] int id)
    {
        
        var productToDelete = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);

        if (productToDelete == null) return NotFound();
        
        _db.Products.Remove(productToDelete);
        await _db.SaveChangesAsync();

        return Ok();
    }
}