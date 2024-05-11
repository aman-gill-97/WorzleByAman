namespace FiveLetters;
using CommunityToolkit.Maui.Views;
using FiveLetters.ViewModel;

public partial class UserStatsPopup : Popup
{
	public UserStatsPopup(UserStatsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}