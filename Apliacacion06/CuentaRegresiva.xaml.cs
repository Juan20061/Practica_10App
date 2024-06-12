using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace Apliacacion06;

public partial class CuentaRegresiva : ContentPage
{
	public CuentaRegresiva()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await StartCountdown();
    }

    private async Task StartCountdown()
    {
        for (int i = 10; i >= 1; i--)
        {
            CountdownLabel.Text = i.ToString();
            await Task.Delay(1000); // Espera 1 segundo
        }
        CountdownLabel.Text = "¡Tiempo!";
    }
}