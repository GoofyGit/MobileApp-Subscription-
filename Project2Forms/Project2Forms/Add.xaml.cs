using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project2Forms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Add : ContentPage
	{
		public Add ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            try{
                double cost = Convert.ToDouble(amount.Text);
                appDb.addItem(subName.Text, dueDate.Date, cost);
                DisplayAlert("Add", "Successfully added", "ok");
            }
            catch{
                DisplayAlert("Error", "The input is invaled please enter again", "ok");
            }
        }
    }
}