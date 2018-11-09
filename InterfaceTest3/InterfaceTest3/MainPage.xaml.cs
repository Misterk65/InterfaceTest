using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceTest3.Interfaces;
using Xamarin.Forms;

namespace InterfaceTest3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Text_OnClicked(object sender, EventArgs e)
        {
           TextLabel.Text = DependencyService.Get<ITextCaption>().GetText(TextLabel.Text);
        }
    }
}
