using AutoMapper;
using FlowCast.Core.Application.DTOs.PredictionData;
using FlowCast.Core.Application.Interfaces;
using FlowCast.Core.Application.ViewModels.PredictionData;
using FlowCast.Core.Domain.Common.Enums;
using Microsoft.AspNetCore.Mvc;

namespace FlowCastApp.Controllers
{
    public class PredictionDataController(IPredictionDataService predictionDataService, IMapper mapper) : Controller
    {
        private readonly IPredictionDataService _predictionDataService = predictionDataService;
        private readonly IMapper _mapper = mapper;

        public async Task<IActionResult> Index()
        {
            var dto = await _predictionDataService.GetAll();
            var viewModels =  _mapper.Map<List<PredictionDataViewModel>>(dto);
            return View(viewModels);
        }
        public IActionResult Create()
        {
            ViewBag.EditMode = false;
            var viewModel = new SavePredictionDataViewModel { Id = 0, PredictionMode = PredictionMode.SMA, Values = [] };
            return RedirectToRoute("Save", viewModel);
        }
      
        [HttpPost]
        public async Task<IActionResult> Create(SavePredictionDataViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return RedirectToRoute("Save", viewModel);

            var dto = _mapper.Map<PredictionDataDTO>(viewModel);
            await _predictionDataService.AddAsync(dto);

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.EditMode = true;
            
            var foundPredictionData = await _predictionDataService.GetById(id);
          
            if (foundPredictionData == null)
                return RedirectToAction("Index");
           
            var viewModel = _mapper.Map<SavePredictionDataViewModel>(foundPredictionData);

            return View("Save", viewModel);
        }
      
        [HttpPost]
        public async Task<IActionResult> Edit(SavePredictionDataViewModel viewModel)
        {
            if(ModelState.IsValid)
                return RedirectToRoute("Save", viewModel);

            var dto = _mapper.Map<PredictionDataDTO>(viewModel);
            await _predictionDataService.UpdateAsync(dto, dto.Id);

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            var foundPredictionData = await _predictionDataService.GetById(id);
            if (foundPredictionData == null)
                return RedirectToAction("Index");

            var viewModel = _mapper.Map<DeletePredictionDataViewModel>(foundPredictionData);
            
            return View(viewModel);
        }
     
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _predictionDataService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
