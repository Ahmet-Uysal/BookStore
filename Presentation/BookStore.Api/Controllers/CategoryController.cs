using System.Net;
using BookStore.Application.Features.Commands.Category.AddCategory;
using BookStore.Application.Features.Commands.Category.UpdateCategory;
using BookStore.Application.Features.Queries.Category.GetCategories;
using BookStore.Application.Features.Queries.Category.GetCategoriesWithSub;
using BookStore.Application.Repositories.BookRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IBookReadRepository _rep;
        public CategoryController(IMediator mediator, IBookReadRepository rep)
        {
            _mediator = mediator;
            _rep = rep;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddCategoryCommandRequest createProductCommandRequest)
        {
            // await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created, await _mediator.Send(createProductCommandRequest));
        }
        [HttpGet(Name = "GetAllCategories")]
        public async Task<IActionResult> Get()
        {
            // throw new Exception("patladı");
            // await _mediator.Send(createProductCommandRequest);
            // var l = _rep.GetAll().Include(x => x.Category);
            // return Ok(l);
            Thread.Sleep(1500);
            return Ok(await _mediator.Send(new GetCategoriesQueryRequest()));
        }
        [HttpGet("[action]")]
        // [Route("[action]")]
        public async Task<IActionResult> GetAllCategoriesWithSub()
        {
            return Ok(await _mediator.Send(new GetCategoriesWithSubQueryRequest()));
        }

        [HttpPut("[action]")]
        // [Route("[action]")]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryCommandRequest entity)
        {
            return Ok(await _mediator.Send(entity));
        }
    }
}