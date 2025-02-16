using System.Drawing;
using PropertyChanged;
using WPFAdvancedConceptsSupporter;

namespace WPFAdvancedConcepts.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class SimpleBindingViewModel
    {
        public List<Color> Colors { get; set; }
        public List<string> ColorNames { get; set; }

        public string SelectedColor { get; set; }

        public SimpleBindingViewModel()
        {
            ColorNames = new List<string>();
            getColorData();
        }

        public async void getColorData()
        {
            Colors = await DataSupporter.GetDataForSimpleBinding();

            foreach (var color in Colors)
            {
                ColorNames.Add(color.Name);
            }
        }
    }
}
