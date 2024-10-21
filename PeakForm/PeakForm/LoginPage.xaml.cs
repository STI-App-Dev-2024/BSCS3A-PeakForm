using PeakForm.ViewModel;

namespace PeakForm;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel(Navigation);
	}
}