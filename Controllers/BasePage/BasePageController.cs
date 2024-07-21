using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;


namespace GubbSMDotnNet.Controllers.BasePage
{
    public abstract class BasePageController<TModel> : RenderController where TModel : PublishedContentModel
    {
        protected BasePageController(

            ILogger<RenderController> logger,
            ICompositeViewEngine compositeViewEngine,
            IUmbracoContextAccessor umbracoContextAccessor)
            : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
        }

        public override IActionResult Index()
        {
            // Your implementation here
            return base.View($"~/Views/{CurrentPage?.ContentType.Alias}/Index.cshtml");
        }
    }
}