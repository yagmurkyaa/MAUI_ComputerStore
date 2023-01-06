namespace Yagmur_180201028;

public partial class Page4 : ContentPage
{
    public static string TotalString { get; set; }
    public Page4()
	{
        InitializeComponent();
        DateTime dateTime = DateTime.Now;
        Item.SectionCalculate();
        total.Text = TotalString;
    }

    private void pay_but_Clicked(object sender, EventArgs e)
    {
        Item.Calculate();
        TotalString = Item.Total.ToString("C");
        total.Text = TotalString;
    }
}

