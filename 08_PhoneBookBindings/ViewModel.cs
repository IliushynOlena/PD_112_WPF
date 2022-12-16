using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _08_PhoneBookBindings
{
    public class ViewModel
    {
        ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
      
        public IEnumerable<Contact> Contacts => contacts;
        public Contact SelectedContact { get; set; }


        public ViewModel()
        {
            contacts.Add(new Contact() { Name = "Vova", Age = 30, Surname = "Pupkin", Phone = "+3807575828", IsMale = true });
            contacts.Add(new Contact() { Name = "Marusia", Age = 25, Surname = "Shishik", Phone = "+380771244", IsMale = false });
            contacts.Add(new Contact() { Name = "Olga", Age = 33, Surname = "Shelesh", Phone = "+38067285792", IsMale = false });
        }
        public void DeleteSelected()
        {
            if (SelectedContact != null)
                contacts.Remove(SelectedContact);
        }

    }
}
