using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EgresosPage : ContentPage
	{
		public EgresosPage()
		{
			InitializeComponent ();

            DatePicker datePicker = new DatePicker
            {
                MinimumDate = new DateTime(2019, 1, 1),
                MaximumDate = new DateTime(2019, 12, 31),
                Date = new DateTime(2019, 3, 25)
            };
        }
	}
}