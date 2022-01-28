using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms_Settings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerPage : ContentPage
    {
        public class GetData
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public PickerPage()
        {
            InitializeComponent();
            foreach (var item in DataCon())
            {
                CodeData.Items.Add(item.Name);
            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contactmethod =  ContactMethod.Items[ContactMethod.SelectedIndex];
            DisplayAlert("Selection", contactmethod, "Cancel");
        }

        private IList<GetData> DataCon()
        {
            return new List<GetData> {

                new GetData { Id = 1, Name = "SMS"},
                new GetData { Id = 2, Name = "Data"},
                new GetData { Id = 3, Name = "Whatsappp"},
                new GetData { Id = 4, Name = "GB"}

            };
        }
    }
}