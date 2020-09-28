using SitecoreForms.Feature.Hero.Factories;
using SitecoreForms.Feature.Hero.Services;
using SitecoreForms.Feature.Hero.ViewModels;
using SitecoreForms.Foundation.Core.Models;
using SitecoreForms.Foundation.Core.Services;

namespace SitecoreForms.Feature.Hero.Mediators
{
    public class HeroMediator : IHeroMediator
    {
        private readonly IHeroService _heroService;
        private readonly IMediatorService _mediatorService;
        private readonly IHeroViewModelFactory _heroViewModelFactory;

        public HeroMediator(IHeroService heroService, IMediatorService mediatorService,
            IHeroViewModelFactory heroViewModelFactory)
        {
            _heroService = heroService;
            _mediatorService = mediatorService;
            _heroViewModelFactory = heroViewModelFactory;
        }

        /// <summary>
        ///     Mediator pattern is overkill in this instance, but here as an example to return response codes to a controller, and
        ///     keep the controller dumb as a result
        /// </summary>
        /// <returns>A mediator response with the result of the view model instantiation</returns>
        public MediatorResponse<HeroViewModel> RequestHeroViewModel()
        {
            var heroItemDataSource = _heroService.GetHeroItems();

            if (heroItemDataSource == null)
                return _mediatorService.GetMediatorResponse<HeroViewModel>(MediatorCodes.HeroResponse.DataSourceError);

            var viewModel =
                _heroViewModelFactory.CreateHeroViewModel(heroItemDataSource, _heroService.IsExperienceEditor);

            if (viewModel == null)
                return _mediatorService.GetMediatorResponse<HeroViewModel>(MediatorCodes.HeroResponse.ViewModelError);

            return _mediatorService.GetMediatorResponse(MediatorCodes.HeroResponse.Ok, viewModel);
        }
    }
}
