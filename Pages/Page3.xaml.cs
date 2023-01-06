namespace Yagmur_180201028;

public partial class Page3 : ContentPage
{
	public Page3()
	{

        InitializeComponent();
        Item.SectionCalculate();
        total.Text = Page4.TotalString;
    }


private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
{
    stepperLabel.Text = e.NewValue.ToString();
    Item.Memory_Size = stepperLabel.Text;
    Item.SectionCalculate();
    total.Text = Page4.TotalString;
}

private void Stepper_ValueChanged_1(object sender, ValueChangedEventArgs e)
{
    stepperLabel2.Text = e.NewValue.ToString();
    Item.Storage_Size = stepperLabel2.Text;
    Item.SectionCalculate();
    total.Text = Page4.TotalString;
}

private void Stepper_ValueChanged_2(object sender, ValueChangedEventArgs e)
{
    stepperLabel3.Text = e.NewValue.ToString();
    Item.Monitor_Size = stepperLabel3.Text;
    Item.SectionCalculate();
    total.Text = Page4.TotalString;
}
}