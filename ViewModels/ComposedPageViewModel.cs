using Umbraco.Cms.Core.Models.PublishedContent;

namespace GubbSMDotnNet.ViewModels;

public class ComposedPageViewModel<TPage, TViewModel> where TPage : PublishedContentModel
{
    public TPage? Page { get; set; }
    public TViewModel? ViewModel { get; set; }
}