namespace Yagmur_180201028;

public partial class Page2 : ContentPage
{
	public Page2()
	{
        InitializeComponent();
    }


    private void RadioButtons_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton radioButton = sender as RadioButton;
        Item.CPU_Type = radioButton.Content.ToString();
    }

    private void RadioButtons2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton radioButton = sender as RadioButton;
        Item.Storage_Type = radioButton.Content.ToString();
    }

}