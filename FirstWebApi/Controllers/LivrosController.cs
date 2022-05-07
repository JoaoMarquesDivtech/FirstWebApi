using FirstWebApi.Entities;
using Lib.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public LivrosController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Livro>> Get()
        {
            var Livros = _context.Livros.ToList();

            if (Livros == null)
                return NotFound();

            return Livros;

        }

        [HttpGet("{id:int}")]
        public ActionResult<Livro> Get(int id)
        {
            var Livro = _context.Livros.FirstOrDefault(tb => tb.Id == id);

            if (Livro == null)
                return NotFound();

            return Livro;

        }




    }
}
