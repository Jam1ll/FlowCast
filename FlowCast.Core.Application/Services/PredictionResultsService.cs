using AutoMapper;
using FlowCast.Core.Application.DTOs.PredictionData;
using FlowCast.Core.Application.DTOs.PredictionResults;
using FlowCast.Core.Application.Interfaces;
using FlowCast.Core.Domain.Common.Enums;
using FlowCast.Core.Domain.Entities;
using FlowCast.Core.Domain.Interfaces;

namespace FlowCast.Core.Application.Services
{
    public class PredictionResultsService(IPredictionResultsRepository predictionResultsRepository, IMapper mapper) : 
        GenericService<PredictionResults, PredictionResultsDTO>(predictionResultsRepository, mapper), IPredictionResultsService
    {
        private readonly IPredictionResultsRepository _predictionResultsRepository = predictionResultsRepository;
        private new readonly IMapper _mapper = mapper;

        public async Task<PredictionResultsDTO> CalculateResults(PredictionDataDTO dto)
        {
            switch (dto.PredictionMode)
            {
                case PredictionMode.SMA:
                    decimal shortSMA = 0;
                    decimal longSMA = 0;

                    for (int i = 0; i < 20; i++)
                    {
                        if (i >= 14)
                        {
                            shortSMA += dto.Values[i];
                        }
                        longSMA += dto.Values[i];
                    }
                    shortSMA /= 5;
                    longSMA /= 20;

                    if (shortSMA > longSMA)
                    {
                        var newResult = new PredictionResultsDTO()
                        {
                            Id = 0,
                            Description = $"Bullish Trend: Short SMA ({shortSMA}) > Long SMA ({longSMA})",
                            DateAdded = DateTime.Now,
                            PredictionMode = dto.PredictionMode,
                            PredictionDataId = dto.Id,
                            PredictionData = dto
                        };

                        var entity = _mapper.Map<PredictionResults>(newResult);
                        await _predictionResultsRepository.AddAsync(entity);
                        return newResult;
                    }

                    else
                    {
                        var newResult = new PredictionResultsDTO()
                        {
                            Id = 0,
                            Description = $"Downward Trend: Long SMA ({longSMA}) > Short SMA ({shortSMA})",
                            DateAdded = DateTime.Now,
                            PredictionMode = dto.PredictionMode,
                            PredictionDataId = dto.Id,
                            PredictionData = dto
                        };

                        var entity = _mapper.Map<PredictionResults>(newResult);
                        await _predictionResultsRepository.AddAsync(entity);
                        return newResult;
                    }

                case PredictionMode.LINEAR_REGRESSION:

                    decimal x;
                    decimal y;
                    decimal Ex = 0m;
                    decimal Ey = 0m;
                    decimal xy;
                    decimal Exy = 0m;
                    decimal x2;
                    decimal Ex2 = 0m;

                    for (int i = 0; i < 20; i++)
                    {
                        x = i + 1m;
                        Ex += x;

                        y = dto.Values[i];
                        Ey += y;

                        xy = x * y;
                        Exy += xy;

                        x2 = x * x;
                        Ex2 += x2;
                    }

                    decimal mX = Ex / 20m;
                    decimal mY = Ey / 20m;

                    decimal m = (Exy - ((Ex * Ey) / 20m)) / (Ex2 - ((Ex * Ex) / 20m));
                    decimal b = mY - m * mX;

                    decimal results = (m * 21m) + b;


                    if (m > 0)
                    {
                        var newResult = new PredictionResultsDTO()
                        {
                            Id = 0,
                            Description = $"21 value: {results} | bullish Trend ({m} > 0)",
                            DateAdded = DateTime.Now,
                            PredictionMode = dto.PredictionMode,
                            PredictionDataId = dto.Id,
                            PredictionData = dto
                        };

                        var entity = _mapper.Map<PredictionResults>(newResult);
                        await _predictionResultsRepository.AddAsync(entity);
                        return newResult;
                    }
                    else if (m == 0)
                    {
                        var newResult = new PredictionResultsDTO()
                        {
                            Id = 0,
                            Description = $"21 value: {results} | Constant Trend ({m} == 0)",
                            DateAdded = DateTime.Now,
                            PredictionMode = dto.PredictionMode,
                            PredictionDataId = dto.Id,
                            PredictionData = dto
                        };

                        var entity = _mapper.Map<PredictionResults>(newResult);
                        await _predictionResultsRepository.AddAsync(entity);
                        return newResult;
                    }
                    else
                    {
                        var newResult = new PredictionResultsDTO()
                        {
                            Id = 0,
                            Description = $"21 value: {results} | Downward Trend ({m} < 0)",
                            DateAdded = DateTime.Now,
                            PredictionMode = dto.PredictionMode,
                            PredictionDataId = dto.Id,
                            PredictionData = dto
                        };

                        var entity = _mapper.Map<PredictionResults>(newResult);
                        await _predictionResultsRepository.AddAsync(entity);
                        return newResult;
                    }
                default:
                    return null;
            }
        }
    }
}
