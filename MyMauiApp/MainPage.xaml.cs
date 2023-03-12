namespace MyMauiApp;

/// <summary>
/// This is the code-behind for the page. 
/// In this file, you define the logic for the various event handlers and other actions that are triggered by the controls on the page. 
/// The example code implements a handler for the Clicked event for the button on the page. 
/// The code simply increments a counter variable and displays the result in a label on the page. 
/// The Semantic service provided as part of the MAUI Essentials library supports accessibility. 
/// The static Announce method of the SemanticScreenReader class specifies the text announced by a screen reader 
/// when the user selects the button:
/// </summary>

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times, I urge you to stop it immediately!";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

