using AutoMapper;
using DotnetYuzuncuYilBireyselProje.Core.DTOs;
using DotnetYuzuncuYilBireyselProje.Core.Models;
using DotnetYuzuncuYilBireyselProje.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYilBireyselProje.API.Controllers
{
    public class ClientController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IClientService _clientService;
        public ClientController(IMapper mapper, IClientService clientService)
        {
            _mapper = mapper;
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var clients = await _clientService.GetAllAsync();
            var clientDto = _mapper.Map<List<ClientDto>>(clients.ToList());
            return CreateActionResult(GlobalResultDto<List<ClientDto>>.Success(200, clientDto));
        }

        [HttpGet("{id}")]
        // Get api/user/3
        public async Task<IActionResult> GetById(int id)
        {
            var client = await _clientService.GetById(id);
            var clientDto = _mapper.Map<ClientDto>(client);
            return CreateActionResult(GlobalResultDto<ClientDto>.Success(200, clientDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ClientDto clientDto)
        {
            await _clientService.UpdateAsync(_mapper.Map<Client>(clientDto));
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var client = await _clientService.GetById(id);
            await _clientService.RemoveAsync(client);

            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }

    }
}
