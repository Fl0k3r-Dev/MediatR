using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Requests;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        private IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create([FromBody] CreateCustomerRequest command)
        {
            return _mediator.Send(command);
        }
    }
}
