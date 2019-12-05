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
	public partial class View : ContentPage
	{
		public View () 
		{
			InitializeComponent ();
            fillLabels();
            runView();
        }

        private void fillLabels()
        {
            
            int totalsaved = appDb.getAll().Count;
            labeltotal.Text = $"Total amount:{totalsaved}";

            double totalcost = appDb.getAll().Sum(x => x.amount);
            labeltotalamount.Text = $"Total cost per month: ${totalcost}";
                      
        }

        private static List<dbEntry> entries = new List<dbEntry>();

        public void runView()
        {
            entries = appDb.getAll();

            foreach (dbEntry entry in entries){
                CoolLabelStack.Children.Add(new Label { Text = $"subscriptions Name: {entry.subName} \nCost per month: ${entry.amount}\n" });
            }
        }
	}
}