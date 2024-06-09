using FHB_BLL.DTO.CategoryWithProductDto;
using FHB_BLL.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CategorywithproductController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategorywithproductController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }






    [HttpPost("AddCategoryWithProducts")]
    public IActionResult AddCategoryWithProducts([FromBody] CategoryWithProductsDto categoryWithProductsDto)
    {
        if (categoryWithProductsDto == null)
        {
            return BadRequest("Category data is null.");
        }

        try
        {
            _categoryService.AddCategoryWithProducts(categoryWithProductsDto);
            return Ok(new { message = "Category and products added successfully." });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "An error occurred while adding the category and products.", error = ex.Message });
        }
    }
}



