using AutoMapper;
using DotnetYuzuncuYilBireyselProje.Core.DTOs;
using DotnetYuzuncuYilBireyselProje.Core.Models;
using DotnetYuzuncuYilBireyselProje.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYilBireyselProje.API.Controllers
{
    
    public class StoreController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IStoreService _storeService;

        public StoreController(IMapper mapper, IStoreService storeService)
        {
            _mapper = mapper;
            _storeService = storeService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var stores = await _storeService.GetAllAsync();
            var storeDto = _mapper.Map<List<StoreDto>>(stores.ToList());

            return CreateActionResult(GlobalResultDto<List<StoreDto>>.Success(200,storeDto));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var store = await _storeService.GetById(id);
            var storeDto = _mapper.Map<StoreDto>(store);

            return CreateActionResult(GlobalResultDto<StoreDto>.Success(200, storeDto));

        }
        [HttpPost]
        public async Task<IActionResult> Save(StoreDto storeDto)
        {
            var store = await _storeService.AddAsync(_mapper.Map<Store>(storeDto));
            var storeDtos = _mapper.Map<StoreDto>(store);

            return CreateActionResult(GlobalResultDto<StoreDto>.Success(201, storeDtos));
        }
        [HttpPut]
        public async Task<IActionResult> Update(StoreDto storeDto)
        {
            await _storeService.UpdateAsync(_mapper.Map<Store>(storeDto));
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var store = await _storeService.GetById(id);
            await _storeService.RemoveAsync(store);

            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }
    }
}
