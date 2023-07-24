using AdsetIntegrato.MVC.ViewModels;
using AutoMapper;


namespace AdsetIntegrato.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMapping"; }
        }

        public DomainToViewModelMappingProfile()
        {
            var configuration = new MapperConfiguration(cfg => {
                cfg.CreateMap<VeiculoViewModel, Veiculo>();
                cfg.CreateMap<ItemDeSerieViewModel, ItemDeSerie>();
            });

        }
    }
}