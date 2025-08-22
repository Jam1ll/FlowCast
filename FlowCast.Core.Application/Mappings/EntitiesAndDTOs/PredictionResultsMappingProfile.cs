using AutoMapper;
using FlowCast.Core.Application.DTOs.PredictionResults;
using FlowCast.Core.Domain.Entities;

namespace FlowCast.Core.Application.Mappings.EntitiesAndDTOs
{
    public class PredictionResultsMappingProfile : Profile
    {
        public PredictionResultsMappingProfile()
        {
            CreateMap<PredictionResults, PredictionResultsDTO>().ReverseMap();
        }
    }
}
