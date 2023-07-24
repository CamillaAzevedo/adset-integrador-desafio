using AdsetIntegrador.MVC.ViewModels;
using AdsetIntegrator.Domain.Entities;
using AutoMapper;

namespace AdsetIntegrador.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public DomainToViewModelMappingProfile()
        {
            CreateMap<VeiculoViewModel, Veiculo>();
            CreateMap<ItemDeSerieViewModel, ItemDeSerie>();
        }
    }
}
