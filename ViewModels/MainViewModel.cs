namespace WPFAdvancedConcepts.ViewModels
{
    public class MainViewModel
    {      
        public SimpleBindingViewModel SimpleBindingVM { get; set; } = new SimpleBindingViewModel();
        public BindingCollectionViewModel BindingCollectionVM { get; set; } = new BindingCollectionViewModel();
    }
}
