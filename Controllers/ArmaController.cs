using Microsoft.AspNetCore.Mvc;
using RpgApi.Data;
using Microsoft.EntityFrameworkCore;
using RpgApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("arma")]
    public class ArmaController : ControllerBase
    {
        private readonly DataContext _context;

        public ArmaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var armas = await _context.TB_ARMAS.ToListAsync();
            return Ok(armas);
        }

        [HttpPost("Inserir")]
        public async Task<IActionResult> Add(Armas novaArma)    {
        try
        {
            if (novaArma.DanoF > 100)
            {
                throw new Exception("Dano não pode ser maior que 100");
            }
            await _context.TB_ARMAS.AddAsync(novaArma);
            await _context.SaveChangesAsync();

            return Ok(novaArma.IdF);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

[HttpPut]
        public async Task<IActionResult> Update(Armas novaArma)
    {
        try
        {
            if (novaArma.DanoF > 100)
            {
                throw new Exception("Pontos de vida não pode ser maior que 100");
            }
            _context.TB_ARMAS.Update(novaArma);
            int linhasAfetadas = await _context.SaveChangesAsync();
            
            return Ok(linhasAfetadas);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{IdF}")]
    public async Task<IActionResult> GetSingle(int IdF)
    {
        try
        {
            Armas a = await _context.TB_ARMAS
                    .FirstOrDefaultAsync(pBusca => pBusca.IdF == IdF);

            return Ok(a);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
        [HttpDelete("{IdF}")]
        public async Task<IActionResult> Delete(int IdF)
    {
        try
        {
            Armas aRemover = await _context.TB_ARMAS.FirstOrDefaultAsync(a => a.IdF == IdF);

            _context.TB_ARMAS.Remove(aRemover);
            int linhasAfetadas  = await _context.SaveChangesAsync();
            
            return Ok(linhasAfetadas);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }    
    }

    }
}
