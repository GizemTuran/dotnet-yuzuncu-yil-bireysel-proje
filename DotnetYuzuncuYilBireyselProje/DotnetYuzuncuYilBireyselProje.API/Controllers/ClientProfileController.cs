using AutoMapper;
using DotnetYuzuncuYilBireyselProje.Core.DTOs;
using DotnetYuzuncuYilBireyselProje.Core.Models;
using DotnetYuzuncuYilBireyselProje.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYilBireyselProje.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientProfileController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IClientProfileService _clientProfileService;
        public ClientProfileController(IMapper mapper, IClientProfileService clientProfileService)
        {
            _mapper = mapper;
            _clientProfileService = clientProfileService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var clientProfiles = await _clientProfileService.GetAllAsync();
            var clientProfilesDto = _mapper.Map<List<ClientProfileDto>>(clientProfiles.ToList());
            return CreateActionResult(GlobalResultDto<List<ClientProfileDto>>.Success(200, clientProfilesDto));
        }

        [HttpGet("{id}")]
        // Get api/user/3
        public async Task<IActionResult> GetById(int id)
        {
            var clientProfile = await _clientProfileService.GetById(id);
            var clientProfileDto = _mapper.Map<ClientProfileDto>(clientProfile);
            return CreateActionResult(GlobalResultDto<ClientProfileDto>.Success(200, clientProfileDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ClientProfileDto clientProfileDto)
        {
            var clientProfile = await _clientProfileService.AddAsync(_mapper.Map<ClientProfile>(clientProfileDto));
            var clientProfileDtos = _mapper.Map<ClientProfileDto>(clientProfile);
            return CreateActionResult(GlobalResultDto<ClientProfileDto>.Success(201, clientProfileDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ClientProfileDto clientProfileDto)
        {
            await _clientProfileService.UpdateAsync(_mapper.Map<ClientProfile>(clientProfileDto));
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var userProfile = await _clientProfileService.GetById(id);
            await _clientProfileService.RemoveAsync(userProfile);

            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }
    }
}
