using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Domain.Commands.Requests
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse >
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //Verifica se o cliente já está cadastrado
            //Valida os dados
            //Insere cliente
            //Envia e-mail de boas-vindas
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Gustavo Ranci",
                Email = "rancigustavo@gmail.com",
                Date = DateTime.Now,
            };

            return Task.FromResult(result);
        }
    }
}
