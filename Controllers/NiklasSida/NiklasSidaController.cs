using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using GubbSMDotnNet.ViewModels;
using GubbSMDotnNet.Controllers;
using GubbSMDotnNet.Controllers.BasePage;
using Umbraco.Cms.Core.Models.PublishedContent;



namespace GubbSMDotnNet.Controllers.NiklasSida
{
    [Route("StartPage")]
    public class NiklasSidaController : BasePageController<PublishedContentModel>
    {
        public NiklasSidaController(
            ILogger<RenderController> logger,
            ICompositeViewEngine compositeViewEngine,
            IUmbracoContextAccessor umbracoContextAccessor)
            : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            // Constructor body
        }

        [HttpGet]
        [Route("Index")]
        public override ViewResult Index()
        {
            return base.View("Views/NiklasSida/Index.cshtml");
        }
    }
}