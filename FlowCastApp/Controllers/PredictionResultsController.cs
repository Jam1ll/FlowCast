using AutoMapper;
using FlowCast.Core.Application.DTOs.PredictionData;
using FlowCast.Core.Application.Interfaces;
using FlowCast.Core.Application.ViewModels.PredictionData;
using Microsoft.AspNetCore.Mvc;

namespace FlowCastApp.Controllers
{
    public class PredictionResultsController(IPredictionResultsService predictionResultsService, IMapper mapper) : Controller
    {
        private readonly IPredictionResultsService _predictionResultsService = predictionResultsService;
        private readonly IMapper _mapper = mapper;

        public async Task<IActionResult> Index(PredictionDataViewModel viewModel)
        {
            if (viewModel == null)
                return RedirectToRoute(new { controller = "PredictionData", action = "Index" });

            var dto = _mapper.Map<PredictionDataDTO>(viewModel);
            var results = await _predictionResultsService.CalculateResults(dto);
            return View(results);
        }
    }
}
