using AutoMapper;
using FlowCast.Core.Application.Interfaces;
using FlowCast.Core.Application.ViewModels.PredictionResults;
using Microsoft.AspNetCore.Mvc;

namespace FlowCastApp.Controllers
{
    public class HomeController(IPredictionResultsService predictionResultsService, IMapper mapper) : Controller
    {
        private readonly IPredictionResultsService _predictionResultsService = predictionResultsService;
        private readonly IMapper _mapper = mapper;

        public async Task<IActionResult> Index()
        {
            var lastResults = await _predictionResultsService.GetAll();
            var viewModels = _mapper.Map<List<PredictionResultsViewModel>>(lastResults);

            return View(viewModels);
        }
    }
}
