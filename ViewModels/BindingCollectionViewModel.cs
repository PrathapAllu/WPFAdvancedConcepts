using System.Collections.ObjectModel;
using System.Windows.Input;
using WPFAdvancedConcepts.Modals;
using WPFAdvancedConceptsSupporter.Services;

namespace WPFAdvancedConcepts.ViewModels
{
    public class BindingCollectionViewModel
    {
        public ObservableCollection<ContactInfo> Contacts { get; set; } = new ObservableCollection<ContactInfo>();
        public string Name { get; set; }
        public long Phone { get; set; }

        public ICommand saveContactCommand { get; set; }
        public BindingCollectionViewModel()
        {
            saveContactCommand = new RelayCommand(SaveContact);

            Contacts = new ObservableCollection<ContactInfo>
            {
                new ContactInfo {Name="Vamsi", PhoneNumber= 9998877766},
                new ContactInfo { Name = "John Doe", PhoneNumber = 1234567890 },
                new ContactInfo { Name = "Jane Smith", PhoneNumber = 2345678901 },
                new ContactInfo { Name = "Mike Johnson", PhoneNumber = 3456789012 },
                new ContactInfo { Name = "Sarah Williams", PhoneNumber = 4567890123 }
            };
        }

        private void SaveContact()
        {
            Contacts.Add(new ContactInfo { Name = Name, PhoneNumber = Phone });
        }
    }
}
