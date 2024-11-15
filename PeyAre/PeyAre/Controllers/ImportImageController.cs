using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeyAre.Models;

[ApiController]
[Route("api/[controller]")]
public class ImageController : ControllerBase
{
    private readonly Microsoft.EntityFrameworkCore.DbContext _context;

    public ImageController(DbContext context)
    {
        _context = context;
    }

    [HttpPost("upload-image")]
    public async Task<IActionResult> UploadImage([FromBody] byte[] imageData)
    {
        var image = new ImageModel { ImageData = imageData };
        _context.Images.Add(image);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet("get-image")]
    public async Task<IActionResult> GetImage()
    {
        var image = await _context.Images.FirstOrDefaultAsync();
        return image != null ? File(image.ImageData, "image/png") : NotFound();
    }
}
