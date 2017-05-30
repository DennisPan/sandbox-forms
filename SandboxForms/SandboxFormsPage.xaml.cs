using System;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Xaml.XamlCompilation(Xamarin.Forms.Xaml.XamlCompilationOptions.Compile)]
namespace SandboxForms
{
    public partial class SandboxFormsPage
    {
        public SandboxFormsPage()
        {
            InitializeComponent();

            extendedLabel.Text = Humanizer.StringHumanizeExtensions.Humanize("Text test  stdff gdfgd Tet.Test");

        }
    }
}
