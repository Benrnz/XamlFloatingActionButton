using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FABTest1
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            MyItems = new ObservableCollection<string>(new []
            {
                "The",
                "quick",
                "brown",
                "fox",
                "jumped",
                "over",
                "the",
                "lazy",
                "dog",
                "1The",
                "1quick",
                "1brown",
                "1fox",
                "1jumped",
                "1over",
                "1the",
                "1lazy",
                "1dog",
                //"2The",
                //"2quick",
                //"2brown",
                //"2fox",
                //"2jumped",
                //"2over",
                //"2the",
                //"2lazy",
                //"2dog",
            });
            BindingContext = this;
        }

        public ObservableCollection<string> MyItems { get; set; }

        public Command FabExecuteCommand
        {
            get
            {
                return new Command(async () => await OnFabExecuted());
            }
        }

        private async Task OnFabExecuted()
        {
            var animate = await DisplayAlert("Fab", "Hide and show the Fab?", "Sure", "Not now");
            if (!animate) return;

            Fab.Hide();
            await Task.Delay(1500);
            Fab.Show();
        }
    }
}
