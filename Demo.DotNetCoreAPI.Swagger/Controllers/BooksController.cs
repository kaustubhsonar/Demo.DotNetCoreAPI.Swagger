using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Demo.DotNetCoreAPI.Swagger.Models;
using Demo.DotNetCoreAPI.Swagger.Repository;

namespace Demo.DotNetCoreAPI.Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookRepository bookRepository = null;
        public BooksController()
        {
            bookRepository = new BookRepository();
        }


        /// <summary>
        /// Get all the books 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = bookRepository.GetAllBooks();
                return Ok(data);
            }
            catch (Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Get book by id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var data = bookRepository.GetBookById(id);
                if (data == null)
                    return NotFound("No books with given Id");
                return Ok(data);
            }
            catch (Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
