using PeakForm.ViewModel;

namespace PeakForm;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
		BindingContext = new SignUpViewModel(Navigation);
	}
}