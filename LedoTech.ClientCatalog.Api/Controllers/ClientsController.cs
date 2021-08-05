using LedoTech.ClientCatalog.Api.Helper;
using LedoTech.ClientCatalog.Application.InputModels;
using LedoTech.ClientCatalog.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LedoTech.ClientCatalog.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/clients")]
    public class ClientsController : Controller
    {
        private readonly IClientAppService clientAppService;

        public ClientsController(IClientAppService courseAppService) => this.clientAppService = courseAppService;

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClientInputModel clientInputModel)
        {
            if (string.IsNullOrEmpty(clientInputModel.RazaoSocial))
            {
                return BadRequest("Razão Social Obrigatória");
            }

            if (string.IsNullOrEmpty(clientInputModel.CNPJ))
            {
                return BadRequest("CNPJ Obrigatório");
            }

            if (!Validator.IsCnpj(clientInputModel.CNPJ))
            {
                return BadRequest("CNPJ inválido");
            }            

            await clientAppService.Register(clientInputModel);
            return Accepted();
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ClientInputModel clientInputModel)
        {
            var result = await clientAppService.Get(clientInputModel.Codigo);

            if (result != null)
            {
                if (string.IsNullOrEmpty(clientInputModel.CNPJ))
                {
                    return BadRequest("CNPJ Obrigatório");
                }

                if (string.IsNullOrEmpty(clientInputModel.RazaoSocial))
                {
                    return BadRequest("Razão Social Obrigatória");
                }

                if (!Validator.IsCnpj(clientInputModel.CNPJ))
                {
                    return BadRequest("CNPJ inválido");
                }

                await clientAppService.Update(clientInputModel);
                return Accepted("Registro Alterado");
            }
            else
            {
                return BadRequest("Registro não encontrado");
            }
        }
        [HttpDelete("{codigo}")]
        public async Task<IActionResult> Delete(long codigo)
        {
            var result = await clientAppService.Get(codigo);

            if (result != null)
            {
                await clientAppService.Remove(codigo);
                return Accepted("Registro removido");
            }
            else
            {
                return BadRequest("Registro não encontrado");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await clientAppService.GetAllClients();

            if (result.Any())
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Nenhum registro encontrado.");
            }
        }

        [HttpGet("{codigo}", Name = "Get")]
        public async Task<IActionResult> Get(long codigo)
        {
            var result = await clientAppService.Get(codigo);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Registro não encontrado");

            }

        }
    }
}
