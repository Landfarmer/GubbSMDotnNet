//using System.Web.Mvc;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.ViewEngines;
//using Microsoft.Extensions.Logging;
//using Umbraco.Cms.Core.Web;
//using Umbraco.Cms.Web.Common.Controllers;
//using GubbSMDotnNet.ViewModels;
//using GubbSMDotnNet.Controllers;
//using GubbSMDotnNet.Controllers.BasePage;
//using Umbraco.Cms.Core.Models.PublishedContent;

//namespace GubbSMDotnNet.Controllers.ContentPage
//{
//    public class ContentPageController : 
//	{

//        public ContentPageController(
//            ILogger<RenderController> logger,
//            ICompositeViewEngine compositeViewEngine,
//            IUmbracoContextAccessor umbracoContextAccessor)
//            : base(logger, compositeViewEngine, umbracoContextAccessor)

//         public override ViewResult View(object? model)
//        {
//            return base.View("/Views/ContentPage/Index.cshtml", model);
//        }
//    }
//}