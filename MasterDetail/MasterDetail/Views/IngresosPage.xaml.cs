using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail.Views
{
    using Models;

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IngresosPage : ContentPage
	{
		public IngresosPage ()
		{
			InitializeComponent ();

            DatePicker datePicker = new DatePicker
            {
                MinimumDate = new DateTime(2019, 1, 1),
                MaximumDate = new DateTime(2019, 12, 31),
                Date = new DateTime(2019, 3, 25)
            };
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetIngresosAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(valorEntry.Text) && !string.IsNullOrWhiteSpace(detalleEntry.Text))
            {
                await App.Database.SaveIngresosAsync(new Item
                {
                    Valor = valorEntry.Text,
                    Detalle = detalleEntry.Text
                });

                valorEntry.Text = detalleEntry.Text = string.Empty;
                listView.ItemsSource = await App.Database.GetIngresosAsync();
            }
        }
	}
}