using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolOf.Data.Abstraction;
using SchoolOf.Data.Models;
using SchoolOf.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace SchoolOf.ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), 200)]
        public async Task<IActionResult> GetProducts()
        {
            throw new System.Exception();

            var myListOfProducts = new List<ProductDto>();
            var productsFromDb = this._unitOfWork.GetRepository<Product>().Find(product => !product.IsDeleted);

            foreach(var p in productsFromDb)
            {
                myListOfProducts.Add(new ProductDto {
                    Category = p.Category,
                    Description = p.Description,
                    Id = p.Id,
                    Image = p.Image,
                    Name = p.Name,
                    Price = p.Price
                });
            }

            return Ok(myListOfProducts);
        }

        [HttpGet]
        [Route("{pageNumber}/{pageSize}")]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), 200)]
        public async Task<IActionResult> GetPaginatedProducts(int pageNumber = 1, int pageSize = 10)
        {
            var productsFromDb = this._unitOfWork.GetRepository<Product>().Find(product => !product.IsDeleted, (pageNumber - 1) * pageSize, pageSize);

            var myListOfProducts = _mapper.Map<List<ProductDto>>(productsFromDb);

            return Ok(myListOfProducts);

        }
    }
}
