using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIPrueba.Models;
using WebAPIPrueba.Data; // Agrega esta directiva para obtener el contexto de la base de datos

namespace WebAPIPrueba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly ProductoDb _context; // Cambia el tipo de DbContext a ProductoDb

        public ProductosController(ILogger<ProductosController> logger, ProductoDb context) // Cambia DbContext a ProductoDb
        {
            _context = context;
        }

        [HttpGet(Name = "GetProductos")]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
        {
            return await _context.Productos.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetProducto")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
            {
                return NotFound();
            }

            return producto;
        }

        [HttpPut("{id}", Name = "PutProducto")]
        public async Task<IActionResult> PutProducto(int id, Producto producto)
        {
            if (id != producto.Id)
            {
                return BadRequest();
            }

            _context.Entry(producto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ProductoExists(id)) 
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private async Task<bool> ProductoExists(int id)
        {
            return await _context.Productos.AnyAsync(e => e.Id == id);
        }

        [HttpPost(Name = "PostProducto")]
        public async Task<ActionResult<Producto>> PostProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducto", new { id = producto.Id }, producto);
        }

        [HttpDelete("{id}", Name = "DeleteProducto")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
